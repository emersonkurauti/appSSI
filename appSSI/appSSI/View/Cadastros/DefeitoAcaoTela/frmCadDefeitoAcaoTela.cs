using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace appSSI
{
    public partial class frmCadDefeitoAcaoTela : KuraFrameWork.Formularios.ucCadastroBasicoNormal
    {
        private caDefeitoAcaoTela objCaDefeitoAcaoTela;
        private conDefeitoAcaoTela objConDefeitoAcaoTela;

        public frmCadDefeitoAcaoTela()
        {
            InitializeComponent();
            this.ControleFiltro(null, null);
            ControleCampos(pnForm.Controls, false);

            objCaDefeitoAcaoTela = new caDefeitoAcaoTela();
            objConDefeitoAcaoTela = new conDefeitoAcaoTela();
        }

        private void frmCadDefeitoAcaoTela_Load(object sender, EventArgs e)
        {
            MontaGridViewDinamico();
            PreencheDadosGridView();
            PreencheDadosGridViewFiltro();
            objConDefeitoAcaoTela.dtDados = dtDados;
        }

        public override void MontaGridViewDinamico()
        {
            objCaDefeitoAcaoTela.RetornarFields(out strFields, out strVisivel, out strNome);
            base.MontaGridViewDinamico();
        }

        private void PreencheDadosGridView()
        {
            objConDefeitoAcaoTela.objCoDefeitoAcaoTela.LimparAtributos();
            objConDefeitoAcaoTela.Select();
            dgvDados.DataSource = dtDados = objConDefeitoAcaoTela.dtDados;
        }

        private void CarregaObjeto()
        {
            objConDefeitoAcaoTela.objCoDefeitoAcaoTela.LimparAtributos();
            objConDefeitoAcaoTela.objCoDefeitoAcaoTela.cdTela = Convert.ToInt32(ucTelasCons.txtCodigo.Text);
            objConDefeitoAcaoTela.objCoDefeitoAcaoTela.cdAcao = Convert.ToInt32(ucAcoesCons.txtCodigo.Text);
            objConDefeitoAcaoTela.objCoDefeitoAcaoTela.cdDefeito = Convert.ToInt32(ucDefeitosCons.txtCodigo.Text);
        }

        public override void CarregaDados(DataRow drDefeitoAcaoTela)
        {
            base.CarregaDados(drDefeitoAcaoTela);

            ucTelasCons.txtCodigo.Text = drDefeitoAcaoTela[objCaDefeitoAcaoTela.cdTela].ToString();
            ucTelasCons.Carregar();

            ucAcoesCons.txtCodigo.Text = drDefeitoAcaoTela[objCaDefeitoAcaoTela.cdAcao].ToString();
            ucAcoesCons.Carregar();

            ucDefeitosCons.txtCodigo.Text = drDefeitoAcaoTela[objCaDefeitoAcaoTela.cdDefeito].ToString();
            ucDefeitosCons.Carregar();
            txtDescricao.Text = ucDefeitosCons.txtDescricao.Text;

            CarregaObjeto();
        }

        public override void tsbSalvar_Click(object sender, EventArgs e)
        {
            if (!CampoObrigatorioNaoPreenchido(pnForm.Controls))
            {
                CarregaObjeto();

                if (!VerificaSeJahExisteDefeitoParaTelaAcao())
                {
                    if (Status == csConstantes.sInserindo)
                    {
                        if (!objConDefeitoAcaoTela.Inserir())
                            MessageBox.Show(objConDefeitoAcaoTela.strMensagemErro);
                        else
                        {
                            base.tsbSalvar_Click(sender, e);
                            PreencheDadosGridView();
                        }

                    }
                    if (Status == csConstantes.sAlterando)
                    {
                        if (!objConDefeitoAcaoTela.Alterar())
                            MessageBox.Show(objConDefeitoAcaoTela.strMensagemErro);
                        else
                        {
                            base.tsbSalvar_Click(sender, e);
                            PreencheDadosGridView();
                        }
                    }
                }
                else
                    MessageBox.Show(csMensagens.msgDefeitoJahReferenciadoAcaoTela);
            }

        }

        public bool VerificaSeJahExisteDefeitoParaTelaAcao()
        {
            if (!objConDefeitoAcaoTela.Select())
                return false;

            if (objConDefeitoAcaoTela.dtDados != null && objConDefeitoAcaoTela.dtDados.Rows.Count > 0)
                return true;

            return false;
        }

        public override void tsbExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir o registro?", "",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.No)
                return;

            objConDefeitoAcaoTela.objCoDefeitoAcaoTela.cdAcao = Convert.ToInt32(ucAcoesCons.txtCodigo.Text);
            objConDefeitoAcaoTela.objCoDefeitoAcaoTela.cdTela = Convert.ToInt32(ucTelasCons.txtCodigo.Text);
            objConDefeitoAcaoTela.objCoDefeitoAcaoTela.cdDefeito = Convert.ToInt32(ucDefeitosCons.txtCodigo.Text);
            
            if (!objConDefeitoAcaoTela.Excluir())
                MessageBox.Show(objConDefeitoAcaoTela.strMensagemErro);
            else
            {
                PreencheDadosGridView();
                base.tsbExcluir_Click(sender, e);
            }
        }

        public override void tsbLimpar_Click(object sender, EventArgs e)
        {
            base.tsbLimpar_Click(sender, e);
            objConDefeitoAcaoTela.objCoDefeitoAcaoTela.LimparAtributos();
        }

        public override void btnConsultar_Click(object sender, EventArgs e)
        {
            objConDefeitoAcaoTela.objCoDefeitoAcaoTela.LimparAtributos();

            objConDefeitoAcaoTela.objCoDefeitoAcaoTela.strFiltro = MontarFiltroConsulta(dgvFiltro, objCaDefeitoAcaoTela.nmTabela);
            if (objConDefeitoAcaoTela.Select())
                dgvDados.DataSource = dtDados = objConDefeitoAcaoTela.dtDados;
            else
                MessageBox.Show(objConDefeitoAcaoTela.strMensagemErro);
        }

        private void ucDefeitosCons_AoConsultarRegistro()
        {
            txtDescricao.Text = ucDefeitosCons.txtDescricao.Text;
        }
    }
}
