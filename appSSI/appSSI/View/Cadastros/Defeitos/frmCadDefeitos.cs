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
    public partial class frmCadDefeitos : KuraFrameWork.Formularios.ucCadastroBasicoNormal
    {
        private caDefeitos objCaDefeitos;
        private conDefeitos objConDefeitos;

        public frmCadDefeitos()
        {
            InitializeComponent();
            this.ControleFiltro(null, null);
            ControleCampos(pnForm.Controls, false);
            
            objCaDefeitos = new caDefeitos();
            objConDefeitos = new conDefeitos();
        }

        private void frmCadDefeitos_Load(object sender, EventArgs e)
        {
            MontaGridViewDinamico();
            PreencheDadosGridView();
            PreencheDadosGridViewFiltro();
            objConDefeitos.dtDados = dtDados;
        }

        public override void MontaGridViewDinamico()
        {
            objCaDefeitos.RetornarFields(out strFields, out strVisivel, out strNome);
            base.MontaGridViewDinamico();
        }

        private void PreencheDadosGridView()
        {
            objConDefeitos.objCoDefeitos.LimparAtributos();
            objConDefeitos.Select();
            dgvDados.DataSource = dtDados = objConDefeitos.dtDados;
        }

        private void CarregaObjeto()
        {
            int cdDefeito;

            objConDefeitos.objCoDefeitos.LimparAtributos();

            int.TryParse(txtCodigo.Text, out cdDefeito);
            objConDefeitos.objCoDefeitos.cdDefeito= cdDefeito;
            objConDefeitos.objCoDefeitos.deDefeito= txtDescricao.Text;

            if (rbInicial.Checked)
                objConDefeitos.objCoDefeitos.flEstagio = 'I';
            if (rbAndamento.Checked)
                objConDefeitos.objCoDefeitos.flEstagio = 'A';
            if (rbDefinido.Checked)
                objConDefeitos.objCoDefeitos.flEstagio = 'D';
            
            objConDefeitos.objCoDefeitos.dtImgDefeitos = ucCadImagens.dtImagens;
            objConDefeitos.objCoDefeitos.dtSolucoesDefeitos = ucCadSolucoesDefeitos.dtDados;
            objConDefeitos.objCoDefeitos.dtDefeitosAcoesTelas = ucCadDefeitosAcoesTelas.dtDados;
        }

        public override void CarregaDados(DataRow drDefeito)
        {
            base.CarregaDados(drDefeito);

            txtCodigo.Text = drDefeito[objCaDefeitos.cdDefeito].ToString();
            txtDescricao.Text = drDefeito[objCaDefeitos.deDefeito].ToString();
            
            if (Convert.ToChar(drDefeito[objCaDefeitos.flEstagio].ToString()) == 'I')
                rbInicial.Checked = true;
            if (Convert.ToChar(drDefeito[objCaDefeitos.flEstagio].ToString()) == 'A')
                rbAndamento.Checked = true;
            if (Convert.ToChar(drDefeito[objCaDefeitos.flEstagio].ToString()) == 'D')
                rbDefinido.Checked = true;

            ucCadImagens.cdDefeito = Convert.ToInt32(drDefeito[objCaDefeitos.cdDefeito].ToString());
            ucCadImagens.btnLimparLista_Click(null, null);
            ucCadImagens.CarregarImagens();

            ucCadSolucoesDefeitos.LimparSolucoesDefeitos();
            ucCadSolucoesDefeitos.CdDefeito = Convert.ToInt32(drDefeito[objCaDefeitos.cdDefeito].ToString());
            ucCadSolucoesDefeitos.CarregarSolcoesDefeitos();

            ucCadDefeitosAcoesTelas.LimparAcoesTelasDefeito();
            ucCadDefeitosAcoesTelas.pcdDefeito = Convert.ToInt32(drDefeito[objCaDefeitos.cdDefeito].ToString());
            ucCadDefeitosAcoesTelas.CarregarAcoesTelasDefeito();

            CarregaObjeto();
        }

        public override void tsbNovo_Click(object sender, EventArgs e)
        {
            ucCadImagens.btnLimparLista_Click(null, null);
            ucCadSolucoesDefeitos.LimparSolucoesDefeitos();
            ucCadDefeitosAcoesTelas.LimparAcoesTelasDefeito();

            rbInicial.Checked = true;
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
                    if (!objConDefeitos.Inserir())
                        MessageBox.Show(objConDefeitos.strMensagemErro);
                    else
                    {
                        txtCodigo.Text = objConDefeitos.objCoDefeitos.cdDefeito.ToString();
                        base.tsbSalvar_Click(sender, e);
                        PreencheDadosGridView();
                    }
                
                }
                if (Status == csConstantes.sAlterando)
                {
                    if (!objConDefeitos.Alterar())
                        MessageBox.Show(objConDefeitos.strMensagemErro);
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

            objConDefeitos.objCoDefeitos.cdDefeito = Convert.ToInt32(txtCodigo.Text);
            if (!objConDefeitos.Excluir())
                MessageBox.Show(objConDefeitos.strMensagemErro);
            else
            {
                PreencheDadosGridView();
                base.tsbExcluir_Click(sender, e);
            }
        }

        public override void tsbLimpar_Click(object sender, EventArgs e)
        {
            base.tsbLimpar_Click(sender, e);
            objConDefeitos.objCoDefeitos.LimparAtributos();
        }

        public override void btnConsultar_Click(object sender, EventArgs e)
        {
            objConDefeitos.objCoDefeitos.LimparAtributos();

            objConDefeitos.objCoDefeitos.strFiltro = MontarFiltroConsulta(dgvFiltro, objCaDefeitos.nmTabela);
            if (objConDefeitos.Select())
                dgvDados.DataSource = dtDados = objConDefeitos.dtDados;
            else
                MessageBox.Show(objConDefeitos.strMensagemErro);
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
                else
                    if (control is ucCadDefeitosAcoesTelas)
                    {
                        ((ucCadDefeitosAcoesTelas)control).LimparAcoesTelasDefeito();
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
            ImprimirRelatorio("crDefeitos.rpt");
            base.tsbImprimir_ButtonClick(sender, e);
        }
    }
}
