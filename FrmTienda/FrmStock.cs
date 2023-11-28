﻿using Entidades;
namespace FrmTienda
{
    public partial class FrmStock : Form
    {
        public Carrito<Tecnologia> producto;
        public DateTime ingreso;
        public AccesoProductos data;
        public FrmStock(string usuario, string perfil)
        {
            InitializeComponent();
            producto = new Carrito<Tecnologia>();
            this.MaximizeBox = false;
            this.ingreso = DateTime.Now;
            label2.Text = usuario;
            label4.Text = this.ingreso.ToString();
            RtbRegistro.ReadOnly = true;
            //this.DarAccesos(perfil);
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
                List<Tecnologia>? carritoOrdenado = producto.Ordenar("precio",this.data, false);
                data.ModificarPosiciones(carritoOrdenado);
            }
            else if (rbAsendente.Checked)
            {
                List<Tecnologia>? carritoOrdenado = producto.Ordenar("precio",this.data);
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
                List<Tecnologia>? carritoOrdenado = producto.Ordenar("categoria",this.data, false);
                data.ModificarPosiciones(carritoOrdenado);
            }
            else if (rbAsendente.Checked)
            {
                List<Tecnologia>? carritoOrdenado = producto.Ordenar("categoria",this.data);
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
                    foreach (Tecnologia producto in productos)
                    {
                        string elementoPosible = $"{producto.categoria} || {producto.marca} || {producto.modelo} || ${producto.precio}";
                        if (elemento == elementoPosible)
                        {
                            LsProductos.Items.RemoveAt(indice);
                            data.EliminarDato(producto.categoria, producto.modelo);
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
            if (this.data.probarConexion())
            {
                this.ActualizarVisor();
                RtbRegistro.AppendText(File.ReadAllText(@"..\..\..\usuarios.log"));
            }
        }
        /// <summary>
        /// Actualiza el listbox mostrando una lista de productos desde la base de datos
        /// </summary>
        public void ActualizarVisor()
        {
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

    }
}
