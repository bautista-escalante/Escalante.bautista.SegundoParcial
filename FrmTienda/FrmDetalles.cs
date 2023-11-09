﻿using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FrmTienda
{
    public partial class FrmDetalles : Form, IEnvios
    {
        Tecnologia tecno;
        public FrmDetalles(Tecnologia tecnologia)
        {
            this.tecno = tecnologia;
            InitializeComponent();
        }
        private void btnCancularEnvio_Click(object sender, EventArgs e)
        {
            try
            {
                txtPrecio.Text = this.CalcularPrecio(this.CalcularPeso(), this.CalcularDestino()).ToString();
            }
            catch (ExceptionCampoVacio ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public int CalcularDestino()
        {
            string destino = CbDestino.SelectedItem.ToString();
            if (destino != null)
            {
                int km = 0;
                switch (destino)
                {
                    case "CABA":
                        km = 200;
                        return km;
                    case "Conurbano":
                        km = 500;
                        return km;
                    case "Interior":
                        km = 1000;
                        return km;
                }
                return km;
            }
            else
            {
                throw new ExceptionCampoVacio("destino");
            }
        }
        public double CalcularPeso()
        {
            if (!string.IsNullOrWhiteSpace(txtPeso.Text))
            {
                try
                {
                return int.Parse(txtPeso.Text);
                }
                catch (Exception)
                {
                    throw new Exception("el campo peso debe ser un numero");
                }
            }
            else
            {
                throw new ExceptionCampoVacio("peso");
            }
        }
        public double CalcularPrecio(double peso, int destino)
        {
            double resultado = peso * 10 + destino * 10;
            return resultado;
        }
        private void FrmDetalles_Load(object sender, EventArgs e)
        {
            RtbDetalles.Text = this.tecno.MostrarInformacionTotal();
        }

        private void CbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}