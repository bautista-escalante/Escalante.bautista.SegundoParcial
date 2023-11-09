using Newtonsoft.Json;
namespace Entidades
{
    public class Carrito
    {
        public List<Tecnologia>? carrito { get; set; }
        public string? marca { get; set; }
        public string? modelo { get; set; }
        public int? ram { get; set; }
        public string? sistema { get; set; }
        public string? categoria { get; set; }
        public int? almacenamiento { get; set; }
        public int? precio { get; set; }
        public int? camara { get; set; }
        public double? pantalla { get; set; }
        public string? procesador { get; set; }
        public double? peso { get; set; }
        public int? resolucion { get; set; }
        public double? pulgadas { get; set; }
        public string? tipo { get; set; }
        public int? nucleos { get; set; }
        public string? chipVideo { get; set; }
        public Carrito()
        {
            this.carrito = new List<Tecnologia>();
        }
        public static List<Carrito> operator +(List<Carrito> carrito, Carrito tecnologia)
        {
            carrito.Add(tecnologia);
            return carrito;
        }
        public static List<Carrito> operator -(List<Carrito> carrito, Carrito tecnologia)
        {
            carrito.Remove(tecnologia);
            return carrito;
        }
        public static bool operator ==(Carrito carrito, Tecnologia tecnologia)
        {
            return carrito.carrito.Contains(tecnologia);
        }

        public static bool operator !=(Carrito carrito, Tecnologia tecnologia)
        {
            return !(carrito == tecnologia);
        }
        public List<Carrito>? OrdenarCarrito(bool ascendente = true)
        {
            List<Carrito>? productos = this.Deserializar("productos.json");
            List<Carrito> productosOrdenados = ascendente ? productos.OrderBy(producto => producto.precio).ToList() : productos.OrderByDescending(producto => producto.precio).ToList();
            return productosOrdenados;
        }
        public void serializar(string ruta, List<Carrito> listaSerializar)
        {
            try
            {
                using StreamWriter sw = new StreamWriter(ruta);
                using JsonWriter writer = new JsonTextWriter(sw);
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(writer, listaSerializar);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Se produjo un error al escribir en el archivo: " + ex.Message);
            }
        }
        public void serializar(string ruta, Tecnologia listaSerializar)
        {
            try
            {
                using StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\" +ruta);
                using JsonWriter writer = new JsonTextWriter(sw);
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(writer, listaSerializar);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Se produjo un error al escribir en el archivo: " + ex.Message);
            }
        }
        public List<Carrito>? Deserializar(string nombre)
        {
            string directorio = AppDomain.CurrentDomain.BaseDirectory;
            string ruta = directorio + nombre;
            if (File.Exists( ruta))
            {
                string json = File.ReadAllText(ruta);
                List<Carrito>? productos = JsonConvert.DeserializeObject<List<Carrito>>(json);
                return productos;
            }
            else if(File.Exists(ruta) !=true)
            {
                Directory.CreateDirectory(ruta);
                string json = File.ReadAllText(ruta);
                List<Carrito>? productos = JsonConvert.DeserializeObject<List<Carrito>>(json);
                return productos;
            }
            else 
            {
                return new List<Carrito>();
            }
        }
        public Carrito? Deserializar()
        {
            string ruta = AppDomain.CurrentDomain.BaseDirectory + "\\Nuevoproducto.json";
            if (File.Exists(ruta))
            {
                string json = File.ReadAllText(ruta);
                Carrito? productos = JsonConvert.DeserializeObject<Carrito>(json);
                return productos;
            }
            else
            {
                return new Carrito();
            }
        }
        public List<Tecnologia>? deserializar()
        {
            string ruta = AppDomain.CurrentDomain.BaseDirectory + "productos.json";
            if (File.Exists(ruta))
            {
                string json = File.ReadAllText(ruta);
                List<Tecnologia>? listaTecnologia = JsonConvert.DeserializeObject<List<Tecnologia>>(json);
                return listaTecnologia;
            }
            else
            {
                throw new Exception("no se encontro el archivo");
            }
        }
    }
}
