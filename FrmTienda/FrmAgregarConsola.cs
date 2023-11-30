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
                foreach (Tecnologia tecnologia in base.datos.ObtenerDatos())
                {
                    Tecnologia datos = base.datos.ObtenerDato(tecnologia.marca, tecnologia.modelo);
                    if (datos.marca == consola.marca && datos.modelo == consola.modelo)
                    {
                        throw new ElementoDuplicadoException("consola");
                    }
                }
                if (base.datos.AgregarDato(consola))
                {
                    DialogResult = DialogResult.Cancel;
                }
            }
            catch (ExceptionCampoVacio ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (ElementoDuplicadoException ex)
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