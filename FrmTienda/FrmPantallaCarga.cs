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
    public partial class FrmPantallaCarga : Form
    {
        public string nombre;
        public string perfil;
        public Usuario usuario;
        public FrmPantallaCarga(Usuario usuario)
        {
            this.usuario = usuario;
            this.nombre = usuario.nombre;
            this.perfil = usuario.perfil;
            InitializeComponent();
        }
        private async void FrmPantallaCarga_Load(object sender, EventArgs e)
        {
            pbLoading.Load("loading-1.gif");
            await Cargar();
        }
        public async Task Cargar()
        {
            await Task.Delay(900);
            this.Close();

        }
    }
}
