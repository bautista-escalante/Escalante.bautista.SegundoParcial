namespace FrmTienda
{
    partial class FrmAgregarLaptop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label7 = new Label();
            txtPulgadas = new TextBox();
            txtPeso = new TextBox();
            label8 = new Label();
            txtProcesador = new TextBox();
            txtCantNucleos = new TextBox();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 282);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 14;
            label7.Text = "pulgadas";
            // 
            // txtPulgadas
            // 
            txtPulgadas.Location = new Point(138, 274);
            txtPulgadas.Name = "txtPulgadas";
            txtPulgadas.Size = new Size(197, 23);
            txtPulgadas.TabIndex = 15;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(138, 329);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(197, 23);
            txtPeso.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 337);
            label8.Name = "label8";
            label8.Size = new Size(32, 15);
            label8.TabIndex = 20;
            label8.Text = "peso";
            // 
            // txtProcesador
            // 
            txtProcesador.Location = new Point(138, 382);
            txtProcesador.Name = "txtProcesador";
            txtProcesador.Size = new Size(197, 23);
            txtProcesador.TabIndex = 21;
            // 
            // txtCantNucleos
            // 
            txtCantNucleos.Location = new Point(138, 441);
            txtCantNucleos.Name = "txtCantNucleos";
            txtCantNucleos.Size = new Size(197, 23);
            txtCantNucleos.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 390);
            label9.Name = "label9";
            label9.Size = new Size(66, 15);
            label9.TabIndex = 23;
            label9.Text = "procesador";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(25, 449);
            label10.Name = "label10";
            label10.Size = new Size(113, 15);
            label10.TabIndex = 24;
            label10.Text = "cantidad de nucleos";
            // 
            // FrmAgregarLaptop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 611);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtCantNucleos);
            Controls.Add(txtProcesador);
            Controls.Add(label8);
            Controls.Add(txtPeso);
            Controls.Add(txtPulgadas);
            Controls.Add(label7);
            Name = "FrmAgregarLaptop";
            Text = "FrmAgregarLaptop";
            Controls.SetChildIndex(label7, 0);
            Controls.SetChildIndex(txtPulgadas, 0);
            Controls.SetChildIndex(txtPeso, 0);
            Controls.SetChildIndex(label8, 0);
            Controls.SetChildIndex(txtProcesador, 0);
            Controls.SetChildIndex(txtCantNucleos, 0);
            Controls.SetChildIndex(label9, 0);
            Controls.SetChildIndex(label10, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private TextBox txtPulgadas;
        private TextBox txtPeso;
        private Label label8;
        private TextBox txtProcesador;
        private TextBox txtCantNucleos;
        private Label label9;
        private Label label10;
    }
}