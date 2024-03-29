using System.Configuration;
using System.Text.Json;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace FrmTienda
{
    public partial class FrmLogin : Form
    {
        private Usuario usuario;
        public Usuario UsuarioDelForm
        {
            get { return this.usuario; }
        }
        public FrmLogin()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }
        public FrmLogin(Usuario usuario) : this()
        {
            this.usuario = usuario;
            this.txtusuario.Focus();
        }
        private void btningresar_Click(object sender, EventArgs e)
        {
            this.usuario = this.Verificar();
            if (this.usuario != null)
            {
                GuardarIngreso(this.usuario);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Error al iniciar sesion");
            }
            this.DialogResult = DialogResult.OK;
        }
        /// <summary>
        /// Verifica las credenciales de un usuario compar�ndolas con un archivo JSON 
        /// </summary>
        /// <returns>
        /// Un objeto de tipo Usuario si las credenciales son v�lidas, o null si no se encontr� ninguna coincidencia.
        /// </returns>
        private Usuario Verificar()
        {
                Usuario? rta = null ;
            string ruta = Directory.GetCurrentDirectory() + @"\MOCK_DATA.json";
            using (StreamReader sr = new StreamReader(ruta))
            {                       
                    string json_str = sr.ReadToEnd();

                List<Usuario>? usuarios = JsonConvert.DeserializeObject<List<Usuario>?>(File.ReadAllText(ruta));
                foreach (Usuario item in usuarios)
                {
                    if (item.nombre == this.txtusuario.Text && item.clave == this.txtcontrase�a.Text || item.correo == this.txtusuario.Text && item.clave == this.txtcontrase�a.Text)
                    {
                        rta = item;
                        break;
                    }
                }
            }
                return rta;
        }
        /// <summary>
        /// Registra el ingreso de un usuario en un archivo de registro
        /// </summary>
        /// <param name="usuario">El objeto Usuario que representa al usuario que ingres�</param>
        public void GuardarIngreso(Usuario usuario)
        {
            using (StreamWriter sw = File.AppendText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "usuarios.log")))
            {
                sw.WriteLine($"ingreso: {usuario.nombre} {usuario.apellido}");
                sw.WriteLine($"correo: {usuario.correo}");
                sw.WriteLine($"fecha:  {DateTime.Now}");
                sw.WriteLine(usuario.ToString());
            }       
        }
    }
}