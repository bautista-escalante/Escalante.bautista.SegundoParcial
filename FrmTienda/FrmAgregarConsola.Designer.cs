namespace FrmTienda
{
    partial class FrmAgregarConsola
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
            txtChip = new TextBox();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 334);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 16;
            label7.Text = "chip de video";
            // 
            // txtChip
            // 
            txtChip.Location = new Point(138, 326);
            txtChip.Name = "txtChip";
            txtChip.Size = new Size(197, 23);
            txtChip.TabIndex = 17;
            // 
            // FrmAgregarConsola
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 596);
            Controls.Add(txtChip);
            Controls.Add(label7);
            Name = "FrmAgregarConsola";
            Text = "Consola";
            Controls.SetChildIndex(label7, 0);
            Controls.SetChildIndex(txtChip, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private TextBox txtChip;
    }
}