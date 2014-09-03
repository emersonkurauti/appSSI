using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace appSSI
{
    public partial class frmConsEmpresas : KuraFrameWork.Formularios.ucConsultaBasicaNormal
    {
        private int _cdEmpresa;
        public int cdEmpresa
        {
            get { return _cdEmpresa; }
            set { _cdEmpresa = value; }
        }

        private string _nmEmpresa;
        public string nmEmpresa
        {
            get { return _nmEmpresa; }
            set { _nmEmpresa = value; }
        }

        conEmpresas objConEmpresas;
        caEmpresas objCaEmpresas;

        public frmConsEmpresas()
        {
            InitializeComponent();
            this.ControleFiltro(null, null);
            
            objCaEmpresas = new caEmpresas();
            objConEmpresas = new conEmpresas();
        }

        private void frmConsSistemas_Load(object sender, EventArgs e)
        {
            MontaGridViewDinamico();
            PreencheDadosGridView();
            PreencheDadosGridViewFiltro();
            objConEmpresas.dtDados = dtDados;
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

        public override void tsbSelecionar_Click(object sender, EventArgs e)
        {
            if (dgvDados.CurrentRow != null && dgvDados.CurrentRow.Index >= 0)
            {
                _cdEmpresa = Convert.ToInt32(dgvDados.CurrentRow.Cells[objCaEmpresas.cdEmpresa].Value.ToString());
                _nmEmpresa = dgvDados.CurrentRow.Cells[objCaEmpresas.nmEmpresa].Value.ToString();
                base.tsbSelecionar_Click(sender, e);
            }
            else
                MessageBox.Show(csMensagens.msgSelecionarRegistro);
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

        public override void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbSelecionar_Click(null, null);
        }
    }
}
