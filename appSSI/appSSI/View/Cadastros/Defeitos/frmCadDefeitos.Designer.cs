namespace appSSI
{
    partial class frmCadDefeitos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadDefeitos));
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.gbEstagio = new System.Windows.Forms.GroupBox();
            this.rbDefinido = new System.Windows.Forms.RadioButton();
            this.rbAndamento = new System.Windows.Forms.RadioButton();
            this.rbInicial = new System.Windows.Forms.RadioButton();
            this.tcImagemSolucao = new System.Windows.Forms.TabControl();
            this.tpImagens = new System.Windows.Forms.TabPage();
            this.ucCadImagens = new appSSI.ucCadImagens();
            this.tpSolucoes = new System.Windows.Forms.TabPage();
            this.ucCadSolucoesDefeitos = new appSSI.ucCadSolucoesDefeitos();
            this.tpAcoesTelas = new System.Windows.Forms.TabPage();
            this.ucCadDefeitosAcoesTelas = new appSSI.ucCadDefeitosAcoesTelas();
            this.pnFiltro.SuspendLayout();
            this.pnForm.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.tcCadastro.SuspendLayout();
            this.tpFormulario.SuspendLayout();
            this.gbEstagio.SuspendLayout();
            this.tcImagemSolucao.SuspendLayout();
            this.tpImagens.SuspendLayout();
            this.tpSolucoes.SuspendLayout();
            this.tpAcoesTelas.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnFiltro
            // 
            this.pnFiltro.Size = new System.Drawing.Size(751, 90);
            // 
            // pnForm
            // 
            this.pnForm.Controls.Add(this.gbEstagio);
            this.pnForm.Controls.Add(this.txtDescricao);
            this.pnForm.Controls.Add(this.lblDescricao);
            this.pnForm.Controls.Add(this.txtCodigo);
            this.pnForm.Controls.Add(this.lblCodigo);
            this.pnForm.Controls.Add(this.tcImagemSolucao);
            this.pnForm.Size = new System.Drawing.Size(751, 437);
            this.pnForm.TabIndex = 0;
            this.pnForm.Controls.SetChildIndex(this.btnPrevious, 0);
            this.pnForm.Controls.SetChildIndex(this.btnFirst, 0);
            this.pnForm.Controls.SetChildIndex(this.btnLast, 0);
            this.pnForm.Controls.SetChildIndex(this.btnNext, 0);
            this.pnForm.Controls.SetChildIndex(this.tcImagemSolucao, 0);
            this.pnForm.Controls.SetChildIndex(this.lblCodigo, 0);
            this.pnForm.Controls.SetChildIndex(this.txtCodigo, 0);
            this.pnForm.Controls.SetChildIndex(this.lblDescricao, 0);
            this.pnForm.Controls.SetChildIndex(this.txtDescricao, 0);
            this.pnForm.Controls.SetChildIndex(this.gbEstagio, 0);
            // 
            // pnBotoes
            // 
            this.pnBotoes.Location = new System.Drawing.Point(661, 0);
            // 
            // tcCadastro
            // 
            this.tcCadastro.Size = new System.Drawing.Size(765, 469);
            // 
            // pnGridFiltro
            // 
            this.pnGridFiltro.Size = new System.Drawing.Size(661, 68);
            // 
            // btnEncolherExpandir
            // 
            this.btnEncolherExpandir.Size = new System.Drawing.Size(749, 20);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(680, 3);
            this.btnNext.TabIndex = 2;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(715, 3);
            this.btnLast.TabIndex = 3;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(610, 3);
            this.btnFirst.TabIndex = 0;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(645, 3);
            this.btnPrevious.TabIndex = 1;
            // 
            // tpFormulario
            // 
            this.tpFormulario.Size = new System.Drawing.Size(757, 443);
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
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.CampoObrigatorio = true;
            this.txtDescricao.Location = new System.Drawing.Point(3, 73);
            this.txtDescricao.MensagemCampoObrigatorio = "Imforme a descrição do defeito.";
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescricao.Size = new System.Drawing.Size(741, 138);
            this.txtDescricao.TabIndex = 5;
            // 
            // gbEstagio
            // 
            this.gbEstagio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbEstagio.Controls.Add(this.rbDefinido);
            this.gbEstagio.Controls.Add(this.rbAndamento);
            this.gbEstagio.Controls.Add(this.rbInicial);
            this.gbEstagio.Location = new System.Drawing.Point(523, 34);
            this.gbEstagio.Name = "gbEstagio";
            this.gbEstagio.Size = new System.Drawing.Size(221, 36);
            this.gbEstagio.TabIndex = 4;
            this.gbEstagio.TabStop = false;
            this.gbEstagio.Text = "Estágio";
            // 
            // rbDefinido
            // 
            this.rbDefinido.AutoSize = true;
            this.rbDefinido.Location = new System.Drawing.Point(151, 13);
            this.rbDefinido.Name = "rbDefinido";
            this.rbDefinido.Size = new System.Drawing.Size(64, 17);
            this.rbDefinido.TabIndex = 2;
            this.rbDefinido.TabStop = true;
            this.rbDefinido.Text = "Definido";
            this.rbDefinido.UseVisualStyleBackColor = true;
            // 
            // rbAndamento
            // 
            this.rbAndamento.AutoSize = true;
            this.rbAndamento.Location = new System.Drawing.Point(66, 13);
            this.rbAndamento.Name = "rbAndamento";
            this.rbAndamento.Size = new System.Drawing.Size(79, 17);
            this.rbAndamento.TabIndex = 1;
            this.rbAndamento.TabStop = true;
            this.rbAndamento.Text = "Andamento";
            this.rbAndamento.UseVisualStyleBackColor = true;
            // 
            // rbInicial
            // 
            this.rbInicial.AutoSize = true;
            this.rbInicial.Location = new System.Drawing.Point(8, 13);
            this.rbInicial.Name = "rbInicial";
            this.rbInicial.Size = new System.Drawing.Size(52, 17);
            this.rbInicial.TabIndex = 0;
            this.rbInicial.TabStop = true;
            this.rbInicial.Text = "Inicial";
            this.rbInicial.UseVisualStyleBackColor = true;
            // 
            // tcImagemSolucao
            // 
            this.tcImagemSolucao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tcImagemSolucao.Controls.Add(this.tpImagens);
            this.tcImagemSolucao.Controls.Add(this.tpSolucoes);
            this.tcImagemSolucao.Controls.Add(this.tpAcoesTelas);
            this.tcImagemSolucao.Location = new System.Drawing.Point(3, 217);
            this.tcImagemSolucao.Name = "tcImagemSolucao";
            this.tcImagemSolucao.SelectedIndex = 0;
            this.tcImagemSolucao.Size = new System.Drawing.Size(741, 215);
            this.tcImagemSolucao.TabIndex = 6;
            // 
            // tpImagens
            // 
            this.tpImagens.Controls.Add(this.ucCadImagens);
            this.tpImagens.Location = new System.Drawing.Point(4, 22);
            this.tpImagens.Name = "tpImagens";
            this.tpImagens.Padding = new System.Windows.Forms.Padding(3);
            this.tpImagens.Size = new System.Drawing.Size(733, 189);
            this.tpImagens.TabIndex = 0;
            this.tpImagens.Text = "Imagens";
            this.tpImagens.UseVisualStyleBackColor = true;
            // 
            // ucCadImagens
            // 
            this.ucCadImagens.cdDefeito = 0;
            this.ucCadImagens.cdSolucao = 0;
            this.ucCadImagens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCadImagens.flDefeito = true;
            this.ucCadImagens.Location = new System.Drawing.Point(3, 3);
            this.ucCadImagens.Name = "ucCadImagens";
            this.ucCadImagens.Size = new System.Drawing.Size(727, 183);
            this.ucCadImagens.TabIndex = 0;
            // 
            // tpSolucoes
            // 
            this.tpSolucoes.Controls.Add(this.ucCadSolucoesDefeitos);
            this.tpSolucoes.Location = new System.Drawing.Point(4, 22);
            this.tpSolucoes.Name = "tpSolucoes";
            this.tpSolucoes.Padding = new System.Windows.Forms.Padding(3);
            this.tpSolucoes.Size = new System.Drawing.Size(733, 189);
            this.tpSolucoes.TabIndex = 1;
            this.tpSolucoes.Text = "Soluções";
            this.tpSolucoes.UseVisualStyleBackColor = true;
            // 
            // ucCadSolucoesDefeitos
            // 
            this.ucCadSolucoesDefeitos.BackColor = System.Drawing.Color.White;
            this.ucCadSolucoesDefeitos.CdDefeito = 0;
            this.ucCadSolucoesDefeitos.CdSolucao = 0;
            this.ucCadSolucoesDefeitos.colunaOrdenada = "";
            this.ucCadSolucoesDefeitos.deDefeito = null;
            this.ucCadSolucoesDefeitos.deSolucao = null;
            this.ucCadSolucoesDefeitos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCadSolucoesDefeitos.dtDados = null;
            this.ucCadSolucoesDefeitos.flDefeito = false;
            this.ucCadSolucoesDefeitos.Location = new System.Drawing.Point(3, 3);
            this.ucCadSolucoesDefeitos.Name = "ucCadSolucoesDefeitos";
            this.ucCadSolucoesDefeitos.order = "";
            this.ucCadSolucoesDefeitos.Size = new System.Drawing.Size(727, 183);
            this.ucCadSolucoesDefeitos.TabIndex = 0;
            // 
            // tpAcoesTelas
            // 
            this.tpAcoesTelas.Controls.Add(this.ucCadDefeitosAcoesTelas);
            this.tpAcoesTelas.Location = new System.Drawing.Point(4, 22);
            this.tpAcoesTelas.Name = "tpAcoesTelas";
            this.tpAcoesTelas.Padding = new System.Windows.Forms.Padding(3);
            this.tpAcoesTelas.Size = new System.Drawing.Size(733, 189);
            this.tpAcoesTelas.TabIndex = 2;
            this.tpAcoesTelas.Text = "Ações/Telas";
            this.tpAcoesTelas.UseVisualStyleBackColor = true;
            // 
            // ucCadDefeitosAcoesTelas
            // 
            this.ucCadDefeitosAcoesTelas.BackColor = System.Drawing.Color.White;
            this.ucCadDefeitosAcoesTelas.colunaOrdenada = "";
            this.ucCadDefeitosAcoesTelas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCadDefeitosAcoesTelas.Location = new System.Drawing.Point(3, 3);
            this.ucCadDefeitosAcoesTelas.Name = "ucCadDefeitosAcoesTelas";
            this.ucCadDefeitosAcoesTelas.order = "";
            this.ucCadDefeitosAcoesTelas.pcdDefeito = 0;
            this.ucCadDefeitosAcoesTelas.pcdTela = 0;
            this.ucCadDefeitosAcoesTelas.Size = new System.Drawing.Size(727, 183);
            this.ucCadDefeitosAcoesTelas.TabIndex = 0;
            // 
            // frmCadDefeitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.bImprimeRelCompleto = false;
            this.bImprimeRelSimples = false;
            this.ClientSize = new System.Drawing.Size(765, 516);
            this.KeyPreview = true;
            this.Name = "frmCadDefeitos";
            this.Text = "Cadastro de Defeitos";
            this.TpCorrente = this.tpFormulario;
            this.Load += new System.EventHandler(this.frmCadDefeitos_Load);
            this.pnFiltro.ResumeLayout(false);
            this.pnForm.ResumeLayout(false);
            this.pnForm.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.tcCadastro.ResumeLayout(false);
            this.tpFormulario.ResumeLayout(false);
            this.gbEstagio.ResumeLayout(false);
            this.gbEstagio.PerformLayout();
            this.tcImagemSolucao.ResumeLayout(false);
            this.tpImagens.ResumeLayout(false);
            this.tpSolucoes.ResumeLayout(false);
            this.tpAcoesTelas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private KuraFrameWork.Componentes_Visuais.ucTextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.GroupBox gbEstagio;
        private System.Windows.Forms.RadioButton rbDefinido;
        private System.Windows.Forms.RadioButton rbAndamento;
        private System.Windows.Forms.RadioButton rbInicial;
        private System.Windows.Forms.TabControl tcImagemSolucao;
        private System.Windows.Forms.TabPage tpImagens;
        private ucCadImagens ucCadImagens;
        private System.Windows.Forms.TabPage tpSolucoes;
        private ucCadSolucoesDefeitos ucCadSolucoesDefeitos;
        private System.Windows.Forms.TabPage tpAcoesTelas;
        private ucCadDefeitosAcoesTelas ucCadDefeitosAcoesTelas;
        public KuraFrameWork.Componentes_Visuais.ucTextBox txtCodigo;



    }
}
