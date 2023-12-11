using Entidades;
using System;

namespace FrmTienda
{
    public partial class FrmStock : Form
    {
        public Carrito<Tecnologia> producto;
        public static string hora;
        public AccesoProductos data;
        public delegate void Actualizar();
        private System.Threading.Timer timer;
        public FrmStock(string usuario, string perfil)
        {
            InitializeComponent();
            producto = new Carrito<Tecnologia>();
            label2.Text = usuario;
            RtbRegistro.ReadOnly = true;
            this.DarAccesos(perfil);
            this.data = new AccesoProductos();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarProducto frmAgregar = new FrmAgregarProducto();
            frmAgregar.StartPosition = FormStartPosition.CenterScreen;
            frmAgregar.ShowDialog();
            this.ActualizarVisor();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice = LsProductos.SelectedIndex;
            List<Tecnologia> lista = data.ObtenerDatos();
            if (indice != -1 && indice != 0)
            {
                Tecnologia? t = lista[indice - 1];
                FrmModificar modificarProducto = new FrmModificar(t.precio);
                modificarProducto.StartPosition = FormStartPosition.CenterScreen;
                modificarProducto.ShowDialog();
                if (modificarProducto.precio != 0)
                {
                    data.ActializarDato(modificarProducto.precio, t.marca, t.modelo);
                }
            }
            else
            {
                MessageBox.Show("tenes que elegir un elemento ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.ActualizarVisor();
        }
        private void btnVerDetalles_Click(object sender, EventArgs e)
        {
            int indice = LsProductos.SelectedIndex;
            List<Tecnologia> lista = data.ObtenerDatos();
            if (indice != -1 && indice != 0)
            {
                Tecnologia t = lista[indice - 1];
                foreach (Tecnologia tecnologia in lista)
                {
                    if (tecnologia.marca == lista[indice - 1].marca && tecnologia.modelo == lista[indice - 1].modelo)
                    {
                        FrmDetalles detalles = new FrmDetalles(t);
                        detalles.StartPosition = FormStartPosition.CenterScreen;
                        detalles.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("tenes que elegir un elemento ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnOrenar_Click(object sender, EventArgs e)
        {
            if (rbDesedente.Checked)
            {
                List<Tecnologia>? carritoOrdenado = producto.Ordenar("precio", this.data, false);
                data.ModificarPosiciones(carritoOrdenado);
            }
            else if (rbAsendente.Checked)
            {
                List<Tecnologia>? carritoOrdenado = producto.Ordenar("precio", this.data);
                data.ModificarPosiciones(carritoOrdenado);
            }
            else
            {
                MessageBox.Show("tenes que elegir un modo ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.ActualizarVisor();
        }
        private void btnOrdenarCategoria_Click(object sender, EventArgs e)
        {
            if (rbDesedente.Checked)
            {
                List<Tecnologia>? carritoOrdenado = producto.Ordenar("categoria", this.data, false);
                data.ModificarPosiciones(carritoOrdenado);
            }
            else if (rbAsendente.Checked)
            {
                List<Tecnologia>? carritoOrdenado = producto.Ordenar("categoria", this.data);
                data.ModificarPosiciones(carritoOrdenado);
            }
            else
            {
                MessageBox.Show("tenes que elegir un modo ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.ActualizarVisor();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = LsProductos.SelectedIndex;
            if (indice != -1 && indice != 0)
            {
                if (MessageBox.Show("¿Está seguro de que desea eliminar este producto?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string? elemento = LsProductos.SelectedItem.ToString();
                    List<Tecnologia> productos = data.ObtenerDatos();
                    Tecnologia productoEliminado = null;
                    foreach (Tecnologia producto in productos)
                    {
                        string elementoPosible = $"{producto.categoria} || {producto.marca} || {producto.modelo} || ${producto.precio}";
                        if (elemento == elementoPosible)
                        {
                            LsProductos.Items.RemoveAt(indice);
                            data.EliminarDato(producto.categoria, producto.modelo);
                            productoEliminado = producto;
                            break;
                        }
                    }
                    if (productoEliminado != null)
                    {
                        SaveFileDialog guardadArchivo = new SaveFileDialog();
                        guardadArchivo.Filter = "Archivos de texto (*.txt)|*.txt";
                        guardadArchivo.Title = "Guardar Producto Eliminado";
                        if (guardadArchivo.ShowDialog() == DialogResult.OK)
                        {
                            string rutaArchivo = guardadArchivo.FileName;
                            GuardarProductoEliminado(productoEliminado, rutaArchivo);
                        }
                    }
                }
                this.ActualizarVisor();
            }
            else
            {
                MessageBox.Show("tenes que elegir un elemento ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GuardarProductoEliminado(Tecnologia producto, string rutaArchivo)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(rutaArchivo))
                {
                    writer.WriteLine($"Categoría: {producto.categoria}");
                    writer.WriteLine($"Marca: {producto.marca}");
                    writer.WriteLine($"Modelo: {producto.modelo}");
                    writer.WriteLine($"Precio: ${producto.precio}");
                }

                MessageBox.Show($"Producto eliminado guardado en {rutaArchivo}", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el producto eliminado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Productos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void OnTimerTick(object state)
        {
            ActualizarHora();
        }
        private void FrmStock_Load(object sender, EventArgs e)
        {
            if (this.data.probarConexion())
            {
                this.MaximizeBox = false;
                this.ActualizarVisor();
                RtbRegistro.AppendText(File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "usuarios.log")));
                this.timer = new System.Threading.Timer(OnTimerTick, null, 0, 1000);
            }
        }
        /// <summary>
        /// Actualiza el listbox mostrando una lista de productos desde la base de datos
        /// </summary>
        public void ActualizarVisor()
        {
            Thread thread = new Thread(ActualizarHora);
            thread.Start();
            LsProductos.Items.Clear();
            LsProductos.Items.Add($"categoria || marca || modelo || precio ");
            List<Tecnologia> productos = data.ObtenerDatos();
            foreach (Tecnologia producto in productos)
            {
                LsProductos.Items.Add($"{producto.categoria} || {producto.marca} || {producto.modelo} || ${producto.precio}");
            }
        }
        /// <summary>
        /// Asigna permisos de acceso a los botones según el perfil de usuario.
        /// </summary>
        /// <param name="perfil">El perfil del usuario </param>
        public void DarAccesos(string perfil)
        {
            switch (perfil)
            {
                case "vendedor":
                    btnModificar.Enabled = false;
                    btnAgregar.Enabled = false;
                    btnEliminar.Enabled = false;
                    break;
                case "supervisor":
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    break;
            }
        }
        public void ActualizarHora()
        {
            if (InvokeRequired)
            {
               Invoke((MethodInvoker)delegate
                {
                    ActualizarHora();
                });
            }
            else
            {
               label4.Text = DateTime.Now.ToString("HH:mm:ss");
            }
        }
    }
}
