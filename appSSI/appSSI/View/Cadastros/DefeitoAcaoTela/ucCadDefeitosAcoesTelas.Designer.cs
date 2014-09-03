namespace appSSI
{
    partial class ucCadDefeitosAcoesTelas
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
            this.dgvAcoesTelas = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.ucAcoesCons = new appSSI.ucAcoesCons();
            this.ucTelasCons = new appSSI.ucTelasCons();
            this.cdDefeito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdTela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CC_deTela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdAcao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CC_deAcao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcoesTelas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAcoesTelas
            // 
            this.dgvAcoesTelas.AllowUserToAddRows = false;
            this.dgvAcoesTelas.AllowUserToDeleteRows = false;
            this.dgvAcoesTelas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAcoesTelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcoesTelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdDefeito,
            this.cdTela,
            this.CC_deTela,
            this.cdAcao,
            this.CC_deAcao});
            this.dgvAcoesTelas.Location = new System.Drawing.Point(0, 84);
            this.dgvAcoesTelas.Name = "dgvAcoesTelas";
            this.dgvAcoesTelas.ReadOnly = true;
            this.dgvAcoesTelas.Size = new System.Drawing.Size(658, 139);
            this.dgvAcoesTelas.TabIndex = 14;
            this.dgvAcoesTelas.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAcoesTelas_ColumnHeaderMouseClick);
            // 
            // btnRemove
            // 
            this.btnRemove.Image = global::appSSI.Properties.Resources.del;
            this.btnRemove.Location = new System.Drawing.Point(0, 42);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(89, 36);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Remover";
            this.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::appSSI.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 36);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ucAcoesCons
            // 
            this.ucAcoesCons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucAcoesCons.bMudouCodigo = false;
            this.ucAcoesCons.CampoObrigatorio = false;
            this.ucAcoesCons.cdTela = 0;
            this.ucAcoesCons.Location = new System.Drawing.Point(95, 42);
            this.ucAcoesCons.MensagemCampoObrigatorio = null;
            this.ucAcoesCons.Name = "ucAcoesCons";
            this.ucAcoesCons.Rotulo = "Ação :";
            this.ucAcoesCons.Size = new System.Drawing.Size(563, 36);
            this.ucAcoesCons.TabIndex = 11;
            this.ucAcoesCons.TelaConsulta = null;
            // 
            // ucTelasCons
            // 
            this.ucTelasCons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucTelasCons.bMudouCodigo = false;
            this.ucTelasCons.CampoObrigatorio = false;
            this.ucTelasCons.cdModulo = 0;
            this.ucTelasCons.Location = new System.Drawing.Point(95, 0);
            this.ucTelasCons.MensagemCampoObrigatorio = null;
            this.ucTelasCons.Name = "ucTelasCons";
            this.ucTelasCons.Rotulo = "Tela :";
            this.ucTelasCons.Size = new System.Drawing.Size(563, 36);
            this.ucTelasCons.TabIndex = 10;
            this.ucTelasCons.TelaConsulta = null;
            this.ucTelasCons.AoConsultarRegistro += new KuraFrameWork.Componentes_Visuais.AoConsultarRegistroEventHandler(this.ucTelasCons_AoConsultarRegistro);
            // 
            // cdDefeito
            // 
            this.cdDefeito.DataPropertyName = "cdDefeito";
            this.cdDefeito.HeaderText = "cdDefeito";
            this.cdDefeito.Name = "cdDefeito";
            this.cdDefeito.ReadOnly = true;
            this.cdDefeito.Visible = false;
            // 
            // cdTela
            // 
            this.cdTela.DataPropertyName = "cdTela";
            this.cdTela.HeaderText = "Cód. Tela";
            this.cdTela.Name = "cdTela";
            this.cdTela.ReadOnly = true;
            // 
            // CC_deTela
            // 
            this.CC_deTela.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CC_deTela.DataPropertyName = "CC_deTela";
            this.CC_deTela.HeaderText = "Tela";
            this.CC_deTela.Name = "CC_deTela";
            this.CC_deTela.ReadOnly = true;
            // 
            // cdAcao
            // 
            this.cdAcao.DataPropertyName = "cdAcao";
            this.cdAcao.HeaderText = "Cód. Ação";
            this.cdAcao.Name = "cdAcao";
            this.cdAcao.ReadOnly = true;
            // 
            // CC_deAcao
            // 
            this.CC_deAcao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CC_deAcao.DataPropertyName = "CC_deAcao";
            this.CC_deAcao.HeaderText = "Ação";
            this.CC_deAcao.Name = "CC_deAcao";
            this.CC_deAcao.ReadOnly = true;
            // 
            // ucCadDefeitosAcoesTelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvAcoesTelas);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ucAcoesCons);
            this.Controls.Add(this.ucTelasCons);
            this.Name = "ucCadDefeitosAcoesTelas";
            this.Size = new System.Drawing.Size(658, 223);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcoesTelas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAcoesTelas;
        public System.Windows.Forms.Button btnRemove;
        public System.Windows.Forms.Button btnAdd;
        private ucAcoesCons ucAcoesCons;
        private ucTelasCons ucTelasCons;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdDefeito;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdTela;
        private System.Windows.Forms.DataGridViewTextBoxColumn CC_deTela;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdAcao;
        private System.Windows.Forms.DataGridViewTextBoxColumn CC_deAcao;

    }
}
