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
                this.chip = txtChip.Text;
                base.asignarValores();
                Consola consola = new Consola(this.chip, base.so, base.ram, base.almacenamiento, base.marca, base.modelo, base.precio);
                base.AgregarElemento(consola);
                DialogResult = DialogResult.Cancel;
            }
            catch (Exception)
            {
                MessageBox.Show("Error creando el producto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}