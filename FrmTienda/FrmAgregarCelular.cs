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
    public partial class FrmAgregarCelular : FrmBase
    {
        public string? camara { get; set; }
        public string? procesador { get; set; }
        public double pantalla { get; set; }
        public FrmAgregarCelular()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        public override void btnAceptar_Click(object sender, EventArgs e)
        {
            try
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
            }
        }
    }
}
