using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace appSSI
{
    public partial class frmConsSolucoes : KuraFrameWork.Formularios.ucConsultaBasicaNormal
    {
        private int _cdSolucao;
        public int cdSolucao
        {
            get { return _cdSolucao; }
            set { _cdSolucao = value; }
        }

        private string _deSolucao;
        public string deSolucao
        {
            get { return _deSolucao; }
            set { _deSolucao = value; }
        }

        conSolucoes objConSolucoes;
        caSolucoes objCaSolucoes;

        public frmConsSolucoes()
        {
            InitializeComponent();
            objConSolucoes = new conSolucoes();
            objCaSolucoes = new caSolucoes();
        }

        private void frmConsSolucoes_Load(object sender, EventArgs e)
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

        public override void tsbSelecionar_Click(object sender, EventArgs e)
        {
            if (dgvDados.CurrentRow != null && dgvDados.CurrentRow.Index >= 0)
            {
                _cdSolucao = Convert.ToInt32(dgvDados.CurrentRow.Cells[objCaSolucoes.cdSolucao].Value.ToString());
                _deSolucao = dgvDados.CurrentRow.Cells[objCaSolucoes.deSolucao].Value.ToString();
                base.tsbSelecionar_Click(sender, e);
            }
            else
                MessageBox.Show(csMensagens.msgSelecionarRegistro);
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

        public override void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbSelecionar_Click(null, null);
        }
    }
}
