using Entidades;
using System.Windows.Forms;

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
                if (txtSo.Text == string.Empty || txtModelo.Text == string.Empty || txtRam.Text == string.Empty
                    || txtAlmacenamiento.Text == string.Empty || txtPrecio.Text == string.Empty)
                {
                    throw new ExceptionCampoVacio();
                }
                else if (!int.TryParse(txtRam.Text, out int ram))
                {
                    throw new CaracterNoNumericoException("ram", "entero");
                }
                else if (!int.TryParse(txtAlmacenamiento.Text, out int almacenamiento))
                {
                    throw new CaracterNoNumericoException("almacenamiento", "entero");
                }
                else if (!int.TryParse(txtPrecio.Text, out int precio))
                {
                    throw new CaracterNoNumericoException("precio", "entero");
                }
                this.so = txtSo.Text;
                this.modelo = txtModelo.Text;
                this.ram = ram;
                this.almacenamiento = almacenamiento;
                this.precio = precio;
                this.marca = this.obtener_marca();
            }
            catch (CaracterNoNumericoException ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (ExceptionCampoVacio ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
