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
        public List<Carrito> OrdenarCarrito(bool ascendente = true)
        {
            List<Carrito> carrito = this.Deserializar(@"..\..\..\productos.json");
            for (int i = 0; i < carrito.Count - 1; i++)
            {
                for (int j = 0; j < carrito.Count - i - 1; j++)
                {
                    if ((ascendente && carrito[j].precio > carrito[j + 1].precio) || (!ascendente && carrito[j].precio < carrito[j + 1].precio))
                    {
                        Carrito aux = carrito[j];
                        carrito[j] = carrito[j + 1];
                        carrito[j + 1] = aux;
                    }
                }
            }
            return carrito;
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
        public List<Carrito> Deserializar(string ruta)
        {
            string json = File.ReadAllText(ruta);
            List<Carrito>? productos = JsonConvert.DeserializeObject<List<Carrito>>(json);
            return productos;
        }
        public Carrito Deserializar()
        {
            string json = File.ReadAllText(@"..\..\..\Nuevoproducto.json");
            Carrito? productos = JsonConvert.DeserializeObject<Carrito>(json);
            return productos;
        }
    }
}
