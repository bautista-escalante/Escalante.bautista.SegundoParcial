using Entidades;
namespace Pruebas
{
    [TestClass]
    public class PruebaCarrito
    {
        [TestMethod]
        public void OperadorSuma_DeberiaAgregarUnElementoAlCarrito()
        {
            List<Carrito> carrito = new List<Carrito>();
            Carrito tecnologia = new Carrito();
            carrito += tecnologia;
            Assert.AreEqual(1, carrito.Count);
            Assert.IsTrue(carrito.Contains(tecnologia));
        }
        [TestMethod]
        public void OperadorResta_DeberiaQuitarUnElementoDelCarrito()
        {
            var carrito = new List<Carrito>();
            var tecnologia = new Carrito();
            carrito.Add(tecnologia);
            var resultado = carrito - tecnologia;
            Assert.AreEqual(0, resultado.Count);
            Assert.IsFalse(resultado.Contains(tecnologia));
        }
        [TestMethod]
        public void OperadorIgual_DeberiaRetornarTrueCuandoElElementoExisteEnElCarrito()
        {
            Carrito? carrito = new Carrito();
            Celular tecnologia = new Celular("android", 4, 64, EMarcas.Samsung, "A12", 120000);
            carrito.carrito.Add(tecnologia);
            bool resultado = carrito == tecnologia;
            Assert.IsTrue(resultado);
        }
        [TestMethod]
        public void OperadorIgual_DeberiaRetornarFalseCuandoElElementoNoExisteEnElCarrito()
        {
            Carrito? carrito = new Carrito();
            Laptop tecnologia = new Laptop(" intel", 4, "windows", 4, 500, EMarcas.Asus, "asus43", 123);
            bool resultado = carrito == tecnologia;
            Assert.IsFalse(resultado);
        }
        [TestMethod]
        public void OperadorDistinto_DeberiaRetornarTrueCuandoElElementoNoExisteEnElCarrito()
        {
            Carrito? carrito = new Carrito();
            Celular tecnologia = new Celular("android", 4, 64, EMarcas.Samsung, "A12", 120000);
            bool resultado = carrito != tecnologia;
            Assert.IsTrue(resultado);
        }
        [TestMethod]
        public void OperadorDistinto_DeberiaRetornarFalseCuandoElElementoExisteEnElCarrito()
        {
            Carrito? carrito = new Carrito();
            Laptop tecnologia = new Laptop(" intel", 4, "windows", 4, 500, EMarcas.Asus, "asus43", 123);
            carrito.carrito.Add(tecnologia);
            bool resultado = carrito != tecnologia;

            Assert.IsFalse(resultado);
        }
        [TestMethod]
        public void OrdenarCarrito_DeberiaOrdenarAscendentementePorPrecio()
        {
            Carrito carrito = new Carrito();
            List<Carrito> resultado = carrito.OrdenarCarrito();
            Assert.AreEqual(3, resultado[0].precio);
            Assert.AreEqual(222, resultado[1].precio);
        }
        [TestMethod]
        public void OrdenarCarrito_DeberiaOrdenarDescendentementePorPrecio()
        {
            Carrito carrito = new Carrito();
            List<Carrito> productos = carrito.Deserializar("productos.json");
            List<Carrito> resultado = carrito.OrdenarCarrito(false);
            Assert.AreEqual(1100000, resultado[0].precio);
            Assert.AreEqual(1000000, resultado[1].precio);

        }
    }
}