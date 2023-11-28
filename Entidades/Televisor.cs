using System.Text;
namespace Entidades
{
    public class Televisor :Tecnologia
    {
        public int resolucion { get; set; }
        public double pulgadas { get; set; }
        public string tipo { get; set; }
        public Televisor(string tipo, string so, int ram, int almacenamiento, EMarcas marca, string modelo, int precio)
            : base( so, ram, almacenamiento, marca, modelo,precio)
        {
            this.resolucion = 0;
            this.pulgadas = 0;
            this.tipo = "no especificado";
        }
        public Televisor(int resolucion,string tipo, string so, int ram, int almacenamiento, EMarcas marca, string modelo, int precio)
            : this( tipo, so, ram, almacenamiento, marca, modelo, precio)
        {
            this.resolucion = resolucion;
            this.tipo = tipo;
        }
        public Televisor(int resolucion,double pulgadas, string tipo, string so, int ram, int almacenamiento, EMarcas marca, string modelo, int precio)
            : this(resolucion,tipo,so,ram,almacenamiento,marca,modelo,precio)
        {
            this.pulgadas = pulgadas;
        }
        public override string MostrarInformacionTotal()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"marca: {base.marca}");
            sb.AppendLine($"modelo: {base.modelo}");
            sb.AppendLine($"sistemaOperativo: {base.sistemOperativo}");
            sb.AppendLine($"pulgadas: {this.pulgadas}"+'"');
            sb.AppendLine($"resolucion: {this.resolucion}");
            sb.AppendLine($"tipo de pantalla: {this.tipo}");
            sb.AppendLine($"ram: {base.ram} gigabytes");
            sb.AppendLine($"almacenamiento: {base.almacenamiento} gigabytes");
            sb.AppendLine($"precio: ${base.precio}");
            return sb.ToString();
        }
        public override string ObtenerCategoria()
        {
            return "televisor";
        }
        public override string ToString()
        {
            return "____________________________";
        }
        public override bool Equals(object? obj)
        {
            bool retorno = false;
            if (obj is Televisor)
            {
                retorno = this == (Televisor)obj;
            }
            return retorno;
        }
        public static bool operator ==(Televisor t1,Televisor t2)
        {
            if (t1.pulgadas.Equals(t2.pulgadas) && t1.modelo.Equals(t2.modelo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Televisor t1, Televisor t2)
        {
            return !(t1 == t2);
        }
    }
}
