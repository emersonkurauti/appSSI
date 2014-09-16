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
    public partial class ucCadSolucoesDefeitos : UserControl
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

        private int _cdSolucao;
        public int CdSolucao
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

        private int _cdDefeito;
        public int CdDefeito
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

        private bool _flDefeito;
        public bool flDefeito
        {
            get { return _flDefeito; }
            set { setFlDefeito(value); }
        }

        private conSolucoesDefeitos objConSolucoesDefeitos;
        private caSolucoesDefeitos objCaSolucoesDefeitos;

        /// <summary>
        /// Método para habilitar campos defeitos ou soluções
        /// </summary>
        /// <param name="bDefeito"></param>
        public void setFlDefeito(bool bDefeito)
        {
            _flDefeito = bDefeito;
            caSolucoesDefeitos objCaSolucoesDef = new caSolucoesDefeitos();

            if (_flDefeito)
            {
                dgvSolucoesDefeitos.Columns[objCaSolucoesDef.CC_deDefeito].Visible = true;
                ucDefeitosCons.Visible = true;

                dgvSolucoesDefeitos.Columns[objCaSolucoesDef.CC_deSolucao].Visible = false;
                ucSolucoesCons.Visible = false;
            }
            else
            {
                dgvSolucoesDefeitos.Columns[objCaSolucoesDef.CC_deSolucao].Visible = true;
                ucSolucoesCons.Visible = true;

                dgvSolucoesDefeitos.Columns[objCaSolucoesDef.CC_deDefeito].Visible = false;
                ucDefeitosCons.Visible = false;
            }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public ucCadSolucoesDefeitos()
        {
            InitializeComponent();

            objConSolucoesDefeitos = new conSolucoesDefeitos(csConstantes.cDefeito);
            objCaSolucoesDefeitos = new caSolucoesDefeitos();
            _dtDados = objConSolucoesDefeitos.objCoSolucoesDefeitos.RetornaEstruturaDT();
        }

        /// <summary>
        /// Método para carregar as soluções/defeitos
        /// </summary>
        public void CarregarSolcoesDefeitos()
        {
            conSolucoesDefeitos objConSolucoesDefeitos = new conSolucoesDefeitos(csConstantes.cDefeito);
            objConSolucoesDefeitos.flDefeito = !flDefeito;

            objConSolucoesDefeitos.objCoSolucoesDefeitos.cdDefeito = _cdDefeito;
            objConSolucoesDefeitos.objCoSolucoesDefeitos.cdSolucao = _cdSolucao;

            if (!objConSolucoesDefeitos.Select())
            {
                MessageBox.Show(objConSolucoesDefeitos.strMensagemErro);
                return;
            }

            if (objConSolucoesDefeitos.dtDados != null)
            {
                _dtDados = objConSolucoesDefeitos.dtDados.Clone();
                _dtDados = objConSolucoesDefeitos.dtDados.Copy();
            }

            dgvSolucoesDefeitos.DataSource = null;
            dgvSolucoesDefeitos.AutoGenerateColumns = false;
            dgvSolucoesDefeitos.DataSource = _dtDados;
            dgvSolucoesDefeitos.Columns[0].Visible = false;
            dgvSolucoesDefeitos.Columns[1].Visible = false;

            CarregarPrimeiroSelecionado();
        }

        /// <summary>
        /// Carrega os dados do primeiro registro da gridview
        /// </summary>
        public void CarregarPrimeiroSelecionado()
        {
            if (_dtDados.Rows.Count > 0)
            {
                if (_flDefeito)
                    dgvSolucoesDefeitos.CurrentCell = dgvSolucoesDefeitos.Rows[0].Cells["CC_deDefeito"];
                else
                    dgvSolucoesDefeitos.CurrentCell = dgvSolucoesDefeitos.Rows[0].Cells["CC_deSolucao"];
                CarregarDescObs();
            }
        }

        /// <summary>
        /// Carrega a descrição e a observação do defeito/solução selecionada
        /// </summary>
        public void CarregarDescObs()
        {
            if (_dtDados.Rows.Count > 0)
            {
                if (_flDefeito)
                {
                    txtDescricao.Text = dgvSolucoesDefeitos.CurrentRow.Cells[objCaSolucoesDefeitos.CC_deDefeito].Value.ToString();
                    txtObs.Text = _dtDados.Rows[dgvSolucoesDefeitos.CurrentRow.Index][objCaSolucoesDefeitos.deObservacao].ToString();
                }
                else
                {
                    txtDescricao.Text = dgvSolucoesDefeitos.CurrentRow.Cells[objCaSolucoesDefeitos.CC_deSolucao].Value.ToString();
                    txtObs.Text = _dtDados.Rows[dgvSolucoesDefeitos.CurrentRow.Index][objCaSolucoesDefeitos.deObservacao].ToString();
                }
            }
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
        /// Limpa a descrição e a observação
        /// </summary>
        public void LimparDescricaoObs()
        {
            txtDescricao.Text = "";
            txtObs.Text = "";
        }

        /// <summary>
        /// Limpa os dados presentes no compoente
        /// </summary>
        public void LimparSolucoesDefeitos()
        {
            if (_dtDados != null)
                _dtDados.Rows.Clear();
            else
                _dtDados = objConSolucoesDefeitos.objCoSolucoesDefeitos.RetornaEstruturaDT();
            _cdDefeito = 0;
            _cdSolucao = 0;
            _deSolucao = "";
            _deDefeito = "";
            LimparDescricaoObs();
            ucDefeitosCons.txtCodigo.Text = "";
            ucDefeitosCons.txtDescricao.Text = "";
            ucSolucoesCons.txtCodigo.Text = "";
            ucSolucoesCons.txtDescricao.Text = "";
        }

        /// <summary>
        /// Adicionar um defeito/solução
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_flDefeito)
            {
                if (ucDefeitosCons.txtCodigo.Text != "")
                {
                    if (!VerificarSeJahExiste(Convert.ToInt32(ucDefeitosCons.txtCodigo.Text)))
                    {
                        DataRow dr = _dtDados.NewRow();

                        dr[objCaSolucoesDefeitos.cdDefeito] = ucDefeitosCons.txtCodigo.Text;
                        dr[objCaSolucoesDefeitos.CC_deDefeito] = ucDefeitosCons.txtDescricao.Text;

                        dr[objCaSolucoesDefeitos.cdSolucao] = _cdSolucao;
                        dr[objCaSolucoesDefeitos.CC_deSolucao] = _deSolucao;
                        dr[objCaSolucoesDefeitos.deObservacao] = "";

                        _dtDados.Rows.Add(dr);

                        dgvSolucoesDefeitos.AutoGenerateColumns = false;
                        dgvSolucoesDefeitos.DataSource = _dtDados;
                        CarregarPrimeiroSelecionado();
                    }
                    else
                        MessageBox.Show(csMensagens.msgDefeitoJahExisteParaSolucao);
                }
                else
                    MessageBox.Show(csMensagens.msgSelecionarRegistro);

                ucDefeitosCons.LimparCampos();
            }
            else
            {
                if (ucSolucoesCons.txtCodigo.Text != "")
                {
                    if (!VerificarSeJahExiste(Convert.ToInt32(ucSolucoesCons.txtCodigo.Text)))
                    {
                        DataRow dr = _dtDados.NewRow();

                        dr[objCaSolucoesDefeitos.cdSolucao] = ucSolucoesCons.txtCodigo.Text;
                        dr[objCaSolucoesDefeitos.CC_deSolucao] = ucSolucoesCons.txtDescricao.Text;

                        dr[objCaSolucoesDefeitos.cdDefeito] = _cdDefeito;
                        dr[objCaSolucoesDefeitos.CC_deDefeito] = _deDefeito;
                        dr[objCaSolucoesDefeitos.deObservacao] = "";

                        _dtDados.Rows.Add(dr);

                        dgvSolucoesDefeitos.AutoGenerateColumns = false;
                        dgvSolucoesDefeitos.DataSource = _dtDados;
                        CarregarPrimeiroSelecionado();
                    }
                    else
                        MessageBox.Show(csMensagens.msgSolucaoJahExisteParaDefeito);
                }
                else
                    MessageBox.Show(csMensagens.msgSelecionarRegistro);

                ucSolucoesCons.LimparCampos();
            }
        }

        /// <summary>
        /// Remove um defeito/solução
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (_flDefeito)
            {
                if (dgvSolucoesDefeitos.CurrentRow != null && dgvSolucoesDefeitos.CurrentRow.Index >= 0)
                {
                    for (int i = 0; i < _dtDados.Rows.Count; i++)
                    {
                        if (Convert.ToInt32(_dtDados.Rows[i][objCaSolucoesDefeitos.cdDefeito].ToString()) ==
                            Convert.ToInt32(dgvSolucoesDefeitos.CurrentRow.Cells[objCaSolucoesDefeitos.cdDefeito].Value.ToString()))
                        {
                            _dtDados.Rows.RemoveAt(i);
                            _dtDados.AcceptChanges();
                        }
                    }
                    LimparDescricaoObs();
                    CarregarPrimeiroSelecionado();
                }
                else
                    MessageBox.Show(csMensagens.msgSelecioneDefeitoParaRemover);
            }
            else
            {
                if (dgvSolucoesDefeitos.CurrentRow != null && dgvSolucoesDefeitos.CurrentRow.Index >= 0)
                {
                    for (int i = 0; i < _dtDados.Rows.Count; i++)
                    {
                        if (Convert.ToInt32(_dtDados.Rows[i][objCaSolucoesDefeitos.cdSolucao].ToString()) ==
                            Convert.ToInt32(dgvSolucoesDefeitos.CurrentRow.Cells[objCaSolucoesDefeitos.cdSolucao].Value.ToString()))
                        {
                            _dtDados.Rows.RemoveAt(i);
                            _dtDados.AcceptChanges();
                        }
                    }
                    LimparDescricaoObs();
                    CarregarPrimeiroSelecionado();
                }
                else
                    MessageBox.Show(csMensagens.msgSelecioneSolucaoParaRemover);
            }
        }

        /// <summary>
        /// Atualiza descrição e observação do defeito/solução
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSolucoesDefeitos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregarDescObs();
        }

        /// <summary>
        /// Verifica se o defeito/solução já está inserido
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        private bool VerificarSeJahExiste(int codigo)
        {
            for (int i = 0; i < _dtDados.Rows.Count; i++)
            {
                if (_flDefeito)
                {
                    if (Convert.ToInt32(_dtDados.Rows[i][objCaSolucoesDefeitos.cdDefeito].ToString()) == codigo)
                        return true;
                }
                else
                {
                    if (Convert.ToInt32(_dtDados.Rows[i][objCaSolucoesDefeitos.cdSolucao].ToString()) == codigo)
                        return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Atualiza a observação da solução
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtObs_Leave(object sender, EventArgs e)
        {
            if (dgvSolucoesDefeitos.CurrentRow != null)
                _dtDados.Rows[dgvSolucoesDefeitos.CurrentRow.Index][objCaSolucoesDefeitos.deObservacao] = txtObs.Text;
        }

        /// <summary>
        /// Ordenação da coluna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSolucoesDefeitos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _dtDados = SortDataTable(_dtDados, dgvSolucoesDefeitos.Columns[e.ColumnIndex].DataPropertyName);
            CarregarDescObs();
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
        /// Evento executado ao salvar
        /// </summary>
        public void Salvar()
        {
            txtObs_Leave(null, null);
        }
    }
}
