namespace appSSI
{
    partial class OpConsultarDefeitosSimilares
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
            this.tcPrincipal = new System.Windows.Forms.TabControl();
            this.tpConsulta = new System.Windows.Forms.TabPage();
            this.gbResultados = new System.Windows.Forms.GroupBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.gbParametros = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblDescDefeito = new System.Windows.Forms.Label();
            this.txtDescDefeito = new System.Windows.Forms.TextBox();
            this.ucAcoesCons = new appSSI.ucAcoesCons();
            this.ucTelasCons = new appSSI.ucTelasCons();
            this.ucModulosCons = new appSSI.ucModulosCons();
            this.ucSistemasCons = new appSSI.ucSistemasCons();
            this.tpDetalhes = new System.Windows.Forms.TabPage();
            this.tcPrincipal.SuspendLayout();
            this.tpConsulta.SuspendLayout();
            this.gbResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.gbParametros.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Controls.Add(this.tpConsulta);
            this.tcPrincipal.Controls.Add(this.tpDetalhes);
            this.tcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPrincipal.Location = new System.Drawing.Point(0, 25);
            this.tcPrincipal.Name = "tcPrincipal";
            this.tcPrincipal.SelectedIndex = 0;
            this.tcPrincipal.Size = new System.Drawing.Size(893, 415);
            this.tcPrincipal.TabIndex = 0;
            // 
            // tpConsulta
            // 
            this.tpConsulta.Controls.Add(this.gbResultados);
            this.tpConsulta.Controls.Add(this.gbParametros);
            this.tpConsulta.Location = new System.Drawing.Point(4, 22);
            this.tpConsulta.Name = "tpConsulta";
            this.tpConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tpConsulta.Size = new System.Drawing.Size(885, 389);
            this.tpConsulta.TabIndex = 0;
            this.tpConsulta.Text = "Consulta";
            this.tpConsulta.UseVisualStyleBackColor = true;
            // 
            // gbResultados
            // 
            this.gbResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbResultados.Controls.Add(this.dgvDados);
            this.gbResultados.Location = new System.Drawing.Point(6, 206);
            this.gbResultados.Name = "gbResultados";
            this.gbResultados.Size = new System.Drawing.Size(873, 177);
            this.gbResultados.TabIndex = 1;
            this.gbResultados.TabStop = false;
            this.gbResultados.Text = "Resultados";
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDados.Location = new System.Drawing.Point(3, 16);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.Size = new System.Drawing.Size(867, 158);
            this.dgvDados.TabIndex = 0;
            // 
            // gbParametros
            // 
            this.gbParametros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbParametros.Controls.Add(this.btnLimpar);
            this.gbParametros.Controls.Add(this.btnConsultar);
            this.gbParametros.Controls.Add(this.lblDescDefeito);
            this.gbParametros.Controls.Add(this.txtDescDefeito);
            this.gbParametros.Controls.Add(this.ucAcoesCons);
            this.gbParametros.Controls.Add(this.ucTelasCons);
            this.gbParametros.Controls.Add(this.ucModulosCons);
            this.gbParametros.Controls.Add(this.ucSistemasCons);
            this.gbParametros.Location = new System.Drawing.Point(6, 6);
            this.gbParametros.Name = "gbParametros";
            this.gbParametros.Size = new System.Drawing.Size(873, 194);
            this.gbParametros.TabIndex = 0;
            this.gbParametros.TabStop = false;
            this.gbParametros.Text = "Parâmetros";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.Image = global::appSSI.Properties.Resources.Limpar;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.Location = new System.Drawing.Point(728, 144);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(139, 40);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.Image = global::appSSI.Properties.Resources.Buscar;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.Location = new System.Drawing.Point(411, 144);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(311, 40);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "Buscar";
            this.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // lblDescDefeito
            // 
            this.lblDescDefeito.AutoSize = true;
            this.lblDescDefeito.Location = new System.Drawing.Point(408, 19);
            this.lblDescDefeito.Name = "lblDescDefeito";
            this.lblDescDefeito.Size = new System.Drawing.Size(111, 13);
            this.lblDescDefeito.TabIndex = 5;
            this.lblDescDefeito.Text = "Descrição do defeito :";
            // 
            // txtDescDefeito
            // 
            this.txtDescDefeito.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescDefeito.Location = new System.Drawing.Point(411, 35);
            this.txtDescDefeito.Multiline = true;
            this.txtDescDefeito.Name = "txtDescDefeito";
            this.txtDescDefeito.Size = new System.Drawing.Size(456, 103);
            this.txtDescDefeito.TabIndex = 4;
            // 
            // ucAcoesCons
            // 
            this.ucAcoesCons.bMudouCodigo = false;
            this.ucAcoesCons.CampoObrigatorio = false;
            this.ucAcoesCons.cdTela = 0;
            this.ucAcoesCons.Location = new System.Drawing.Point(6, 145);
            this.ucAcoesCons.MensagemCampoObrigatorio = null;
            this.ucAcoesCons.Name = "ucAcoesCons";
            this.ucAcoesCons.Rotulo = "Ação :";
            this.ucAcoesCons.Size = new System.Drawing.Size(399, 36);
            this.ucAcoesCons.TabIndex = 3;
            this.ucAcoesCons.TelaConsulta = null;
            // 
            // ucTelasCons
            // 
            this.ucTelasCons.bMudouCodigo = false;
            this.ucTelasCons.CampoObrigatorio = false;
            this.ucTelasCons.cdModulo = 0;
            this.ucTelasCons.Location = new System.Drawing.Point(6, 103);
            this.ucTelasCons.MensagemCampoObrigatorio = null;
            this.ucTelasCons.Name = "ucTelasCons";
            this.ucTelasCons.Rotulo = "Tela :";
            this.ucTelasCons.Size = new System.Drawing.Size(399, 36);
            this.ucTelasCons.TabIndex = 2;
            this.ucTelasCons.TelaConsulta = null;
            this.ucTelasCons.AoConsultarRegistro += new KuraFrameWork.Componentes_Visuais.AoConsultarRegistroEventHandler(this.ucTelasCons_AoConsultarRegistro);
            // 
            // ucModulosCons
            // 
            this.ucModulosCons.bMudouCodigo = false;
            this.ucModulosCons.CampoObrigatorio = false;
            this.ucModulosCons.cdSistema = 0;
            this.ucModulosCons.Location = new System.Drawing.Point(6, 61);
            this.ucModulosCons.MensagemCampoObrigatorio = null;
            this.ucModulosCons.Name = "ucModulosCons";
            this.ucModulosCons.Rotulo = "Modulo :";
            this.ucModulosCons.Size = new System.Drawing.Size(399, 36);
            this.ucModulosCons.TabIndex = 1;
            this.ucModulosCons.TelaConsulta = null;
            this.ucModulosCons.AoConsultarRegistro += new KuraFrameWork.Componentes_Visuais.AoConsultarRegistroEventHandler(this.ucModulosCons_AoConsultarRegistro);
            // 
            // ucSistemasCons
            // 
            this.ucSistemasCons.bMudouCodigo = false;
            this.ucSistemasCons.CampoObrigatorio = false;
            this.ucSistemasCons.Location = new System.Drawing.Point(6, 19);
            this.ucSistemasCons.MensagemCampoObrigatorio = null;
            this.ucSistemasCons.Name = "ucSistemasCons";
            this.ucSistemasCons.Rotulo = "Sistema :";
            this.ucSistemasCons.Size = new System.Drawing.Size(399, 36);
            this.ucSistemasCons.TabIndex = 0;
            this.ucSistemasCons.TelaConsulta = "appSSI.frmConsSistemas";
            this.ucSistemasCons.AoConsultarRegistro += new KuraFrameWork.Componentes_Visuais.AoConsultarRegistroEventHandler(this.ucSistemasCons_AoConsultarRegistro);
            // 
            // tpDetalhes
            // 
            this.tpDetalhes.Location = new System.Drawing.Point(4, 22);
            this.tpDetalhes.Name = "tpDetalhes";
            this.tpDetalhes.Padding = new System.Windows.Forms.Padding(3);
            this.tpDetalhes.Size = new System.Drawing.Size(885, 389);
            this.tpDetalhes.TabIndex = 1;
            this.tpDetalhes.Text = "Detalhes";
            this.tpDetalhes.UseVisualStyleBackColor = true;
            // 
            // OpConsultarDefeitosSimilares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.bBNovo = false;
            this.bEditar = false;
            this.bExcluir = false;
            this.bFechar = false;
            this.bImprimir = false;
            this.bLimpar = false;
            this.bMostrarMenu = false;
            this.bSalvar = false;
            this.ClientSize = new System.Drawing.Size(893, 462);
            this.Controls.Add(this.tcPrincipal);
            this.MinimumSize = new System.Drawing.Size(0, 0);
            this.Name = "OpConsultarDefeitosSimilares";
            this.Text = "Consultar Defeitos Similares";
            this.Controls.SetChildIndex(this.tcPrincipal, 0);
            this.tcPrincipal.ResumeLayout(false);
            this.tpConsulta.ResumeLayout(false);
            this.gbResultados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.gbParametros.ResumeLayout(false);
            this.gbParametros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcPrincipal;
        private System.Windows.Forms.TabPage tpConsulta;
        private System.Windows.Forms.TabPage tpDetalhes;
        private System.Windows.Forms.GroupBox gbParametros;
        private ucAcoesCons ucAcoesCons;
        private ucTelasCons ucTelasCons;
        private ucModulosCons ucModulosCons;
        private ucSistemasCons ucSistemasCons;
        private System.Windows.Forms.Label lblDescDefeito;
        private System.Windows.Forms.TextBox txtDescDefeito;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox gbResultados;
        private System.Windows.Forms.DataGridView dgvDados;
    }
}
