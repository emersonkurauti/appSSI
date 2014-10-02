using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace appSSI
{
    public partial class ucTelasCons : KuraFrameWork.Componentes_Visuais.ucConsulta
    {
        conTelas objConTelas;
        caTelas objCaTelas;

        private int _cdModulo;
        public int cdModulo
        {
            get { return _cdModulo; }
            set { _cdModulo = value; }
        }

        public ucTelasCons()
        {
            InitializeComponent();
            objConTelas = new conTelas();
            objCaTelas = new caTelas();
        }

        public override void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsTelas form = new frmConsTelas();
            form.cdModulo = _cdModulo;
            form.ShowDialog();

            if (form.cdTela != 0)
            {
                txtCodigo.Text = form.cdTela.ToString();
                txtDescricao.Text = form.nmTela.ToString();
            }
        }

        public override void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                if (Convert.ToInt32(txtCodigo.Text) >= 0)
                {
                    objConTelas.objCoTelas.LimparAtributos();
                    objConTelas.objCoTelas.cdTela = Convert.ToInt32(txtCodigo.Text);
                    objConTelas.objCoTelas.cdModulo = _cdModulo;
                    objConTelas.Select();

                    if (objConTelas.dtDados.Rows.Count > 0)
                    {
                        txtCodigo.Text = objConTelas.dtDados.Rows[0][objCaTelas.cdTela].ToString();
                        txtDescricao.Text = objConTelas.dtDados.Rows[0][objCaTelas.nmTela].ToString();
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
            frmCadTelas frmCadTelas = new frmCadTelas();
            frmCadTelas.ShowDialog();
        }
    }
}
