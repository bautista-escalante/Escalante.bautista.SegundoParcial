namespace FrmTienda
{
    partial class FrmAgregarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarProducto));
            btnCelular = new Button();
            BtnConsola = new Button();
            btnDesktop = new Button();
            btnLaptop = new Button();
            btnTelevisor = new Button();
            SuspendLayout();
            // 
            // btnCelular
            // 
            btnCelular.Location = new Point(131, 12);
            btnCelular.Name = "btnCelular";
            btnCelular.Size = new Size(154, 58);
            btnCelular.TabIndex = 0;
            btnCelular.Text = "Celular";
            btnCelular.UseVisualStyleBackColor = true;
            btnCelular.Click += btnCelular_Click;
            // 
            // BtnConsola
            // 
            BtnConsola.Location = new Point(131, 100);
            BtnConsola.Name = "BtnConsola";
            BtnConsola.Size = new Size(154, 58);
            BtnConsola.TabIndex = 1;
            BtnConsola.Text = "Consola";
            BtnConsola.UseVisualStyleBackColor = true;
            BtnConsola.Click += BtnConsola_Click;
            // 
            // btnDesktop
            // 
            btnDesktop.Location = new Point(131, 189);
            btnDesktop.Name = "btnDesktop";
            btnDesktop.Size = new Size(154, 58);
            btnDesktop.TabIndex = 2;
            btnDesktop.Text = "Desktop";
            btnDesktop.UseVisualStyleBackColor = true;
            btnDesktop.Click += btnDesktop_Click;
            // 
            // btnLaptop
            // 
            btnLaptop.Location = new Point(131, 283);
            btnLaptop.Name = "btnLaptop";
            btnLaptop.Size = new Size(154, 58);
            btnLaptop.TabIndex = 3;
            btnLaptop.Text = "Laptop";
            btnLaptop.UseVisualStyleBackColor = true;
            btnLaptop.Click += btnLaptop_Click;
            // 
            // btnTelevisor
            // 
            btnTelevisor.Location = new Point(131, 380);
            btnTelevisor.Name = "btnTelevisor";
            btnTelevisor.Size = new Size(154, 58);
            btnTelevisor.TabIndex = 4;
            btnTelevisor.Text = "Televisor";
            btnTelevisor.UseVisualStyleBackColor = true;
            btnTelevisor.Click += btnTelevisor_Click;
            // 
            // FrmAgregarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(417, 450);
            Controls.Add(btnTelevisor);
            Controls.Add(btnLaptop);
            Controls.Add(btnDesktop);
            Controls.Add(BtnConsola);
            Controls.Add(btnCelular);
            Name = "FrmAgregarProducto";
            Text = "agregar";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCelular;
        private Button BtnConsola;
        private Button btnDesktop;
        private Button btnLaptop;
        private Button btnTelevisor;
    }
}