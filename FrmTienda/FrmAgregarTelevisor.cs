using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmTienda
{
    public partial class FrmAgregarTelevisor : FrmBase
    {
        public int resolucion { get; set; }
        public double pulgadas { get; set; }
        public string tipo { get; set; }
        public FrmAgregarTelevisor()
        {
            InitializeComponent();
        }
        public override void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtResolucion.Text == string.Empty || txtPulgdas.Text == string.Empty || txtTipo.Text == string.Empty)
                {
                    throw new ExceptionCampoVacio();
                }
                else if (!int.TryParse(txtResolucion.Text, out int resolucion))
                {
                    throw new CaracterNoNumericoException("Resolucion", "entero");
                }
                else if (!double.TryParse(txtPulgdas.Text, out double pulgadas))
                {
                    throw new CaracterNoNumericoException("Pulgdas", "decimales");
                }
                this.resolucion = resolucion;
                this.pulgadas = pulgadas;
                this.tipo = txtTipo.Text;
                base.asignarValores();
                Televisor tv = new Televisor(this.resolucion, this.pulgadas, this.tipo, base.so, base.ram,base.almacenamiento, base.marca, base.modelo, base.precio);
                foreach (Tecnologia tecnologia in base.datos.ObtenerDatos())
                {
                    Tecnologia dato = base.datos.ObtenerDato(tecnologia.marca, tecnologia.modelo);
                    if (dato.marca == tv.marca && dato.modelo == tv.modelo)
                    {
                        throw new ElementoDuplicadoException("televisor");
                    }
                }
                if (base.datos.AgregarDato(tv))
                {
                    DialogResult = DialogResult.Cancel;
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
            catch (ElementoDuplicadoException ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
