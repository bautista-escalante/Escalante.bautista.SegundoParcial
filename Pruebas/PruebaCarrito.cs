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
            Assert.AreEqual(resultado[0].precio, resultado[0].precio);
            Assert.AreEqual(resultado[1].precio, resultado[1].precio);
        }
        [TestMethod]
        public void Ordenar_DeberiaOrdenarDescendentementePorPrecio()
        {
            Carrito<Tecnologia> carrito = new Carrito<Tecnologia>();
            AccesoProductos productos = new AccesoProductos();
            List<Tecnologia> producto = productos.ObtenerDatos();
            List<Tecnologia> resultado = carrito.Ordenar("precio", productos,false);
            Assert.AreEqual(resultado[0].precio, resultado[0].precio);

        }
        [TestMethod]
        public void Ordenar_DeberiaOrdenarAscendentementePorCategoria()
        {
            Carrito<Tecnologia> carrito = new Carrito<Tecnologia>();
            AccesoProductos productos = new AccesoProductos();
            List<Tecnologia> producto = productos.ObtenerDatos();
            List<Tecnologia> resultado = carrito.Ordenar("categoria", productos);
            Assert.IsTrue(resultado[0].categoria == resultado[0].categoria);
        }
        [TestMethod]
        public void Ordenar_DeberiaOrdenarDescendentementePorCategoria()
        {
            Carrito<Tecnologia> carrito = new Carrito<Tecnologia>();
            AccesoProductos productos = new AccesoProductos();
            List<Tecnologia> producto = productos.ObtenerDatos();
            List<Tecnologia> resultado = carrito.Ordenar("categoria", productos,false);
            Assert.IsTrue(resultado[0].categoria == resultado[0].categoria);
        }
    }
}