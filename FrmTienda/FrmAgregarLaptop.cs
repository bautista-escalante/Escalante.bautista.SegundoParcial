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
                this.pulgadas = double.Parse(txtPulgadas.Text);
                this.peso = int.Parse(txtPeso.Text);
                base.asignarValores();
                this.cantNucleos = int.Parse(txtCantNucleos.Text);
                this.procesador = txtProcesador.Text;
                Laptop laptop = new Laptop(this.rgb, this.pulgadas, this.peso,procesador,cantNucleos, base.so, base.ram, base.almacenamiento, base.marca, base.modelo, precio);
                base.AgregarElemento(laptop);
                DialogResult = DialogResult.Cancel;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("pulgadas, peso, nucleos y precio deben ser numeros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (JsonSerializationException)
            {
                MessageBox.Show("error al crear el producto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
