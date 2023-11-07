using System.Windows.Forms;

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
                    FrmStock frmStock = new FrmStock(frm.UsuarioDelForm.nombre,frm.UsuarioDelForm.perfil);
                    frmStock.StartPosition = FormStartPosition.CenterScreen;
                    Application.Run(frmStock);
                }          

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("La aplicación terminó.", "FIN DEL PROGRAMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}