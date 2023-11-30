namespace FrmTienda
{
    partial class FrmDetalles
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
            RtbDetalles = new RichTextBox();
            btnCancularEnvio = new Button();
            btnSalir = new Button();
            txtPrecio = new TextBox();
            txtPeso = new TextBox();
            precio = new Label();
            label2 = new Label();
            label3 = new Label();
            CbDestino = new ComboBox();
            pbEnvio = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbEnvio).BeginInit();
            SuspendLayout();
            // 
            // RtbDetalles
            // 
            RtbDetalles.BackColor = Color.FromArgb(192, 255, 255);
            RtbDetalles.Location = new Point(12, 12);
            RtbDetalles.Name = "RtbDetalles";
            RtbDetalles.Size = new Size(338, 400);
            RtbDetalles.TabIndex = 0;
            RtbDetalles.Text = "";
            // 
            // btnCancularEnvio
            // 
            btnCancularEnvio.BackColor = Color.FromArgb(192, 255, 255);
            btnCancularEnvio.Location = new Point(502, 441);
            btnCancularEnvio.Name = "btnCancularEnvio";
            btnCancularEnvio.Size = new Size(104, 33);
            btnCancularEnvio.TabIndex = 1;
            btnCancularEnvio.Text = "calcular envio";
            btnCancularEnvio.UseVisualStyleBackColor = false;
            btnCancularEnvio.Click += btnCancularEnvio_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(192, 255, 255);
            btnSalir.Location = new Point(12, 441);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(104, 33);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.FromArgb(192, 255, 255);
            txtPrecio.Location = new Point(447, 247);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(159, 23);
            txtPrecio.TabIndex = 3;
            // 
            // txtPeso
            // 
            txtPeso.BackColor = Color.FromArgb(192, 255, 255);
            txtPeso.Location = new Point(447, 148);
            txtPeso.Name = "txtPeso";
            txtPeso.PlaceholderText = "ej: 5 ";
            txtPeso.Size = new Size(159, 23);
            txtPeso.TabIndex = 4;
            // 
            // precio
            // 
            precio.AutoSize = true;
            precio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            precio.Location = new Point(376, 255);
            precio.Name = "precio";
            precio.Size = new Size(45, 15);
            precio.TabIndex = 6;
            precio.Text = "precio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(376, 156);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 7;
            label2.Text = "peso:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(376, 52);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 8;
            label3.Text = "destino:";
            // 
            // CbDestino
            // 
            CbDestino.BackColor = Color.FromArgb(192, 255, 255);
            CbDestino.FormattingEnabled = true;
            CbDestino.Items.AddRange(new object[] { "CABA", "Conurbano", "Interior" });
            CbDestino.Location = new Point(447, 44);
            CbDestino.Name = "CbDestino";
            CbDestino.Size = new Size(159, 23);
            CbDestino.TabIndex = 9;
            CbDestino.SelectedIndexChanged += CbDestino_SelectedIndexChanged;
            // 
            // pbEnvio
            // 
            pbEnvio.Location = new Point(376, 303);
            pbEnvio.Name = "pbEnvio";
            pbEnvio.Size = new Size(230, 130);
            pbEnvio.TabIndex = 10;
            pbEnvio.TabStop = false;
            pbEnvio.Visible = false;
            // 
            // FrmDetalles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo;
            ClientSize = new Size(632, 500);
            Controls.Add(pbEnvio);
            Controls.Add(CbDestino);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(precio);
            Controls.Add(txtPeso);
            Controls.Add(txtPrecio);
            Controls.Add(btnSalir);
            Controls.Add(btnCancularEnvio);
            Controls.Add(RtbDetalles);
            Name = "FrmDetalles";
            Text = "Detalles";
            Load += FrmDetalles_Load;
            ((System.ComponentModel.ISupportInitialize)pbEnvio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox RtbDetalles;
        private Button btnCancularEnvio;
        private Button btnSalir;
        private TextBox txtPrecio;
        private TextBox txtPeso;
        private Label precio;
        private Label label2;
        private Label label3;
        private ComboBox CbDestino;
        private PictureBox pbEnvio;
    }
}