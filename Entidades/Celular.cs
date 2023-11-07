using System.Text;

namespace Entidades
{
    public class Celular : Tecnologia
    {
        public string procesador;
        public double pantalla;
        public string camara;


        public Celular(string so, int ram, int almacenamiento, EMarcas marca, string modelo, int precio)
            : base(so, ram, almacenamiento, marca, modelo, precio)
        {
            this.procesador = "no especificado";
            this.camara = "no especificado";
            this.pantalla = 0.0;
        }
        public Celular(string prosador, string camara, string so, int ram, int almacenamiento, EMarcas marca, string modelo, int precio)
            : this(so, ram, almacenamiento, marca, modelo, precio)
        {
            this.procesador = prosador;
            this.camara = camara;
        }
        public Celular(string prosador, string camara, double pantalla, string so, int ram, int almacenamiento, EMarcas marca, string modelo, int precio)
            : this(prosador, camara, so, ram, almacenamiento, marca, modelo, precio)
        {
            this.pantalla = pantalla;
        }
        public Celular(string camara, string prosador, double pantalla, string so, int almacenamiento, EMarcas marca, string modelo, int ram, int precio)
            : this(prosador, camara, pantalla, so, ram, almacenamiento, marca, modelo, precio)
        {
        }
        public override string MostrarInformacionTotal()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"marca {base.marca}");
            sb.AppendLine($"modelo {base.modelo}");
            sb.AppendLine($"sistema {base.sistemOperativo}");
            sb.AppendLine($"procesador {this.procesador}");
            sb.AppendLine($"pulgadas {this.pantalla} ");
            sb.AppendLine($"camara {this.camara}");
            sb.AppendLine($"ram {base.ram} gigabytes");
            sb.AppendLine($"almacenamiento {base.almacenamiento}");
            sb.AppendLine($"precio: ${base.precio}");
            return sb.ToString();
        }
        public override string ObtenerCategoria()
        {
            return "celular";
        }
        public override string ToString()
        {
            return "*********************************";
        }
        public override bool Equals(object? obj)
        {
            bool retorno = false;
            if (obj is Celular)
            {
                retorno = this == (Celular)obj;
            }
            return retorno;
        }
        public static bool operator ==(Celular c1, Celular c2)
        {
            if (c1.pantalla.Equals(c2.pantalla) && c1.modelo.Equals(c2.modelo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Celular c1, Celular c2)
        {
            return !(c1 == c2);
        }
    }
}
