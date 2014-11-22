namespace appSSI
{
    partial class frmCadSistemas
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
            this.txtCodigo = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.gbIntegracao = new System.Windows.Forms.GroupBox();
            this.ucAreaTaskCons = new appSSI.ucAreaTaskCons();
            this.txtAreaTASK = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.lblAreaTask = new System.Windows.Forms.Label();
            this.txtProjetoTask = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.lblProjetoTask = new System.Windows.Forms.Label();
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
            this.pnForm.Controls.Add(this.lblCodigo);
            this.pnForm.Controls.Add(this.txtCodigo);
            this.pnForm.TabIndex = 0;
            this.pnForm.Controls.SetChildIndex(this.btnLast, 0);
            this.pnForm.Controls.SetChildIndex(this.btnPrevious, 0);
            this.pnForm.Controls.SetChildIndex(this.btnNext, 0);
            this.pnForm.Controls.SetChildIndex(this.btnFirst, 0);
            this.pnForm.Controls.SetChildIndex(this.txtCodigo, 0);
            this.pnForm.Controls.SetChildIndex(this.lblCodigo, 0);
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
            // txtCodigo
            // 
            this.txtCodigo.AceitaEspaco = true;
            this.txtCodigo.CampoObrigatorio = false;
            this.txtCodigo.Location = new System.Drawing.Point(3, 34);
            this.txtCodigo.MensagemCampoObrigatorio = null;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 7;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(0, 18);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 13);
            this.lblCodigo.TabIndex = 6;
            this.lblCodigo.Text = "Código :";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(0, 57);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(65, 13);
            this.lblDescricao.TabIndex = 8;
            this.lblDescricao.Text = "*Descrição :";
            // 
            // txtDescricao
            // 
            this.txtDescricao.AceitaEspaco = true;
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.CampoObrigatorio = true;
            this.txtDescricao.Location = new System.Drawing.Point(3, 73);
            this.txtDescricao.MensagemCampoObrigatorio = "Informe a descrição do sistema.";
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(660, 20);
            this.txtDescricao.TabIndex = 4;
            // 
            // gbIntegracao
            // 
            this.gbIntegracao.Controls.Add(this.ucAreaTaskCons);
            this.gbIntegracao.Controls.Add(this.txtAreaTASK);
            this.gbIntegracao.Controls.Add(this.lblAreaTask);
            this.gbIntegracao.Controls.Add(this.txtProjetoTask);
            this.gbIntegracao.Controls.Add(this.lblProjetoTask);
            this.gbIntegracao.Location = new System.Drawing.Point(3, 99);
            this.gbIntegracao.Name = "gbIntegracao";
            this.gbIntegracao.Size = new System.Drawing.Size(453, 163);
            this.gbIntegracao.TabIndex = 5;
            this.gbIntegracao.TabStop = false;
            this.gbIntegracao.Text = "Dados Integração TASK";
            // 
            // ucAreaTaskCons
            // 
            this.ucAreaTaskCons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucAreaTaskCons.bCadastrar = false;
            this.ucAreaTaskCons.bMudouCodigo = false;
            this.ucAreaTaskCons.CampoObrigatorio = false;
            this.ucAreaTaskCons.cd_area = 0;
            this.ucAreaTaskCons.Location = new System.Drawing.Point(10, 101);
            this.ucAreaTaskCons.MensagemCampoObrigatorio = "Informe a AREA para integração.";
            this.ucAreaTaskCons.Name = "ucAreaTaskCons";
            this.ucAreaTaskCons.Rotulo = "*Área TASK";
            this.ucAreaTaskCons.Size = new System.Drawing.Size(437, 36);
            this.ucAreaTaskCons.TabIndex = 2;
            this.ucAreaTaskCons.TelaConsulta = null;
            // 
            // txtAreaTASK
            // 
            this.txtAreaTASK.AceitaEspaco = true;
            this.txtAreaTASK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAreaTASK.CampoObrigatorio = true;
            this.txtAreaTASK.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAreaTASK.Location = new System.Drawing.Point(10, 75);
            this.txtAreaTASK.MensagemCampoObrigatorio = "Informe a área para cadastro de OS no TASK.";
            this.txtAreaTASK.Name = "txtAreaTASK";
            this.txtAreaTASK.Size = new System.Drawing.Size(437, 20);
            this.txtAreaTASK.TabIndex = 1;
            // 
            // lblAreaTask
            // 
            this.lblAreaTask.AutoSize = true;
            this.lblAreaTask.Location = new System.Drawing.Point(7, 59);
            this.lblAreaTask.Name = "lblAreaTask";
            this.lblAreaTask.Size = new System.Drawing.Size(64, 13);
            this.lblAreaTask.TabIndex = 4;
            this.lblAreaTask.Text = "*Área TASK";
            // 
            // txtProjetoTask
            // 
            this.txtProjetoTask.AceitaEspaco = true;
            this.txtProjetoTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProjetoTask.CampoObrigatorio = true;
            this.txtProjetoTask.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProjetoTask.Location = new System.Drawing.Point(10, 36);
            this.txtProjetoTask.MensagemCampoObrigatorio = "Informe o projeto para cadastro de OS no TASK.";
            this.txtProjetoTask.Name = "txtProjetoTask";
            this.txtProjetoTask.Size = new System.Drawing.Size(437, 20);
            this.txtProjetoTask.TabIndex = 0;
            // 
            // lblProjetoTask
            // 
            this.lblProjetoTask.AutoSize = true;
            this.lblProjetoTask.Location = new System.Drawing.Point(7, 20);
            this.lblProjetoTask.Name = "lblProjetoTask";
            this.lblProjetoTask.Size = new System.Drawing.Size(75, 13);
            this.lblProjetoTask.TabIndex = 3;
            this.lblProjetoTask.Text = "*Projeto TASK";
            // 
            // frmCadSistemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.bImprimeRelCompleto = false;
            this.bImprimeRelSimples = false;
            this.ClientSize = new System.Drawing.Size(684, 367);
            this.KeyPreview = true;
            this.Name = "frmCadSistemas";
            this.Text = "Cadastro de Sistemas";
            this.TpCorrente = this.tpFormulario;
            this.Load += new System.EventHandler(this.frmCadSistemas_Load);
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
        private System.Windows.Forms.Label lblDescricao;
        private KuraFrameWork.Componentes_Visuais.ucTextBox txtDescricao;
        private System.Windows.Forms.GroupBox gbIntegracao;
        private KuraFrameWork.Componentes_Visuais.ucTextBox txtAreaTASK;
        private System.Windows.Forms.Label lblAreaTask;
        private KuraFrameWork.Componentes_Visuais.ucTextBox txtProjetoTask;
        private System.Windows.Forms.Label lblProjetoTask;
        public ucAreaTaskCons ucAreaTaskCons;
        public KuraFrameWork.Componentes_Visuais.ucTextBox txtCodigo;
    }
}
