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
    public partial class frmCadEmpresas : KuraFrameWork.Formularios.ucCadastroBasicoNormal
    {
        private caEmpresas objCaEmpresas;
        private conEmpresas objConEmpresas;

        private caSistemas objCaSistemas;
        private conSistemas objConSistemas;
        private DataTable dtSistemas;

        private caSistemasEmpresas objCaSistemasEmpresas;
        private conSistemasEmpresas objConSistemasEmpresas;
        private DataTable dtSisEmp;

        public frmCadEmpresas()
        {
            InitializeComponent();
            this.ControleFiltro(null, null);
            ControleCampos(pnForm.Controls, false);
            
            objCaEmpresas = new caEmpresas();
            objConEmpresas = new conEmpresas();
            
            objCaSistemas = new caSistemas();
            objConSistemas = new conSistemas();

            objCaSistemasEmpresas = new caSistemasEmpresas();
            objConSistemasEmpresas = new conSistemasEmpresas();
        }

        private void frmCadEmpresas_Load(object sender, EventArgs e)
        {
            MontaGridViewDinamico();
            PreencheDadosGridView();
            PreencheDadosGridViewFiltro();
            objConEmpresas.dtDados = dtDados;
            dtSistemas = objConSistemas.objCoSistemas.RetornaEstruturaDT();
        }

        public override void MontaGridViewDinamico()
        {
            objCaEmpresas.RetornarFields(out strFields, out strVisivel, out strNome);
            base.MontaGridViewDinamico();
        }

        private void PreencheDadosGridView()
        {
            objConEmpresas.objCoEmpresas.LimparAtributos();
            objConEmpresas.Select();
            dgvDados.DataSource = dtDados = objConEmpresas.dtDados;
        }

        public void CarregarSistemasEmpresas()
        {
            conSistemas objConSistemasAux = new conSistemas();
            DataTable dtAux;
            DataRow dr;

            int cdEmpresa;
            int.TryParse(txtCodigo.Text, out cdEmpresa);
            objConSistemasEmpresas.objCoSistemasEmpresas.LimparAtributos();
            objConSistemasEmpresas.objCoSistemasEmpresas.cdEmpresa = cdEmpresa;
            objConSistemasEmpresas.Select();
            dtSisEmp = objConSistemasEmpresas.dtDados;

            dtSistemas.Rows.Clear();

            for (int i = 0; i < dtSisEmp.Rows.Count; i++)
            {
                objConSistemasAux.objCoSistemas.LimparAtributos();
                objConSistemasAux.objCoSistemas.cdSistema = Convert.ToInt32(dtSisEmp.Rows[i][objCaSistemasEmpresas.cdSistema].ToString());
                objConSistemasAux.Select();

                dtAux = objConSistemasAux.dtDados;

                dr = dtSistemas.NewRow();

                dr[objCaSistemas.cdSistema] = Convert.ToInt32(dtAux.Rows[0][objCaSistemas.cdSistema].ToString());
                dr[objCaSistemas.nmSistema] = dtAux.Rows[0][objCaSistemas.nmSistema].ToString();

                dtSistemas.Rows.Add(dr);
            }

            dgvSistemasEmpresas.DataSource = null;
            dgvSistemasEmpresas.AutoGenerateColumns = false;
            dgvSistemasEmpresas.DataSource = dtSistemas;
            dgvSistemasEmpresas.Columns[0].Visible = false;
        }

        private void CarregaObjeto()
        {
            int cdEmpresa;

            objConEmpresas.objCoEmpresas.LimparAtributos();

            int.TryParse(txtCodigo.Text, out cdEmpresa);
            objConEmpresas.objCoEmpresas.cdEmpresa = cdEmpresa;
            objConEmpresas.objCoEmpresas.nmEmpresa = txtNome.Text;
            objConEmpresas.objCoEmpresas.nmFantasiaEmpresa = txtNomeFantasia.Text;
            objConEmpresas.objCoEmpresas.nuCNPJ = Convert.ToInt64(txtCNPJ.PegaTexto());
            objConEmpresas.objCoEmpresas.deLogradouro = txtLogradouro.Text;
            objConEmpresas.objCoEmpresas.nuNumero = Convert.ToInt32(txtNuLogradouro.Text);
            objConEmpresas.objCoEmpresas.deBairro = txtBairro.Text;
            objConEmpresas.objCoEmpresas.deComplemento = txtComplemento.Text;
            objConEmpresas.objCoEmpresas.nuCEP = Convert.ToInt32(txtCEP.PegaTexto());
            objConEmpresas.objCoEmpresas.nuTelefone = Convert.ToInt64(txtTelefone.PegaTexto());

            objConEmpresas.objCoEmpresas.dtSisEmp = dtSistemas;
        }

        public override void CarregaDados(DataRow drEmpresa)
        {
            base.CarregaDados(drEmpresa);

            txtCodigo.Text = drEmpresa[objCaEmpresas.cdEmpresa].ToString();
            txtNome.Text = drEmpresa[objCaEmpresas.nmEmpresa].ToString();
            txtNomeFantasia.Text = drEmpresa[objCaEmpresas.nmFantasiaEmpresa].ToString();
            txtCNPJ.Text = drEmpresa[objCaEmpresas.nuCNPJ].ToString();
            txtLogradouro.Text = drEmpresa[objCaEmpresas.deLogradouro].ToString();
            txtNuLogradouro.Text = drEmpresa[objCaEmpresas.nuNumero].ToString();
            txtBairro.Text = drEmpresa[objCaEmpresas.deBairro].ToString();
            txtComplemento.Text = drEmpresa[objCaEmpresas.deComplemento].ToString();
            txtCEP.Text = drEmpresa[objCaEmpresas.nuCEP].ToString();
            txtTelefone.Text = drEmpresa[objCaEmpresas.nuTelefone].ToString();

            CarregarSistemasEmpresas();
            CarregaObjeto();
        }

        public override void tsbNovo_Click(object sender, EventArgs e)
        {
            dtSistemas.Rows.Clear();
            base.tsbNovo_Click(sender, e);
        }

        public override void tsbSalvar_Click(object sender, EventArgs e)
        {
            if (!CampoObrigatorioNaoPreenchido(pnForm.Controls))
            {
                CarregaObjeto();

                if (Status == csConstantes.sInserindo)
                {
                    if (!objConEmpresas.Inserir())
                        MessageBox.Show(objConEmpresas.strMensagemErro);
                    else
                    {
                        txtCodigo.Text = objConEmpresas.objCoEmpresas.cdEmpresa.ToString();
                        base.tsbSalvar_Click(sender, e);
                        PreencheDadosGridView();
                    }
                
                }
                if (Status == csConstantes.sAlterando)
                {
                    if (!objConEmpresas.Alterar())
                        MessageBox.Show(objConEmpresas.strMensagemErro);
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
            objConEmpresas.objCoEmpresas.cdEmpresa = Convert.ToInt32(txtCodigo.Text);
            if (!objConEmpresas.Excluir())
                MessageBox.Show(objConEmpresas.strMensagemErro);
            else
            {
                PreencheDadosGridView();
                base.tsbExcluir_Click(sender, e);
            }
        }

        public override void tsbLimpar_Click(object sender, EventArgs e)
        {
            base.tsbLimpar_Click(sender, e);
            objConEmpresas.objCoEmpresas.LimparAtributos();
        }

        public override void btnConsultar_Click(object sender, EventArgs e)
        {
            objConEmpresas.objCoEmpresas.LimparAtributos();

            objConEmpresas.objCoEmpresas.strFiltro = MontarFiltroConsulta(dgvFiltro, objCaEmpresas.nmTabela);
            if (objConEmpresas.Select())
                dgvDados.DataSource = dtDados = objConEmpresas.dtDados;
            else
                MessageBox.Show(objConEmpresas.strMensagemErro);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ucSistemasCons.txtCodigo.Text != "" && !VerificarSeSistemaJahExiste(Convert.ToInt32(ucSistemasCons.txtCodigo.Text)))
            {
                DataRow drSistema = dtSistemas.NewRow();

                drSistema[objCaSistemas.cdSistema] = ucSistemasCons.txtCodigo.Text;
                drSistema[objCaSistemas.nmSistema] = ucSistemasCons.txtDescricao.Text;

                dtSistemas.Rows.Add(drSistema);

                ucSistemasCons.LimparCampos();

                dgvSistemasEmpresas.DataSource = dtSistemas;
            }
            else
                MessageBox.Show(csMensagens.msgSistemaEmpresaJahAssociado);
        }

        private bool VerificarSeSistemaJahExiste(int cdSistema)
        {
            for (int i = 0; i < dtSistemas.Rows.Count; i++)
            {
                if (Convert.ToInt32(dtSistemas.Rows[i][objCaSistemas.cdSistema].ToString()) == cdSistema)
                    return true;
            }
            return false;
        }

        private void txtRemove_Click(object sender, EventArgs e)
        {
            if (dgvSistemasEmpresas.CurrentRow != null && dgvSistemasEmpresas.CurrentRow.Index >= 0)
            {
                for (int i = 0; i < dtSistemas.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dtSistemas.Rows[i][objCaSistemas.cdSistema].ToString()) ==
                        Convert.ToInt32(dgvSistemasEmpresas.CurrentRow.Cells[objCaSistemas.cdSistema].Value.ToString()))
                    {
                        dtSistemas.Rows.RemoveAt(i);
                        dtSistemas.AcceptChanges();
                    }
                }
            }
            else
                MessageBox.Show(csMensagens.msgSistemaEmpresaSelecioneParaRemover);
        }

        public override void tsbImprimir_ButtonClick(object sender, EventArgs e)
        {
            conRelatorio objConRelatorio = new conRelatorio();
            caRelatorios objCaRelatorios = new caRelatorios();

            objConRelatorio.objCoRelatorios.nmRelatorio = "crEmpresa.rpt";

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
