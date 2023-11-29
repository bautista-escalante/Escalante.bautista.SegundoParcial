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
            Assert.AreEqual(460000, resultado[0].precio);
            Assert.AreEqual(510000, resultado[1].precio);
        }
        [TestMethod]
        public void Ordenar_DeberiaOrdenarDescendentementePorPrecio()
        {
            Carrito<Tecnologia> carrito = new Carrito<Tecnologia>();
            AccesoProductos productos = new AccesoProductos();
            List<Tecnologia> producto = productos.ObtenerDatos();
            List<Tecnologia> resultado = carrito.Ordenar("precio", productos,false);
            Assert.AreEqual(1100000, resultado[0].precio);

        }
        [TestMethod]
        public void Ordenar_DeberiaOrdenarAscendentementePorCategoria()
        {
            Carrito<Tecnologia> carrito = new Carrito<Tecnologia>();
            AccesoProductos productos = new AccesoProductos();
            List<Tecnologia> producto = productos.ObtenerDatos();
            List<Tecnologia> resultado = carrito.Ordenar("categoria", productos);
            Assert.AreEqual("celular", resultado[0].categoria);
        }
        [TestMethod]
        public void Ordenar_DeberiaOrdenarDescendentementePorCategoria()
        {
            Carrito<Tecnologia> carrito = new Carrito<Tecnologia>();
            AccesoProductos productos = new AccesoProductos();
            List<Tecnologia> producto = productos.ObtenerDatos();
            List<Tecnologia> resultado = carrito.Ordenar("categoria", productos,false);
            Assert.AreEqual("laptop", resultado[0].categoria);
        }
    }
}