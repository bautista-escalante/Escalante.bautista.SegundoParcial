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
    public partial class FrmAgregarProducto : Form
    {
        public FrmAgregarProducto()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }
        private void btnCelular_Click(object sender, EventArgs e)
        {
            FrmAgregarCelular frmAgregar = new FrmAgregarCelular();
            frmAgregar.StartPosition = FormStartPosition.CenterScreen;
            frmAgregar.ShowDialog();
            DialogResult = DialogResult.Cancel;
        }
        private void BtnConsola_Click(object sender, EventArgs e)
        {
            FrmAgregarConsola frmAgregar = new FrmAgregarConsola();
            frmAgregar.StartPosition = FormStartPosition.CenterScreen;
            frmAgregar.ShowDialog();
            DialogResult = DialogResult.Cancel;
        }
        private void btnDesktop_Click(object sender, EventArgs e)
        {
            FrmAgregarDesktop frmAgregar = new FrmAgregarDesktop();
            frmAgregar.StartPosition = FormStartPosition.CenterScreen;
            frmAgregar.ShowDialog();
            DialogResult = DialogResult.Cancel;
        }
        private void btnLaptop_Click(object sender, EventArgs e)
        {
            FrmAgregarLaptop frmAgregar = new FrmAgregarLaptop();
            frmAgregar.StartPosition = FormStartPosition.CenterScreen;
            frmAgregar.ShowDialog();
            DialogResult = DialogResult.Cancel;
        }
        private void btnTelevisor_Click(object sender, EventArgs e)
        {
            FrmAgregarTelevisor frmAgregar = new FrmAgregarTelevisor();
            frmAgregar.StartPosition = FormStartPosition.CenterScreen;
            frmAgregar.ShowDialog();
            DialogResult = DialogResult.Cancel;
        }
    }
}
