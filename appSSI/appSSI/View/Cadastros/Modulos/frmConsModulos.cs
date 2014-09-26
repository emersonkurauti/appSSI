using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace appSSI
{
    public partial class frmConsModulos : KuraFrameWork.Formularios.ucConsultaBasicaNormal
    {
        private int _cdModulo;
        public int cdModulo
        {
            get { return _cdModulo; }
            set { _cdModulo = value; }
        }

        private string _nmModulo;
        public string nmModulo
        {
            get { return _nmModulo; }
            set { _nmModulo = value; }
        }

        private int _cdSistema;
        public int cdSistema
        {
            get { return _cdSistema; }
            set { _cdSistema = value; }
        }

        conModulos objConModulos;
        caModulos objCaModulos;

        public frmConsModulos()
        {
            InitializeComponent();
            this.ControleFiltro(null, null);
            
            objCaModulos = new caModulos();
            objConModulos = new conModulos();
        }

        private void frmConsModulos_Load(object sender, EventArgs e)
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
            objConModulos.objCoModulos.cdSistema = _cdSistema;
            objConModulos.Select();
            dgvDados.DataSource = dtDados = objConModulos.dtDados;
        }

        public override void tsbSelecionar_Click(object sender, EventArgs e)
        {
            if (dgvDados.CurrentRow != null && dgvDados.CurrentRow.Index >= 0)
            {
                _cdModulo = Convert.ToInt32(dgvDados.CurrentRow.Cells[objCaModulos.cdModulo].Value.ToString());
                _nmModulo = dgvDados.CurrentRow.Cells[objCaModulos.nmModulo].Value.ToString();
                base.tsbSelecionar_Click(sender, e);
            }
            else
                MessageBox.Show(csMensagens.msgSelecionarRegistro);
        }

        public override void btnConsultar_Click(object sender, EventArgs e)
        {
            objConModulos.objCoModulos.LimparAtributos();

            if (_cdSistema != 0)
                objConModulos.objCoModulos.strFiltro = MontarFiltroConsulta(dgvFiltro, objCaModulos.nmTabela) + " AND cdSistema = " + _cdSistema.ToString();
            else
                objConModulos.objCoModulos.strFiltro = MontarFiltroConsulta(dgvFiltro, objCaModulos.nmTabela);

            if (objConModulos.Select())
                dgvDados.DataSource = dtDados = objConModulos.dtDados;
            else
                MessageBox.Show(objConModulos.strMensagemErro);
        }

        public override void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbSelecionar_Click(null, null);
        }
    }
}
