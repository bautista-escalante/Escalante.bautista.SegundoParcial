namespace FrmTienda
{
    partial class FrmBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBase));
            btnAceptar = new Button();
            btnCancelar = new Button();
            txtPrecio = new TextBox();
            txtAlmacenamiento = new TextBox();
            txtRam = new TextBox();
            txtModelo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtSo = new TextBox();
            label6 = new Label();
            cbMarca = new ComboBox();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(12, 538);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(104, 46);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(231, 538);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(104, 46);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(138, 491);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(197, 23);
            txtPrecio.TabIndex = 2;
            // 
            // txtAlmacenamiento
            // 
            txtAlmacenamiento.Location = new Point(138, 170);
            txtAlmacenamiento.Name = "txtAlmacenamiento";
            txtAlmacenamiento.Size = new Size(197, 23);
            txtAlmacenamiento.TabIndex = 3;
            // 
            // txtRam
            // 
            txtRam.Location = new Point(138, 122);
            txtRam.Name = "txtRam";
            txtRam.Size = new Size(197, 23);
            txtRam.TabIndex = 4;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(138, 63);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(197, 23);
            txtModelo.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 20);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 7;
            label1.Text = "marca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 71);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 8;
            label2.Text = "modelo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 130);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 9;
            label3.Text = "ram";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 178);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 10;
            label4.Text = "almacenamiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 491);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 11;
            label5.Text = "precio";
            // 
            // txtSo
            // 
            txtSo.Location = new Point(138, 219);
            txtSo.Name = "txtSo";
            txtSo.Size = new Size(197, 23);
            txtSo.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 227);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 13;
            label6.Text = "sis. operativo";
            // 
            // cbMarca
            // 
            cbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMarca.FormattingEnabled = true;
            cbMarca.Items.AddRange(new object[] { " Apple", " Asus", " LG", " Lenovo", " Microsoft", " Nintendo", " Philips", " Samsung", " Sony", " Xiaomi", " indefinido" });
            cbMarca.Location = new Point(138, 17);
            cbMarca.Name = "cbMarca";
            cbMarca.Size = new Size(197, 23);
            cbMarca.TabIndex = 15;
            // 
            // FrmBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(347, 596);
            Controls.Add(cbMarca);
            Controls.Add(label6);
            Controls.Add(txtSo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtModelo);
            Controls.Add(txtRam);
            Controls.Add(txtAlmacenamiento);
            Controls.Add(txtPrecio);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Name = "FrmBase";
            Text = "FrmBase";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnCancelar;
        private TextBox txtPrecio;
        private TextBox txtAlmacenamiento;
        private TextBox txtRam;
        private TextBox txtModelo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtSo;
        private Label label6;
        private ComboBox cbMarca;
    }
}