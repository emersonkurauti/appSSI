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
    public partial class frmCadModulos : KuraFrameWork.Formularios.ucCadastroBasicoNormal
    {
        private caModulos objCaModulos;
        private conModulos objConModulos;

        public frmCadModulos()
        {
            InitializeComponent();
            this.ControleFiltro(null, null);
            ControleCampos(pnForm.Controls, false);

            objCaModulos = new caModulos();
            objConModulos = new conModulos();
        }

        private void frmCadModulos_Load(object sender, EventArgs e)
        {
            MontaGridViewDinamico();
            PreencheDadosGridView();
            PreencheDadosGridViewFiltro();
            objConModulos.dtDados = dtDados;
        }

        public override void MontaGridViewDinamico()
        {
            objCaModulos.RetornarFields(out strFields, out strVisivel, out strNome);
            base.MontaGridViewDinamico();
        }

        private void PreencheDadosGridView()
        {
            objConModulos.objCoModulos.LimparAtributos();
            objConModulos.Select();
            dgvDados.DataSource = dtDados = objConModulos.dtDados;
        }

        private void CarregaObjeto()
        {
            int cdModulo;

            objConModulos.objCoModulos.LimparAtributos();

            int.TryParse(txtCodigo.Text, out cdModulo);
            objConModulos.objCoModulos.cdModulo = cdModulo;
            objConModulos.objCoModulos.cdSistema = Convert.ToInt32(ucSistemasCons.txtCodigo.Text);
            objConModulos.objCoModulos.nmModulo = txtDescricao.Text;
            objConModulos.objCoModulos.taskModulo = txtModuloTASK.Text;
        }

        public override void CarregaDados(DataRow drModulo)
        {
            base.CarregaDados(drModulo);

            txtCodigo.Text = drModulo[objCaModulos.cdModulo].ToString();
            ucSistemasCons.txtCodigo.Text = drModulo[objCaModulos.cdSistema].ToString();
            txtDescricao.Text = drModulo[objCaModulos.nmModulo].ToString();
            txtModuloTASK.Text = drModulo[objCaModulos.taskModulo].ToString();

            ucSistemasCons.Carregar();
            CarregaObjeto();
        }

        public override void tsbSalvar_Click(object sender, EventArgs e)
        {
            if (!CampoObrigatorioNaoPreenchido(pnForm.Controls))
            {
                CarregaObjeto();

                if (Status == csConstantes.sInserindo)
                {
                    if (!objConModulos.Inserir())
                        MessageBox.Show(objConModulos.strMensagemErro);
                    else
                    {
                        txtCodigo.Text = objConModulos.objCoModulos.cdModulo.ToString();
                        base.tsbSalvar_Click(sender, e);
                        PreencheDadosGridView();
                    }
                
                }
                if (Status == csConstantes.sAlterando)
                {
                    if (!objConModulos.Alterar())
                        MessageBox.Show(objConModulos.strMensagemErro);
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

            objConModulos.objCoModulos.cdModulo= Convert.ToInt32(txtCodigo.Text);
            if (!objConModulos.Excluir())
                MessageBox.Show(objConModulos.strMensagemErro);
            else
            {
                PreencheDadosGridView();
                base.tsbExcluir_Click(sender, e);
            }
        }

        public override void tsbLimpar_Click(object sender, EventArgs e)
        {
            base.tsbLimpar_Click(sender, e);
            objConModulos.objCoModulos.LimparAtributos();
        }

        public override void btnConsultar_Click(object sender, EventArgs e)
        {
            objConModulos.objCoModulos.LimparAtributos();

            objConModulos.objCoModulos.strFiltro = MontarFiltroConsulta(dgvFiltro, objCaModulos.nmTabela);
            if (objConModulos.Select())
                dgvDados.DataSource = dtDados = objConModulos.dtDados;
            else
                MessageBox.Show(objConModulos.strMensagemErro);
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
            ImprimirRelatorio("crModulos.rpt");
            base.tsmiResultadoSimples_Click(sender, e);
        }

        public override void tsmiResultadoCompleto_Click(object sender, EventArgs e)
        {
            ImprimirRelatorio("crModulosC.rpt");
            base.tsmiResultadoCompleto_Click(sender, e);
        }
    }
}
