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
                this.resolucion = int.Parse(txtResolucion.Text);
                this.pulgadas = double.Parse(txtPulgdas.Text);
                this.tipo = txtTipo.Text;
                base.asignarValores();
                Televisor tv = new Televisor(this.resolucion, this.pulgadas, this.tipo, base.so, base.ram,base.almacenamiento, base.marca, base.modelo, base.precio);
                if (base.datos.AgregarDato(tv))
                {
                    DialogResult = DialogResult.Cancel;
                }
            }
            catch (CaracterNoNumericoException)
            {
                throw new CaracterNoNumericoException("resolucion, pulgadas", "numeros");
            }
        }
    }
}
