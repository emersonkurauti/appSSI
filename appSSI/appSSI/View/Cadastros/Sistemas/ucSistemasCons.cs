using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace appSSI
{
    public partial class ucSistemasCons : KuraFrameWork.Componentes_Visuais.ucConsulta
    {
        conSistemas objConSistemas;
        caSistemas objCaSistemas;

        public ucSistemasCons()
        {
            InitializeComponent();
            objConSistemas = new conSistemas();
            objCaSistemas = new caSistemas();
        }

        public override void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsSistemas form = new frmConsSistemas();
            form.ShowDialog();

            if (form.cdSistema != 0)
            {
                txtCodigo.Text = form.cdSistema.ToString();
                txtDescricao.Text = form.nmSistema.ToString();
            }
        }

        public override void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                if (Convert.ToInt32(txtCodigo.Text) > 0)
                {
                    objConSistemas.objCoSistemas.LimparAtributos();
                    objConSistemas.objCoSistemas.cdSistema = Convert.ToInt32(txtCodigo.Text);
                    objConSistemas.Select();

                    if (objConSistemas.dtDados.Rows.Count > 0)
                    {
                        txtCodigo.Text = objConSistemas.dtDados.Rows[0][objCaSistemas.cdSistema].ToString();
                        txtDescricao.Text = objConSistemas.dtDados.Rows[0][objCaSistemas.nmSistema].ToString();
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
        }

        public void Carregar()
        {
            txtCodigo_Leave(null, null);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadSistemas frmCadSistemas = new frmCadSistemas();
            frmCadSistemas.ShowDialog();
        }
    }
}
