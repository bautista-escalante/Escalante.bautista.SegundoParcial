using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Newtonsoft.Json;

namespace FrmTienda
{
    public partial class FrmAgregarDesktop : FrmBase
    {
        public string? placa { get; set; }
        public string? procesador { get; set; }
        public int? nucleos { get; set; }
        public FrmAgregarDesktop()
        {
            InitializeComponent();
        }
        public override void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPLaca.Text == string.Empty || txtProcesador.Text == string.Empty || txtCantNucleos.Text == string.Empty)
                {
                    throw new ExceptionCampoVacio();
                }
                else if (!int.TryParse(txtCantNucleos.Text, out int cantNucleos))
                {
                    throw new CaracterNoNumericoException("cantidad de nucleos", "entero");
                }
                this.placa = txtPLaca.Text;
                this.procesador = txtProcesador.Text;
                this.nucleos = int.Parse(txtCantNucleos.Text);
                base.asignarValores();
                Destop pc = new Destop(this.placa, base.so, base.ram, base.almacenamiento, base.marca, base.modelo, precio);
                foreach (Tecnologia tecnologia in base.datos.ObtenerDatos())
                {
                    Tecnologia datos = base.datos.ObtenerDato(tecnologia.marca, tecnologia.modelo);
                    if (datos.marca == pc.marca && datos.modelo == pc.modelo)
                    {
                        throw new ElementoDuplicadoException("desktop");
                    }
                }
                if (base.datos.AgregarDato(pc))
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
