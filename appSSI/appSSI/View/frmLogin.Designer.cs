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
            this.btnConfirmar.Size = new System.Drawing.Size(102, 23);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(164, 113);
            // 
            // pcbFundoLogin
            // 
            this.pcbFundoLogin.Size = new System.Drawing.Size(293, 170);
            // 
            // txtUsuario
            // 
            this.txtUsuario.MaxLength = 15;
            this.txtUsuario.Size = new System.Drawing.Size(217, 20);
            // 
            // txtSenha
            // 
            this.txtSenha.MaxLength = 20;
            this.txtSenha.Size = new System.Drawing.Size(217, 20);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(293, 170);
            this.Name = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pcbFundoLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
