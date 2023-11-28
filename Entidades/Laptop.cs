using System.Text;

namespace Entidades
{
    public class Laptop: Computadora
    {
        public double pulgadas { get; set; }
        public int peso { get; set; }
        public Laptop(string procesador, int nucleos, string so, int ram, int almacenamiento, EMarcas marca, string modelo, int precio)
            : base( procesador, nucleos, so, ram, almacenamiento, marca, modelo, precio)
        {
            this.pulgadas = 0;
            this.peso = 0;
        }
        public Laptop(double pulgadas,int peso, string procesador, int nucleos, string so, int ram, int almacenamiento, EMarcas marca, string modelo, int precio)
            : this( procesador, nucleos, so, ram, almacenamiento, marca, modelo, precio)
        {
            this.pulgadas = pulgadas;
            this.peso = peso;
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
            sb.AppendLine($"pantalla: {this.pulgadas}"+'"');
            sb.AppendLine($"peso: {this.peso}");
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
            if (obj is Laptop)
            {
                retorno = this == (Laptop)obj;
            }
            return retorno;
        }
        public static bool operator ==(Laptop l1, Laptop l2)
        {
            if (l1.peso.Equals(l2.peso) && l1.modelo.Equals(l2.modelo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Laptop l1, Laptop l2)
        {
            return !(l1 == l2);
        }
        public override string ObtenerCategoria()
        {
            return "laptop";
        }
    }
}
