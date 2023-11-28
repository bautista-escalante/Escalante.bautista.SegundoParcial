using System.Text;

namespace Entidades
{
    public class Destop :Computadora
    {
        public string placaVideo;
        public Destop(string so, int ram, int almacenamiento, EMarcas marca, string modelo, int precio)
            : base(so, ram, almacenamiento, marca, modelo, precio)
        {
            this.placaVideo = "no especificado";
        }
        public Destop(string placaVideo, string so, int ram, int almacenamiento, EMarcas marca, string modelo, int precio)
            : this( so, ram, almacenamiento, marca, modelo, precio)
        {
            this.placaVideo = placaVideo;
        }
        public override string MostrarInformacionTotal()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"marca: {base.marca}");
            sb.AppendLine($"modelo: {base.modelo}");
            sb.AppendLine($"sistemaOperativo: {base.sistemOperativo}");
            sb.AppendLine($"procesador: {this.procesador}");
            sb.AppendLine($"cantNucleos: {this.cantNucleos}");
            sb.AppendLine($"ram: {base.ram} gigabytes");
            sb.AppendLine($"almacenamiento: {base.almacenamiento} gigabytes");
            sb.AppendLine($"placa de video: {this.placaVideo}");
            sb.AppendLine($"precio: ${base.precio}");
            return sb.ToString();
        }
        public override string ToString()
        {
            return "###########################";
        }
        public override bool Equals(object? obj)
        {
            bool retorno = false;
            if (obj is Destop)
            {
                retorno = this == (Destop)obj;
            }
            return retorno;
        }
        public static bool operator ==(Destop d1, Destop d2)
        {
            if (d1.placaVideo.Equals(d2.placaVideo) && d1.modelo.Equals(d2.modelo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Destop d1, Destop d2)
        {
            return !(d1 == d2);
        }
        public override string ObtenerCategoria()
        {
            return "desktop";
        }
    }
}
