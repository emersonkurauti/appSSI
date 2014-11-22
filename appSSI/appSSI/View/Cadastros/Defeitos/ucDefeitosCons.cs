using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace appSSI
{
    public partial class ucDefeitosCons : KuraFrameWork.Componentes_Visuais.ucConsulta
    {
        conDefeitos objConDefeitos;
        caDefeitos objCaDefeitos;

        public ucDefeitosCons()
        {
            InitializeComponent();
            objConDefeitos = new conDefeitos();
            objCaDefeitos = new caDefeitos();
        }

        public override void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsDefeitos form = new frmConsDefeitos();
            form.ShowDialog();

            if (form.cdDefeito != 0)
            {
                txtCodigo.Text = form.cdDefeito.ToString();
                txtDescricao.Text = form.deDefeito.ToString();
            }
        }

        public override void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                if (Convert.ToInt32(txtCodigo.Text) > 0)
                {
                    objConDefeitos.objCoDefeitos.LimparAtributos();
                    objConDefeitos.objCoDefeitos.cdDefeito = Convert.ToInt32(txtCodigo.Text);
                    objConDefeitos.Select();

                    if (objConDefeitos.dtDados.Rows.Count > 0)
                    {
                        txtCodigo.Text = objConDefeitos.dtDados.Rows[0][objCaDefeitos.cdDefeito].ToString();
                        txtDescricao.Text = objConDefeitos.dtDados.Rows[0][objCaDefeitos.deDefeito].ToString();
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
            frmCadDefeitos frmCadDefeitos = new frmCadDefeitos();
            frmCadDefeitos.ShowDialog();

            int codigo;

            int.TryParse(frmCadDefeitos.txtCodigo.Text, out codigo);

            if (codigo > 0)
            {
                txtCodigo.Text = codigo.ToString();
                txtCodigo_Leave(null, null);
            }
        }
    }
}
