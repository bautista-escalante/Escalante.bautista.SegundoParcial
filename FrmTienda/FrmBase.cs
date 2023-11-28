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
        public AccesoProductos datos;
        public List<Tecnologia> producto { get; set; }
        public FrmBase()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.datos = new AccesoProductos();
            this.producto = this.datos.ObtenerDatos();
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
            catch (CaracterNoNumericoException)
            {
                throw new CaracterNoNumericoException("almacenamiento, ram y precio", "entero");
            }
            catch (ExceptionCampoVacio)
            {
                throw new CaracterNoNumericoException("precio","entero");
            }
            catch (Exception)
            {
                throw new Exception("error inesperado");
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
                EMarcas marca = (EMarcas)Enum.Parse(typeof(EMarcas), cbMarca.Text);
                return marca;
            }
            catch (Exception)
            {
                MessageBox.Show("la marca no existe", "NO EXISTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ShowDialog();
                return EMarcas.indefinido;
            }
        }
    }
}
