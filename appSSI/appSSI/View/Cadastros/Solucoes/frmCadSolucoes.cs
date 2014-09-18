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
    public partial class frmCadSolucoes : KuraFrameWork.Formularios.ucCadastroBasicoNormal
    {
        private caSolucoes objCaSolucoes;
        private conSolucoes objConSolucoes;

        public frmCadSolucoes()
        {
            InitializeComponent();
            this.ControleFiltro(null, null);
            ControleCampos(pnForm.Controls, false);

            objCaSolucoes = new caSolucoes();
            objConSolucoes = new conSolucoes();
        }

        private void frmCadSolucoes_Load(object sender, EventArgs e)
        {
            MontaGridViewDinamico();
            PreencheDadosGridView();
            PreencheDadosGridViewFiltro();
            objConSolucoes.dtDados = dtDados;
        }

        public override void MontaGridViewDinamico()
        {
            objCaSolucoes.RetornarFields(out strFields, out strVisivel, out strNome);
            base.MontaGridViewDinamico();
        }

        private void PreencheDadosGridView()
        {
            objConSolucoes.objCoSolucoes.LimparAtributos();
            objConSolucoes.Select();
            dgvDados.DataSource = dtDados = objConSolucoes.dtDados;
        }

        private void CarregaObjeto()
        {
            int cdSolucao;

            objConSolucoes.objCoSolucoes.LimparAtributos();

            int.TryParse(txtCodigo.Text, out cdSolucao);
            objConSolucoes.objCoSolucoes.cdSolucao = cdSolucao;
            objConSolucoes.objCoSolucoes.deSolucao = txtDescricao.Text;

            if (rbCliente.Checked)
                objConSolucoes.objCoSolucoes.flNivel = 'C';
            if (rbSuporte.Checked)
                objConSolucoes.objCoSolucoes.flNivel = 'S';
            if (rbDesenvolvedor.Checked)
                objConSolucoes.objCoSolucoes.flNivel = 'D';

            objConSolucoes.objCoSolucoes.dtImgSolucoes = ucCadImagens.dtImagens;
            objConSolucoes.objCoSolucoes.dtSolucoesDefeitos = ucCadSolucoesDefeitos.dtDados;
        }

        public override void CarregaDados(DataRow drSolucao)
        {
            base.CarregaDados(drSolucao);

            txtCodigo.Text = drSolucao[objCaSolucoes.cdSolucao].ToString();
            txtDescricao.Text = drSolucao[objCaSolucoes.deSolucao].ToString();

            if (Convert.ToChar(drSolucao[objCaSolucoes.flNivel].ToString()) == 'C')
                rbCliente.Checked = true;
            if (Convert.ToChar(drSolucao[objCaSolucoes.flNivel].ToString()) == 'S')
                rbSuporte.Checked = true;
            if (Convert.ToChar(drSolucao[objCaSolucoes.flNivel].ToString()) == 'D')
                rbDesenvolvedor.Checked = true;

            ucCadImagens.cdSolucao = Convert.ToInt32(drSolucao[objCaSolucoes.cdSolucao].ToString());
            ucCadImagens.btnLimparLista_Click(null, null);
            ucCadImagens.CarregarImagens();

            ucCadSolucoesDefeitos.LimparSolucoesDefeitos();
            ucCadSolucoesDefeitos.CdSolucao = Convert.ToInt32(drSolucao[objCaSolucoes.cdSolucao].ToString());
            ucCadSolucoesDefeitos.CarregarSolcoesDefeitos();

            CarregaObjeto();
        }

        public override void tsbNovo_Click(object sender, EventArgs e)
        {
            ucCadImagens.btnLimparLista_Click(null, null);
            ucCadSolucoesDefeitos.LimparSolucoesDefeitos();
            rbCliente.Checked = true;
            base.tsbNovo_Click(sender, e);
        }

        public override void tsbSalvar_Click(object sender, EventArgs e)
        {
            if (!CampoObrigatorioNaoPreenchido(pnForm.Controls))
            {
                CarregaObjeto();
                ucCadSolucoesDefeitos.Salvar();

                if (Status == csConstantes.sInserindo)
                {
                    if (!objConSolucoes.Inserir())
                        MessageBox.Show(objConSolucoes.strMensagemErro);
                    else
                    {
                        txtCodigo.Text = objConSolucoes.objCoSolucoes.cdSolucao.ToString();
                        base.tsbSalvar_Click(sender, e);
                        PreencheDadosGridView();
                    }

                }
                if (Status == csConstantes.sAlterando)
                {
                    if (!objConSolucoes.Alterar())
                        MessageBox.Show(objConSolucoes.strMensagemErro);
                    else
                    {
                        base.tsbSalvar_Click(sender, e);
                        PreencheDadosGridView();
                    }
                }
            }

        }

        public override void tsbExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir o registro?", "",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.No)
                return;

            objConSolucoes.objCoSolucoes.cdSolucao = Convert.ToInt32(txtCodigo.Text);
            if (!objConSolucoes.Excluir())
                MessageBox.Show(objConSolucoes.strMensagemErro);
            else
            {
                PreencheDadosGridView();
                base.tsbExcluir_Click(sender, e);
            }
        }

        public override void tsbLimpar_Click(object sender, EventArgs e)
        {
            base.tsbLimpar_Click(sender, e);
            objConSolucoes.objCoSolucoes.LimparAtributos();
        }

        public override void btnConsultar_Click(object sender, EventArgs e)
        {
            objConSolucoes.objCoSolucoes.LimparAtributos();

            objConSolucoes.objCoSolucoes.strFiltro = MontarFiltroConsulta(dgvFiltro, objCaSolucoes.nmTabela);
            if (objConSolucoes.Select())
                dgvDados.DataSource = dtDados = objConSolucoes.dtDados;
            else
                MessageBox.Show(objConSolucoes.strMensagemErro);
        }

        public override void LimparCampos(Control.ControlCollection Controles)
        {
            base.LimparCampos(Controles);

            foreach (var control in Controles)
            {
                if (control is ucCadSolucoesDefeitos)
                {
                    ((ucCadSolucoesDefeitos)control).LimparSolucoesDefeitos();
                }
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

        public override void tsbImprimir_ButtonClick(object sender, EventArgs e)
        {
            ImprimirRelatorio("crSolucoes.rpt");
            base.tsbImprimir_ButtonClick(sender, e);
        }
    }
}
