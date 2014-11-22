namespace appSSI
{
    partial class frmLogin
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
            ((System.ComponentModel.ISupportInitialize)(this.pcbFundoLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(65, 125);
            this.btnConfirmar.Size = new System.Drawing.Size(90, 28);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(161, 125);
            this.btnFinalizar.Size = new System.Drawing.Size(75, 28);
            // 
            // pcbFundoLogin
            // 
            this.pcbFundoLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcbFundoLogin.Image = global::appSSI.Properties.Resources.skype;
            this.pcbFundoLogin.Size = new System.Drawing.Size(251, 67);
            this.pcbFundoLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(65, 73);
            this.txtUsuario.MaxLength = 15;
            this.txtUsuario.Size = new System.Drawing.Size(171, 20);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(65, 99);
            this.txtSenha.MaxLength = 20;
            this.txtSenha.Size = new System.Drawing.Size(171, 20);
            // 
            // lbUsuario
            // 
            this.lbUsuario.Location = new System.Drawing.Point(9, 80);
            // 
            // lbSenha
            // 
            this.lbSenha.Location = new System.Drawing.Point(16, 106);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(251, 178);
            this.Name = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pcbFundoLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
