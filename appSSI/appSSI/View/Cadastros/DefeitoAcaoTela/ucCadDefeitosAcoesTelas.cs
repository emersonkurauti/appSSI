using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace appSSI
{
    public partial class ucCadDefeitosAcoesTelas : UserControl
    {
        private string _ColunaOrdenada = "";
        public string colunaOrdenada
        {
            get { return _ColunaOrdenada; }
            set { _ColunaOrdenada = value; }
        }

        private string _Order = "";
        public string order
        {
            get { return _Order; }
            set { _Order = value; }
        }

        private DataTable _dtDados;
        public DataTable dtDados
        {
            get { return _dtDados; }
            set { _dtDados = value; }
        }

        private int _cdTela;
        public int pcdTela
        {
            get { return _cdTela; }
            set { _cdTela = value; }
        }

        private int _cdDefeito;
        public int pcdDefeito
        {
            get { return _cdDefeito; }
            set { _cdDefeito = value; }
        }

        private conDefeitoAcaoTela objConDefeitoAcaoTela;
        private caDefeitoAcaoTela objCaDefeitoAcaoTela;

        /// <summary>
        /// Construtor
        /// </summary>
        public ucCadDefeitosAcoesTelas()
        {
            InitializeComponent();

            objConDefeitoAcaoTela = new conDefeitoAcaoTela();
            objCaDefeitoAcaoTela = new caDefeitoAcaoTela();
            _dtDados = objConDefeitoAcaoTela.objCoDefeitoAcaoTela.RetornaEstruturaDT();
        }

        /// <summary>
        /// Método para carregar as soluções/defeitos
        /// </summary>
        public void CarregarAcoesTelasDefeito()
        {
            conDefeitoAcaoTela objConDefeitoAcaoTela = new conDefeitoAcaoTela();

            objConDefeitoAcaoTela.objCoDefeitoAcaoTela.cdDefeito = _cdDefeito;

            if (!objConDefeitoAcaoTela.Select())
            {
                MessageBox.Show(objConDefeitoAcaoTela.strMensagemErro);
                return;
            }

            if (objConDefeitoAcaoTela.dtDados != null)
            {
                _dtDados = objConDefeitoAcaoTela.dtDados.Clone();
                _dtDados = objConDefeitoAcaoTela.dtDados.Copy();
            }

            dgvAcoesTelas.DataSource = null;
            dgvAcoesTelas.AutoGenerateColumns = false;
            dgvAcoesTelas.DataSource = _dtDados;
            dgvAcoesTelas.Columns[0].Visible = false;
        }

        /// <summary>
        /// Método executado ao carregar o componente na tela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucCadSolucoesDefeitos_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Limpa os dados presentes no compoente
        /// </summary>
        public void LimparAcoesTelasDefeito()
        {
            if (_dtDados != null)
                _dtDados.Rows.Clear();
            else
                _dtDados = objConDefeitoAcaoTela.objCoDefeitoAcaoTela.RetornaEstruturaDT();
            _cdDefeito = 0;
            _cdTela = 0;
            ucTelasCons.LimparCampos();
            ucAcoesCons.LimparCampos();
        }

        /// <summary>
        /// Adicionar um defeito/solução
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
                if (ucTelasCons.txtCodigo.Text != "" && ucAcoesCons.txtCodigo.Text !="")
                {
                    if (!VerificarSeJahExiste(Convert.ToInt32(ucTelasCons.txtCodigo.Text), Convert.ToInt32(ucAcoesCons.txtCodigo.Text)))
                    {
                        DataRow dr = _dtDados.NewRow();

                        dr[objCaDefeitoAcaoTela.cdTela] = Convert.ToInt32(ucTelasCons.txtCodigo.Text);
                        dr[objCaDefeitoAcaoTela.cdAcao] = Convert.ToInt32(ucAcoesCons.txtCodigo.Text);
                        dr[objCaDefeitoAcaoTela.cdDefeito] = _cdDefeito;
                        dr[objCaDefeitoAcaoTela.CC_deAcao] = ucAcoesCons.txtDescricao.Text;
                        dr[objCaDefeitoAcaoTela.CC_deTela] = ucTelasCons.txtDescricao.Text;

                        _dtDados.Rows.Add(dr);

                        dgvAcoesTelas.AutoGenerateColumns = false;
                        dgvAcoesTelas.DataSource = _dtDados;
                    }
                    else
                        MessageBox.Show(csMensagens.msgDefeitoJahReferenciadoAcaoTela);
                }
                else
                    MessageBox.Show(csMensagens.msgSelecioneAcaoTela);
        }

        /// <summary>
        /// Remove um defeito/solução
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvAcoesTelas.CurrentRow != null && dgvAcoesTelas.CurrentRow.Index >= 0)
            {
                bool bExisteTela = false;
                bool bExisteAcao = false;
                for (int i = 0; i < _dtDados.Rows.Count; i++)
                {
                    bExisteTela = Convert.ToInt32(_dtDados.Rows[i][objCaDefeitoAcaoTela.cdTela].ToString()) ==
                        Convert.ToInt32(dgvAcoesTelas.CurrentRow.Cells[objCaDefeitoAcaoTela.cdTela].Value.ToString());
                    bExisteAcao = Convert.ToInt32(_dtDados.Rows[i][objCaDefeitoAcaoTela.cdTela].ToString()) ==
                        Convert.ToInt32(dgvAcoesTelas.CurrentRow.Cells[objCaDefeitoAcaoTela.cdTela].Value.ToString());
                    if (bExisteTela && bExisteAcao)
                    {
                        _dtDados.Rows.RemoveAt(i);
                        _dtDados.AcceptChanges();
                    }
                }
            }
            else
                MessageBox.Show(csMensagens.msgSelecioneAcaoTela);
        }

        /// <summary>
        /// Verifica se o defeito/solução já está inserido
        /// </summary>
        /// <param name="cdTela"></param>
        /// <returns></returns>
        private bool VerificarSeJahExiste(int cdTela, int cdAcao)
        {
            for (int i = 0; i < _dtDados.Rows.Count; i++)
                if (Convert.ToInt32(_dtDados.Rows[i][objCaDefeitoAcaoTela.cdTela].ToString()) == cdTela &&
                   Convert.ToInt32(_dtDados.Rows[i][objCaDefeitoAcaoTela.cdAcao].ToString()) == cdAcao)
                    return true;
            
            return false;
        }

        /// <summary>
        /// Ordenação da coluna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvAcoesTelas_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _dtDados = SortDataTable(_dtDados, dgvAcoesTelas.Columns[e.ColumnIndex].DataPropertyName);
        }

        /// <summary>
        /// Ordena o DataTable
        /// </summary>
        /// <param name="oDtt"></param>
        /// <param name="Sort"></param>
        /// <returns></returns>
        public DataTable SortDataTable(DataTable oDtt, string Sort)
        {
            if (_ColunaOrdenada == "")
                _ColunaOrdenada = Sort;

            if (_ColunaOrdenada == Sort && (_Order == "" || _Order == " ASC"))
                _Order = " DESC";
            else
            {
                _ColunaOrdenada = Sort;
                _Order = " ASC";
            }

            if (oDtt == null)
                return null;

            if (String.IsNullOrEmpty(Sort))
                return oDtt;

            oDtt.DefaultView.Sort = Sort + _Order;
            DataTable oDttTemp = oDtt.DefaultView.ToTable();

            return oDttTemp;

        }

        /// <summary>
        /// Para filtrar as ações da tela
        /// </summary>
        private void ucTelasCons_AoConsultarRegistro()
        {
            if (ucTelasCons.bMudouCodigo)
            {
                ucAcoesCons.LimparCampos();
                ucAcoesCons.cdTela = Convert.ToInt32(ucTelasCons.txtCodigo.Text);
            }
        }
    }
}
