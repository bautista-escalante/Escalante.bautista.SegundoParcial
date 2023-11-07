namespace FrmTienda
{
    partial class FrmAgregarDesktop
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
            txtPLaca = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtCantNucleos = new TextBox();
            txtProcesador = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // txtPLaca
            // 
            txtPLaca.Location = new Point(138, 296);
            txtPLaca.Name = "txtPLaca";
            txtPLaca.Size = new Size(197, 23);
            txtPLaca.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 304);
            label7.Name = "label7";
            label7.Size = new Size(83, 15);
            label7.TabIndex = 15;
            label7.Text = "placa de video";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 433);
            label8.Name = "label8";
            label8.Size = new Size(107, 15);
            label8.TabIndex = 18;
            label8.Text = "cantidad de nuclos";
            // 
            // txtCantNucleos
            // 
            txtCantNucleos.Location = new Point(138, 425);
            txtCantNucleos.Name = "txtCantNucleos";
            txtCantNucleos.Size = new Size(197, 23);
            txtCantNucleos.TabIndex = 20;
            // 
            // txtProcesador
            // 
            txtProcesador.Location = new Point(138, 366);
            txtProcesador.Name = "txtProcesador";
            txtProcesador.Size = new Size(197, 23);
            txtProcesador.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 374);
            label9.Name = "label9";
            label9.Size = new Size(66, 15);
            label9.TabIndex = 22;
            label9.Text = "procesador";
            // 
            // FrmAgregarDesktop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 590);
            Controls.Add(label9);
            Controls.Add(txtProcesador);
            Controls.Add(txtCantNucleos);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtPLaca);
            Name = "FrmAgregarDesktop";
            Text = "FrmAgregarDesktop";
            Controls.SetChildIndex(txtPLaca, 0);
            Controls.SetChildIndex(label7, 0);
            Controls.SetChildIndex(label8, 0);
            Controls.SetChildIndex(txtCantNucleos, 0);
            Controls.SetChildIndex(txtProcesador, 0);
            Controls.SetChildIndex(label9, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPLaca;
        private Label label7;
        private Label label8;
        private TextBox txtCantNucleos;
        private TextBox txtProcesador;
        private Label label9;
    }
}