using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace appSSI
{
    public partial class frmConsAcoes : KuraFrameWork.Formularios.ucConsultaBasicaNormal
    {
        private int _cdAcao;
        public int cdAcao
        {
            get { return _cdAcao; }
            set { _cdAcao = value; }
        }

        private string _deAcao;
        public string deAcao
        {
            get { return _deAcao; }
            set { _deAcao = value; }
        }

        conAcoes objConAcoes;
        caAcoes objCaAcoes;

        public frmConsAcoes()
        {
            InitializeComponent();
            this.ControleFiltro(null, null);
            
            objCaAcoes = new caAcoes();
            objConAcoes = new conAcoes();
        }

        private void frmConsAcoes_Load(object sender, EventArgs e)
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

        public override void tsbSelecionar_Click(object sender, EventArgs e)
        {
            if (dgvDados.CurrentRow != null && dgvDados.CurrentRow.Index >= 0)
            {
                _cdAcao = Convert.ToInt32(dgvDados.CurrentRow.Cells[objCaAcoes.cdAcao].Value.ToString());
                _deAcao = dgvDados.CurrentRow.Cells[objCaAcoes.deAcao].Value.ToString();
                base.tsbSelecionar_Click(sender, e);
            }
            else
                MessageBox.Show(csMensagens.msgSelecionarRegistro);
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

        public override void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbSelecionar_Click(null, null);
        }
    }
}
