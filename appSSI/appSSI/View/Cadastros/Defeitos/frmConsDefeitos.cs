using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace appSSI
{
    public partial class frmConsDefeitos : KuraFrameWork.Formularios.ucConsultaBasicaNormal
    {
        private int _cdDefeito;
        public int cdDefeito
        {
            get { return _cdDefeito; }
            set { _cdDefeito = value; }
        }

        private string _deDefeito;
        public string deDefeito
        {
            get { return _deDefeito; }
            set { _deDefeito = value; }
        }

        conDefeitos objConDefeitos;
        caDefeitos objCaDefeitos;

        public frmConsDefeitos()
        {
            InitializeComponent();
            objConDefeitos = new conDefeitos();
            objCaDefeitos = new caDefeitos();
        }

        private void frmConsDefeitos_Load(object sender, EventArgs e)
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

        public override void tsbSelecionar_Click(object sender, EventArgs e)
        {
            if (dgvDados.CurrentRow != null && dgvDados.CurrentRow.Index >= 0)
            {
                _cdDefeito = Convert.ToInt32(dgvDados.CurrentRow.Cells[objCaDefeitos.cdDefeito].Value.ToString());
                _deDefeito = dgvDados.CurrentRow.Cells[objCaDefeitos.deDefeito].Value.ToString();
                base.tsbSelecionar_Click(sender, e);
            }
            else
                MessageBox.Show(csMensagens.msgSelecionarRegistro);
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

        public override void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbSelecionar_Click(null, null);
        }
    }
}
