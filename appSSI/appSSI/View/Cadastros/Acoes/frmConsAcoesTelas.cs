using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace appSSI
{
    public partial class frmConsAcoesTelas : KuraFrameWork.Formularios.ucConsultaBasicaNormal
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

        private int _cdTela;
        public int cdTela
        {
            get { return _cdTela; }
            set { _cdTela = value; }
        }

        conTelasAcoes objConTelasAcoes;
        caTelasAcoes objCaTelasAcoes;

        public frmConsAcoesTelas()
        {
            InitializeComponent();
            this.ControleFiltro(null, null);

            objCaTelasAcoes = new caTelasAcoes();
            objConTelasAcoes = new conTelasAcoes();
        }

        private void frmConsAcoesTelas_Load(object sender, EventArgs e)
        {
            MontaGridViewDinamico();
            PreencheDadosGridView();
            PreencheDadosGridViewFiltro();
            objConTelasAcoes.dtDados = dtDados;
        }
        
        public override void MontaGridViewDinamico()
        {
            objCaTelasAcoes.RetornarFields(out strFields, out strVisivel, out strNome);
            base.MontaGridViewDinamico();
        }

        private void PreencheDadosGridView()
        {
            objConTelasAcoes.objCoTelasAcoes.LimparAtributos();
            objConTelasAcoes.objCoTelasAcoes.cdTela = _cdTela;
            objConTelasAcoes.Select();
            dgvDados.DataSource = dtDados = objConTelasAcoes.dtDados;
        }

        public override void tsbSelecionar_Click(object sender, EventArgs e)
        {
            if (dgvDados.CurrentRow != null && dgvDados.CurrentRow.Index >= 0)
            {
                _cdAcao = Convert.ToInt32(dgvDados.CurrentRow.Cells[objCaTelasAcoes.cdAcao].Value.ToString());
                _deAcao = dgvDados.CurrentRow.Cells[objCaTelasAcoes.CC_deAcao].Value.ToString();
                base.tsbSelecionar_Click(sender, e);
            }
            else
                MessageBox.Show(csMensagens.msgSelecionarRegistro);
        }

        public override void btnConsultar_Click(object sender, EventArgs e)
        {
            objConTelasAcoes.objCoTelasAcoes.LimparAtributos();

            if (_cdTela != 0)
                objConTelasAcoes.objCoTelasAcoes.cdTela = _cdTela;

            objConTelasAcoes.objCoTelasAcoes.strFiltro = MontarFiltroConsulta(dgvFiltro, objCaTelasAcoes.nmTabela);
            if (objConTelasAcoes.Select())
                dgvDados.DataSource = dtDados = objConTelasAcoes.dtDados;
            else
                MessageBox.Show(objConTelasAcoes.strMensagemErro);
        }

        public override void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbSelecionar_Click(null, null);
        }
    }
}
