namespace FrmTienda
{
    partial class FrmAgregarTelevisor
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
            txtPulgdas = new TextBox();
            label7 = new Label();
            txtResolucion = new TextBox();
            txtTipo = new TextBox();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // txtPulgdas
            // 
            txtPulgdas.Location = new Point(138, 375);
            txtPulgdas.Name = "txtPulgdas";
            txtPulgdas.Size = new Size(197, 23);
            txtPulgdas.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 317);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 15;
            label7.Text = "resolucion";
            // 
            // txtResolucion
            // 
            txtResolucion.Location = new Point(138, 309);
            txtResolucion.Name = "txtResolucion";
            txtResolucion.Size = new Size(197, 23);
            txtResolucion.TabIndex = 16;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(138, 435);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(197, 23);
            txtTipo.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 383);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 18;
            label8.Text = "pulgadas";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 443);
            label9.Name = "label9";
            label9.Size = new Size(28, 15);
            label9.TabIndex = 19;
            label9.Text = "tipo";
            // 
            // FrmAgregarTelevisor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 595);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtTipo);
            Controls.Add(txtResolucion);
            Controls.Add(label7);
            Controls.Add(txtPulgdas);
            Name = "FrmAgregarTelevisor";
            Text = "Televisor";
            Controls.SetChildIndex(txtPulgdas, 0);
            Controls.SetChildIndex(label7, 0);
            Controls.SetChildIndex(txtResolucion, 0);
            Controls.SetChildIndex(txtTipo, 0);
            Controls.SetChildIndex(label8, 0);
            Controls.SetChildIndex(label9, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPulgdas;
        private Label label7;
        private TextBox txtResolucion;
        private TextBox txtTipo;
        private Label label8;
        private Label label9;
    }
}