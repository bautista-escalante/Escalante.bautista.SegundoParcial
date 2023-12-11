using System.Windows.Forms;
using System.Threading.Tasks;
namespace FrmTienda
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            FrmLogin frm = new FrmLogin();
            frm.StartPosition = FormStartPosition.CenterScreen;
            try
            {
                do
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        break;
                    }
                }while (frm.DialogResult != DialogResult.Cancel);
                if (frm.UsuarioDelForm != null)
                {
                    Task.Run(() => nombre(frm.UsuarioDelForm));
                    FrmStock stock = new FrmStock(frm.UsuarioDelForm.nombre, frm.UsuarioDelForm.perfil);
                    stock.StartPosition = FormStartPosition.CenterScreen;
                    stock.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void nombre(Usuario usuario)
        {
            FrmPantallaCarga frmCarga = new FrmPantallaCarga(usuario);
            frmCarga.StartPosition = FormStartPosition.CenterScreen;
            frmCarga.ShowDialog();
        }
    }
}