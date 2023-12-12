using Entidades;
namespace Pruebas
{
    [TestClass]
    public class PruebaCarrito
    {
        [TestMethod]
        public void Ordenar_DeberiaOrdenarAscendentementePorPrecio()
        {
            Carrito<Tecnologia> carrito = new Carrito<Tecnologia>();
            AccesoProductos productos = new AccesoProductos();
            List<Tecnologia> producto = productos.ObtenerDatos();
            List<Tecnologia> resultado = carrito.Ordenar("precio",productos);
            for (int i = 0;i<resultado.Count-1;i++)
            {
                Assert.IsTrue(resultado[i].precio <= resultado[i + 1].precio);
            }
        }
        [TestMethod]
        public void Ordenar_DeberiaOrdenarDescendentementePorPrecio()
        {
            Carrito<Tecnologia> carrito = new Carrito<Tecnologia>();
            AccesoProductos productos = new AccesoProductos();
            List<Tecnologia> producto = productos.ObtenerDatos();
            List<Tecnologia> resultado = carrito.Ordenar("precio", productos,false);
            for (int i = 0; i < resultado.Count - 1; i++)
            {
                Assert.IsTrue(resultado[i].precio >= resultado[i + 1].precio);
            }
        }
        [TestMethod]
        public void Ordenar_DeberiaOrdenarAscendentementePorCategoria()
        {
            Carrito<Tecnologia> carrito = new Carrito<Tecnologia>();
            AccesoProductos productos = new AccesoProductos();
            List<Tecnologia> resultado = carrito.Ordenar("categoria", productos);
            for (int i = 0; i < resultado.Count - 1; i++)
            {
                Assert.IsTrue(resultado[i].categoria.Length == resultado[i].categoria.Length);
            }
        }
        [TestMethod]
        public void Ordenar_DeberiaOrdenarDescendentementePorCategoria()
        {
            Carrito<Tecnologia> carrito = new Carrito<Tecnologia>();
            AccesoProductos productos = new AccesoProductos();
            List<Tecnologia> producto = productos.ObtenerDatos();
            List<Tecnologia> resultado = carrito.Ordenar("categoria", productos,false);
            for (int i = 0; i < resultado.Count - 1; i++)
            {
                Assert.IsTrue(resultado[i].categoria.Length == resultado[i].categoria.Length);
            };
        }
    }
}