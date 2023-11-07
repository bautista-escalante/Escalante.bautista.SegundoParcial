﻿using System;
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
    public partial class FrmModificar : Form
    {
        internal int? precio;
        public FrmModificar(int? precio)
        {
            this.precio = precio;
            InitializeComponent();
            this.ControlBox = false;

        }
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                int nuevoPrecio = int.Parse(txtNuevo.Text);
                if(nuevoPrecio != 0)
                {
                    this.precio = nuevoPrecio;
                    DialogResult = DialogResult.Cancel;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("el precio debe ser un numero entero", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea cancelar? todo el progreso se perdera", "Confirmar Cierre", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                DialogResult = DialogResult.Cancel;
            }
        }
        private void FrmModificar_Load(object sender, EventArgs e)
        {
            this.textBox2.Text = this.precio.ToString();
        }
    }
}