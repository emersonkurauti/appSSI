﻿namespace appSSI
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
            this.ucSistemasCons = new appSSI.ucSistemasCons();
            this.ucModulosCons = new appSSI.ucModulosCons();
            this.ucTelasCons = new appSSI.ucTelasCons();
            this.ucAcoesCons = new appSSI.ucAcoesCons();
            this.SuspendLayout();
            // 
            // ucSistemasCons
            // 
            this.ucSistemasCons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSistemasCons.bMudouCodigo = false;
            this.ucSistemasCons.CampoObrigatorio = true;
            this.ucSistemasCons.Location = new System.Drawing.Point(0, 0);
            this.ucSistemasCons.MensagemCampoObrigatorio = "Selecione  o sistema.";
            this.ucSistemasCons.Name = "ucSistemasCons";
            this.ucSistemasCons.Rotulo = "Sistema :";
            this.ucSistemasCons.Size = new System.Drawing.Size(436, 36);
            this.ucSistemasCons.TabIndex = 0;
            this.ucSistemasCons.TelaConsulta = "appSSI.frmConsSistemas";
            this.ucSistemasCons.AoConsultarRegistro += new KuraFrameWork.Componentes_Visuais.AoConsultarRegistroEventHandler(this.ucSistemasCons_AoConsultarRegistro);
            // 
            // ucModulosCons
            // 
            this.ucModulosCons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucModulosCons.bMudouCodigo = false;
            this.ucModulosCons.CampoObrigatorio = true;
            this.ucModulosCons.cdSistema = 0;
            this.ucModulosCons.Location = new System.Drawing.Point(0, 42);
            this.ucModulosCons.MensagemCampoObrigatorio = "Selecione o módulo.";
            this.ucModulosCons.Name = "ucModulosCons";
            this.ucModulosCons.Rotulo = "Modulo :";
            this.ucModulosCons.Size = new System.Drawing.Size(436, 36);
            this.ucModulosCons.TabIndex = 1;
            this.ucModulosCons.TelaConsulta = null;
            this.ucModulosCons.AoConsultarRegistro += new KuraFrameWork.Componentes_Visuais.AoConsultarRegistroEventHandler(this.ucModulosCons_AoConsultarRegistro);
            // 
            // ucTelasCons
            // 
            this.ucTelasCons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucTelasCons.bMudouCodigo = false;
            this.ucTelasCons.CampoObrigatorio = true;
            this.ucTelasCons.cdModulo = 0;
            this.ucTelasCons.Location = new System.Drawing.Point(0, 84);
            this.ucTelasCons.MensagemCampoObrigatorio = "Selecione a tela.";
            this.ucTelasCons.Name = "ucTelasCons";
            this.ucTelasCons.Rotulo = "Tela :";
            this.ucTelasCons.Size = new System.Drawing.Size(436, 36);
            this.ucTelasCons.TabIndex = 2;
            this.ucTelasCons.TelaConsulta = null;
            this.ucTelasCons.AoConsultarRegistro += new KuraFrameWork.Componentes_Visuais.AoConsultarRegistroEventHandler(this.ucTelasCons_AoConsultarRegistro);
            // 
            // ucAcoesCons
            // 
            this.ucAcoesCons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucAcoesCons.bMudouCodigo = false;
            this.ucAcoesCons.CampoObrigatorio = true;
            this.ucAcoesCons.cdTela = 0;
            this.ucAcoesCons.Location = new System.Drawing.Point(0, 126);
            this.ucAcoesCons.MensagemCampoObrigatorio = "Selecione a ação.";
            this.ucAcoesCons.Name = "ucAcoesCons";
            this.ucAcoesCons.Rotulo = "Ação :";
            this.ucAcoesCons.Size = new System.Drawing.Size(436, 36);
            this.ucAcoesCons.TabIndex = 3;
            this.ucAcoesCons.TelaConsulta = null;
            this.ucAcoesCons.AoConsultarRegistro += new KuraFrameWork.Componentes_Visuais.AoConsultarRegistroEventHandler(this.ucAcoesCons_AoConsultarRegistro);
            // 
            // ucParametroSistemaModuloAcaoTela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ucAcoesCons);
            this.Controls.Add(this.ucTelasCons);
            this.Controls.Add(this.ucModulosCons);
            this.Controls.Add(this.ucSistemasCons);
            this.Name = "ucParametroSistemaModuloAcaoTela";
            this.Size = new System.Drawing.Size(436, 165);
            this.ResumeLayout(false);

        }

        #endregion

        private ucSistemasCons ucSistemasCons;
        private ucModulosCons ucModulosCons;
        private ucTelasCons ucTelasCons;
        private ucAcoesCons ucAcoesCons;
    }
}
