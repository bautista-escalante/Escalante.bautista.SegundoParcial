namespace FrmTienda
{
    partial class FrmModificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificar));
            BtnAceptar = new Button();
            BtnCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtNuevo = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // BtnAceptar
            // 
            BtnAceptar.Location = new Point(12, 246);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(103, 40);
            BtnAceptar.TabIndex = 0;
            BtnAceptar.Text = "aceptar";
            BtnAceptar.UseVisualStyleBackColor = true;
            BtnAceptar.Click += BtnAceptar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(243, 246);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(103, 40);
            BtnCancelar.TabIndex = 1;
            BtnCancelar.Text = "cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 55);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 2;
            label1.Text = "precio actual";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 146);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 3;
            label2.Text = "Nuevo precio";
            // 
            // txtNuevo
            // 
            txtNuevo.Location = new Point(149, 146);
            txtNuevo.Name = "txtNuevo";
            txtNuevo.Size = new Size(187, 23);
            txtNuevo.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(149, 55);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(187, 23);
            textBox2.TabIndex = 5;
            // 
            // FrmModificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(358, 298);
            Controls.Add(textBox2);
            Controls.Add(txtNuevo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnAceptar);
            Name = "FrmModificar";
            Text = "Modificar";
            Load += FrmModificar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAceptar;
        private Button BtnCancelar;
        private Label label1;
        private Label label2;
        private TextBox txtNuevo;
        private TextBox textBox2;
    }
}