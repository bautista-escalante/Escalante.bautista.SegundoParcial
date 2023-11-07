using Newtonsoft.Json;
using System.Text;

namespace Entidades
{
    public abstract class Tecnologia
    {
        public string sistemOperativo { get; set; }
        public int ram { get; set; }
        public int almacenamiento { get; set; }
        public EMarcas marca { get; set; }
        public string modelo { get; set; }
        public int precio { get; set; }
        public string categoria { get; set; }
        protected Tecnologia()
        {
            this.ram = 0;
            this.almacenamiento = 0;
            this.sistemOperativo = "sin sistema";
            this.precio = 0;
            this.marca = EMarcas.indefinido;
            this.modelo = "no definido";
            this.categoria = this.ObtenerCategoria();
        }
        protected Tecnologia(string so):this()
        {
            this.sistemOperativo = so;
        }
        protected Tecnologia(string so, int ram):this(so)
        {
            this.ram = ram;
        }
        protected Tecnologia(string so, int ram,int almacenamiento):this(so,ram)
        {
            this.almacenamiento = almacenamiento;
        }

        protected Tecnologia(string so, int ram, int almacenamiento, EMarcas marca)
            :this(so,ram,almacenamiento)
        {
            this.marca = marca;
        }
        protected Tecnologia(string so, int ram, int almacenamiento, EMarcas marca,string modelo,int precio)
            : this(so, ram, almacenamiento,marca)
        {
            this.modelo = modelo;
            this.precio = precio;
        }
        /// <summary>
        /// brinda informacian sobre: la marca, el modelo y el precio.
        /// </summary>
        /// <returns>
        /// Una cadena de texto que contiene la marca, modelo y precio del dispositivo.
        /// </returns>
        public string MostrarInformacionParcial()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($" marca: {this.marca} || modelo: {this.modelo} || precio: {this.precio}");
            return sb.ToString();
        }
        /// <summary>
        /// Obtiene la información detallada de un dispositivo y le da formato
        /// </summary>
        /// <returns>
        /// un string que contiene información detallada del dispositivo.
        /// </returns>
        public abstract string MostrarInformacionTotal();
        /// <returns>
        /// en una línea de caracteres especiales que es utilizada com separadores
        /// </returns>
        public virtual string ToString()
        {
            return string.Empty;
        }
        /// <summary>
        /// Determina si el objeto ingresado es igual a otro objeto
        /// </summary>
        /// <returns>
        /// true si el objeto actual es igual al objeto pasado como argumento de tipo Celular; de lo contrario, false.
        /// </returns>
        public virtual bool Equals(object ob)
        {
            return base.Equals(ob);
        }
        /// <returns>
        /// la categoria ala que pertenece
        /// </returns>
        public virtual string ObtenerCategoria()
        {
            return "tecnologia"; 
        }


    }
}