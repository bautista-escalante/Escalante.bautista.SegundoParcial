# CRUD  tienda de tecnologia

primer parcial de laboratorio usando c#, windows forms y programacion orientada a objetos

# sobre mi 

Actualmente, soy estudiante de una tecnicatura en programación y tengo 22 años. Mi fascinación por la tecnología comenzó a los 17 años cuando decidí inscribirme en un curso de reparación de PC. Con el tiempo, desarrollé la habilidad de aprender cosas cada vez más interesantes que me sacan constantemente de mi zona de confort, como la electrónica general, la energía solar y las luces de emergencia.

Mi primera incursión en el mundo de la programación fue a través de Arduino. Más tarde, cuando ingresé a la carrera, tuve la oportunidad de aprender Python y solidificar aún más mis conceptos sobre Arduino. Estoy decidido a seguir avanzando en esta ruta.


# diagrama de clases completo

![Escalante bautista - Microsoft Visual Studio 30_11_2023 18_45_43 (1)](https://github.com/bautista-escalante/Escalante.bautista.SegundoParcial/assets/123372673/e4a3a20b-3b23-406b-b453-e4f0ff1f74dd)

## clase base: Tecnologia

![tecno](https://github.com/bautista-escalante/Escalante.bautista.SegundoParcial/assets/123372673/b92c79f4-6b49-41a9-8214-6bec40914b43)

## clases derivadas
 * Consola
   
![consola](https://github.com/bautista-escalante/Escalante.bautista.SegundoParcial/assets/123372673/aac89ae3-b2fe-4ce2-b432-5207f21c6b70)

 * herencia de clase computadora: laptop y desktop

   
![derivadas de pc](https://github.com/bautista-escalante/Escalante.bautista.SegundoParcial/assets/123372673/a225fd69-da09-4f47-bf26-1dda596d80b9)


 * celular
   
![celu](https://github.com/bautista-escalante/Escalante.bautista.SegundoParcial/assets/123372673/b6859f45-ad01-4e85-96b8-75c142c365b6)

* televisor 

![tv](https://github.com/bautista-escalante/Escalante.bautista.SegundoParcial/assets/123372673/9a56345a-0993-422e-b903-aa34f7df0aab)

## herencia grafica
al agregar objetos nuevos todos necesitaban diferentes pestañas cons distintos atributos, pero habia 5 iguales que pertenecial a la clase base Tecnologia

![base](https://github.com/bautista-escalante/Escalante.bautista.SegundoParcial/assets/123372673/c81aff56-97fa-4b62-9fb1-0e25d553eb67)

### ejemplo: Celular

![FrmAgregarCelular 3_11_2023 17_54_28](https://github.com/bautista-escalante/Escalante.bautista.SegundoParcial/assets/123372673/79c3d188-4140-4575-bd07-ad68675699f5)


# ventanas

## login
Usando los usuarios hardcodeados en MOCK_DATA.json, permite ingresar el usuario y la contraseña par empezar a interactuar con la app

![login 14_10_2023 12_37_40](https://github.com/bautista-escalante/Escalante.Bautista.PrimerParcial/assets/123372673/0cf35920-9e6e-4621-8724-0297e73286d8)

## pantalla de carga
en un hilo se cargan los datos mientras se muetra una pantalla de carga 

![loading-1](https://github.com/bautista-escalante/Escalante.bautista.SegundoParcial/assets/123372673/4e432556-2b46-45e6-b1c8-d48eb5dd409f)

## pantalla principal 
cuanta con un listBox donde se muestran los productos y un RichTextBox donde se muestra el registro de usuarios
dentro de esta pestaña se puede hacer difentes funcionalidades dependiendo del perfil 
estas estan dadas por los botones

![stock 30_11_2023 19_16_44](https://github.com/bautista-escalante/Escalante.bautista.SegundoParcial/assets/123372673/1ce590fc-a21a-49ed-ab6e-4ff51d1b5cec)

### botones 

 *  agregar elemento
se da a elegir que producto agregar a la base de datos
para luego dirigirte a otra pestaña con los atributos correspondientes

![agregar 30_11_2023 19_29_04](https://github.com/bautista-escalante/Escalante.bautista.SegundoParcial/assets/123372673/be606bd8-fbca-4b6a-9dd4-9478f42d4b19)


 *  ver detalles
esta pestaña te permite ver todos los datos detallados del prodcto seleccionado
tambien te permite calcular el precio del envio

![Detalles 30_11_2023 19_33_46](https://github.com/bautista-escalante/Escalante.bautista.SegundoParcial/assets/123372673/98e78195-965f-4e92-bf91-6321a28c7ae8)

al detectar el canbio surgen dos eventos uno que agrega el precio de envio al RichTextBox y otro que muestrar un gif

![camion](https://github.com/bautista-escalante/Escalante.bautista.SegundoParcial/assets/123372673/0e21d44b-4703-4a79-9036-c0333ad733e8)


 *  modificar precio
este te permite modificar el precio del producto seleccionado

![Modificar 3_11_2023 17_53_24](https://github.com/bautista-escalante/Escalante.bautista.SegundoParcial/assets/123372673/12ad5db9-1898-425b-8602-eee2908dc8df)


 *  ordenar por precio o ordenar por categoria
estos botones cuantan con dos formas, asendente o desendente

![Escalante bautista - Microsoft Visual Studio 30_11_2023 19_46_29](https://github.com/bautista-escalante/Escalante.bautista.SegundoParcial/assets/123372673/b158ac6b-850e-4284-8a03-087664bdfc35)


 *  eliminar producto
este boton borra de manera definitica el producto y te permite guardarlo si queres en un archivo txt usando SaveDialogResult
antes de borrarlo te avisa con esta alerta

![stock 3_11_2023 18_29_10](https://github.com/bautista-escalante/Escalante.bautista.SegundoParcial/assets/123372673/986ca47a-6376-47a0-9c66-6443feec7b33)



















