using Entidades;
using System.Runtime.CompilerServices;

internal class Program
{

    private static void Main(string[] args)
    {// resolucion, pulgadas, tipo, so, ram, almacenamiento, marca, modelo, precio
        /*Televisor tv2 = new Televisor(1080, 90, "oled", "Tizen OS", 3, 20, EMarcas.Samsung, "SamsungQN90AQLEDTV", 230000);
        Console.WriteLine(tv1.ObtenerCategoria());
        Console.WriteLine(tv1.MostrarInformacionParcial());
        Console.Write(tv1.MostrarInformacionTotal());
        Console.WriteLine(tv1.ToString());
        Console.WriteLine(tv1 == tv1);*/
        Carrito carrito = new Carrito();

        Consola consola = new Consola(false, "pepe", "sony", 12, 100, EMarcas.Sony, "ps4", 40000);
        Televisor tv1 = new Televisor(1080, 98, "oled", "Tizen OS", 3, 20, EMarcas.Samsung, "SamsungQN90AQLEDTV", 230000);
        carrito += tv1;
        carrito += consola;

        Console.WriteLine(carrito.MostrarStock());
        Console.WriteLine(carrito.MostrarCarrito());
        Console.WriteLine(carrito.ordenarCarrito());
        /* Celular celular = new Celular(camara, prosador, pantalla, so, almacenamiento, marca, modelo, ram, precio);
        / this.carrito.Add(celular);


         Televisor televisor = new Televisor(resolucion, pulgadas, tipo, so, ram, almacenamiento, marca, modelo, precio);
         carrito.Add(televisor);


         Laptop laptop = new Laptop(rgb, procesador, nucleos, so, ram, almacenamiento, marca, modelo, precio);
         carrito.Add(laptop);


         Destop desktop = new Destop(rgb, placaVideo, so, ram, almacenamiento, marca, modelo, precio);
         //this.carrito = this.carrito + desktop;*/
    }
    
    }