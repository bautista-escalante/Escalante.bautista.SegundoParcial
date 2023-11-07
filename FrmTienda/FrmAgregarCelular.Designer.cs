namespace FrmTienda
{
    partial class FrmAgregarCelular
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
            txtCamara = new TextBox();
            txtPantalla = new TextBox();
            txtProcesador = new TextBox();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 308);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 14;
            label7.Text = "camara";
            // 
            // txtCamara
            // 
            txtCamara.Location = new Point(138, 300);
            txtCamara.Name = "txtCamara";
            txtCamara.Size = new Size(197, 23);
            txtCamara.TabIndex = 15;
            // 
            // txtPantalla
            // 
            txtPantalla.Location = new Point(138, 364);
            txtPantalla.Name = "txtPantalla";
            txtPantalla.Size = new Size(197, 23);
            txtPantalla.TabIndex = 16;
            // 
            // txtProcesador
            // 
            txtProcesador.Location = new Point(138, 434);
            txtProcesador.Name = "txtProcesador";
            txtProcesador.Size = new Size(197, 23);
            txtProcesador.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 372);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 18;
            label8.Text = "pantalla";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 442);
            label9.Name = "label9";
            label9.Size = new Size(66, 15);
            label9.TabIndex = 19;
            label9.Text = "procesador";
            // 
            // FrmAgregarCelular
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 602);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtProcesador);
            Controls.Add(txtPantalla);
            Controls.Add(txtCamara);
            Controls.Add(label7);
            Name = "FrmAgregarCelular";
            Text = "FrmAgregarCelular";
            Controls.SetChildIndex(label7, 0);
            Controls.SetChildIndex(txtCamara, 0);
            Controls.SetChildIndex(txtPantalla, 0);
            Controls.SetChildIndex(txtProcesador, 0);
            Controls.SetChildIndex(label8, 0);
            Controls.SetChildIndex(label9, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private TextBox txtCamara;
        private TextBox txtPantalla;
        private TextBox txtProcesador;
        private Label label8;
        private Label label9;
    }
}