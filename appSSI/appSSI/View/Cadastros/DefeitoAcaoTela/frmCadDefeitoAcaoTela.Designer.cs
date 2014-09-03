namespace appSSI
{
    partial class frmCadDefeitoAcaoTela
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
            this.ucTelasCons = new appSSI.ucTelasCons();
            this.ucAcoesCons = new appSSI.ucAcoesCons();
            this.ucDefeitosCons = new appSSI.ucDefeitosCons();
            this.gbDescDefeito = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.pnFiltro.SuspendLayout();
            this.pnForm.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.tcCadastro.SuspendLayout();
            this.tpFormulario.SuspendLayout();
            this.gbDescDefeito.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnFiltro
            // 
            this.pnFiltro.Size = new System.Drawing.Size(826, 90);
            // 
            // pnForm
            // 
            this.pnForm.Controls.Add(this.gbDescDefeito);
            this.pnForm.Controls.Add(this.ucDefeitosCons);
            this.pnForm.Controls.Add(this.ucTelasCons);
            this.pnForm.Controls.Add(this.ucAcoesCons);
            this.pnForm.Size = new System.Drawing.Size(826, 401);
            this.pnForm.Controls.SetChildIndex(this.btnPrevious, 0);
            this.pnForm.Controls.SetChildIndex(this.btnFirst, 0);
            this.pnForm.Controls.SetChildIndex(this.btnLast, 0);
            this.pnForm.Controls.SetChildIndex(this.btnNext, 0);
            this.pnForm.Controls.SetChildIndex(this.ucAcoesCons, 0);
            this.pnForm.Controls.SetChildIndex(this.ucTelasCons, 0);
            this.pnForm.Controls.SetChildIndex(this.ucDefeitosCons, 0);
            this.pnForm.Controls.SetChildIndex(this.gbDescDefeito, 0);
            // 
            // pnBotoes
            // 
            this.pnBotoes.Location = new System.Drawing.Point(736, 0);
            // 
            // tcCadastro
            // 
            this.tcCadastro.Size = new System.Drawing.Size(840, 433);
            // 
            // pnGridFiltro
            // 
            this.pnGridFiltro.Size = new System.Drawing.Size(736, 68);
            // 
            // btnEncolherExpandir
            // 
            this.btnEncolherExpandir.Size = new System.Drawing.Size(824, 20);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(755, 3);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(790, 3);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(685, 3);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(720, 3);
            // 
            // tpFormulario
            // 
            this.tpFormulario.Size = new System.Drawing.Size(832, 407);
            // 
            // ucTelasCons
            // 
            this.ucTelasCons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucTelasCons.CampoObrigatorio = true;
            this.ucTelasCons.Location = new System.Drawing.Point(3, 37);
            this.ucTelasCons.MensagemCampoObrigatorio = "Selecione a tela.";
            this.ucTelasCons.Name = "ucTelasCons";
            this.ucTelasCons.Rotulo = "Tela :";
            this.ucTelasCons.Size = new System.Drawing.Size(818, 36);
            this.ucTelasCons.TabIndex = 15;
            this.ucTelasCons.TelaConsulta = null;
            // 
            // ucAcoesCons
            // 
            this.ucAcoesCons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucAcoesCons.CampoObrigatorio = true;
            this.ucAcoesCons.Location = new System.Drawing.Point(3, 79);
            this.ucAcoesCons.MensagemCampoObrigatorio = "Selecione a ação.";
            this.ucAcoesCons.Name = "ucAcoesCons";
            this.ucAcoesCons.Rotulo = "Ação :";
            this.ucAcoesCons.Size = new System.Drawing.Size(818, 36);
            this.ucAcoesCons.TabIndex = 14;
            this.ucAcoesCons.TelaConsulta = null;
            // 
            // ucDefeitosCons
            // 
            this.ucDefeitosCons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucDefeitosCons.CampoObrigatorio = true;
            this.ucDefeitosCons.Location = new System.Drawing.Point(3, 121);
            this.ucDefeitosCons.MensagemCampoObrigatorio = "Selecione o defeito da ação/tela.";
            this.ucDefeitosCons.Name = "ucDefeitosCons";
            this.ucDefeitosCons.Rotulo = "Descrição do Defeito :";
            this.ucDefeitosCons.Size = new System.Drawing.Size(818, 36);
            this.ucDefeitosCons.TabIndex = 16;
            this.ucDefeitosCons.TelaConsulta = null;
            this.ucDefeitosCons.AoConsultarRegistro += new KuraFrameWork.Componentes_Visuais.AoConsultarRegistroEventHandler(this.ucDefeitosCons_AoConsultarRegistro);
            // 
            // gbDescDefeito
            // 
            this.gbDescDefeito.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDescDefeito.Controls.Add(this.txtDescricao);
            this.gbDescDefeito.Location = new System.Drawing.Point(3, 163);
            this.gbDescDefeito.Name = "gbDescDefeito";
            this.gbDescDefeito.Size = new System.Drawing.Size(816, 231);
            this.gbDescDefeito.TabIndex = 17;
            this.gbDescDefeito.TabStop = false;
            this.gbDescDefeito.Text = "Descrição do Defeito";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescricao.Location = new System.Drawing.Point(3, 16);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(810, 212);
            this.txtDescricao.TabIndex = 0;
            // 
            // frmCadDefeitoAcaoTela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(840, 480);
            this.Name = "frmCadDefeitoAcaoTela";
            this.Text = "Cadastro de Defeito da Ação da Tela";
            this.TpCorrente = this.tpFormulario;
            this.Load += new System.EventHandler(this.frmCadDefeitoAcaoTela_Load);
            this.pnFiltro.ResumeLayout(false);
            this.pnForm.ResumeLayout(false);
            this.pnBotoes.ResumeLayout(false);
            this.tcCadastro.ResumeLayout(false);
            this.tpFormulario.ResumeLayout(false);
            this.gbDescDefeito.ResumeLayout(false);
            this.gbDescDefeito.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucAcoesCons ucAcoesCons;
        private ucTelasCons ucTelasCons;
        private ucDefeitosCons ucDefeitosCons;
        private System.Windows.Forms.GroupBox gbDescDefeito;
        private System.Windows.Forms.TextBox txtDescricao;
    }
}
