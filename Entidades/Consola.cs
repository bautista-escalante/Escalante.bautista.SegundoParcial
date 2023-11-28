using System.Text;

namespace Entidades
{
    public class Consola : Tecnologia
    {
        public string chipVideo; 
        
        public Consola(string so, int ram, int almacenamiento, EMarcas marca, string modelo, int precio)
            : base( so, ram, almacenamiento, marca, modelo, precio)
        {
            this.chipVideo = "no especificado";
        }
        public Consola(string chipVideo, string so, int ram, int almacenamiento, EMarcas marca, string modelo, int precio)
            : this(so, ram, almacenamiento, marca, modelo, precio)
        {
            this.chipVideo = chipVideo;
        }

        public override string MostrarInformacionTotal()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"marca: {base.marca}");
            sb.AppendLine($"modelo: {base.modelo}");
            sb.AppendLine($"sistemaOperativo: {base.sistemOperativo}");
            sb.AppendLine($"pulgadas: {this.chipVideo} ");
            sb.AppendLine($"ram: {base.ram} gigabytes");
            sb.AppendLine($"almacenamiento: {base.almacenamiento} gigabytes");
            sb.AppendLine($"precio: ${base.precio}");
            return sb.ToString();
        }
        public override string ObtenerCategoria()
        {
            return "consola";
        }
        public override string ToString()
        {
            return "---------------------------";
        }
        public override bool Equals(object? obj)
        {
            bool retorno = false;
            if (obj is Consola)
            {
                retorno = this == (Consola)obj;
            }
            return retorno;
        }
        public static bool operator ==(Consola c1, Consola c2)
        {
            if (c1.sistemOperativo.Equals(c2.sistemOperativo) && c1.modelo.Equals(c2.modelo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Consola c1, Consola c2)
        {
            return !(c1==c2);
        }
    }
}
