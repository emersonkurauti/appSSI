namespace appSSI
{
    partial class frmCadTelas
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
            this.txtDescicao = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.gbAcoes = new System.Windows.Forms.GroupBox();
            this.dgvAcao = new System.Windows.Forms.DataGridView();
            this.cdAcao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deAcao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.ucAcoesCons = new appSSI.ucAcoesCons();
            this.ucModulosCons = new appSSI.ucModulosCons();
            this.pnFiltro.SuspendLayout();
            this.pnForm.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.tcCadastro.SuspendLayout();
            this.tpFormulario.SuspendLayout();
            this.gbAcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcao)).BeginInit();
            this.SuspendLayout();
            // 
            // pnForm
            // 
            this.pnForm.Controls.Add(this.gbAcoes);
            this.pnForm.Controls.Add(this.txtDescicao);
            this.pnForm.Controls.Add(this.lblDescricao);
            this.pnForm.Controls.Add(this.ucModulosCons);
            this.pnForm.Controls.Add(this.txtCodigo);
            this.pnForm.Controls.Add(this.lblCodigo);
            this.pnForm.TabIndex = 0;
            this.pnForm.Controls.SetChildIndex(this.btnLast, 0);
            this.pnForm.Controls.SetChildIndex(this.btnPrevious, 0);
            this.pnForm.Controls.SetChildIndex(this.btnNext, 0);
            this.pnForm.Controls.SetChildIndex(this.btnFirst, 0);
            this.pnForm.Controls.SetChildIndex(this.lblCodigo, 0);
            this.pnForm.Controls.SetChildIndex(this.txtCodigo, 0);
            this.pnForm.Controls.SetChildIndex(this.ucModulosCons, 0);
            this.pnForm.Controls.SetChildIndex(this.lblDescricao, 0);
            this.pnForm.Controls.SetChildIndex(this.txtDescicao, 0);
            this.pnForm.Controls.SetChildIndex(this.gbAcoes, 0);
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
            this.lblCodigo.Size = new System.Drawing.Size(70, 13);
            this.lblCodigo.TabIndex = 7;
            this.lblCodigo.Text = "Código Tela :";
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
            // txtDescicao
            // 
            this.txtDescicao.AceitaEspaco = true;
            this.txtDescicao.CampoObrigatorio = true;
            this.txtDescicao.Location = new System.Drawing.Point(3, 73);
            this.txtDescicao.MaxLength = 30;
            this.txtDescicao.MensagemCampoObrigatorio = "Informe a descrição da tela.";
            this.txtDescicao.Name = "txtDescicao";
            this.txtDescicao.Size = new System.Drawing.Size(255, 20);
            this.txtDescicao.TabIndex = 4;
            // 
            // gbAcoes
            // 
            this.gbAcoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAcoes.Controls.Add(this.dgvAcao);
            this.gbAcoes.Controls.Add(this.txtRemove);
            this.gbAcoes.Controls.Add(this.btnAdd);
            this.gbAcoes.Controls.Add(this.ucAcoesCons);
            this.gbAcoes.Location = new System.Drawing.Point(3, 99);
            this.gbAcoes.Name = "gbAcoes";
            this.gbAcoes.Size = new System.Drawing.Size(660, 182);
            this.gbAcoes.TabIndex = 6;
            this.gbAcoes.TabStop = false;
            this.gbAcoes.Text = "Ações da Tela";
            // 
            // dgvAcao
            // 
            this.dgvAcao.AllowUserToAddRows = false;
            this.dgvAcao.AllowUserToDeleteRows = false;
            this.dgvAcao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAcao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdAcao,
            this.deAcao});
            this.dgvAcao.Location = new System.Drawing.Point(261, 19);
            this.dgvAcao.Name = "dgvAcao";
            this.dgvAcao.ReadOnly = true;
            this.dgvAcao.Size = new System.Drawing.Size(393, 157);
            this.dgvAcao.TabIndex = 3;
            // 
            // cdAcao
            // 
            this.cdAcao.DataPropertyName = "cdAcao";
            this.cdAcao.HeaderText = "cdAcao";
            this.cdAcao.Name = "cdAcao";
            this.cdAcao.ReadOnly = true;
            this.cdAcao.Visible = false;
            // 
            // deAcao
            // 
            this.deAcao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deAcao.DataPropertyName = "deAcao";
            this.deAcao.HeaderText = "Ação";
            this.deAcao.Name = "deAcao";
            this.deAcao.ReadOnly = true;
            // 
            // txtRemove
            // 
            this.txtRemove.Image = global::appSSI.Properties.Resources.del;
            this.txtRemove.Location = new System.Drawing.Point(134, 61);
            this.txtRemove.Name = "txtRemove";
            this.txtRemove.Size = new System.Drawing.Size(121, 39);
            this.txtRemove.TabIndex = 2;
            this.txtRemove.Text = "Remover";
            this.txtRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.txtRemove.UseVisualStyleBackColor = true;
            this.txtRemove.Click += new System.EventHandler(this.txtRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::appSSI.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(6, 61);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 39);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ucAcoesCons
            // 
            this.ucAcoesCons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucAcoesCons.bCadastrar = true;
            this.ucAcoesCons.bMudouCodigo = false;
            this.ucAcoesCons.CampoObrigatorio = false;
            this.ucAcoesCons.cdTela = 0;
            this.ucAcoesCons.Location = new System.Drawing.Point(6, 19);
            this.ucAcoesCons.MensagemCampoObrigatorio = null;
            this.ucAcoesCons.Name = "ucAcoesCons";
            this.ucAcoesCons.Rotulo = "Ação :";
            this.ucAcoesCons.Size = new System.Drawing.Size(249, 36);
            this.ucAcoesCons.TabIndex = 0;
            this.ucAcoesCons.TelaConsulta = null;
            // 
            // ucModulosCons
            // 
            this.ucModulosCons.bCadastrar = true;
            this.ucModulosCons.bMudouCodigo = false;
            this.ucModulosCons.CampoObrigatorio = true;
            this.ucModulosCons.cdSistema = 0;
            this.ucModulosCons.Location = new System.Drawing.Point(264, 57);
            this.ucModulosCons.MensagemCampoObrigatorio = "Informe o módulo da tela.";
            this.ucModulosCons.Name = "ucModulosCons";
            this.ucModulosCons.Rotulo = "*Modulo :";
            this.ucModulosCons.Size = new System.Drawing.Size(399, 36);
            this.ucModulosCons.TabIndex = 5;
            this.ucModulosCons.TelaConsulta = null;
            // 
            // frmCadTelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(684, 367);
            this.KeyPreview = true;
            this.Name = "frmCadTelas";
            this.Text = "Cadastro de Telas";
            this.TpCorrente = this.tpFormulario;
            this.Load += new System.EventHandler(this.frmCadTelas_Load);
            this.pnFiltro.ResumeLayout(false);
            this.pnForm.ResumeLayout(false);
            this.pnForm.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.tcCadastro.ResumeLayout(false);
            this.tpFormulario.ResumeLayout(false);
            this.gbAcoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KuraFrameWork.Componentes_Visuais.ucTextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private ucModulosCons ucModulosCons;
        private KuraFrameWork.Componentes_Visuais.ucTextBox txtDescicao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.GroupBox gbAcoes;
        private ucAcoesCons ucAcoesCons;
        private System.Windows.Forms.Button txtRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvAcao;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdAcao;
        private System.Windows.Forms.DataGridViewTextBoxColumn deAcao;
    }
}
