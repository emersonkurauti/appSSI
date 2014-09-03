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
    public partial class frmCadAcoes : KuraFrameWork.Formularios.ucCadastroBasicoNormal
    {
        private caAcoes objCaAcoes;
        private conAcoes objConAcoes;

        public frmCadAcoes()
        {
            InitializeComponent();
            this.ControleFiltro(null, null);
            ControleCampos(pnForm.Controls, false);

            objCaAcoes = new caAcoes();
            objConAcoes = new conAcoes();
        }

        private void frmCadAcoes_Load(object sender, EventArgs e)
        {
            MontaGridViewDinamico();
            PreencheDadosGridView();
            PreencheDadosGridViewFiltro();
            objConAcoes.dtDados = dtDados;
        }

        public override void MontaGridViewDinamico()
        {
            objCaAcoes.RetornarFields(out strFields, out strVisivel, out strNome);
            base.MontaGridViewDinamico();
        }

        private void PreencheDadosGridView()
        {
            objConAcoes.objCoAcoes.LimparAtributos();
            objConAcoes.Select();
            dgvDados.DataSource = dtDados = objConAcoes.dtDados;
        }

        private void CarregaObjeto()
        {
            int cdAcao;

            objConAcoes.objCoAcoes.LimparAtributos();

            int.TryParse(txtCodigo.Text, out cdAcao);
            objConAcoes.objCoAcoes.cdAcao = cdAcao;
            objConAcoes.objCoAcoes.deAcao = txtDescricao.Text;
        }

        public override void CarregaDados(DataRow drAcao)
        {
            base.CarregaDados(drAcao);

            txtCodigo.Text = drAcao[objCaAcoes.cdAcao].ToString();
            txtDescricao.Text = drAcao[objCaAcoes.deAcao].ToString();

            CarregaObjeto();
        }

        public override void tsbSalvar_Click(object sender, EventArgs e)
        {
            if (!CampoObrigatorioNaoPreenchido(pnForm.Controls))
            {
                CarregaObjeto();

                if (Status == csConstantes.sInserindo)
                {
                    if (!objConAcoes.Inserir())
                        MessageBox.Show(objConAcoes.strMensagemErro);
                    else
                    {
                        txtCodigo.Text = objConAcoes.objCoAcoes.cdAcao.ToString();
                        base.tsbSalvar_Click(sender, e);
                        PreencheDadosGridView();
                    }
                
                }
                if (Status == csConstantes.sAlterando)
                {
                    if (!objConAcoes.Alterar())
                        MessageBox.Show(objConAcoes.strMensagemErro);
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
            objConAcoes.objCoAcoes.cdAcao= Convert.ToInt32(txtCodigo.Text);
            if (!objConAcoes.Excluir())
                MessageBox.Show(objConAcoes.strMensagemErro);
            else
            {
                PreencheDadosGridView();
                base.tsbExcluir_Click(sender, e);
            }
        }

        public override void tsbLimpar_Click(object sender, EventArgs e)
        {
            base.tsbLimpar_Click(sender, e);
            objConAcoes.objCoAcoes.LimparAtributos();
        }

        public override void btnConsultar_Click(object sender, EventArgs e)
        {
            objConAcoes.objCoAcoes.LimparAtributos();

            objConAcoes.objCoAcoes.strFiltro = MontarFiltroConsulta(dgvFiltro, objCaAcoes.nmTabela);
            if (objConAcoes.Select())
                dgvDados.DataSource = dtDados = objConAcoes.dtDados;
            else
                MessageBox.Show(objConAcoes.strMensagemErro);
        }

        public override void tsbImprimir_ButtonClick(object sender, EventArgs e)
        {
            conRelatorio objConRelatorio = new conRelatorio();
            caRelatorios objCaRelatorios = new caRelatorios();

            objConRelatorio.objCoRelatorios.nmRelatorio = "crAcoes.rpt";

            if (!objConRelatorio.Select())
            {
                MessageBox.Show(objConRelatorio.strMensagemErro);
                return;
            }

            base.tsbImprimir_ButtonClick(sender, e);
            appRelatorios.frmGerenciadorRPT frm = new appRelatorios.frmGerenciadorRPT();
            frm.GerarRelatorio(Convert.ToInt32(objConRelatorio.dtDados.Rows[0][objCaRelatorios.cdRelatorio].ToString()), dtDados);
        }
    }
}
