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
                this.placa = txtPLaca.Text;
                this.procesador = txtProcesador.Text;
                this.nucleos = int.Parse(txtCantNucleos.Text);
                base.asignarValores();
                Destop pc = new Destop(this.placa, base.so, base.ram, base.almacenamiento, base.marca, base.modelo, precio);
                base.AgregarElemento(pc);
                DialogResult = DialogResult.Cancel;
            }
            catch (Exception)
            {
                MessageBox.Show("Error. ingrese un numero entero en nucleos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
