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
    public partial class frmCadTelas : KuraFrameWork.Formularios.ucCadastroBasicoNormal
    {
        private caTelas objCaTelas;
        private conTelas objConTelas;

        private caAcoes objCaAcoes;
        private conAcoes objConAcoes;
        private DataTable dtAcoes;

        private caTelasAcoes objCaTelasAcoes;
        private conTelasAcoes objConTelasAcoes;
        private DataTable dtTelasAcoes;

        public frmCadTelas()
        {
            InitializeComponent();
            this.ControleFiltro(null, null);
            ControleCampos(pnForm.Controls, false);

            dtTelasAcoes = new DataTable();
            
            objCaTelas = new caTelas();
            objConTelas = new conTelas();

            objCaAcoes = new caAcoes();
            objConAcoes = new conAcoes();
            
            objCaTelasAcoes = new caTelasAcoes();
            objConTelasAcoes = new conTelasAcoes();
        }

        private void frmCadTelas_Load(object sender, EventArgs e)
        {
            MontaGridViewDinamico();
            PreencheDadosGridView();
            PreencheDadosGridViewFiltro();
            objConTelas.dtDados = dtDados;
            dtAcoes = objConAcoes.objCoAcoes.RetornaEstruturaDT();
        }

        public override void MontaGridViewDinamico()
        {
            objCaTelas.RetornarFields(out strFields, out strVisivel, out strNome);
            base.MontaGridViewDinamico();
        }

        private void PreencheDadosGridView()
        {
            objConTelas.objCoTelas.LimparAtributos();
            objConTelas.Select();
            dgvDados.DataSource = dtDados = objConTelas.dtDados;
        }

        public void CarregarTelasAcoes()
        {
            DataTable dtAux;
            DataRow dr;

            int cdTela;
            int.TryParse(txtCodigo.Text, out cdTela);
            objConTelasAcoes.objCoTelasAcoes.LimparAtributos();
            objConTelasAcoes.objCoTelasAcoes.cdTela= cdTela;
            objConTelasAcoes.Select();
            dtTelasAcoes = objConTelasAcoes.dtDados;

            dtAcoes.Rows.Clear();

            for (int i = 0; i < dtTelasAcoes.Rows.Count; i++)
            {
                objConAcoes.objCoAcoes.LimparAtributos();
                objConAcoes.objCoAcoes.cdAcao = Convert.ToInt32(dtTelasAcoes.Rows[i][objCaTelasAcoes.cdAcao].ToString());
                objConAcoes.Select();

                dtAux = objConAcoes.dtDados;

                dr = dtAcoes.NewRow();
                dr[objCaAcoes.cdAcao] = Convert.ToInt32(dtAux.Rows[0][objCaAcoes.cdAcao].ToString());
                dr[objCaAcoes.deAcao] = dtAux.Rows[0][objCaAcoes.deAcao].ToString();

                dtAcoes.Rows.Add(dr);
            }

            dgvAcao.DataSource = null;
            dgvAcao.AutoGenerateColumns = false;
            dgvAcao.DataSource = dtAcoes;
            dgvAcao.Columns[0].Visible = false;
        }

        private void CarregaObjeto()
        {
            int cdTela;

            objConTelas.objCoTelas.LimparAtributos();

            int.TryParse(txtCodigo.Text, out cdTela);
            objConTelas.objCoTelas.cdTela = cdTela;
            objConTelas.objCoTelas.cdModulo = Convert.ToInt32(ucModulosCons.txtCodigo.Text);
            objConTelas.objCoTelas.nmTela = txtDescicao.Text;

            objConTelas.objCoTelas.dtTelasAcoes = dtAcoes;
        }

        public override void CarregaDados(DataRow drEmpresa)
        {
            base.CarregaDados(drEmpresa);

            txtCodigo.Text = drEmpresa[objCaTelas.cdTela].ToString();
            ucModulosCons.txtCodigo.Text = drEmpresa[objCaTelas.cdModulo].ToString();
            txtDescicao.Text = drEmpresa[objCaTelas.nmTela].ToString();

            ucModulosCons.Carregar();
            CarregarTelasAcoes();
            CarregaObjeto();
        }

        public override void tsbNovo_Click(object sender, EventArgs e)
        {
            dtTelasAcoes.Rows.Clear();
            base.tsbNovo_Click(sender, e);
        }

        public override void tsbSalvar_Click(object sender, EventArgs e)
        {
            if (!CampoObrigatorioNaoPreenchido(pnForm.Controls))
            {
                CarregaObjeto();

                if (Status == csConstantes.sInserindo)
                {
                    if (!objConTelas.Inserir())
                        MessageBox.Show(objConTelas.strMensagemErro);
                    else
                    {
                        txtCodigo.Text = objConTelas.objCoTelas.cdTela.ToString();
                        base.tsbSalvar_Click(sender, e);
                        PreencheDadosGridView();
                    }
                
                }
                if (Status == csConstantes.sAlterando)
                {
                    if (!objConTelas.Alterar())
                        MessageBox.Show(objConTelas.strMensagemErro);
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
            objConTelas.objCoTelas.cdTela = Convert.ToInt32(txtCodigo.Text);
            if (!objConTelas.Excluir())
                MessageBox.Show(objConTelas.strMensagemErro);
            else
            {
                PreencheDadosGridView();
                base.tsbExcluir_Click(sender, e);
            }
        }

        public override void tsbLimpar_Click(object sender, EventArgs e)
        {
            base.tsbLimpar_Click(sender, e);
            objConTelas.objCoTelas.LimparAtributos();
        }

        public override void btnConsultar_Click(object sender, EventArgs e)
        {
            objConTelas.objCoTelas.LimparAtributos();

            objConTelas.objCoTelas.strFiltro = MontarFiltroConsulta(dgvFiltro, objCaTelas.nmTabela);
            if (objConTelas.Select())
                dgvDados.DataSource = dtDados = objConTelas.dtDados;
            else
                MessageBox.Show(objConTelas.strMensagemErro);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ucAcoesCons.txtCodigo.Text != "" && !VerificarSeSistemaJahExiste(Convert.ToInt32(ucAcoesCons.txtCodigo.Text)))
            {
                DataRow drAcao = dtAcoes.NewRow();

                drAcao[objCaAcoes.cdAcao] = ucAcoesCons.txtCodigo.Text;
                drAcao[objCaAcoes.deAcao] = ucAcoesCons.txtDescricao.Text;

                dtAcoes.Rows.Add(drAcao);

                ucAcoesCons.LimparCampos();

                dgvAcao.DataSource = dtAcoes;
            }
            else
                MessageBox.Show(csMensagens.msgTelaAcaoJahAssociado);
        }

        private bool VerificarSeSistemaJahExiste(int cdAcao)
        {
            for (int i = 0; i < dtAcoes.Rows.Count; i++)
            {
                if (Convert.ToInt32(dtAcoes.Rows[i][objCaAcoes.cdAcao].ToString()) == cdAcao)
                    return true;
            }
            return false;
        }

        private void txtRemove_Click(object sender, EventArgs e)
        {
            if (dgvAcao.CurrentRow != null && dgvAcao.CurrentRow.Index >= 0)
            {
                for (int i = 0; i < dtAcoes.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dtAcoes.Rows[i][objCaAcoes.cdAcao].ToString()) ==
                        Convert.ToInt32(dgvAcao.CurrentRow.Cells[objCaAcoes.cdAcao].Value.ToString()))
                        dtAcoes.Rows.RemoveAt(i);
                }
            }
            else
                MessageBox.Show(csMensagens.msgTelaAcaoSelecioneParaRemover);
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
            ImprimirRelatorio("crTelas.rpt");
            base.tsmiResultadoSimples_Click(sender, e);
        }

        public override void tsmiResultadoCompleto_Click(object sender, EventArgs e)
        {
            ImprimirRelatorio("crTelasC.rpt");
            base.tsmiResultadoCompleto_Click(sender, e);
        }
    }
}
