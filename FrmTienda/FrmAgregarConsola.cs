using Entidades;
namespace FrmTienda
{
    public partial class FrmAgregarConsola : FrmBase
    {
        public string chip { get; set; }
        public FrmAgregarConsola()
        {
            InitializeComponent();
        }
        /*try
            {
                if (txtCamara.Text == string.Empty || txtProcesador.Text == string.Empty || txtPantalla.Text == string.Empty) 
                { 
                    throw new ExceptionCampoVacio();
                }
                else if (!double.TryParse(txtPantalla.Text, out double pantalla))
                {
                    throw new CaracterNoNumericoException("Pantalla", "desimal");
                }
                this.camara = txtCamara.Text;
                this.procesador = txtProcesador.Text;
                this.pantalla = pantalla;
                base.asignarValores();
                Celular celular = new Celular(this.camara, this.procesador, this.pantalla, base.so, base.almacenamiento, base.marca, base.modelo, base.ram, base.precio);
                if(base.datos.AgregarDato(celular))
                {
                    DialogResult = DialogResult.Cancel;
                }
            }
            catch (ExceptionCampoVacio ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch(CaracterNoNumericoException ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }*/
        public override void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtChip.Text == string.Empty)
                {
                    throw new ExceptionCampoVacio();
                }
                this.chip = txtChip.Text;
                base.asignarValores();
                Consola consola = new Consola(this.chip, base.so, base.ram, base.almacenamiento, base.marca, base.modelo, base.precio);
                base.datos.AgregarDato(consola);
                DialogResult = DialogResult.Cancel;
            }
            catch (ExceptionCampoVacio ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("Error creando el producto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}