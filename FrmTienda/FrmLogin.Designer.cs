namespace FrmTienda
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btningresar = new Button();
            txtusuario = new TextBox();
            txtcontraseña = new TextBox();
            SuspendLayout();
            // 
            // btningresar
            // 
            btningresar.Location = new Point(158, 258);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(180, 42);
            btningresar.TabIndex = 0;
            btningresar.Text = "ingresar";
            btningresar.UseVisualStyleBackColor = true;
            btningresar.Click += btningresar_Click;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(158, 143);
            txtusuario.Name = "txtusuario";
            txtusuario.PlaceholderText = "ingrese su usuario";
            txtusuario.Size = new Size(180, 23);
            txtusuario.TabIndex = 3;
            // 
            // txtcontraseña
            // 
            txtcontraseña.Location = new Point(158, 205);
            txtcontraseña.Name = "txtcontraseña";
            txtcontraseña.PasswordChar = '*';
            txtcontraseña.PlaceholderText = "ingrese su contraseña";
            txtcontraseña.Size = new Size(180, 23);
            txtcontraseña.TabIndex = 4;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.tech_nexus;
            ClientSize = new Size(501, 331);
            Controls.Add(txtcontraseña);
            Controls.Add(txtusuario);
            Controls.Add(btningresar);
            ForeColor = Color.Black;
            Name = "FrmLogin";
            Text = "login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btningresar;
        private TextBox txtusuario;
        private TextBox txtcontraseña;
    }
}