namespace FrmTienda
{
    partial class FrmStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStock));
            btnAgregar = new Button();
            btnModificar = new Button();
            btnOrenar = new Button();
            LsProductos = new ListBox();
            btnEliminar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            rbAsendente = new RadioButton();
            rbDesedente = new RadioButton();
            groupBox1 = new GroupBox();
            RtbRegistro = new RichTextBox();
            btnVerDetalles = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(192, 192, 255);
            btnAgregar.Location = new Point(12, 397);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 41);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "agregar elemento";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(192, 192, 255);
            btnModificar.Location = new Point(287, 397);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 40);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "modificar precio";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnOrenar
            // 
            btnOrenar.BackColor = Color.FromArgb(192, 192, 255);
            btnOrenar.Location = new Point(581, 397);
            btnOrenar.Name = "btnOrenar";
            btnOrenar.Size = new Size(75, 41);
            btnOrenar.TabIndex = 2;
            btnOrenar.Text = "Orenar por precio";
            btnOrenar.UseVisualStyleBackColor = false;
            btnOrenar.Click += btnOrenar_Click;
            // 
            // LsProductos
            // 
            LsProductos.BackColor = Color.FromArgb(192, 192, 255);
            LsProductos.FormattingEnabled = true;
            LsProductos.ItemHeight = 15;
            LsProductos.Location = new Point(12, 42);
            LsProductos.Name = "LsProductos";
            LsProductos.Size = new Size(590, 349);
            LsProductos.TabIndex = 3;
            LsProductos.SelectedIndexChanged += Productos_SelectedIndexChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(192, 192, 255);
            btnEliminar.Location = new Point(713, 397);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 41);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar producto";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 192, 255);
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(56, 9);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 5;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 192, 255);
            label2.Location = new Point(146, 9);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 6;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(192, 192, 255);
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(530, 9);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 7;
            label3.Text = "fecha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(192, 192, 255);
            label4.Location = new Point(608, 9);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 8;
            label4.Text = "label4";
            // 
            // rbAsendente
            // 
            rbAsendente.AutoSize = true;
            rbAsendente.Location = new Point(6, 0);
            rbAsendente.Name = "rbAsendente";
            rbAsendente.Size = new Size(79, 19);
            rbAsendente.TabIndex = 9;
            rbAsendente.TabStop = true;
            rbAsendente.Text = "asendente";
            rbAsendente.UseVisualStyleBackColor = true;
            // 
            // rbDesedente
            // 
            rbDesedente.AutoSize = true;
            rbDesedente.Location = new Point(6, 21);
            rbDesedente.Name = "rbDesedente";
            rbDesedente.Size = new Size(86, 19);
            rbDesedente.TabIndex = 10;
            rbDesedente.TabStop = true;
            rbDesedente.Text = "desendente";
            rbDesedente.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(192, 192, 255);
            groupBox1.Controls.Add(rbDesedente);
            groupBox1.Controls.Add(rbAsendente);
            groupBox1.Location = new Point(426, 397);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(106, 41);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // RtbRegistro
            // 
            RtbRegistro.BackColor = Color.FromArgb(192, 192, 255);
            RtbRegistro.Location = new Point(620, 42);
            RtbRegistro.Name = "RtbRegistro";
            RtbRegistro.Size = new Size(168, 349);
            RtbRegistro.TabIndex = 12;
            RtbRegistro.Text = "";
            // 
            // btnVerDetalles
            // 
            btnVerDetalles.BackColor = Color.FromArgb(192, 192, 255);
            btnVerDetalles.Location = new Point(146, 397);
            btnVerDetalles.Name = "btnVerDetalles";
            btnVerDetalles.Size = new Size(75, 40);
            btnVerDetalles.TabIndex = 13;
            btnVerDetalles.Text = "ver detalles";
            btnVerDetalles.UseVisualStyleBackColor = false;
            btnVerDetalles.Click += btnVerDetalles_Click;
            // 
            // FrmStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(btnVerDetalles);
            Controls.Add(RtbRegistro);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(LsProductos);
            Controls.Add(btnOrenar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Name = "FrmStock";
            Text = "stock";
            Load += FrmStock_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Button btnModificar;
        private Button btnOrenar;
        private ListBox LsProductos;
        private Button btnEliminar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private RadioButton rbAsendente;
        private RadioButton rbDesedente;
        private GroupBox groupBox1;
        private RichTextBox RtbRegistro;
        private Button btnVerDetalles;
    }
}