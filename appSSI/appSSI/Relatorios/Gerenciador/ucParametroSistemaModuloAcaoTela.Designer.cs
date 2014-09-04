namespace appSSI
{
    partial class ucParametroSistemaModuloAcaoTela
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucSistemasCons1 = new appSSI.ucSistemasCons();
            this.ucModulosCons1 = new appSSI.ucModulosCons();
            this.ucTelasCons1 = new appSSI.ucTelasCons();
            this.ucAcoesCons1 = new appSSI.ucAcoesCons();
            this.SuspendLayout();
            // 
            // ucSistemasCons1
            // 
            this.ucSistemasCons1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSistemasCons1.bMudouCodigo = false;
            this.ucSistemasCons1.CampoObrigatorio = false;
            this.ucSistemasCons1.Location = new System.Drawing.Point(0, 0);
            this.ucSistemasCons1.MensagemCampoObrigatorio = null;
            this.ucSistemasCons1.Name = "ucSistemasCons1";
            this.ucSistemasCons1.Rotulo = "Sistema :";
            this.ucSistemasCons1.Size = new System.Drawing.Size(436, 36);
            this.ucSistemasCons1.TabIndex = 0;
            this.ucSistemasCons1.TelaConsulta = "appSSI.frmConsSistemas";
            // 
            // ucModulosCons1
            // 
            this.ucModulosCons1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucModulosCons1.bMudouCodigo = false;
            this.ucModulosCons1.CampoObrigatorio = false;
            this.ucModulosCons1.cdSistema = 0;
            this.ucModulosCons1.Location = new System.Drawing.Point(0, 42);
            this.ucModulosCons1.MensagemCampoObrigatorio = null;
            this.ucModulosCons1.Name = "ucModulosCons1";
            this.ucModulosCons1.Rotulo = "Modulo :";
            this.ucModulosCons1.Size = new System.Drawing.Size(436, 36);
            this.ucModulosCons1.TabIndex = 1;
            this.ucModulosCons1.TelaConsulta = null;
            // 
            // ucTelasCons1
            // 
            this.ucTelasCons1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucTelasCons1.bMudouCodigo = false;
            this.ucTelasCons1.CampoObrigatorio = false;
            this.ucTelasCons1.cdModulo = 0;
            this.ucTelasCons1.Location = new System.Drawing.Point(0, 84);
            this.ucTelasCons1.MensagemCampoObrigatorio = null;
            this.ucTelasCons1.Name = "ucTelasCons1";
            this.ucTelasCons1.Rotulo = "Tela :";
            this.ucTelasCons1.Size = new System.Drawing.Size(436, 36);
            this.ucTelasCons1.TabIndex = 2;
            this.ucTelasCons1.TelaConsulta = null;
            // 
            // ucAcoesCons1
            // 
            this.ucAcoesCons1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucAcoesCons1.bMudouCodigo = false;
            this.ucAcoesCons1.CampoObrigatorio = false;
            this.ucAcoesCons1.cdTela = 0;
            this.ucAcoesCons1.Location = new System.Drawing.Point(0, 126);
            this.ucAcoesCons1.MensagemCampoObrigatorio = null;
            this.ucAcoesCons1.Name = "ucAcoesCons1";
            this.ucAcoesCons1.Rotulo = "Ação :";
            this.ucAcoesCons1.Size = new System.Drawing.Size(436, 36);
            this.ucAcoesCons1.TabIndex = 3;
            this.ucAcoesCons1.TelaConsulta = null;
            // 
            // ucParametroSistemaModuloAcaoTela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ucAcoesCons1);
            this.Controls.Add(this.ucTelasCons1);
            this.Controls.Add(this.ucModulosCons1);
            this.Controls.Add(this.ucSistemasCons1);
            this.Name = "ucParametroSistemaModuloAcaoTela";
            this.Size = new System.Drawing.Size(436, 165);
            this.ResumeLayout(false);

        }

        #endregion

        private ucSistemasCons ucSistemasCons1;
        private ucModulosCons ucModulosCons1;
        private ucTelasCons ucTelasCons1;
        private ucAcoesCons ucAcoesCons1;
    }
}
