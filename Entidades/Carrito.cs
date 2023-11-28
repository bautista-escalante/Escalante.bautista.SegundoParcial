using Newtonsoft.Json;
using System.Linq;

namespace Entidades
{
    public class Carrito<T> where T: Tecnologia
    {
        public string? marca;
        public string? modelo;
        public int? ram;
        public string? sistema;
        public string? categoria;
        public int? almacenamiento;
        public int? precio;
        public int? camara;
        public double? pantalla;
        public string? procesador;
        public double? peso;
        public int? resolucion;
        public double? pulgadas;
        public string? tipo;
        public int? nucleos;
        public string? chipVideo;
        public static List<Carrito<T>> operator +(List<Carrito<T>> carrito, Carrito<T> tecnologia)
        {
            if (carrito!= tecnologia)
            {
                carrito.Add(tecnologia);
                return carrito;
            }
            else
            {
                return carrito;
            }
        }
        public static List<Carrito<T>> operator -(List<Carrito<T>> carrito, Carrito<T> tecnologia)
        {
            if (carrito != tecnologia)
            {
                carrito.Remove(tecnologia);
                return carrito;
            }
            else
            {
                return carrito;
            }
        }
        public static bool operator ==(List<Carrito<T>> carrito, Carrito<T> tecnologia)
        {
            return carrito.Contains(tecnologia);
        }
        public static bool operator !=(List<Carrito<T>> carrito, Carrito<T> tecnologia)
        {
            return !(carrito == tecnologia);
        }
        public List<Tecnologia>? Ordenar(string parametro ,AccesoProductos data,bool ascendente = true)
        {
            List<Tecnologia> lista = data.ObtenerDatos();
            if (ascendente)
            {
                if (parametro == "precio")
                {
                    lista = lista.OrderBy(x => x.precio).ToList();
                }
                else
                {
                    lista = lista.OrderBy(x => x.categoria).ToList();
                }
            }
            else
            {
                if (parametro == "precio")
                {
                    lista = lista.OrderByDescending(x => x.precio).ToList();
                }
                else
                {
                    lista = lista.OrderByDescending(x => x.categoria).ToList();
                }
            }
            return lista;
        }
    }
}
