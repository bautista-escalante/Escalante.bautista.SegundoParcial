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
    public  class ProductosAccesoDatos
    {
        public  string connectionString;
        public  SqlCommand? comando;
        public  SqlConnection coneccion;
        public ProductosAccesoDatos()
        {
            connectionString = "Server=.;Database=Productos;Integrated Security=True;";
            comando = new SqlCommand();
            coneccion = new SqlConnection(connectionString);
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = coneccion;
        }
        public Tecnologia? ObtenerDato(EMarcas marca, string modelo)
        {
            Tecnologia retorno = null;
            List<Tecnologia> pepe= this.ObtenerDatos();
            foreach (Tecnologia item in pepe)
            {
                if (item.marca == marca && item.modelo == modelo)
                {
                    retorno = item;
                }
            }
            return retorno; 
        }
        public List<Tecnologia> ObtenerDatos()
        {
            List<Tecnologia> lista = new List<Tecnologia>();
            try
            {
                coneccion.Open();
                comando.CommandText = "SELECT * FROM Productos";
                using (SqlDataReader dR = comando.ExecuteReader())
                {
                    while (dR.Read())
                    {
                        EMarcas marca = (EMarcas)Enum.Parse(typeof(EMarcas), dR["marca"].ToString());
                        switch (dR["categoria"])
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
                                    dR["placaVideo"].ToString(),
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
                coneccion.Close();
            }
            return lista;
        }
        public bool AgregarDato(Tecnologia tec)
        {
            bool retorno = false;
            try
            {
                coneccion.Open();
                if (tec is Celular celular)
                {
                    comando.CommandText = "INSERT INTO Productos (camara,procesador,pantalla,sistema,almacenamiento,marca, modelo, categoria,ram, precio) " +
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
                        comando.CommandText = "INSERT INTO Productos (chipVideo, sistema, ram, almacenamiento, marca, modelo, categoria, precio) " +
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
                    comando.CommandText = "INSERT INTO Productos (placaVideo, sistema, ram, almacenamiento, marca, modelo, categoria, precio) " +
                    "VALUES (@placaVideo, @sistema, @ram, @almacenamiento, @marca, @modelo, @categoria, @precio)";
                    comando.Parameters.AddWithValue("@placaVideo", desktop.placaVideo);
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
                    comando.CommandText = "INSERT INTO Productos (pulgadas, peso, procesador, nucleos, sistema, ram, almacenamiento, marca, modelo, categoria, precio) " +
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
                        comando.CommandText = "INSERT INTO Productos (resolucion, pulgadas, tipo, sistema, ram, almacenamiento, marca, modelo, categoria, precio) " +
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
            catch (Exception)
            {
                
            }
            finally
            {
                coneccion.Close();
            }
            return retorno;
        }
        public bool ActializarDato(int precio,EMarcas marca,string modelo)
        {
            bool retorno = false;
            try
            {
                coneccion.Open();
                comando.CommandText = "UPDATE Productos SET precio = @nuevoPrecio WHERE modelo = @modelo AND marca = @marca";
                comando.Parameters.AddWithValue("@nuevoPrecio", precio);
                comando.Parameters.AddWithValue("@modelo", modelo);
                comando.Parameters.AddWithValue("@marca", marca);
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
        public bool EliminarDato(EMarcas marca, string modelo)
        {
            bool retorno = false;
            try
            {
                coneccion.Open();
                comando.CommandText = "DELETE FROM Productos WHERE marca = @marca AND modelo = @modelo";
                comando.Parameters.AddWithValue("@marca", marca);
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
    }
}
