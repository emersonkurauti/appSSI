namespace appSSI
{
    partial class frmCadSolucoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadSolucoes));
            this.gbNivel = new System.Windows.Forms.GroupBox();
            this.rbDesenvolvedor = new System.Windows.Forms.RadioButton();
            this.rbSuporte = new System.Windows.Forms.RadioButton();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.txtDescricao = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtCodigo = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tcImagemSolucao = new System.Windows.Forms.TabControl();
            this.tpImagens = new System.Windows.Forms.TabPage();
            this.ucCadImagens = new appSSI.ucCadImagens();
            this.tpDefeitos = new System.Windows.Forms.TabPage();
            this.ucCadSolucoesDefeitos = new appSSI.ucCadSolucoesDefeitos();
            this.txtDtCadastro = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.lblDtCadastro = new System.Windows.Forms.Label();
            this.pnFiltro.SuspendLayout();
            this.pnForm.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.tcCadastro.SuspendLayout();
            this.tpFormulario.SuspendLayout();
            this.gbNivel.SuspendLayout();
            this.tcImagemSolucao.SuspendLayout();
            this.tpImagens.SuspendLayout();
            this.tpDefeitos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnFiltro
            // 
            this.pnFiltro.Size = new System.Drawing.Size(740, 90);
            // 
            // pnForm
            // 
            this.pnForm.Controls.Add(this.lblDtCadastro);
            this.pnForm.Controls.Add(this.txtDtCadastro);
            this.pnForm.Controls.Add(this.gbNivel);
            this.pnForm.Controls.Add(this.txtDescricao);
            this.pnForm.Controls.Add(this.lblDescricao);
            this.pnForm.Controls.Add(this.txtCodigo);
            this.pnForm.Controls.Add(this.lblCodigo);
            this.pnForm.Controls.Add(this.tcImagemSolucao);
            this.pnForm.Size = new System.Drawing.Size(740, 427);
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
            this.pnForm.Controls.SetChildIndex(this.gbNivel, 0);
            this.pnForm.Controls.SetChildIndex(this.txtDtCadastro, 0);
            this.pnForm.Controls.SetChildIndex(this.lblDtCadastro, 0);
            // 
            // pnBotoes
            // 
            this.pnBotoes.Location = new System.Drawing.Point(650, 0);
            // 
            // tcCadastro
            // 
            this.tcCadastro.Size = new System.Drawing.Size(754, 459);
            // 
            // pnGridFiltro
            // 
            this.pnGridFiltro.Size = new System.Drawing.Size(650, 68);
            // 
            // btnEncolherExpandir
            // 
            this.btnEncolherExpandir.Size = new System.Drawing.Size(738, 20);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(669, 3);
            this.btnNext.TabIndex = 2;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(704, 3);
            this.btnLast.TabIndex = 3;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(599, 3);
            this.btnFirst.TabIndex = 0;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(634, 3);
            this.btnPrevious.TabIndex = 1;
            // 
            // tpFormulario
            // 
            this.tpFormulario.Size = new System.Drawing.Size(746, 433);
            // 
            // gbNivel
            // 
            this.gbNivel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbNivel.Controls.Add(this.rbDesenvolvedor);
            this.gbNivel.Controls.Add(this.rbSuporte);
            this.gbNivel.Controls.Add(this.rbCliente);
            this.gbNivel.Location = new System.Drawing.Point(419, 34);
            this.gbNivel.Name = "gbNivel";
            this.gbNivel.Size = new System.Drawing.Size(312, 36);
            this.gbNivel.TabIndex = 4;
            this.gbNivel.TabStop = false;
            this.gbNivel.Text = "Nível";
            // 
            // rbDesenvolvedor
            // 
            this.rbDesenvolvedor.AutoSize = true;
            this.rbDesenvolvedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDesenvolvedor.ForeColor = System.Drawing.Color.Brown;
            this.rbDesenvolvedor.Location = new System.Drawing.Point(178, 9);
            this.rbDesenvolvedor.Name = "rbDesenvolvedor";
            this.rbDesenvolvedor.Size = new System.Drawing.Size(134, 21);
            this.rbDesenvolvedor.TabIndex = 2;
            this.rbDesenvolvedor.TabStop = true;
            this.rbDesenvolvedor.Text = "Desenvolvedor";
            this.rbDesenvolvedor.UseVisualStyleBackColor = true;
            // 
            // rbSuporte
            // 
            this.rbSuporte.AutoSize = true;
            this.rbSuporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSuporte.ForeColor = System.Drawing.Color.ForestGreen;
            this.rbSuporte.Location = new System.Drawing.Point(89, 9);
            this.rbSuporte.Name = "rbSuporte";
            this.rbSuporte.Size = new System.Drawing.Size(83, 21);
            this.rbSuporte.TabIndex = 1;
            this.rbSuporte.TabStop = true;
            this.rbSuporte.Text = "Suporte";
            this.rbSuporte.UseVisualStyleBackColor = true;
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCliente.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rbCliente.Location = new System.Drawing.Point(7, 9);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(76, 21);
            this.rbCliente.TabIndex = 0;
            this.rbCliente.TabStop = true;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
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
            this.txtDescricao.Size = new System.Drawing.Size(730, 123);
            this.txtDescricao.TabIndex = 5;
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
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(0, 18);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 13);
            this.lblCodigo.TabIndex = 7;
            this.lblCodigo.Text = "Código :";
            // 
            // tcImagemSolucao
            // 
            this.tcImagemSolucao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tcImagemSolucao.Controls.Add(this.tpImagens);
            this.tcImagemSolucao.Controls.Add(this.tpDefeitos);
            this.tcImagemSolucao.Location = new System.Drawing.Point(3, 202);
            this.tcImagemSolucao.Name = "tcImagemSolucao";
            this.tcImagemSolucao.SelectedIndex = 0;
            this.tcImagemSolucao.Size = new System.Drawing.Size(735, 220);
            this.tcImagemSolucao.TabIndex = 6;
            // 
            // tpImagens
            // 
            this.tpImagens.Controls.Add(this.ucCadImagens);
            this.tpImagens.Location = new System.Drawing.Point(4, 22);
            this.tpImagens.Name = "tpImagens";
            this.tpImagens.Padding = new System.Windows.Forms.Padding(3);
            this.tpImagens.Size = new System.Drawing.Size(727, 194);
            this.tpImagens.TabIndex = 0;
            this.tpImagens.Text = "Imagens";
            this.tpImagens.UseVisualStyleBackColor = true;
            // 
            // ucCadImagens
            // 
            this.ucCadImagens.cdDefeito = 0;
            this.ucCadImagens.cdSolucao = 0;
            this.ucCadImagens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCadImagens.flDefeito = false;
            this.ucCadImagens.Location = new System.Drawing.Point(3, 3);
            this.ucCadImagens.Name = "ucCadImagens";
            this.ucCadImagens.Size = new System.Drawing.Size(721, 188);
            this.ucCadImagens.TabIndex = 0;
            // 
            // tpDefeitos
            // 
            this.tpDefeitos.Controls.Add(this.ucCadSolucoesDefeitos);
            this.tpDefeitos.Location = new System.Drawing.Point(4, 22);
            this.tpDefeitos.Name = "tpDefeitos";
            this.tpDefeitos.Padding = new System.Windows.Forms.Padding(3);
            this.tpDefeitos.Size = new System.Drawing.Size(727, 194);
            this.tpDefeitos.TabIndex = 1;
            this.tpDefeitos.Text = "Defeitos";
            this.tpDefeitos.UseVisualStyleBackColor = true;
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
            this.ucCadSolucoesDefeitos.flDefeito = true;
            this.ucCadSolucoesDefeitos.Location = new System.Drawing.Point(3, 3);
            this.ucCadSolucoesDefeitos.Name = "ucCadSolucoesDefeitos";
            this.ucCadSolucoesDefeitos.order = "";
            this.ucCadSolucoesDefeitos.Size = new System.Drawing.Size(721, 188);
            this.ucCadSolucoesDefeitos.TabIndex = 0;
            // 
            // txtDtCadastro
            // 
            this.txtDtCadastro.AceitaEspaco = true;
            this.txtDtCadastro.CampoObrigatorio = false;
            this.txtDtCadastro.Location = new System.Drawing.Point(109, 34);
            this.txtDtCadastro.MensagemCampoObrigatorio = null;
            this.txtDtCadastro.Name = "txtDtCadastro";
            this.txtDtCadastro.ReadOnly = true;
            this.txtDtCadastro.Size = new System.Drawing.Size(75, 20);
            this.txtDtCadastro.TabIndex = 10;
            // 
            // lblDtCadastro
            // 
            this.lblDtCadastro.AutoSize = true;
            this.lblDtCadastro.Location = new System.Drawing.Point(106, 18);
            this.lblDtCadastro.Name = "lblDtCadastro";
            this.lblDtCadastro.Size = new System.Drawing.Size(72, 13);
            this.lblDtCadastro.TabIndex = 11;
            this.lblDtCadastro.Text = "Dt. Cadastro :";
            // 
            // frmCadSolucoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.bImprimeRelCompleto = false;
            this.bImprimeRelSimples = false;
            this.ClientSize = new System.Drawing.Size(754, 506);
            this.KeyPreview = true;
            this.Name = "frmCadSolucoes";
            this.Text = "Cadastro de Soluções";
            this.TpCorrente = this.tpFormulario;
            this.Load += new System.EventHandler(this.frmCadSolucoes_Load);
            this.pnFiltro.ResumeLayout(false);
            this.pnForm.ResumeLayout(false);
            this.pnForm.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.tcCadastro.ResumeLayout(false);
            this.tpFormulario.ResumeLayout(false);
            this.gbNivel.ResumeLayout(false);
            this.gbNivel.PerformLayout();
            this.tcImagemSolucao.ResumeLayout(false);
            this.tpImagens.ResumeLayout(false);
            this.tpDefeitos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNivel;
        private System.Windows.Forms.RadioButton rbDesenvolvedor;
        private System.Windows.Forms.RadioButton rbSuporte;
        private System.Windows.Forms.RadioButton rbCliente;
        private KuraFrameWork.Componentes_Visuais.ucTextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TabControl tcImagemSolucao;
        private System.Windows.Forms.TabPage tpImagens;
        private ucCadImagens ucCadImagens;
        private System.Windows.Forms.TabPage tpDefeitos;
        private ucCadSolucoesDefeitos ucCadSolucoesDefeitos;
        private System.Windows.Forms.Label lblDtCadastro;
        private KuraFrameWork.Componentes_Visuais.ucTextBox txtDtCadastro;
        public KuraFrameWork.Componentes_Visuais.ucTextBox txtCodigo;

    }
}
