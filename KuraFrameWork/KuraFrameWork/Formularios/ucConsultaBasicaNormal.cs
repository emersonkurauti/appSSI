using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KuraFrameWork.Formularios
{
    public partial class ucConsultaBasicaNormal : KuraFrameWork.Formularios.ucCadastroBasico
    {
        public string strFields = "", strVisivel = "", strNome = "";

        public ucConsultaBasicaNormal()
        {
            InitializeComponent();
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
        }

        public override void MontaGridViewDinamico()
        {
            MontarDataGridView(dgvDados, strFields, strVisivel, strNome);
        }

        private void dgvDados_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dtDados = SortDataTable(dtDados, dgvDados.Columns[e.ColumnIndex].DataPropertyName);
        }

        public virtual void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        public virtual void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
