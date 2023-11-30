using Newtonsoft.Json;
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
    public partial class FrmAgregarLaptop : FrmBase
    {
        public double pulgadas { get; set; }
        public int peso { get; set; }
        public bool rgb { get; set; }
        public int cantNucleos { get; set; }
        public string procesador { get; set; }
        public FrmAgregarLaptop()
        {
            InitializeComponent();
        }
        public override void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPulgadas.Text == string.Empty || txtProcesador.Text == string.Empty 
                    || txtPeso.Text == string.Empty || txtCantNucleos.Text == string.Empty )
                {
                    throw new ExceptionCampoVacio();
                }
                else if (!double.TryParse(txtPulgadas.Text, out double Pulgadas))
                {
                    throw new CaracterNoNumericoException("pulgadas", "desimal");
                }
                else if (!int.TryParse(txtPeso.Text, out int peso))
                {
                    throw new CaracterNoNumericoException("peso", "entero");
                }
                else if (!int.TryParse(txtCantNucleos.Text, out int cantNucleos))
                {
                    throw new CaracterNoNumericoException("cantidad de nucleos", "entero");
                }

                this.pulgadas = pulgadas;
                this.peso = peso;
                base.asignarValores();
                this.cantNucleos = cantNucleos;
                this.procesador = txtProcesador.Text;
                Laptop laptop = new Laptop(this.pulgadas, this.peso, procesador, cantNucleos, base.so, base.ram, base.almacenamiento, base.marca, base.modelo, precio);
                foreach (Tecnologia tecnologia in base.datos.ObtenerDatos())
                {
                    Tecnologia dato = base.datos.ObtenerDato(tecnologia.marca, tecnologia.modelo);
                    if (dato.marca == laptop.marca && dato.modelo == laptop.modelo)
                    {
                        throw new ElementoDuplicadoException("laptop");
                    }
                }
                if (base.datos.AgregarDato(laptop))
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
