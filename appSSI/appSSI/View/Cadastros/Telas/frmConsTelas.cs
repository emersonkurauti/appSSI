using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace appSSI
{
    public partial class frmConsTelas : KuraFrameWork.Formularios.ucConsultaBasicaNormal
    {
        private int _cdTela;
        public int cdTela
        {
            get { return _cdTela; }
            set { _cdTela = value; }
        }

        private string _nmTela;
        public string nmTela
        {
            get { return _nmTela; }
            set { _nmTela = value; }
        }

        private int _cdModulo;
        public int cdModulo
        {
            get { return _cdModulo; }
            set { _cdModulo = value; }
        }

        conTelas objConTelas;
        caTelas objCaTelas;

        public frmConsTelas()
        {
            InitializeComponent();
            this.ControleFiltro(null, null);

            objConTelas = new conTelas();
            objCaTelas = new caTelas();
        }

        private void frmConsTelas_Load(object sender, EventArgs e)
        {
            MontaGridViewDinamico();
            PreencheDadosGridView();
            PreencheDadosGridViewFiltro();
            objConTelas.dtDados = dtDados;
        }
        
        public override void MontaGridViewDinamico()
        {
            objCaTelas.RetornarFields(out strFields, out strVisivel, out strNome);
            base.MontaGridViewDinamico();
        }

        private void PreencheDadosGridView()
        {
            objConTelas.objCoTelas.LimparAtributos();
            objConTelas.objCoTelas.cdModulo = _cdModulo;
            objConTelas.Select();
            dgvDados.DataSource = dtDados = objConTelas.dtDados;
        }

        public override void tsbSelecionar_Click(object sender, EventArgs e)
        {
            if (dgvDados.CurrentRow != null && dgvDados.CurrentRow.Index >= 0)
            {
                _cdTela = Convert.ToInt32(dgvDados.CurrentRow.Cells[objCaTelas.cdTela].Value.ToString());
                _nmTela = dgvDados.CurrentRow.Cells[objCaTelas.nmTela].Value.ToString();
                base.tsbSelecionar_Click(sender, e);
            }
            else
                MessageBox.Show(csMensagens.msgSelecionarRegistro);
        }

        public override void btnConsultar_Click(object sender, EventArgs e)
        {
            objConTelas.objCoTelas.LimparAtributos();

            if (_cdModulo != 0)
                objConTelas.objCoTelas.cdModulo = _cdModulo;

            objConTelas.objCoTelas.strFiltro = MontarFiltroConsulta(dgvFiltro, objCaTelas.nmTabela);
            if (objConTelas.Select())
                dgvDados.DataSource = dtDados = objConTelas.dtDados;
            else
                MessageBox.Show(objConTelas.strMensagemErro);
        }

        public override void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbSelecionar_Click(null, null);
        }
    }
}
