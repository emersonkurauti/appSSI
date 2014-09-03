using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace appSSI
{
    public partial class ucSolucoesCons : KuraFrameWork.Componentes_Visuais.ucConsulta
    {
        conSolucoes objConSolucoes;
        caSolucoes objCaSolucoes;

        public ucSolucoesCons()
        {
            InitializeComponent();
            objConSolucoes = new conSolucoes();
            objCaSolucoes = new caSolucoes();
        }

        public override void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsSolucoes form = new frmConsSolucoes();
            form.ShowDialog();

            if (form.cdSolucao != 0)
            {
                txtCodigo.Text = form.cdSolucao.ToString();
                txtDescricao.Text = form.deSolucao.ToString();
            }
        }

        public override void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                if (Convert.ToInt32(txtCodigo.Text) > 0)
                {
                    objConSolucoes.objCoSolucoes.LimparAtributos();
                    objConSolucoes.objCoSolucoes.cdSolucao = Convert.ToInt32(txtCodigo.Text);
                    objConSolucoes.Select();

                    if (objConSolucoes.dtDados.Rows.Count > 0)
                    {
                        txtCodigo.Text = objConSolucoes.dtDados.Rows[0][objCaSolucoes.cdSolucao].ToString();
                        txtDescricao.Text = objConSolucoes.dtDados.Rows[0][objCaSolucoes.deSolucao].ToString();
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
            frmCadSolucoes frmCadSolucoes = new frmCadSolucoes();
            frmCadSolucoes.ShowDialog();
        }
    }
}
