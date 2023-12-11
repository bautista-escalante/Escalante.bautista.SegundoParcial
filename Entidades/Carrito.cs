using Newtonsoft.Json;
using System.Linq;
namespace Entidades
{
    public class Carrito<T> where T: Tecnologia
    {
        public List<Tecnologia> lista { get; set; }
        public Carrito() 
        {
            this.lista = new List<Tecnologia>();
        }
        public static List<Carrito<T>> operator +(List<Carrito<T>> carrito, Carrito<T> tecnologia)
        {
            if (carrito.Contains(tecnologia))
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
            if (carrito.Contains(tecnologia))
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
             return carrito.Any(item => item.Equals(tecnologia));
        }
        public static bool operator !=(List<Carrito<T>> carrito, Carrito<T> tecnologia)
        {
            return !(carrito == tecnologia);
        }
        /// <summary>
        /// Ordena una lista de objetos Tecnologia según el parámetro especificado.
        /// </summary>
        /// <param name="criterio">El parámetro por el cual se va a ordenar la lista (puede ser "precio" o "categoria").</param>
        /// <param name="data">El objeto AccesoProductos que proporciona acceso a los datos.</param>
        /// <param name="ascendente">Indica si la lista debe ordenarse de forma ascendente (predeterminado) o descendente.</param>
        /// <returns>Una lista ordenada de objetos Tecnologia según el parámetro especificado.</returns>

        public List<Tecnologia>? Ordenar(string criterio ,AccesoProductos data,bool ascendente = true)
        {
            List<Tecnologia> lista = data.ObtenerDatos();
            if (ascendente)
            {
                if (criterio == "precio")
                {
                    lista = lista.OrderBy(x => x.precio).ToList();
                }
                else
                {
                    lista = lista.OrderBy(x => x.precio).ToList();
                }
            }
            else
            {
                if (criterio == "precio")
                {
                    lista = lista.OrderByDescending(x => x.categoria).ToList();
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
