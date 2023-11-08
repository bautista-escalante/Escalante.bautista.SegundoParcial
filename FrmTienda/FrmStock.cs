using Entidades;
namespace FrmTienda
{
    public partial class FrmStock : Form
    {
        public Carrito producto;
        public DateTime ingreso;
        public FrmStock(string usuario, string perfil)
        {
            InitializeComponent();
            producto = new Carrito();
            this.MaximizeBox = false;
            this.ingreso = DateTime.Now;
            label2.Text = usuario;
            label4.Text = this.ingreso.ToString();
            RtbRegistro.ReadOnly = true;
            this.DarAccesos(perfil);
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
            List<Carrito> carrito = producto.Deserializar("productos.json");
            if (indice != -1 && indice != 0)
            {
                Carrito c = carrito[indice - 1];
                FrmModificar modificarProducto = new FrmModificar(c.precio);
                modificarProducto.StartPosition = FormStartPosition.CenterScreen;
                modificarProducto.ShowDialog();
                c.precio = modificarProducto.precio;
                producto.serializar("productos.json", carrito);
            }
            else
            {
                MessageBox.Show("tenes que elegir un elemento ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.ActualizarVisor();
        }
        private void btnOrenar_Click(object sender, EventArgs e)
        {
            if (rbDesedente.Checked)
            {
                List<Carrito> carritoOrdenado = producto.OrdenarCarrito(ascendente: false);
                producto.serializar("productos.json", carritoOrdenado);
            }
            else if (rbAsendente.Checked)
            {
                List<Carrito> carritoOrdenado = producto.OrdenarCarrito();
                producto.serializar("productos.json", carritoOrdenado);
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
                    List<Carrito> productos = producto.Deserializar("productos.json");
                    foreach (Carrito producto in productos)
                    {
                        string elementoPosible = $"{producto.categoria} || {producto.marca} || {producto.modelo} || ${producto.precio}";
                        if (elemento == elementoPosible)
                        {
                            LsProductos.Items.RemoveAt(indice);
                            List<Carrito> nuevaLista = productos - producto;
                            producto.serializar("productos.json", nuevaLista);
                            break;
                        }
                    }
                    this.ActualizarVisor();
                }
            }
            else
            {
                MessageBox.Show("tenes que elegir un elemento ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Productos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void FrmStock_Load(object sender, EventArgs e)
        {
            this.ActualizarVisor();
            RtbRegistro.AppendText(File.ReadAllText(@"..\..\..\usuarios.log"));
        }
        /// <summary>
        /// Actualiza el listbox mostrando una lista de productos desde un archivo JSON
        /// </summary>
        public void ActualizarVisor()
        {
            LsProductos.Items.Clear();
            LsProductos.Items.Add($"categoria || marca || modelo || precio ");
            List<Carrito> productos = producto.Deserializar("productos.json");
            foreach (Carrito producto in productos)
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
    }
}
