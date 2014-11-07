namespace appSSI
{
    partial class frmCadEmpresas
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
            this.dgvSistemasEmpresas = new System.Windows.Forms.DataGridView();
            this.cdSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbNomeFantasia = new System.Windows.Forms.Label();
            this.lbCNPJ = new System.Windows.Forms.Label();
            this.lbLogradouro = new System.Windows.Forms.Label();
            this.lbNumero = new System.Windows.Forms.Label();
            this.lbBairro = new System.Windows.Forms.Label();
            this.lbComplemento = new System.Windows.Forms.Label();
            this.lbCEP = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.gbSisEmpresa = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNome = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.txtNomeFantasia = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.txtCNPJ = new KuraFrameWork.Componentes_Visuais.ucTextBoxMaskCNPJ();
            this.txtLogradouro = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.txtNuLogradouro = new KuraFrameWork.Componentes_Visuais.ucTextBoxNumero();
            this.txtBairro = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.txtComplemento = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.txtCEP = new KuraFrameWork.Componentes_Visuais.ucTextBoxMaxCEP();
            this.txtTelefone = new KuraFrameWork.Componentes_Visuais.ucTextBoxMaskTelefone();
            this.ucSistemasCons = new appSSI.ucSistemasCons();
            this.pnFiltro.SuspendLayout();
            this.pnForm.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.tcCadastro.SuspendLayout();
            this.tpFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSistemasEmpresas)).BeginInit();
            this.gbSisEmpresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnForm
            // 
            this.pnForm.Controls.Add(this.txtTelefone);
            this.pnForm.Controls.Add(this.txtCEP);
            this.pnForm.Controls.Add(this.txtComplemento);
            this.pnForm.Controls.Add(this.txtBairro);
            this.pnForm.Controls.Add(this.txtNuLogradouro);
            this.pnForm.Controls.Add(this.txtLogradouro);
            this.pnForm.Controls.Add(this.txtCNPJ);
            this.pnForm.Controls.Add(this.txtNomeFantasia);
            this.pnForm.Controls.Add(this.txtNome);
            this.pnForm.Controls.Add(this.gbSisEmpresa);
            this.pnForm.Controls.Add(this.lbTelefone);
            this.pnForm.Controls.Add(this.lbCEP);
            this.pnForm.Controls.Add(this.lbComplemento);
            this.pnForm.Controls.Add(this.lbBairro);
            this.pnForm.Controls.Add(this.lbNumero);
            this.pnForm.Controls.Add(this.lbLogradouro);
            this.pnForm.Controls.Add(this.lbCNPJ);
            this.pnForm.Controls.Add(this.lbNomeFantasia);
            this.pnForm.Controls.Add(this.lbNome);
            this.pnForm.Controls.Add(this.lbCodigo);
            this.pnForm.Controls.Add(this.txtCodigo);
            this.pnForm.TabIndex = 0;
            this.pnForm.Controls.SetChildIndex(this.txtCodigo, 0);
            this.pnForm.Controls.SetChildIndex(this.lbCodigo, 0);
            this.pnForm.Controls.SetChildIndex(this.lbNome, 0);
            this.pnForm.Controls.SetChildIndex(this.lbNomeFantasia, 0);
            this.pnForm.Controls.SetChildIndex(this.lbCNPJ, 0);
            this.pnForm.Controls.SetChildIndex(this.lbLogradouro, 0);
            this.pnForm.Controls.SetChildIndex(this.lbNumero, 0);
            this.pnForm.Controls.SetChildIndex(this.lbBairro, 0);
            this.pnForm.Controls.SetChildIndex(this.lbComplemento, 0);
            this.pnForm.Controls.SetChildIndex(this.lbCEP, 0);
            this.pnForm.Controls.SetChildIndex(this.lbTelefone, 0);
            this.pnForm.Controls.SetChildIndex(this.gbSisEmpresa, 0);
            this.pnForm.Controls.SetChildIndex(this.btnLast, 0);
            this.pnForm.Controls.SetChildIndex(this.btnPrevious, 0);
            this.pnForm.Controls.SetChildIndex(this.btnNext, 0);
            this.pnForm.Controls.SetChildIndex(this.btnFirst, 0);
            this.pnForm.Controls.SetChildIndex(this.txtNome, 0);
            this.pnForm.Controls.SetChildIndex(this.txtNomeFantasia, 0);
            this.pnForm.Controls.SetChildIndex(this.txtCNPJ, 0);
            this.pnForm.Controls.SetChildIndex(this.txtLogradouro, 0);
            this.pnForm.Controls.SetChildIndex(this.txtNuLogradouro, 0);
            this.pnForm.Controls.SetChildIndex(this.txtBairro, 0);
            this.pnForm.Controls.SetChildIndex(this.txtComplemento, 0);
            this.pnForm.Controls.SetChildIndex(this.txtCEP, 0);
            this.pnForm.Controls.SetChildIndex(this.txtTelefone, 0);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
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
            // dgvSistemasEmpresas
            // 
            this.dgvSistemasEmpresas.AllowUserToAddRows = false;
            this.dgvSistemasEmpresas.AllowUserToDeleteRows = false;
            this.dgvSistemasEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSistemasEmpresas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdSistema,
            this.nmSistema});
            this.dgvSistemasEmpresas.Location = new System.Drawing.Point(260, 16);
            this.dgvSistemasEmpresas.Name = "dgvSistemasEmpresas";
            this.dgvSistemasEmpresas.ReadOnly = true;
            this.dgvSistemasEmpresas.Size = new System.Drawing.Size(391, 82);
            this.dgvSistemasEmpresas.TabIndex = 3;
            // 
            // cdSistema
            // 
            this.cdSistema.DataPropertyName = "cdSistema";
            this.cdSistema.HeaderText = "cdSistema";
            this.cdSistema.Name = "cdSistema";
            this.cdSistema.ReadOnly = true;
            this.cdSistema.Visible = false;
            // 
            // nmSistema
            // 
            this.nmSistema.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nmSistema.DataPropertyName = "nmSistema";
            this.nmSistema.HeaderText = "Sistema";
            this.nmSistema.Name = "nmSistema";
            this.nmSistema.ReadOnly = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(3, 34);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 15;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(0, 18);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(46, 13);
            this.lbCodigo.TabIndex = 14;
            this.lbCodigo.Text = "Código :";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(0, 57);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(45, 13);
            this.lbNome.TabIndex = 16;
            this.lbNome.Text = "*Nome :";
            // 
            // lbNomeFantasia
            // 
            this.lbNomeFantasia.AutoSize = true;
            this.lbNomeFantasia.Location = new System.Drawing.Point(263, 57);
            this.lbNomeFantasia.Name = "lbNomeFantasia";
            this.lbNomeFantasia.Size = new System.Drawing.Size(85, 13);
            this.lbNomeFantasia.TabIndex = 17;
            this.lbNomeFantasia.Text = "*Nome fantasia :";
            // 
            // lbCNPJ
            // 
            this.lbCNPJ.AutoSize = true;
            this.lbCNPJ.Location = new System.Drawing.Point(0, 96);
            this.lbCNPJ.Name = "lbCNPJ";
            this.lbCNPJ.Size = new System.Drawing.Size(44, 13);
            this.lbCNPJ.TabIndex = 18;
            this.lbCNPJ.Text = "*CNPJ :";
            // 
            // lbLogradouro
            // 
            this.lbLogradouro.AutoSize = true;
            this.lbLogradouro.Location = new System.Drawing.Point(121, 96);
            this.lbLogradouro.Name = "lbLogradouro";
            this.lbLogradouro.Size = new System.Drawing.Size(71, 13);
            this.lbLogradouro.TabIndex = 19;
            this.lbLogradouro.Text = "*Logradouro :";
            // 
            // lbNumero
            // 
            this.lbNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNumero.AutoSize = true;
            this.lbNumero.Location = new System.Drawing.Point(561, 96);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(54, 13);
            this.lbNumero.TabIndex = 22;
            this.lbNumero.Text = "*Número :";
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Location = new System.Drawing.Point(0, 135);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(40, 13);
            this.lbBairro.TabIndex = 24;
            this.lbBairro.Text = "Bairro :";
            // 
            // lbComplemento
            // 
            this.lbComplemento.AutoSize = true;
            this.lbComplemento.Location = new System.Drawing.Point(263, 135);
            this.lbComplemento.Name = "lbComplemento";
            this.lbComplemento.Size = new System.Drawing.Size(77, 13);
            this.lbComplemento.TabIndex = 20;
            this.lbComplemento.Text = "Complemento :";
            // 
            // lbCEP
            // 
            this.lbCEP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCEP.AutoSize = true;
            this.lbCEP.Location = new System.Drawing.Point(455, 135);
            this.lbCEP.Name = "lbCEP";
            this.lbCEP.Size = new System.Drawing.Size(38, 13);
            this.lbCEP.TabIndex = 21;
            this.lbCEP.Text = "*CEP :";
            // 
            // lbTelefone
            // 
            this.lbTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(561, 135);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(59, 13);
            this.lbTelefone.TabIndex = 23;
            this.lbTelefone.Text = "*Telefone :";
            // 
            // gbSisEmpresa
            // 
            this.gbSisEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSisEmpresa.Controls.Add(this.ucSistemasCons);
            this.gbSisEmpresa.Controls.Add(this.dgvSistemasEmpresas);
            this.gbSisEmpresa.Controls.Add(this.btnRemove);
            this.gbSisEmpresa.Controls.Add(this.btnAdd);
            this.gbSisEmpresa.Location = new System.Drawing.Point(6, 177);
            this.gbSisEmpresa.Name = "gbSisEmpresa";
            this.gbSisEmpresa.Size = new System.Drawing.Size(657, 104);
            this.gbSisEmpresa.TabIndex = 13;
            this.gbSisEmpresa.TabStop = false;
            this.gbSisEmpresa.Text = "Sistemas da Empresa";
            // 
            // btnRemove
            // 
            this.btnRemove.Image = global::appSSI.Properties.Resources.del;
            this.btnRemove.Location = new System.Drawing.Point(133, 59);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(121, 39);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remover";
            this.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.txtRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::appSSI.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(6, 59);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 39);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNome
            // 
            this.txtNome.AceitaEspaco = true;
            this.txtNome.CampoObrigatorio = true;
            this.txtNome.Location = new System.Drawing.Point(3, 73);
            this.txtNome.MaxLength = 100;
            this.txtNome.MensagemCampoObrigatorio = "Informe o nome da empresa.";
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(257, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.AceitaEspaco = true;
            this.txtNomeFantasia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeFantasia.CampoObrigatorio = true;
            this.txtNomeFantasia.Location = new System.Drawing.Point(266, 73);
            this.txtNomeFantasia.MaxLength = 100;
            this.txtNomeFantasia.MensagemCampoObrigatorio = "Informe o nome fantasia da empresa.";
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(397, 20);
            this.txtNomeFantasia.TabIndex = 5;
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.CampoObrigatorio = true;
            this.txtCNPJ.Location = new System.Drawing.Point(3, 112);
            this.txtCNPJ.Mask = "99,999,999/9999-99";
            this.txtCNPJ.MensagemCampoObrigatorio = "Informe o CNPJ da empresa.";
            this.txtCNPJ.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(115, 20);
            this.txtCNPJ.TabIndex = 6;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.AceitaEspaco = true;
            this.txtLogradouro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogradouro.CampoObrigatorio = true;
            this.txtLogradouro.Location = new System.Drawing.Point(124, 112);
            this.txtLogradouro.MaxLength = 100;
            this.txtLogradouro.MensagemCampoObrigatorio = "Informe o logradouro da empresa.";
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(434, 20);
            this.txtLogradouro.TabIndex = 7;
            // 
            // txtNuLogradouro
            // 
            this.txtNuLogradouro.AceitaEspaco = true;
            this.txtNuLogradouro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNuLogradouro.CampoObrigatorio = true;
            this.txtNuLogradouro.Location = new System.Drawing.Point(564, 112);
            this.txtNuLogradouro.MensagemCampoObrigatorio = "Informe o número do endereço da empresa.";
            this.txtNuLogradouro.Name = "txtNuLogradouro";
            this.txtNuLogradouro.Size = new System.Drawing.Size(99, 20);
            this.txtNuLogradouro.TabIndex = 8;
            // 
            // txtBairro
            // 
            this.txtBairro.AceitaEspaco = true;
            this.txtBairro.CampoObrigatorio = false;
            this.txtBairro.Location = new System.Drawing.Point(3, 151);
            this.txtBairro.MaxLength = 30;
            this.txtBairro.MensagemCampoObrigatorio = null;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(257, 20);
            this.txtBairro.TabIndex = 9;
            // 
            // txtComplemento
            // 
            this.txtComplemento.AceitaEspaco = true;
            this.txtComplemento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComplemento.CampoObrigatorio = false;
            this.txtComplemento.Location = new System.Drawing.Point(266, 151);
            this.txtComplemento.MaxLength = 50;
            this.txtComplemento.MensagemCampoObrigatorio = null;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(186, 20);
            this.txtComplemento.TabIndex = 10;
            // 
            // txtCEP
            // 
            this.txtCEP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCEP.CampoObrigatorio = true;
            this.txtCEP.Location = new System.Drawing.Point(458, 151);
            this.txtCEP.Mask = "00000-999";
            this.txtCEP.MensagemCampoObrigatorio = "Informe o CEP da empresa.";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(100, 20);
            this.txtCEP.TabIndex = 11;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefone.CampoObrigatorio = true;
            this.txtTelefone.Location = new System.Drawing.Point(564, 151);
            this.txtTelefone.Mask = "(99) 0000-0000";
            this.txtTelefone.MensagemCampoObrigatorio = "Informe o telefone da empresa.";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(99, 20);
            this.txtTelefone.TabIndex = 12;
            // 
            // ucSistemasCons
            // 
            this.ucSistemasCons.bCadastrar = true;
            this.ucSistemasCons.bMudouCodigo = false;
            this.ucSistemasCons.CampoObrigatorio = false;
            this.ucSistemasCons.cdEmpresa = 0;
            this.ucSistemasCons.Location = new System.Drawing.Point(6, 16);
            this.ucSistemasCons.MensagemCampoObrigatorio = null;
            this.ucSistemasCons.Name = "ucSistemasCons";
            this.ucSistemasCons.Rotulo = "Sistema :";
            this.ucSistemasCons.Size = new System.Drawing.Size(248, 36);
            this.ucSistemasCons.TabIndex = 0;
            this.ucSistemasCons.TelaConsulta = "appSSI.frmConsSistemas";
            // 
            // frmCadEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.bImprimeRelCompleto = false;
            this.bImprimeRelSimples = false;
            this.ClientSize = new System.Drawing.Size(684, 367);
            this.HelpButton = false;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(700, 300);
            this.Name = "frmCadEmpresas";
            this.Text = "Cadastro de Empresas";
            this.TpCorrente = this.tpFormulario;
            this.Load += new System.EventHandler(this.frmCadEmpresas_Load);
            this.pnFiltro.ResumeLayout(false);
            this.pnForm.ResumeLayout(false);
            this.pnForm.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.tcCadastro.ResumeLayout(false);
            this.tpFormulario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSistemasEmpresas)).EndInit();
            this.gbSisEmpresa.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbNomeFantasia;
        private System.Windows.Forms.Label lbCNPJ;
        private System.Windows.Forms.Label lbLogradouro;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.Label lbCEP;
        private System.Windows.Forms.Label lbComplemento;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.GroupBox gbSisEmpresa;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdSistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmSistema;
        private System.Windows.Forms.DataGridView dgvSistemasEmpresas;
        private KuraFrameWork.Componentes_Visuais.ucTextBox txtNome;
        private KuraFrameWork.Componentes_Visuais.ucTextBoxMaskCNPJ txtCNPJ;
        private KuraFrameWork.Componentes_Visuais.ucTextBox txtNomeFantasia;
        private KuraFrameWork.Componentes_Visuais.ucTextBox txtLogradouro;
        private KuraFrameWork.Componentes_Visuais.ucTextBoxNumero txtNuLogradouro;
        private KuraFrameWork.Componentes_Visuais.ucTextBox txtComplemento;
        private KuraFrameWork.Componentes_Visuais.ucTextBox txtBairro;
        private KuraFrameWork.Componentes_Visuais.ucTextBoxMaskTelefone txtTelefone;
        private KuraFrameWork.Componentes_Visuais.ucTextBoxMaxCEP txtCEP;
        private ucSistemasCons ucSistemasCons;
    }
}
