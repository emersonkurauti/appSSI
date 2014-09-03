using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace appSSI
{
    public partial class OpConsultarDefeitosSimilares : KuraFrameWork.Formularios.ucCadastroBasico
    {
        public OpConsultarDefeitosSimilares()
        {
            InitializeComponent();
        }

        private void ucSistemasCons_AoConsultarRegistro()
        {
            if (ucSistemasCons.bMudouCodigo)
            {
                ucModulosCons.LimparCampos();
                ucTelasCons.LimparCampos();
                ucAcoesCons.LimparCampos();
                ucModulosCons.cdSistema = Convert.ToInt32(ucSistemasCons.txtCodigo.Text);

                ucModulosCons.txtCodigo.Focus();
            }
        }

        private void ucModulosCons_AoConsultarRegistro()
        {
            if (ucModulosCons.bMudouCodigo)
            {
                ucTelasCons.LimparCampos();
                ucAcoesCons.LimparCampos();
                ucTelasCons.cdModulo = Convert.ToInt32(ucModulosCons.txtCodigo.Text);

                ucTelasCons.txtCodigo.Focus();
            }
        }

        private void ucTelasCons_AoConsultarRegistro()
        {
            if (ucTelasCons.bMudouCodigo)
            {
                ucAcoesCons.LimparCampos();
                ucAcoesCons.cdTela = Convert.ToInt32(ucTelasCons.txtCodigo.Text);

                ucAcoesCons.txtCodigo.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ucSistemasCons.LimparCampos();
            ucModulosCons.LimparCampos();
            ucTelasCons.LimparCampos();
            ucAcoesCons.LimparCampos();
            txtDescDefeito.Clear();
            dgvDados.DataSource = null;

            ucSistemasCons.txtCodigo.Focus();
        }
    }
}
