namespace appSSI
{
    partial class ucCadSolucoesDefeitos
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
            this.dgvSolucoesDefeitos = new System.Windows.Forms.DataGridView();
            this.cdDefeito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdSolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CC_deDefeito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CC_deSolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tcDescricaoObs = new System.Windows.Forms.TabControl();
            this.tpDescricao = new System.Windows.Forms.TabPage();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.tpObs = new System.Windows.Forms.TabPage();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.ucDefeitosCons = new appSSI.ucDefeitosCons();
            this.ucSolucoesCons = new appSSI.ucSolucoesCons();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolucoesDefeitos)).BeginInit();
            this.tcDescricaoObs.SuspendLayout();
            this.tpDescricao.SuspendLayout();
            this.tpObs.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSolucoesDefeitos
            // 
            this.dgvSolucoesDefeitos.AllowUserToAddRows = false;
            this.dgvSolucoesDefeitos.AllowUserToDeleteRows = false;
            this.dgvSolucoesDefeitos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvSolucoesDefeitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolucoesDefeitos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdDefeito,
            this.cdSolucao,
            this.CC_deDefeito,
            this.CC_deSolucao});
            this.dgvSolucoesDefeitos.Location = new System.Drawing.Point(3, 45);
            this.dgvSolucoesDefeitos.Name = "dgvSolucoesDefeitos";
            this.dgvSolucoesDefeitos.ReadOnly = true;
            this.dgvSolucoesDefeitos.Size = new System.Drawing.Size(377, 142);
            this.dgvSolucoesDefeitos.TabIndex = 0;
            this.dgvSolucoesDefeitos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSolucoesDefeitos_CellClick);
            this.dgvSolucoesDefeitos.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSolucoesDefeitos_ColumnHeaderMouseClick);
            // 
            // cdDefeito
            // 
            this.cdDefeito.DataPropertyName = "cdDefeito";
            this.cdDefeito.HeaderText = "cdDefeito";
            this.cdDefeito.Name = "cdDefeito";
            this.cdDefeito.ReadOnly = true;
            this.cdDefeito.Visible = false;
            // 
            // cdSolucao
            // 
            this.cdSolucao.DataPropertyName = "cdSolucao";
            this.cdSolucao.HeaderText = "cdSolucao";
            this.cdSolucao.Name = "cdSolucao";
            this.cdSolucao.ReadOnly = true;
            this.cdSolucao.Visible = false;
            // 
            // CC_deDefeito
            // 
            this.CC_deDefeito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CC_deDefeito.DataPropertyName = "CC_deDefeito";
            this.CC_deDefeito.HeaderText = "Descrição do defeito";
            this.CC_deDefeito.Name = "CC_deDefeito";
            this.CC_deDefeito.ReadOnly = true;
            this.CC_deDefeito.Visible = false;
            // 
            // CC_deSolucao
            // 
            this.CC_deSolucao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CC_deSolucao.DataPropertyName = "CC_deSolucao";
            this.CC_deSolucao.HeaderText = "Descrição da solução";
            this.CC_deSolucao.Name = "CC_deSolucao";
            this.CC_deSolucao.ReadOnly = true;
            this.CC_deSolucao.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::appSSI.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 36);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Image = global::appSSI.Properties.Resources.del;
            this.btnRemove.Location = new System.Drawing.Point(98, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(89, 36);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remover";
            this.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tcDescricaoObs
            // 
            this.tcDescricaoObs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tcDescricaoObs.Controls.Add(this.tpDescricao);
            this.tcDescricaoObs.Controls.Add(this.tpObs);
            this.tcDescricaoObs.Location = new System.Drawing.Point(386, 45);
            this.tcDescricaoObs.Name = "tcDescricaoObs";
            this.tcDescricaoObs.SelectedIndex = 0;
            this.tcDescricaoObs.Size = new System.Drawing.Size(336, 142);
            this.tcDescricaoObs.TabIndex = 7;
            // 
            // tpDescricao
            // 
            this.tpDescricao.Controls.Add(this.txtDescricao);
            this.tpDescricao.Location = new System.Drawing.Point(4, 22);
            this.tpDescricao.Name = "tpDescricao";
            this.tpDescricao.Padding = new System.Windows.Forms.Padding(3);
            this.tpDescricao.Size = new System.Drawing.Size(328, 116);
            this.tpDescricao.TabIndex = 0;
            this.tpDescricao.Text = "Descrição";
            this.tpDescricao.UseVisualStyleBackColor = true;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescricao.Location = new System.Drawing.Point(3, 3);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescricao.Size = new System.Drawing.Size(322, 110);
            this.txtDescricao.TabIndex = 0;
            // 
            // tpObs
            // 
            this.tpObs.Controls.Add(this.txtObs);
            this.tpObs.Location = new System.Drawing.Point(4, 22);
            this.tpObs.Name = "tpObs";
            this.tpObs.Padding = new System.Windows.Forms.Padding(3);
            this.tpObs.Size = new System.Drawing.Size(328, 116);
            this.tpObs.TabIndex = 1;
            this.tpObs.Text = "Observação";
            this.tpObs.UseVisualStyleBackColor = true;
            // 
            // txtObs
            // 
            this.txtObs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObs.Location = new System.Drawing.Point(3, 3);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObs.Size = new System.Drawing.Size(322, 110);
            this.txtObs.TabIndex = 0;
            this.txtObs.Leave += new System.EventHandler(this.txtObs_Leave);
            // 
            // ucDefeitosCons
            // 
            this.ucDefeitosCons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucDefeitosCons.CampoObrigatorio = false;
            this.ucDefeitosCons.Location = new System.Drawing.Point(193, 3);
            this.ucDefeitosCons.MensagemCampoObrigatorio = null;
            this.ucDefeitosCons.Name = "ucDefeitosCons";
            this.ucDefeitosCons.Rotulo = "Descrição do Defeito :";
            this.ucDefeitosCons.Size = new System.Drawing.Size(529, 36);
            this.ucDefeitosCons.TabIndex = 8;
            this.ucDefeitosCons.TelaConsulta = null;
            // 
            // ucSolucoesCons
            // 
            this.ucSolucoesCons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSolucoesCons.CampoObrigatorio = false;
            this.ucSolucoesCons.Location = new System.Drawing.Point(193, 3);
            this.ucSolucoesCons.MensagemCampoObrigatorio = null;
            this.ucSolucoesCons.Name = "ucSolucoesCons";
            this.ucSolucoesCons.Rotulo = "Descrição da Solução :";
            this.ucSolucoesCons.Size = new System.Drawing.Size(529, 36);
            this.ucSolucoesCons.TabIndex = 9;
            this.ucSolucoesCons.TelaConsulta = null;
            // 
            // ucCadSolucoesDefeitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ucSolucoesCons);
            this.Controls.Add(this.tcDescricaoObs);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvSolucoesDefeitos);
            this.Controls.Add(this.ucDefeitosCons);
            this.Name = "ucCadSolucoesDefeitos";
            this.Size = new System.Drawing.Size(725, 190);
            this.Load += new System.EventHandler(this.ucCadSolucoesDefeitos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolucoesDefeitos)).EndInit();
            this.tcDescricaoObs.ResumeLayout(false);
            this.tpDescricao.ResumeLayout(false);
            this.tpDescricao.PerformLayout();
            this.tpObs.ResumeLayout(false);
            this.tpObs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvSolucoesDefeitos;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnRemove;
        public System.Windows.Forms.TabControl tcDescricaoObs;
        public System.Windows.Forms.TabPage tpDescricao;
        public System.Windows.Forms.TabPage tpObs;
        public System.Windows.Forms.TextBox txtDescricao;
        public System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdDefeito;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdSolucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn CC_deDefeito;
        private System.Windows.Forms.DataGridViewTextBoxColumn CC_deSolucao;
        private ucDefeitosCons ucDefeitosCons;
        private ucSolucoesCons ucSolucoesCons;
    }
}
