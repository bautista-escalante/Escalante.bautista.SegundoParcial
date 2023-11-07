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
            rbSi = new RadioButton();
            rbNo = new RadioButton();
            groupBox1 = new GroupBox();
            txtPeso = new TextBox();
            label8 = new Label();
            txtProcesador = new TextBox();
            txtCantNucleos = new TextBox();
            label9 = new Label();
            label10 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 318);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 14;
            label7.Text = "pulgadas";
            // 
            // txtPulgadas
            // 
            txtPulgadas.Location = new Point(138, 310);
            txtPulgadas.Name = "txtPulgadas";
            txtPulgadas.Size = new Size(197, 23);
            txtPulgadas.TabIndex = 15;
            // 
            // rbSi
            // 
            rbSi.AutoSize = true;
            rbSi.Location = new Point(23, 22);
            rbSi.Name = "rbSi";
            rbSi.Size = new Size(33, 19);
            rbSi.TabIndex = 16;
            rbSi.TabStop = true;
            rbSi.Text = "si";
            rbSi.UseVisualStyleBackColor = true;
            // 
            // rbNo
            // 
            rbNo.AutoSize = true;
            rbNo.Location = new Point(23, 45);
            rbNo.Name = "rbNo";
            rbNo.Size = new Size(39, 19);
            rbNo.TabIndex = 17;
            rbNo.TabStop = true;
            rbNo.Text = "no";
            rbNo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbSi);
            groupBox1.Controls.Add(rbNo);
            groupBox1.Location = new Point(12, 409);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(94, 70);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "rgb";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(138, 353);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(197, 23);
            txtPeso.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 362);
            label8.Name = "label8";
            label8.Size = new Size(32, 15);
            label8.TabIndex = 20;
            label8.Text = "peso";
            // 
            // txtProcesador
            // 
            txtProcesador.Location = new Point(138, 397);
            txtProcesador.Name = "txtProcesador";
            txtProcesador.Size = new Size(197, 23);
            txtProcesador.TabIndex = 21;
            // 
            // txtCantNucleos
            // 
            txtCantNucleos.Location = new Point(138, 450);
            txtCantNucleos.Name = "txtCantNucleos";
            txtCantNucleos.Size = new Size(197, 23);
            txtCantNucleos.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(138, 379);
            label9.Name = "label9";
            label9.Size = new Size(66, 15);
            label9.TabIndex = 23;
            label9.Text = "procesador";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(138, 433);
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
            Controls.Add(groupBox1);
            Controls.Add(txtPulgadas);
            Controls.Add(label7);
            Name = "FrmAgregarLaptop";
            Text = "FrmAgregarLaptop";
            Controls.SetChildIndex(label7, 0);
            Controls.SetChildIndex(txtPulgadas, 0);
            Controls.SetChildIndex(groupBox1, 0);
            Controls.SetChildIndex(txtPeso, 0);
            Controls.SetChildIndex(label8, 0);
            Controls.SetChildIndex(txtProcesador, 0);
            Controls.SetChildIndex(txtCantNucleos, 0);
            Controls.SetChildIndex(label9, 0);
            Controls.SetChildIndex(label10, 0);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private TextBox txtPulgadas;
        private RadioButton rbSi;
        private RadioButton rbNo;
        private GroupBox groupBox1;
        private TextBox txtPeso;
        private Label label8;
        private TextBox txtProcesador;
        private TextBox txtCantNucleos;
        private Label label9;
        private Label label10;
    }
}