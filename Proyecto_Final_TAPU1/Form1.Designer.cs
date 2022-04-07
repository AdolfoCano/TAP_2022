namespace Proyecto_Final_TAPU1
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.CB_Invitado = new System.Windows.Forms.CheckBox();
            this.GB_Acceso = new System.Windows.Forms.GroupBox();
            this.Txt_LoginU = new System.Windows.Forms.TextBox();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.GB_Acceso.SuspendLayout();
            this.SuspendLayout();
            // 
            // CB_Invitado
            // 
            this.CB_Invitado.AutoSize = true;
            this.CB_Invitado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CB_Invitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Invitado.Location = new System.Drawing.Point(12, 78);
            this.CB_Invitado.Name = "CB_Invitado";
            this.CB_Invitado.Size = new System.Drawing.Size(82, 24);
            this.CB_Invitado.TabIndex = 0;
            this.CB_Invitado.Text = "Invitado";
            this.CB_Invitado.UseVisualStyleBackColor = true;
            this.CB_Invitado.CheckedChanged += new System.EventHandler(this.CB_Invitado_CheckedChanged);
            // 
            // GB_Acceso
            // 
            this.GB_Acceso.Controls.Add(this.Txt_LoginU);
            this.GB_Acceso.Controls.Add(this.Btn_Cancelar);
            this.GB_Acceso.Controls.Add(this.Btn_Aceptar);
            this.GB_Acceso.Controls.Add(this.CB_Invitado);
            this.GB_Acceso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_Acceso.Location = new System.Drawing.Point(0, 0);
            this.GB_Acceso.Name = "GB_Acceso";
            this.GB_Acceso.Size = new System.Drawing.Size(364, 116);
            this.GB_Acceso.TabIndex = 1;
            this.GB_Acceso.TabStop = false;
            this.GB_Acceso.Text = "Acceso";
            // 
            // Txt_LoginU
            // 
            this.Txt_LoginU.BackColor = System.Drawing.Color.White;
            this.Txt_LoginU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_LoginU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_LoginU.Location = new System.Drawing.Point(3, 16);
            this.Txt_LoginU.Name = "Txt_LoginU";
            this.Txt_LoginU.Size = new System.Drawing.Size(358, 26);
            this.Txt_LoginU.TabIndex = 1;
            this.Txt_LoginU.Click += new System.EventHandler(this.Txt_LoginU_Click);
            this.Txt_LoginU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_LoginU_KeyPress);
            this.Txt_LoginU.Leave += new System.EventHandler(this.Txt_LoginU_Leave);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancelar.Location = new System.Drawing.Point(241, 73);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(102, 37);
            this.Btn_Cancelar.TabIndex = 2;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Aceptar.Location = new System.Drawing.Point(133, 73);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(102, 37);
            this.Btn_Aceptar.TabIndex = 1;
            this.Btn_Aceptar.Text = "Aceptar";
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            this.Btn_Aceptar.MouseLeave += new System.EventHandler(this.Btn_Aceptar_MouseLeave);
            this.Btn_Aceptar.MouseHover += new System.EventHandler(this.Btn_Aceptar_MouseHover);
            this.Btn_Aceptar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btn_Aceptar_MouseMove);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 116);
            this.ControlBox = false;
            this.Controls.Add(this.GB_Acceso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.GB_Acceso.ResumeLayout(false);
            this.GB_Acceso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox CB_Invitado;
        private System.Windows.Forms.GroupBox GB_Acceso;
        private System.Windows.Forms.TextBox Txt_LoginU;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Aceptar;
    }
}

