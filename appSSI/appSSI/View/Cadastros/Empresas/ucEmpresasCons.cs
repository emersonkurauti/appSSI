using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace appSSI
{
    public partial class ucEmpresasCons : KuraFrameWork.Componentes_Visuais.ucConsulta
    {
        conEmpresas objConEmpresas;
        caEmpresas objCaEmpresas;

        public ucEmpresasCons()
        {
            InitializeComponent();
            objConEmpresas = new conEmpresas();
            objCaEmpresas = new caEmpresas();
        }

        public override void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsEmpresas form = new frmConsEmpresas();
            form.ShowDialog();

            if (form.cdEmpresa != 0)
            {
                txtCodigo.Text = form.cdEmpresa.ToString();
                txtDescricao.Text = form.nmEmpresa.ToString();
            }
        }

        public override void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                if (Convert.ToInt32(txtCodigo.Text) > 0)
                {
                    objConEmpresas.objCoEmpresas.LimparAtributos();
                    objConEmpresas.objCoEmpresas.cdEmpresa = Convert.ToInt32(txtCodigo.Text);
                    objConEmpresas.Select();

                    if (objConEmpresas.dtDados.Rows.Count > 0)
                    {
                        txtCodigo.Text = objConEmpresas.dtDados.Rows[0][objCaEmpresas.cdEmpresa].ToString();
                        txtDescricao.Text = objConEmpresas.dtDados.Rows[0][objCaEmpresas.nmEmpresa].ToString();
                    }
                    else
                    {
                        LimparCampos();
                        MessageBox.Show(csMensagens.msgErroConsultar);
                    }
                }
                else
                {
                    LimparCampos();
                    MessageBox.Show(csMensagens.msgErroValorInvalido);
                }

                base.txtCodigo_Leave(sender, e);
            }
            else
            {
                LimparCampos();
            }
        }

        public void Carregar()
        {
            txtCodigo_Leave(null, null);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadEmpresas frmCadEmpresas = new frmCadEmpresas();
            frmCadEmpresas.ShowDialog();

            int codigo;

            int.TryParse(frmCadEmpresas.txtCodigo.Text, out codigo);

            if (codigo > 0)
            {
                txtCodigo.Text = codigo.ToString();
                txtCodigo_Leave(null, null);
            }
        }
    }
}
