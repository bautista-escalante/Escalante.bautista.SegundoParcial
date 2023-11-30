using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
namespace Entidades
{
    public  class AccesoProductos
    {
        public string connectionString;
        public SqlCommand? comando;
        public SqlConnection coneccion;
        public AccesoProductos()
        {
            connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Productos;Integrated Security=True";
            comando = new SqlCommand();
            coneccion = new SqlConnection(connectionString);
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = coneccion;
        }
        public bool probarConexion()
        {
            bool retorno = false;
            try
            {
                this.coneccion.Open();
                retorno = true;
            }
            catch(Exception)
            {

            }
            finally
            {
                if (this.coneccion.State == System.Data.ConnectionState.Open)
                {
                    this.coneccion.Close();
                }
            }
            return retorno;
        }
        /// <summary>
        /// Obtiene un objeto Tecnologia basado en la marca y el modelo proporcionados.
        /// </summary>
        /// <returns>Un objeto Tecnologia que coincide con la marca y el modelo, o null si no se encuentra ninguna coincidencia.</returns>
        public Tecnologia? ObtenerDato(EMarcas marca, string modelo)
        {
            Tecnologia retorno = null;
            List<Tecnologia> lista= this.ObtenerDatos();
            foreach (Tecnologia item in lista)
            {
                if (item.marca == marca && item.modelo == modelo)
                {
                    retorno = item;
                }
            }
            return retorno; 
        }
        /// <summary>
        /// Obtiene datos de la base de datos y devuelve una lista de objetos de la clase Tecnologia.
        /// </summary>
        /// <returns>Una lista de objetos Tecnologia.</returns>
        public List<Tecnologia> ObtenerDatos()
        {
            List<Tecnologia> lista = new List<Tecnologia>();
            try
            {
                coneccion.Open();
                comando.CommandText = "SELECT * FROM producto";
                using (SqlDataReader dR = comando.ExecuteReader())
                {
                    while (dR.Read())
                    {
                        EMarcas marca = (EMarcas)Enum.Parse(typeof(EMarcas), dR["marca"].ToString(),true);
                        switch (dR["categoria"].ToString())
                        {
                            case "celular":
                                Celular elemento = new Celular(
                                    dR["camara"].ToString(),
                                    dR["procesador"].ToString(),
                                    Convert.ToDouble(dR["pantalla"]),
                                    dR["sistema"].ToString(),
                                    Convert.ToInt32(dR["almacenamiento"]),
                                    marca,
                                    dR["modelo"].ToString(),
                                    Convert.ToInt32(dR["ram"]),
                                    Convert.ToInt32(dR["precio"]));
                                lista.Add(elemento);
                                break;
                            case "consola":
                                Consola consola = new Consola(
                                    dR["chipVideo"].ToString(),
                                    dR["sistema"].ToString(),
                                    Convert.ToInt32(dR["ram"]),
                                    Convert.ToInt32(dR["almacenamiento"]),
                                    marca,
                                    dR["modelo"].ToString(),
                                    Convert.ToInt32(dR["precio"]));
                                lista.Add(consola);
                                break;

                            case "desktop":
                                Destop desktop = new Destop(
                                    dR["chipVideo"].ToString(),
                                    dR["sistema"].ToString(),
                                    Convert.ToInt32(dR["ram"]),
                                    Convert.ToInt32(dR["almacenamiento"]),
                                    marca,
                                    dR["modelo"].ToString(),
                                    Convert.ToInt32(dR["precio"]));
                                lista.Add(desktop);
                                break;
                            case "laptop":
                                Laptop laptop = new Laptop(
                                    Convert.ToDouble(dR["pulgadas"]),
                                    Convert.ToInt32(dR["peso"]),
                                    dR["procesador"].ToString(),
                                    Convert.ToInt32(dR["nucleos"]),
                                    dR["sistema"].ToString(),
                                    Convert.ToInt32(dR["ram"]),
                                    Convert.ToInt32(dR["almacenamiento"]),
                                    marca,
                                    dR["modelo"].ToString(),
                                    Convert.ToInt32(dR["precio"]));
                                lista.Add(laptop);
                                break;
                            case "televisor":
                                Televisor televisor = new Televisor(
                                    Convert.ToInt32(dR["resolucion"]),
                                    Convert.ToDouble(dR["pulgadas"]),
                                    dR["tipo"].ToString(),
                                    dR["sistema"].ToString(),
                                    Convert.ToInt32(dR["ram"]),
                                    Convert.ToInt32(dR["almacenamiento"]),
                                    marca,
                                    dR["modelo"].ToString(),
                                    Convert.ToInt32(dR["precio"]));
                                lista.Add(televisor);
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                if (this.coneccion.State == System.Data.ConnectionState.Open)
                {
                    this.coneccion.Close();
                }
            }
            return lista;
        }
        /// <summary>
        /// Agrega un objeto Tecnologia a la base de datos.
        /// </summary>
        /// <returns>True si la operación de inserción fue exitosa, False en caso contrario.</returns>
        public bool AgregarDato(Tecnologia tec)
        {
            bool retorno = false;
            try
            {
                coneccion.Open();
                comando.Parameters.Clear();
                if (tec is Celular celular)
                {
                    comando.CommandText = "INSERT INTO producto (marca,modelo,categoria,precio,ram,almacenamiento,camara,procesador,pantalla,sistema) " +
                    "VALUES (@marca, @modelo, @categoria, @precio, @ram, @almacenamiento, @camara, @procesador, @pantalla, @sistema)";
                    comando.Parameters.AddWithValue("@marca", celular.marca);
                    comando.Parameters.AddWithValue("@Modelo", celular.modelo);
                    comando.Parameters.AddWithValue("@Categoria", celular.categoria);
                    comando.Parameters.AddWithValue("@Precio", celular.precio);
                    comando.Parameters.AddWithValue("@Ram", celular.ram);
                    comando.Parameters.AddWithValue("@Almacenamiento", celular.almacenamiento);
                    comando.Parameters.AddWithValue("@camara", celular.camara);
                    comando.Parameters.AddWithValue("@procesador", celular.procesador);
                    comando.Parameters.AddWithValue("@pantalla", celular.pantalla);
                    comando.Parameters.AddWithValue("@sistema", celular.sistemOperativo);
                }
                else if (tec is Consola consola)
                {
                        comando.CommandText = "INSERT INTO producto (chipVideo, sistema, ram, almacenamiento, marca, modelo, categoria, precio) " +
                            "VALUES (@chipVideo, @sistema, @ram, @almacenamiento, @marca, @modelo, @categoria, @precio)";
                        comando.Parameters.AddWithValue("@chipVideo", consola.chipVideo);
                        comando.Parameters.AddWithValue("@sistema", consola.sistemOperativo);
                        comando.Parameters.AddWithValue("@ram", consola.ram);
                        comando.Parameters.AddWithValue("@almacenamiento", consola.almacenamiento);
                        comando.Parameters.AddWithValue("@marca", consola.marca);
                        comando.Parameters.AddWithValue("@modelo", consola.modelo);
                        comando.Parameters.AddWithValue("@categoria", consola.categoria);
                        comando.Parameters.AddWithValue("@precio", consola.precio);
                }
                else if (tec is Destop desktop)
                {
                    comando.CommandText = "INSERT INTO producto (chipVideo, sistema, ram, almacenamiento, marca, modelo, categoria, precio) " +
                    "VALUES (@chipVideo, @sistema, @ram, @almacenamiento, @marca, @modelo, @categoria, @precio)";
                    comando.Parameters.AddWithValue("@chipVideo", desktop.placaVideo);
                    comando.Parameters.AddWithValue("@sistema", desktop.sistemOperativo);
                    comando.Parameters.AddWithValue("@ram", desktop.ram);
                    comando.Parameters.AddWithValue("@almacenamiento", desktop.almacenamiento);
                    comando.Parameters.AddWithValue("@marca", desktop.marca);
                    comando.Parameters.AddWithValue("@modelo", desktop.modelo);
                    comando.Parameters.AddWithValue("@categoria", desktop.categoria);
                    comando.Parameters.AddWithValue("@precio", desktop.precio);
                }
                else if (tec is Laptop laptop)
                {
                    comando.CommandText = "INSERT INTO producto (pulgadas, peso, procesador, nucleos, sistema, ram, almacenamiento, marca, modelo, categoria, precio) " +
                    "VALUES (@pulgadas, @peso, @procesador, @nucleos, @sistema, @ram, @almacenamiento, @marca, @modelo, @categoria, @precio)";
                    comando.Parameters.AddWithValue("@pulgadas", laptop.pulgadas);
                    comando.Parameters.AddWithValue("@peso", laptop.peso);
                    comando.Parameters.AddWithValue("@procesador", laptop.procesador);
                    comando.Parameters.AddWithValue("@nucleos", laptop.cantNucleos);
                    comando.Parameters.AddWithValue("@sistema", laptop.sistemOperativo);
                    comando.Parameters.AddWithValue("@ram", laptop.ram);
                    comando.Parameters.AddWithValue("@almacenamiento", laptop.almacenamiento);
                    comando.Parameters.AddWithValue("@marca", laptop.marca);
                    comando.Parameters.AddWithValue("@modelo", laptop.modelo);
                    comando.Parameters.AddWithValue("@categoria", laptop.categoria);
                    comando.Parameters.AddWithValue("@precio", laptop.precio);
                }
                else if (tec is Televisor televisor)
                {
                        comando.CommandText = "INSERT INTO producto (resolucion, pulgadas, tipo, sistema, ram, almacenamiento, marca, modelo, categoria, precio) " +
                        "VALUES (@resolucion, @pulgadas, @tipo, @sistema, @ram, @almacenamiento, @marca, @modelo, @categoria, @precio)";
                        comando.Parameters.AddWithValue("@resolucion", televisor.resolucion);
                        comando.Parameters.AddWithValue("@pulgadas", televisor.pulgadas);
                        comando.Parameters.AddWithValue("@tipo", televisor.tipo);
                        comando.Parameters.AddWithValue("@sistema", televisor.sistemOperativo);
                        comando.Parameters.AddWithValue("@ram", televisor.ram);
                        comando.Parameters.AddWithValue("@almacenamiento", televisor.almacenamiento);
                        comando.Parameters.AddWithValue("@marca", televisor.marca);
                        comando.Parameters.AddWithValue("@modelo", televisor.modelo);
                        comando.Parameters.AddWithValue("@categoria", televisor.categoria);
                        comando.Parameters.AddWithValue("@precio", televisor.precio);
                }
                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    retorno = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                if (this.coneccion.State == System.Data.ConnectionState.Open)
                {
                    this.coneccion.Close();
                }
            }
            return retorno;
        }
        /// <summary>
        /// Actualiza el precio de un producto en la base de datos según la marca y el modelo proporcionados.
        /// </summary>
        /// <returns>True si la actualización fue exitosa, False en caso contrario.</returns>
        public bool ActializarDato(int precio,EMarcas marca,string modelo)
        {
            bool retorno = false;
            try
            {
                coneccion.Open();
                comando.Parameters.Clear();
                comando.CommandText = "UPDATE producto SET precio = @precio WHERE modelo = @modelo";
                comando.Parameters.AddWithValue("@precio", precio);
                comando.Parameters.AddWithValue("@modelo", modelo);
                int filasAfectadas = comando.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    retorno = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                coneccion.Close();
            }
            return retorno;
        }
        /// <summary>
        /// Elimina un producto de la base de datos según la marca y el modelo proporcionados.
        /// </summary>
        /// <returns>True si la eliminación fue exitosa, False en caso contrario.</returns>
        public bool EliminarDato(string marca, string modelo)
        {
            bool retorno = false;
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandText = "DELETE FROM producto WHERE modelo = @modelo";
                        comando.Parameters.AddWithValue("@modelo", modelo);
                        int filasAfectadas = comando.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            retorno = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                if (this.coneccion.State == System.Data.ConnectionState.Open)
                {
                    this.coneccion.Close();
                }
            }
            return retorno;
        }
        /// <summary>
        /// Modifica las posiciones de la tabla "producto" en la base de datos al vaciarla y luego insertar los elementos de la lista.
        /// </summary>
        public void ModificarPosiciones(List<Tecnologia> lista)
        {
            try
            {
                coneccion.Open();
                comando.CommandText = "TRUNCATE TABLE producto";
                int filasAfectadas = comando.ExecuteNonQuery();
                if (filasAfectadas <= 0)
                {
                    if (this.coneccion.State == System.Data.ConnectionState.Open)
                    {
                        this.coneccion.Close();
                    }
                    foreach (Tecnologia item in lista)
                    {
                        this.AgregarDato(item);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                if (this.coneccion.State == System.Data.ConnectionState.Open)
                {
                    this.coneccion.Close();
                }
            }
        }
    }
}
