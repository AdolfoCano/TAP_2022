namespace Proyecto_Final_TAPU1
{
    partial class FrmImagenes
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
            this.PB_MostrarImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MostrarImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_MostrarImagen
            // 
            this.PB_MostrarImagen.BackColor = System.Drawing.Color.Transparent;
            this.PB_MostrarImagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB_MostrarImagen.Location = new System.Drawing.Point(0, 0);
            this.PB_MostrarImagen.Name = "PB_MostrarImagen";
            this.PB_MostrarImagen.Size = new System.Drawing.Size(198, 170);
            this.PB_MostrarImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_MostrarImagen.TabIndex = 0;
            this.PB_MostrarImagen.TabStop = false;
            this.PB_MostrarImagen.Click += new System.EventHandler(this.PB_MostrarImagen_Click);
            // 
            // FrmImagenes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(198, 170);
            this.Controls.Add(this.PB_MostrarImagen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(938, 254);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmImagenes";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Imagenes";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.FrmImagenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_MostrarImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_MostrarImagen;
    }
}