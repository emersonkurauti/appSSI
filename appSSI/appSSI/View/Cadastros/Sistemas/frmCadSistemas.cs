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
    public partial class frmCadSistemas : KuraFrameWork.Formularios.ucCadastroBasicoNormal
    {
        private caSistemas objCaSistemas;
        private conSistemas objConSistemas;

        public frmCadSistemas()
        {
            InitializeComponent();
            this.ControleFiltro(null, null);
            ControleCampos(pnForm.Controls, false);

            objCaSistemas = new caSistemas();
            objConSistemas = new conSistemas();
        }

        private void frmCadSistemas_Load(object sender, EventArgs e)
        {
            MontaGridViewDinamico();
            PreencheDadosGridView();
            PreencheDadosGridViewFiltro();
            objConSistemas.dtDados = dtDados;
        }

        public override void MontaGridViewDinamico()
        {
            objCaSistemas.RetornarFields(out strFields, out strVisivel, out strNome);
            base.MontaGridViewDinamico();
        }

        private void PreencheDadosGridView()
        {
            objConSistemas.objCoSistemas.LimparAtributos();
            objConSistemas.Select();
            dgvDados.DataSource = dtDados = objConSistemas.dtDados;
        }

        private void CarregaObjeto()
        {
            int cdSistema;

            objConSistemas.objCoSistemas.LimparAtributos();

            int.TryParse(txtCodigo.Text, out cdSistema);
            objConSistemas.objCoSistemas.cdSistema= cdSistema;
            objConSistemas.objCoSistemas.nmSistema = txtDescricao.Text;
            objConSistemas.objCoSistemas.taskProjeto = txtProjetoTask.Text;
            objConSistemas.objCoSistemas.taskArea = txtAreaTASK.Text;
        }

        public override void CarregaDados(DataRow drSistema)
        {
            base.CarregaDados(drSistema);

            txtCodigo.Text = drSistema[objCaSistemas.cdSistema].ToString();
            txtDescricao.Text = drSistema[objCaSistemas.nmSistema].ToString();
            txtProjetoTask.Text = drSistema[objCaSistemas.taskProjeto].ToString();
            txtAreaTASK.Text = drSistema[objCaSistemas.taskArea].ToString();
            
            CarregaObjeto();
        }

        public override void tsbSalvar_Click(object sender, EventArgs e)
        {
            if (!CampoObrigatorioNaoPreenchido(pnForm.Controls))
            {
                CarregaObjeto();

                if (Status == csConstantes.sInserindo)
                {
                    if (!objConSistemas.Inserir())
                        MessageBox.Show(objConSistemas.strMensagemErro);
                    else
                    {
                        txtCodigo.Text = objConSistemas.objCoSistemas.cdSistema.ToString();
                        base.tsbSalvar_Click(sender, e);
                        PreencheDadosGridView();
                    }
                
                }
                if (Status == csConstantes.sAlterando)
                {
                    if (!objConSistemas.Alterar())
                        MessageBox.Show(objConSistemas.strMensagemErro);
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

            objConSistemas.objCoSistemas.cdSistema= Convert.ToInt32(txtCodigo.Text);
            if (!objConSistemas.Excluir())
                MessageBox.Show(objConSistemas.strMensagemErro);
            else
            {
                PreencheDadosGridView();
                base.tsbExcluir_Click(sender, e);
            }
        }

        public override void tsbLimpar_Click(object sender, EventArgs e)
        {
            base.tsbLimpar_Click(sender, e);
            objConSistemas.objCoSistemas.LimparAtributos();
        }

        public override void btnConsultar_Click(object sender, EventArgs e)
        {
            objConSistemas.objCoSistemas.LimparAtributos();

            objConSistemas.objCoSistemas.strFiltro = MontarFiltroConsulta(dgvFiltro, objCaSistemas.nmTabela);
            if (objConSistemas.Select())
                dgvDados.DataSource = dtDados = objConSistemas.dtDados;
            else
                MessageBox.Show(objConSistemas.strMensagemErro);
        }

        public override void tsbImprimir_ButtonClick(object sender, EventArgs e)
        {
            conRelatorio objConRelatorio = new conRelatorio();
            caRelatorios objCaRelatorios = new caRelatorios();

            objConRelatorio.objCoRelatorios.nmRelatorio = "crSistemas.rpt";

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
