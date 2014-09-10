namespace appSSI
{
    partial class frmCadUsuarios
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTpUsuario = new System.Windows.Forms.Label();
            this.gbAutenticacao = new System.Windows.Forms.GroupBox();
            this.lblCriticaSenha = new System.Windows.Forms.Label();
            this.txtConfirmacaoSenha = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.txtSenha = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.txtLogin = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.lblCriticaConfSenha = new System.Windows.Forms.Label();
            this.lblCriticaLogin = new System.Windows.Forms.Label();
            this.lblConfirmSenha = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.ckAtivo = new System.Windows.Forms.CheckBox();
            this.txtNome = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.txtCPF = new KuraFrameWork.Componentes_Visuais.ucTextBoxMaskCPF();
            this.txtEmail = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.cbTpUsuario = new KuraFrameWork.Componentes_Visuais.ucComboBox();
            this.ucEmpresasCons = new appSSI.ucEmpresasCons();
            this.gbIntegracao = new System.Windows.Forms.GroupBox();
            this.txtUsuarioTASK = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.lblUsuarioTask = new System.Windows.Forms.Label();
            this.txtProjetoTask = new KuraFrameWork.Componentes_Visuais.ucTextBox();
            this.lblProjetoTask = new System.Windows.Forms.Label();
            this.pnFiltro.SuspendLayout();
            this.pnForm.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.tcCadastro.SuspendLayout();
            this.tpFormulario.SuspendLayout();
            this.gbAutenticacao.SuspendLayout();
            this.gbIntegracao.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnForm
            // 
            this.pnForm.Controls.Add(this.gbIntegracao);
            this.pnForm.Controls.Add(this.ucEmpresasCons);
            this.pnForm.Controls.Add(this.cbTpUsuario);
            this.pnForm.Controls.Add(this.txtEmail);
            this.pnForm.Controls.Add(this.txtCPF);
            this.pnForm.Controls.Add(this.txtNome);
            this.pnForm.Controls.Add(this.ckAtivo);
            this.pnForm.Controls.Add(this.gbAutenticacao);
            this.pnForm.Controls.Add(this.lblTpUsuario);
            this.pnForm.Controls.Add(this.lblEmail);
            this.pnForm.Controls.Add(this.lblCPF);
            this.pnForm.Controls.Add(this.txtCodigo);
            this.pnForm.Controls.Add(this.lblNome);
            this.pnForm.Controls.Add(this.lblCodigo);
            this.pnForm.Size = new System.Drawing.Size(670, 297);
            this.pnForm.TabIndex = 0;
            this.pnForm.Controls.SetChildIndex(this.lblCodigo, 0);
            this.pnForm.Controls.SetChildIndex(this.lblNome, 0);
            this.pnForm.Controls.SetChildIndex(this.txtCodigo, 0);
            this.pnForm.Controls.SetChildIndex(this.lblCPF, 0);
            this.pnForm.Controls.SetChildIndex(this.lblEmail, 0);
            this.pnForm.Controls.SetChildIndex(this.lblTpUsuario, 0);
            this.pnForm.Controls.SetChildIndex(this.gbAutenticacao, 0);
            this.pnForm.Controls.SetChildIndex(this.ckAtivo, 0);
            this.pnForm.Controls.SetChildIndex(this.txtNome, 0);
            this.pnForm.Controls.SetChildIndex(this.txtCPF, 0);
            this.pnForm.Controls.SetChildIndex(this.txtEmail, 0);
            this.pnForm.Controls.SetChildIndex(this.cbTpUsuario, 0);
            this.pnForm.Controls.SetChildIndex(this.btnLast, 0);
            this.pnForm.Controls.SetChildIndex(this.btnPrevious, 0);
            this.pnForm.Controls.SetChildIndex(this.btnNext, 0);
            this.pnForm.Controls.SetChildIndex(this.btnFirst, 0);
            this.pnForm.Controls.SetChildIndex(this.ucEmpresasCons, 0);
            this.pnForm.Controls.SetChildIndex(this.gbIntegracao, 0);
            // 
            // tcCadastro
            // 
            this.tcCadastro.Size = new System.Drawing.Size(684, 329);
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
            // tpFormulario
            // 
            this.tpFormulario.Size = new System.Drawing.Size(676, 303);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(0, 18);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 13);
            this.lblCodigo.TabIndex = 12;
            this.lblCodigo.Text = "Código :";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(0, 57);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 13);
            this.lblNome.TabIndex = 14;
            this.lblNome.Text = "*Nome :";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(3, 34);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 13;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(0, 96);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(37, 13);
            this.lblCPF.TabIndex = 15;
            this.lblCPF.Text = "*CPF :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(106, 96);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 13);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "E-Mail :";
            // 
            // lblTpUsuario
            // 
            this.lblTpUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTpUsuario.AutoSize = true;
            this.lblTpUsuario.Location = new System.Drawing.Point(440, 96);
            this.lblTpUsuario.Name = "lblTpUsuario";
            this.lblTpUsuario.Size = new System.Drawing.Size(89, 13);
            this.lblTpUsuario.TabIndex = 17;
            this.lblTpUsuario.Text = "*Tipo do Usuário:";
            // 
            // gbAutenticacao
            // 
            this.gbAutenticacao.Controls.Add(this.lblCriticaSenha);
            this.gbAutenticacao.Controls.Add(this.txtConfirmacaoSenha);
            this.gbAutenticacao.Controls.Add(this.txtSenha);
            this.gbAutenticacao.Controls.Add(this.txtLogin);
            this.gbAutenticacao.Controls.Add(this.lblCriticaConfSenha);
            this.gbAutenticacao.Controls.Add(this.lblCriticaLogin);
            this.gbAutenticacao.Controls.Add(this.lblConfirmSenha);
            this.gbAutenticacao.Controls.Add(this.lblSenha);
            this.gbAutenticacao.Controls.Add(this.lblLogin);
            this.gbAutenticacao.Location = new System.Drawing.Point(6, 138);
            this.gbAutenticacao.Name = "gbAutenticacao";
            this.gbAutenticacao.Size = new System.Drawing.Size(352, 152);
            this.gbAutenticacao.TabIndex = 9;
            this.gbAutenticacao.TabStop = false;
            this.gbAutenticacao.Text = "Autenticação";
            // 
            // lblCriticaSenha
            // 
            this.lblCriticaSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCriticaSenha.AutoSize = true;
            this.lblCriticaSenha.Location = new System.Drawing.Point(159, 75);
            this.lblCriticaSenha.Name = "lblCriticaSenha";
            this.lblCriticaSenha.Size = new System.Drawing.Size(11, 13);
            this.lblCriticaSenha.TabIndex = 7;
            this.lblCriticaSenha.Text = "*";
            // 
            // txtConfirmacaoSenha
            // 
            this.txtConfirmacaoSenha.AceitaEspaco = false;
            this.txtConfirmacaoSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirmacaoSenha.CampoObrigatorio = true;
            this.txtConfirmacaoSenha.Location = new System.Drawing.Point(6, 111);
            this.txtConfirmacaoSenha.MaxLength = 20;
            this.txtConfirmacaoSenha.MensagemCampoObrigatorio = "Confirme a senha.";
            this.txtConfirmacaoSenha.Name = "txtConfirmacaoSenha";
            this.txtConfirmacaoSenha.PasswordChar = '*';
            this.txtConfirmacaoSenha.Size = new System.Drawing.Size(147, 20);
            this.txtConfirmacaoSenha.TabIndex = 2;
            this.txtConfirmacaoSenha.Leave += new System.EventHandler(this.txtConfirmacaoSenha_Leave);
            // 
            // txtSenha
            // 
            this.txtSenha.AceitaEspaco = false;
            this.txtSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenha.CampoObrigatorio = true;
            this.txtSenha.Location = new System.Drawing.Point(6, 72);
            this.txtSenha.MaxLength = 20;
            this.txtSenha.MensagemCampoObrigatorio = "Informe a senha do usuário.";
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(147, 20);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // txtLogin
            // 
            this.txtLogin.AceitaEspaco = false;
            this.txtLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogin.CampoObrigatorio = true;
            this.txtLogin.Location = new System.Drawing.Point(6, 32);
            this.txtLogin.MaxLength = 15;
            this.txtLogin.MensagemCampoObrigatorio = "Informe o login do usuário.";
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(147, 20);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.Leave += new System.EventHandler(this.txtLogin_Leave);
            // 
            // lblCriticaConfSenha
            // 
            this.lblCriticaConfSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCriticaConfSenha.AutoSize = true;
            this.lblCriticaConfSenha.Location = new System.Drawing.Point(159, 114);
            this.lblCriticaConfSenha.Name = "lblCriticaConfSenha";
            this.lblCriticaConfSenha.Size = new System.Drawing.Size(11, 13);
            this.lblCriticaConfSenha.TabIndex = 8;
            this.lblCriticaConfSenha.Text = "*";
            // 
            // lblCriticaLogin
            // 
            this.lblCriticaLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCriticaLogin.AutoSize = true;
            this.lblCriticaLogin.Location = new System.Drawing.Point(159, 35);
            this.lblCriticaLogin.Name = "lblCriticaLogin";
            this.lblCriticaLogin.Size = new System.Drawing.Size(11, 13);
            this.lblCriticaLogin.TabIndex = 6;
            this.lblCriticaLogin.Text = "*";
            // 
            // lblConfirmSenha
            // 
            this.lblConfirmSenha.AutoSize = true;
            this.lblConfirmSenha.Location = new System.Drawing.Point(3, 95);
            this.lblConfirmSenha.Name = "lblConfirmSenha";
            this.lblConfirmSenha.Size = new System.Drawing.Size(95, 13);
            this.lblConfirmSenha.TabIndex = 5;
            this.lblConfirmSenha.Text = "*Confirmar Senha :";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(3, 55);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(48, 13);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "*Senha :";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(3, 16);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(43, 13);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Text = "*Login :";
            // 
            // ckAtivo
            // 
            this.ckAtivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckAtivo.AutoSize = true;
            this.ckAtivo.Checked = true;
            this.ckAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckAtivo.Location = new System.Drawing.Point(613, 50);
            this.ckAtivo.Name = "ckAtivo";
            this.ckAtivo.Size = new System.Drawing.Size(50, 17);
            this.ckAtivo.TabIndex = 4;
            this.ckAtivo.Text = "Ativo";
            this.ckAtivo.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.AceitaEspaco = true;
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.CampoObrigatorio = true;
            this.txtNome.Location = new System.Drawing.Point(3, 73);
            this.txtNome.MensagemCampoObrigatorio = "Informe o nome do usuário.";
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(660, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtCPF
            // 
            this.txtCPF.CampoObrigatorio = true;
            this.txtCPF.Location = new System.Drawing.Point(3, 111);
            this.txtCPF.Mask = "999,999,999-AA";
            this.txtCPF.MensagemCampoObrigatorio = "Informe o CPF do usuário.";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 20);
            this.txtCPF.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.AceitaEspaco = false;
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.CampoObrigatorio = false;
            this.txtEmail.Location = new System.Drawing.Point(109, 111);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.MensagemCampoObrigatorio = null;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(328, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // cbTpUsuario
            // 
            this.cbTpUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTpUsuario.CampoObrigatorio = true;
            this.cbTpUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTpUsuario.FormattingEnabled = true;
            this.cbTpUsuario.Location = new System.Drawing.Point(443, 111);
            this.cbTpUsuario.MensagemCampoObrigatorio = "Selecione um tipo para o usuário.";
            this.cbTpUsuario.Name = "cbTpUsuario";
            this.cbTpUsuario.Size = new System.Drawing.Size(220, 21);
            this.cbTpUsuario.TabIndex = 8;
            // 
            // ucEmpresasCons
            // 
            this.ucEmpresasCons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucEmpresasCons.bCadastrar = true;
            this.ucEmpresasCons.bMudouCodigo = false;
            this.ucEmpresasCons.CampoObrigatorio = true;
            this.ucEmpresasCons.Location = new System.Drawing.Point(364, 145);
            this.ucEmpresasCons.MensagemCampoObrigatorio = "Informe a empresa.";
            this.ucEmpresasCons.Name = "ucEmpresasCons";
            this.ucEmpresasCons.Rotulo = "*Empresa :";
            this.ucEmpresasCons.Size = new System.Drawing.Size(299, 36);
            this.ucEmpresasCons.TabIndex = 10;
            this.ucEmpresasCons.TelaConsulta = null;
            // 
            // gbIntegracao
            // 
            this.gbIntegracao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbIntegracao.Controls.Add(this.txtUsuarioTASK);
            this.gbIntegracao.Controls.Add(this.lblUsuarioTask);
            this.gbIntegracao.Controls.Add(this.txtProjetoTask);
            this.gbIntegracao.Controls.Add(this.lblProjetoTask);
            this.gbIntegracao.Location = new System.Drawing.Point(364, 187);
            this.gbIntegracao.Name = "gbIntegracao";
            this.gbIntegracao.Size = new System.Drawing.Size(299, 103);
            this.gbIntegracao.TabIndex = 11;
            this.gbIntegracao.TabStop = false;
            this.gbIntegracao.Text = "Dados Integração TASK";
            // 
            // txtUsuarioTASK
            // 
            this.txtUsuarioTASK.AceitaEspaco = true;
            this.txtUsuarioTASK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuarioTASK.CampoObrigatorio = true;
            this.txtUsuarioTASK.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuarioTASK.Location = new System.Drawing.Point(10, 77);
            this.txtUsuarioTASK.MensagemCampoObrigatorio = "Informe o usuário para cadastro de OS no TASK.";
            this.txtUsuarioTASK.Name = "txtUsuarioTASK";
            this.txtUsuarioTASK.Size = new System.Drawing.Size(283, 20);
            this.txtUsuarioTASK.TabIndex = 1;
            // 
            // lblUsuarioTask
            // 
            this.lblUsuarioTask.AutoSize = true;
            this.lblUsuarioTask.Location = new System.Drawing.Point(7, 61);
            this.lblUsuarioTask.Name = "lblUsuarioTask";
            this.lblUsuarioTask.Size = new System.Drawing.Size(84, 13);
            this.lblUsuarioTask.TabIndex = 3;
            this.lblUsuarioTask.Text = "*Usuário TASK :";
            // 
            // txtProjetoTask
            // 
            this.txtProjetoTask.AceitaEspaco = true;
            this.txtProjetoTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProjetoTask.CampoObrigatorio = true;
            this.txtProjetoTask.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProjetoTask.Location = new System.Drawing.Point(10, 38);
            this.txtProjetoTask.MensagemCampoObrigatorio = "Informe o projeto para cadastro de OS no TASK.";
            this.txtProjetoTask.Name = "txtProjetoTask";
            this.txtProjetoTask.Size = new System.Drawing.Size(283, 20);
            this.txtProjetoTask.TabIndex = 0;
            // 
            // lblProjetoTask
            // 
            this.lblProjetoTask.AutoSize = true;
            this.lblProjetoTask.Location = new System.Drawing.Point(7, 22);
            this.lblProjetoTask.Name = "lblProjetoTask";
            this.lblProjetoTask.Size = new System.Drawing.Size(81, 13);
            this.lblProjetoTask.TabIndex = 2;
            this.lblProjetoTask.Text = "*Projeto TASK :";
            // 
            // frmCadUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(684, 376);
            this.Name = "frmCadUsuarios";
            this.Text = "Cadastro de Usuários";
            this.TpCorrente = this.tpFormulario;
            this.Load += new System.EventHandler(this.frmCadUsuarios_Load);
            this.pnFiltro.ResumeLayout(false);
            this.pnForm.ResumeLayout(false);
            this.pnForm.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.tcCadastro.ResumeLayout(false);
            this.tpFormulario.ResumeLayout(false);
            this.gbAutenticacao.ResumeLayout(false);
            this.gbAutenticacao.PerformLayout();
            this.gbIntegracao.ResumeLayout(false);
            this.gbIntegracao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTpUsuario;
        private System.Windows.Forms.GroupBox gbAutenticacao;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblConfirmSenha;
        private System.Windows.Forms.Label lblCriticaConfSenha;
        private System.Windows.Forms.Label lblCriticaLogin;
        private System.Windows.Forms.CheckBox ckAtivo;
        private KuraFrameWork.Componentes_Visuais.ucTextBox txtEmail;
        private KuraFrameWork.Componentes_Visuais.ucTextBoxMaskCPF txtCPF;
        private KuraFrameWork.Componentes_Visuais.ucTextBox txtNome;
        private KuraFrameWork.Componentes_Visuais.ucTextBox txtSenha;
        private KuraFrameWork.Componentes_Visuais.ucTextBox txtLogin;
        private KuraFrameWork.Componentes_Visuais.ucTextBox txtConfirmacaoSenha;
        private KuraFrameWork.Componentes_Visuais.ucComboBox cbTpUsuario;
        private System.Windows.Forms.Label lblCriticaSenha;
        private ucEmpresasCons ucEmpresasCons;
        private System.Windows.Forms.GroupBox gbIntegracao;
        private KuraFrameWork.Componentes_Visuais.ucTextBox txtProjetoTask;
        private System.Windows.Forms.Label lblProjetoTask;
        private KuraFrameWork.Componentes_Visuais.ucTextBox txtUsuarioTASK;
        private System.Windows.Forms.Label lblUsuarioTask;
    }
}
