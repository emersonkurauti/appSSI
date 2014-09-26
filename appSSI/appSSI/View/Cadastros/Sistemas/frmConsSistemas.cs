using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace appSSI
{
    public partial class frmConsSistemas : KuraFrameWork.Formularios.ucConsultaBasicaNormal
    {
        private int _cdSistema;
        public int cdSistema
        {
            get { return _cdSistema; }
            set { _cdSistema = value; }
        }

        private string _nmSistema;
        public string nmSistema
        {
            get { return _nmSistema; }
            set { _nmSistema = value; }
        }

        private string _strFiltro;
        public string strFiltro
        {
            get { return _strFiltro; }
            set { _strFiltro = value; }
        }

        conSistemas objConSistemas;
        caSistemas objCaSistemas;

        public frmConsSistemas()
        {
            InitializeComponent();
            this.ControleFiltro(null, null);
            
            objCaSistemas = new caSistemas();
            objConSistemas = new conSistemas();
        }

        private void frmConsSistemas_Load(object sender, EventArgs e)
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

            if (_strFiltro != "")
                objConSistemas.objCoSistemas.strFiltro = _strFiltro;

            objConSistemas.Select();
            dgvDados.DataSource = dtDados = objConSistemas.dtDados;
        }

        public override void tsbSelecionar_Click(object sender, EventArgs e)
        {
            if (dgvDados.CurrentRow != null && dgvDados.CurrentRow.Index >= 0)
            {
                _cdSistema = Convert.ToInt32(dgvDados.CurrentRow.Cells[objCaSistemas.cdSistema].Value.ToString());
                _nmSistema = dgvDados.CurrentRow.Cells[objCaSistemas.nmSistema].Value.ToString();
                base.tsbSelecionar_Click(sender, e);
            }
            else
                MessageBox.Show(csMensagens.msgSelecionarRegistro);
        }

        public override void btnConsultar_Click(object sender, EventArgs e)
        {
            objConSistemas.objCoSistemas.LimparAtributos();

            if (_strFiltro != "")
                objConSistemas.objCoSistemas.strFiltro = MontarFiltroConsulta(dgvFiltro, objCaSistemas.nmTabela) +
                    " AND " + strFiltro;
            else
                objConSistemas.objCoSistemas.strFiltro = MontarFiltroConsulta(dgvFiltro, objCaSistemas.nmTabela);

            if (objConSistemas.Select())
                dgvDados.DataSource = dtDados = objConSistemas.dtDados;
            else
                MessageBox.Show(objConSistemas.strMensagemErro);
        }

        public override void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbSelecionar_Click(null, null);
        }
    }
}
