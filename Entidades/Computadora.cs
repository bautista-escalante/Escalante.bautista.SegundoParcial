namespace Entidades
{
    public abstract class Computadora: Tecnologia
    {
        public string procesador { get; set; } 
        public int cantNucleos { get; set; }
        public Computadora(string so, int ram, int almacenamiento, EMarcas marca, string modelo, int precio)
            : base(so, ram, almacenamiento, marca, modelo, precio)
        {
            this.procesador = "no especificado";
            this.cantNucleos = 0;
        }
        public Computadora(string procesador, string so, int ram, int almacenamiento, EMarcas marca, string modelo, int precio)
            : this(so, ram, almacenamiento, marca, modelo, precio)
        {
            this.procesador = procesador;
        }
        public Computadora(string procesador, int nucleos, string so, int ram, int almacenamiento, EMarcas marca, string modelo, int precio)
            :this(procesador, so, ram, almacenamiento, marca, modelo, precio)
        {
            this.cantNucleos = nucleos;
        }
    }
}