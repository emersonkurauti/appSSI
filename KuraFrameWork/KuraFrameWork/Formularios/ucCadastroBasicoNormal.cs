using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KuraFrameWork.Formularios
{
    public partial class ucCadastroBasicoNormal : KuraFrameWork.Formularios.ucCadastroBasico
    {
        public string strFields = "", strVisivel = "", strNome = "";

        private int _PosCursorDt;
        private DataRow _drLinha;

        public DataRow drLinha
        {
            get { return _drLinha; }
            set { _drLinha = value; }
        }

        public int PosCursorDt
        {
            get { return _PosCursorDt; }
            set { _PosCursorDt = value; }
        }
        private TabPage _tpCorrente;

        public TabPage TpCorrente
        {
            get { return _tpCorrente; }
            set { _tpCorrente = value; }
        }

        public ucCadastroBasicoNormal()
        {
            InitializeComponent();
            _tpCorrente = tcCadastro.SelectedTab;
            _PosCursorDt = 0;
            LimparCampos(pnForm.Controls);
            ControleCampos(pnForm.Controls, false);
        }

        public void ControleFiltro(object sender, EventArgs e)
        {
            if (pnFiltro.Height != 20)
            {
                pnFiltro.Height = 20;
                btnEncolherExpandir.Text = "Mostrar Filtros";
                btnEncolherExpandir.Image = KuraFrameWork.Properties.Resources.Expandir;
                dgvDados.Height = dgvDados.Height + 70;
            }
            else
            {
                pnFiltro.Height = 90;
                btnEncolherExpandir.Text = "Esconder Filtros";
                btnEncolherExpandir.Image = KuraFrameWork.Properties.Resources.Encolher;
                dgvDados.Height = dgvDados.Height - 70;
            }
        }

        public override void tsbNovo_Click(object sender, EventArgs e)
        {
            base.tsbNovo_Click(sender, e);
            tcCadastro.SelectedIndex = 1;
            LimparCampos(pnForm.Controls);
            ControleCampos(pnForm.Controls, true);
        }

        public override void tsbEditar_Click(object sender, EventArgs e)
        {
            base.tsbEditar_Click(sender, e);
            tcCadastro.SelectedIndex = 1;
            ControleCampos(pnForm.Controls, true);
        }

        public override void tsbLimpar_Click(object sender, EventArgs e)
        {
            base.tsbLimpar_Click(sender, e);
            LimparCampos(pnForm.Controls);
            ControleCampos(pnForm.Controls, false);
        }

        public override void tsbSalvar_Click(object sender, EventArgs e)
        {
                base.tsbSalvar_Click(sender, e);
                ControleCampos(pnForm.Controls, false);
        }

        public override void tsbExcluir_Click(object sender, EventArgs e)
        {
            base.tsbExcluir_Click(sender, e);
            tsbLimpar_Click(null, null);
        }

        public virtual void btnFirst_Click(object sender, EventArgs e)
        {
            if (dtDados != null && dtDados.Rows.Count > 0)
            {
                drLinha = dtDados.NewRow();
                if (ControleRegistroNaoSalvoContinua())
                {
                    _PosCursorDt = 0;
                    drLinha = dtDados.Rows[_PosCursorDt];
                    CarregaDados(drLinha);
                }
            }
        }

        public virtual void btnPrevious_Click(object sender, EventArgs e)
        {
            if (dtDados != null && dtDados.Rows.Count > 0)
            {
                drLinha = dtDados.NewRow();
                if (ControleRegistroNaoSalvoContinua() && _PosCursorDt > 0)
                {
                    drLinha = dtDados.Rows[--_PosCursorDt];
                    CarregaDados(drLinha);
                }
            }
        }

        public virtual void btnNext_Click(object sender, EventArgs e)
        {
            if (dtDados != null && dtDados.Rows.Count > 0)
            {
                drLinha = dtDados.NewRow();
                if (ControleRegistroNaoSalvoContinua() && _PosCursorDt < dtDados.Rows.Count - 1)
                {
                    drLinha = dtDados.Rows[++_PosCursorDt];
                    CarregaDados(drLinha);
                }
            }
        }

        public virtual void btnLast_Click(object sender, EventArgs e)
        {
            if (dtDados != null && dtDados.Rows.Count > 0)
            {
                drLinha = dtDados.NewRow();
                if (ControleRegistroNaoSalvoContinua())
                {
                    _PosCursorDt = dtDados.Rows.Count - 1;
                    drLinha = dtDados.Rows[_PosCursorDt];
                    CarregaDados(drLinha);
                }
            }
        }

        private void tcCadastro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_tpCorrente == tpFormulario && tcCadastro.SelectedTab == tpConsulta)
            {
                ControleRegistroNaoSalvoContinua();
            }

            _tpCorrente = tcCadastro.SelectedTab;
        }

        public override bool ControleRegistroNaoSalvoContinua()
        {
            if (Status.ToString().Trim() != "")
            {
                if (MessageBox.Show(csMensagem.msgRegistroEmEdicao, csMensagem.msgAppSSI,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tsbLimpar_Click(null, null);
                }
                else
                {
                    tcCadastro.SelectedTab = tpFormulario;
                    return false;
                }
            }

            return true;
        }

        public virtual void CarregaDados(DataRow drDados)
        {
            tsbEditar.Enabled = true;
            tsbExcluir.Enabled = true;
        }

        public virtual void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDados.DataSource != null && dgvDados.Rows.Count > 0)
            {
                _PosCursorDt = dgvDados.CurrentRow.Index;
                drLinha = dtDados.Rows[_PosCursorDt];
                CarregaDados(drLinha);
            }
        }

        public virtual void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvDados_CellClick(sender, e);
            tcCadastro.SelectedTab = tpFormulario;
        }

        public virtual void PreencheDadosGridViewFiltro()
        {
            for (int i = 0; i < dgvDados.ColumnCount; i++)
            {
                if (dgvDados.Columns[i].Visible)
                    dgvFiltro.Rows.Add(dgvDados.Columns[i].DataPropertyName, dgvDados.Columns[i].HeaderText, "", "", "");
            }
        }

        private void dgvFiltro_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFiltro.CurrentCell.ColumnIndex == 2 && dgvFiltro.CurrentCell.Value.ToString() == "Entre")
            {
                dgvFiltro.CurrentRow.Cells[4].ReadOnly = false;
            }
            else
                if (dgvFiltro.CurrentCell.ColumnIndex == 2 && dgvFiltro.CurrentCell.Value.ToString() != "Entre")
                {
                    dgvFiltro.CurrentRow.Cells[4].ReadOnly = true;
                    dgvFiltro.CurrentRow.Cells[4].Value = "";
                }
        }

        private void btnLimparFiltro_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvFiltro.Rows.Count; i++)
            {
                dgvFiltro.Rows[i].Cells[2].Value = "";
                dgvFiltro.Rows[i].Cells[3].Value = "";
                dgvFiltro.Rows[i].Cells[4].Value = "";
                dgvFiltro.Rows[i].Cells[4].ReadOnly = true;
            }

            btnConsultar_Click(null, null);
        }

        public override void ControleCampos(Control.ControlCollection Controles, bool bStatus)
        {
            base.ControleCampos(Controles, bStatus);

            btnFirst.Enabled = true;
            btnLast.Enabled = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
        }

        public override void MontaGridViewDinamico()
        {
            MontarDataGridView(dgvDados, strFields, strVisivel, strNome);
        }

        public override bool CampoObrigatorioNaoPreenchido(Control.ControlCollection Controles)
        {
            return base.CampoObrigatorioNaoPreenchido(Controles);
        }

        public virtual void btnConsultar_Click(object sender, EventArgs e)
        {
        }

        private void dgvDados_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dtDados = SortDataTable(dtDados, dgvDados.Columns[e.ColumnIndex].DataPropertyName);
        }

        private void ucCadastroBasicoNormal_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start(Application.StartupPath + "\\Help\\HELP - " + this.Text + ".pdf");
            }
        }
    }
}
