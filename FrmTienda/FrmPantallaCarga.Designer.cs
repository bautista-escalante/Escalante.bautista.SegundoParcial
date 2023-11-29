namespace FrmTienda
{
    partial class FrmPantallaCarga
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
            pbLoading = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbLoading).BeginInit();
            SuspendLayout();
            // 
            // pbLoading
            // 
            pbLoading.Location = new Point(0, -2);
            pbLoading.Name = "pbLoading";
            pbLoading.Size = new Size(801, 569);
            pbLoading.TabIndex = 0;
            pbLoading.TabStop = false;
            // 
            // FrmPantallaCarga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 564);
            Controls.Add(pbLoading);
            MinimizeBox = false;
            Name = "FrmPantallaCarga";
            Text = "cargando";
            TransparencyKey = Color.Black;
            Load += FrmPantallaCarga_Load;
            ((System.ComponentModel.ISupportInitialize)pbLoading).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbLoading;
    }
}