using Entidades;
namespace FrmTienda
{
    public partial class FrmDetalles : Form, IEnvios
    {
        public delegate void DetectarCambio(string ruta);
        public event DetectarCambio MostrarAnimacion;
        public event DetectarCambio MostrarEnvio;
        Tecnologia tecno;
        public FrmDetalles(Tecnologia tecnologia)
        {
            this.tecno = tecnologia;
            InitializeComponent();
            MostrarAnimacion += MostarGif;
            MostrarEnvio += ImprimirEnvio;
        }
        public void MostarGif(string ruta)
        {
            pbEnvio.Visible = true;
            pbEnvio.Load(ruta);
        }
        public void ImprimirEnvio(string entrada)
        {
            RtbDetalles.AppendText("precio de envio: $" + entrada + Environment.NewLine);
        }
        private void btnCancularEnvio_Click(object sender, EventArgs e)
        {
            try
            {
                txtPrecio.Text = this.CalcularPrecio(this.CalcularPeso(), this.CalcularDestino()).ToString();
                MostrarAnimacion?.Invoke("camion.gif");
                MostrarEnvio?.Invoke(txtPrecio.Text);
            }
            catch (ExceptionCampoVacio ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public int CalcularDestino()
        {
            string destino = CbDestino.SelectedItem?.ToString();
            if (destino != null)
            {
                int km = 0;
                switch (destino)
                {
                    case "CABA":
                        km = 200;
                        return km;
                    case "Conurbano":
                        km = 500;
                        return km;
                    case "Interior":
                        km = 1000;
                        return km;
                }
                return km;
            }
            else
            {
                throw new ExceptionCampoVacio();
            }
        }
        public double CalcularPeso()
        {
            double peso = 0;
            try
            {
                if (!double.TryParse(txtPeso.Text, out peso))
                {
                    throw new CaracterNoNumericoException("peso", "entero");
                }
                else if (txtPeso.Text == string.Empty)
                {
                    throw new ExceptionCampoVacio();
                }
            }
            catch (CaracterNoNumericoException ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (ExceptionCampoVacio ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return peso;
        }
        public double CalcularPrecio(double peso, int destino)
        {
            double resultado = peso * 10 + destino * 10;
            return resultado;
        }
        private void FrmDetalles_Load(object sender, EventArgs e)
        {
            RtbDetalles.Text = this.tecno.MostrarInformacionTotal();
        }
        private void CbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
