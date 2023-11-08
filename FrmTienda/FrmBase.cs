using Entidades;
namespace FrmTienda
{
    public partial class FrmBase : Form
    {
        public string so { get; set; }
        public EMarcas marca { get; set; }
        public string modelo { get; set; }
        public int ram { get; set; }
        public int almacenamiento { get; set; }
        public int precio { get; set; }
        public Carrito producto { get; set; }
        public FrmBase()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.producto = new Carrito();
        }
        public virtual void btnAceptar_Click(object sender, EventArgs e)
        {
        }
        public void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea cancelar? todo el progreso se perdera", "Confirmar Cierre", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                DialogResult = DialogResult.Cancel;
            }
        }
        /// <summary>
        /// Asigna valores a las propiedades de un objeto Celular a partir de los datos ingresados en los controles de la interfaz.
        /// </summary>
        public void asignarValores()
        {
            try
            {
                this.so = txtSo.Text;
                this.modelo = txtModelo.Text;
                this.ram = int.Parse(txtRam.Text);
                this.almacenamiento = int.Parse(txtAlmacenamiento.Text);
                this.precio = int.Parse(txtPrecio.Text);
                this.marca = this.obtener_marca();
            }
            catch (Exception)
            {
                MessageBox.Show("almacenamiento, ram y precio deben ser numeros enteros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Obtiene una marca de la enumeración EMarcas a partir de un valor ingresado en un control de texto.
        /// </summary>
        /// <returns>
        /// Un valor de la enumeración EMarcas que representa la marca obtenida a partir del texto ingresado.
        /// Si la marca no existe, se devuelve EMarcas.indefinido.
        /// </returns>
        public EMarcas obtener_marca()
        {
            try
            {
                EMarcas marca = (EMarcas)Enum.Parse(typeof(EMarcas), txtMarca.Text);
                return marca;
            }
            catch (Exception)
            {
                MessageBox.Show("la marca no existe", "NO EXISTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ShowDialog();
                return EMarcas.indefinido;
            }
        }
        ///<summary>
        /// Realiza la deserialización de datos desde un archivo JSON original,
        /// luego serializa nuevos datos en un archivo JSON, y agrega los datos 
        /// deserializados a la lista original antes de volver a serializarla.
        /// </summary>
        /// <param name="tecnologia">La tecnología a ser serializada en el archivo nuevo.</param>
        /// <returns>Una lista actualizada de objetos Carrito.</returns>
        public void AgregarElemento(Tecnologia tecnologia)
        {
            Carrito carrito = new Carrito();
            List<Carrito> listaPrincipal = carrito.Deserializar("productos.json");
            carrito.serializar("productos.json", tecnologia);
            Carrito nuevojson = carrito.Deserializar();
            listaPrincipal += nuevojson;
            carrito.serializar("productos.json", listaPrincipal);
        }
    }
}
