namespace appSSI
{
    partial class frmCadModulos
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.gbIntegracao = new System.Windows.Forms.GroupBox();
            this.txtModuloTASK = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.lblModuloTASK = new System.Windows.Forms.Label();
            this.ucSistemasCons = new appSSI.ucSistemasCons();
            this.pnFiltro.SuspendLayout();
            this.pnForm.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.tcCadastro.SuspendLayout();
            this.tpFormulario.SuspendLayout();
            this.gbIntegracao.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnForm
            // 
            this.pnForm.Controls.Add(this.gbIntegracao);
            this.pnForm.Controls.Add(this.txtDescricao);
            this.pnForm.Controls.Add(this.lblDescricao);
            this.pnForm.Controls.Add(this.ucSistemasCons);
            this.pnForm.Controls.Add(this.txtCodigo);
            this.pnForm.Controls.Add(this.lblCodigo);
            this.pnForm.TabIndex = 0;
            this.pnForm.Controls.SetChildIndex(this.btnLast, 0);
            this.pnForm.Controls.SetChildIndex(this.btnPrevious, 0);
            this.pnForm.Controls.SetChildIndex(this.btnNext, 0);
            this.pnForm.Controls.SetChildIndex(this.btnFirst, 0);
            this.pnForm.Controls.SetChildIndex(this.lblCodigo, 0);
            this.pnForm.Controls.SetChildIndex(this.txtCodigo, 0);
            this.pnForm.Controls.SetChildIndex(this.ucSistemasCons, 0);
            this.pnForm.Controls.SetChildIndex(this.lblDescricao, 0);
            this.pnForm.Controls.SetChildIndex(this.txtDescricao, 0);
            this.pnForm.Controls.SetChildIndex(this.gbIntegracao, 0);
            // 
            // btnNext
            // 
            this.btnNext.TabIndex = 2;
            // 
            // btnLast
            // 
            this.btnLast.TabIndex = 3;
            // 
            // btnFirst
            // 
            this.btnFirst.TabIndex = 0;
            // 
            // btnPrevious
            // 
            this.btnPrevious.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(0, 18);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 13);
            this.lblCodigo.TabIndex = 7;
            this.lblCodigo.Text = "Código :";
            // 
            // txtCodigo
            // 
            this.txtCodigo.AceitaEspaco = true;
            this.txtCodigo.CampoObrigatorio = false;
            this.txtCodigo.Location = new System.Drawing.Point(3, 34);
            this.txtCodigo.MensagemCampoObrigatorio = null;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 8;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(0, 57);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(65, 13);
            this.lblDescricao.TabIndex = 9;
            this.lblDescricao.Text = "*Descrição :";
            // 
            // txtDescricao
            // 
            this.txtDescricao.AceitaEspaco = true;
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.CampoObrigatorio = true;
            this.txtDescricao.Location = new System.Drawing.Point(3, 73);
            this.txtDescricao.MaxLength = 60;
            this.txtDescricao.MensagemCampoObrigatorio = "Informe a descrição.";
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(307, 20);
            this.txtDescricao.TabIndex = 4;
            // 
            // gbIntegracao
            // 
            this.gbIntegracao.Controls.Add(this.txtModuloTASK);
            this.gbIntegracao.Controls.Add(this.lblModuloTASK);
            this.gbIntegracao.Location = new System.Drawing.Point(3, 99);
            this.gbIntegracao.Name = "gbIntegracao";
            this.gbIntegracao.Size = new System.Drawing.Size(299, 64);
            this.gbIntegracao.TabIndex = 6;
            this.gbIntegracao.TabStop = false;
            this.gbIntegracao.Text = "Dados Integração TASK";
            // 
            // txtModuloTASK
            // 
            this.txtModuloTASK.AceitaEspaco = true;
            this.txtModuloTASK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModuloTASK.CampoObrigatorio = true;
            this.txtModuloTASK.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtModuloTASK.Location = new System.Drawing.Point(10, 36);
            this.txtModuloTASK.MensagemCampoObrigatorio = "Informe o modulo para cadastro de OS no TASK.";
            this.txtModuloTASK.Name = "txtModuloTASK";
            this.txtModuloTASK.Size = new System.Drawing.Size(283, 20);
            this.txtModuloTASK.TabIndex = 0;
            // 
            // lblModuloTASK
            // 
            this.lblModuloTASK.AutoSize = true;
            this.lblModuloTASK.Location = new System.Drawing.Point(7, 20);
            this.lblModuloTASK.Name = "lblModuloTASK";
            this.lblModuloTASK.Size = new System.Drawing.Size(77, 13);
            this.lblModuloTASK.TabIndex = 1;
            this.lblModuloTASK.Text = "*Modulo TASK";
            // 
            // ucSistemasCons
            // 
            this.ucSistemasCons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSistemasCons.bCadastrar = true;
            this.ucSistemasCons.bMudouCodigo = false;
            this.ucSistemasCons.CampoObrigatorio = true;
            this.ucSistemasCons.cdEmpresa = 0;
            this.ucSistemasCons.Location = new System.Drawing.Point(316, 57);
            this.ucSistemasCons.MensagemCampoObrigatorio = "Selecione o sistema.";
            this.ucSistemasCons.Name = "ucSistemasCons";
            this.ucSistemasCons.Rotulo = "*Sistema :";
            this.ucSistemasCons.Size = new System.Drawing.Size(347, 36);
            this.ucSistemasCons.TabIndex = 5;
            this.ucSistemasCons.TelaConsulta = "appSSI.frmConsSistemas";
            // 
            // frmCadModulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(684, 367);
            this.KeyPreview = true;
            this.Name = "frmCadModulos";
            this.Text = "Cadastro de Módulos";
            this.TpCorrente = this.tpFormulario;
            this.Load += new System.EventHandler(this.frmCadModulos_Load);
            this.pnFiltro.ResumeLayout(false);
            this.pnForm.ResumeLayout(false);
            this.pnForm.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.tcCadastro.ResumeLayout(false);
            this.tpFormulario.ResumeLayout(false);
            this.gbIntegracao.ResumeLayout(false);
            this.gbIntegracao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private ucSistemasCons ucSistemasCons;
        private KuraFrameWork.Componentes_Visuais.ucTextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.GroupBox gbIntegracao;
        private KuraFrameWork.Componentes_Visuais.ucTextBox txtModuloTASK;
        private System.Windows.Forms.Label lblModuloTASK;
        public KuraFrameWork.Componentes_Visuais.ucTextBox txtCodigo;
    }
}
