using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using appRelatorios;

namespace appSSI
{
    public partial class frmCadUsuarios : KuraFrameWork.Formularios.ucCadastroBasicoNormal
    {
        conUsuarios objConUsuarios;
        caUsuarios objCaUsuarios;

        conEmpresas objConEmpresas;
        caEmpresas objCaEmpresas;

        DataTable dtTpUsuarios;

        private bool bLoginValido = true;
        private bool bSenhaValida = true;
        private bool bConfSenha = true;

        public frmCadUsuarios()
        {
            InitializeComponent();
            this.ControleFiltro(null, null);
            ControleCampos(pnForm.Controls, false);

            objConUsuarios = new conUsuarios();
            objCaUsuarios = new caUsuarios();

            objConEmpresas = new conEmpresas();
            objCaEmpresas = new caEmpresas();
        }

        private void frmCadUsuarios_Load(object sender, EventArgs e)
        {
            MontaGridViewDinamico();
            PreencheDadosGridView();
            PreencheDadosGridViewFiltro();
            CarregarTiposDeUsuario();
            objConUsuarios.dtDados = dtDados;
        }

        public override void MontaGridViewDinamico()
        {
            objCaUsuarios.RetornarFields(out strFields, out strVisivel, out strNome);
            base.MontaGridViewDinamico();
        }

        private void PreencheDadosGridView()
        {
            objConUsuarios.objCoUsuarios.LimparAtributos();
            objConUsuarios.Select();
            dgvDados.DataSource = dtDados = objConUsuarios.dtDados;
        }

        private void CarregaObjeto()
        {
            int cdUsuario;

            objConUsuarios.objCoUsuarios.LimparAtributos();

            int.TryParse(txtCodigo.Text, out cdUsuario);
            objConUsuarios.objCoUsuarios.cdUsuario = cdUsuario;
            objConUsuarios.objCoUsuarios.nmUsuario = txtNome.Text;
            objConUsuarios.objCoUsuarios.nuCPF = Convert.ToInt64(txtCPF.PegaTexto());
            objConUsuarios.objCoUsuarios.deEmail = txtEmail.Text;
            objConUsuarios.objCoUsuarios.flTpUsuario = Convert.ToChar(cbTpUsuario.SelectedValue.ToString());
            if (ckAtivo.Checked)
                objConUsuarios.objCoUsuarios.flAtivo = 'S';
            else
                objConUsuarios.objCoUsuarios.flAtivo = 'N';
            objConUsuarios.objCoUsuarios.deLogin = txtLogin.Text;
            objConUsuarios.objCoUsuarios.deSenha = txtSenha.Text;
            objConUsuarios.objCoUsuarios.taskProjeto = txtProjetoTask.Text;
            objConUsuarios.objCoUsuarios.taskUsuario = txtUsuarioTASK.Text;
            objConUsuarios.objCoUsuarios.cdEmpresa = Convert.ToInt32(ucEmpresasCons.txtCodigo.Text);
        }

        private void LimparCriticas()
        {
            lblCriticaLogin.Text = "*";
            lblCriticaLogin.ForeColor = Color.Black;
            lblCriticaSenha.Text = "*";
            lblCriticaSenha.ForeColor = Color.Black;
            lblCriticaConfSenha.Text = "*";
            lblCriticaConfSenha.ForeColor = Color.Black;
        }

        public override void CarregaDados(DataRow drUsuario)
        {
            base.CarregaDados(drUsuario);

            ckAtivo.Checked = false;
            if (Convert.ToChar(drUsuario[objCaUsuarios.flAtivo].ToString()) == 'S')
                ckAtivo.Checked = true;

            txtCodigo.Text = drUsuario[objCaUsuarios.cdUsuario].ToString();
            txtNome.Text = drUsuario[objCaUsuarios.nmUsuario].ToString();
            txtCPF.Text = drUsuario[objCaUsuarios.nuCPF].ToString();
            txtEmail.Text = drUsuario[objCaUsuarios.deEmail].ToString();
            cbTpUsuario.SelectedValue = Convert.ToChar(drUsuario[objCaUsuarios.flTpUsuario].ToString());
            ucEmpresasCons.txtCodigo.Text = drUsuario[objCaUsuarios.cdEmpresa].ToString();
            txtLogin.Text = drUsuario[objCaUsuarios.deLogin].ToString();
            txtSenha.Text = txtConfirmacaoSenha.Text = drUsuario[objCaUsuarios.deSenha].ToString();
            txtProjetoTask.Text = drUsuario[objCaUsuarios.taskProjeto].ToString();
            txtUsuarioTASK.Text = drUsuario[objCaUsuarios.taskUsuario].ToString();

            ucEmpresasCons.Carregar();
        }

        public override void tsbNovo_Click(object sender, EventArgs e)
        {
            base.tsbNovo_Click(sender, e);
            bLoginValido = false;
            bSenhaValida = false;
            bConfSenha = false;
        }

        public override void tsbEditar_Click(object sender, EventArgs e)
        {
            base.tsbEditar_Click(sender, e);
            bLoginValido = true;
            bSenhaValida = true;
            bConfSenha = true;
        }

        public override void tsbSalvar_Click(object sender, EventArgs e)
        {
            txtLogin_Leave(null, null);
            txtSenha_Leave(null, null);
            txtConfirmacaoSenha_Leave(null, null);

            if (bLoginValido && bSenhaValida && bConfSenha)
            {
                if (!CampoObrigatorioNaoPreenchido(pnForm.Controls))
                {
                    CarregaObjeto();

                    if (Status == csConstantes.sInserindo)
                    {
                        if (!objConUsuarios.Inserir())
                            MessageBox.Show(objConUsuarios.strMensagemErro);
                        else
                        {
                            txtCodigo.Text = objConUsuarios.objCoUsuarios.cdEmpresa.ToString();
                            base.tsbSalvar_Click(sender, e);
                            PreencheDadosGridView();
                            LimparCriticas();
                        }

                    }
                    if (Status == csConstantes.sAlterando)
                    {
                        if (!objConUsuarios.Alterar())
                            MessageBox.Show(objConUsuarios.strMensagemErro);
                        else
                        {
                            base.tsbSalvar_Click(sender, e);
                            PreencheDadosGridView();
                            LimparCriticas();
                        }
                    }
                }
            }
            else
                MessageBox.Show(csMensagens.msgPreencherCredenciais);
        }

        public override void tsbExcluir_Click(object sender, EventArgs e)
        {
            objConUsuarios.objCoUsuarios.cdUsuario = Convert.ToInt32(txtCodigo.Text);
            if (!objConUsuarios.Excluir())
                MessageBox.Show(objConUsuarios.strMensagemErro);
            else
            {
                PreencheDadosGridView();
                base.tsbExcluir_Click(sender, e);
            }
        }

        public override void tsbLimpar_Click(object sender, EventArgs e)
        {
            base.tsbLimpar_Click(sender, e);
            objConUsuarios.objCoUsuarios.LimparAtributos();
            LimparCriticas();
        }

        public override void btnConsultar_Click(object sender, EventArgs e)
        {
            objConUsuarios.objCoUsuarios.LimparAtributos();

            objConUsuarios.objCoUsuarios.strFiltro = MontarFiltroConsulta(dgvFiltro, objCaUsuarios.nmTabela);
            if (objConUsuarios.Select())
                dgvDados.DataSource = dtDados = objConUsuarios.dtDados;
            else
                MessageBox.Show(objConUsuarios.strMensagemErro);
        }

        public void CarregarTiposDeUsuario()
        {
            dtTpUsuarios = new DataTable();
            dtTpUsuarios.Columns.Add("cdTpUsuario");
            dtTpUsuarios.Columns.Add("deTpUsuario");

            DataRow dr;
            
            dr = dtTpUsuarios.NewRow();
            dr["cdTpUsuario"] = 'C';
            dr["deTpUsuario"] = "Cliente";
            dtTpUsuarios.Rows.Add(dr);
            dr = dtTpUsuarios.NewRow();
            dr["cdTpUsuario"] = 'S';
            dr["deTpUsuario"] = "Suporte";
            dtTpUsuarios.Rows.Add(dr);
            dr = dtTpUsuarios.NewRow();
            dr["cdTpUsuario"] = 'D';
            dr["deTpUsuario"] = "Desenvolvedor";
            dtTpUsuarios.Rows.Add(dr);
            dr = dtTpUsuarios.NewRow();
            dr["cdTpUsuario"] = 'G';
            dr["deTpUsuario"] = "Gestor";
            dtTpUsuarios.Rows.Add(dr);

            cbTpUsuario.ValueMember = "cdTpUsuario";
            cbTpUsuario.DisplayMember = "deTpUsuario";
            cbTpUsuario.DataSource = dtTpUsuarios;
        }

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            lblCriticaLogin.Text = "*";
            lblCriticaLogin.ForeColor = Color.Black;
            bLoginValido = true;

            if (txtLogin.Text.Length < 5)
            {
                lblCriticaLogin.Text = "Mínimo 5 caracteres.";
                lblCriticaLogin.ForeColor = Color.Red;
                txtLogin.SelectAll();
                bLoginValido = false;
            }
            else
            {
                lblCriticaLogin.Text = "Login válido.";
                lblCriticaLogin.ForeColor = Color.Green;
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            lblCriticaSenha.Text = "*";
            lblCriticaSenha.ForeColor = Color.Black;
            bSenhaValida = true;

            if (Status == 'I' || Status == 'A')
            {
                if (txtSenha.Text.Length < 5)
                {
                    lblCriticaSenha.Text = "Mínimo 5 caracteres.";
                    lblCriticaSenha.ForeColor = Color.Red;
                    txtSenha.SelectAll();
                    bSenhaValida = false;
                }
                else
                {
                    lblCriticaSenha.Text = "Senha válida.";
                    lblCriticaSenha.ForeColor = Color.Green;
                }
            }
        }

        private void txtConfirmacaoSenha_Leave(object sender, EventArgs e)
        {
            lblCriticaConfSenha.Text = "*";
            lblCriticaConfSenha.ForeColor = Color.Black;
            bConfSenha = true;

            if (!txtSenha.Text.Equals(txtConfirmacaoSenha.Text))
            {
                lblCriticaConfSenha.Text = "Confirmação não confere.";
                lblCriticaConfSenha.ForeColor = Color.Red;
                txtConfirmacaoSenha.SelectAll();
                bConfSenha = false;
            }
            else
            {
                lblCriticaConfSenha.Text = "Confirmação da senha Ok.";
                lblCriticaConfSenha.ForeColor = Color.Green;
            }
        }

        public void ImprimirRelatorio(string strNmRelatorio)
        {
            conRelatorio objConRelatorio = new conRelatorio();
            caRelatorios objCaRelatorios = new caRelatorios();

            objConRelatorio.objCoRelatorios.nmRelatorio = strNmRelatorio;

            if (!objConRelatorio.Select())
            {
                MessageBox.Show(objConRelatorio.strMensagemErro);
                return;
            }

            appRelatorios.frmGerenciadorRPT frm = new appRelatorios.frmGerenciadorRPT();
            frm.GerarRelatorio(Convert.ToInt32(objConRelatorio.dtDados.Rows[0][objCaRelatorios.cdRelatorio].ToString()), dtDados);
        }

        public override void tsmiResultadoSimples_Click(object sender, EventArgs e)
        {
            ImprimirRelatorio("crUsuarios.rpt");
            base.tsmiResultadoSimples_Click(sender, e);
        }

        public override void tsmiResultadoCompleto_Click(object sender, EventArgs e)
        {
            ImprimirRelatorio("crUsuariosC.rpt");
            base.tsmiResultadoCompleto_Click(sender, e);
        }
    }
}
