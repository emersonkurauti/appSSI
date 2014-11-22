using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace appSSI
{
    public partial class ucAcoesCons : KuraFrameWork.Componentes_Visuais.ucConsulta
    {
        conAcoes objConAcoes;
        caAcoes objCaAcoes;

        conTelasAcoes objConTelasAcoes;
        caTelasAcoes objCaTelasAcoes;

        private int _cdTela;
        public int cdTela
        {
            get { return _cdTela; }
            set { _cdTela = value; }
        }

        public ucAcoesCons()
        {
            InitializeComponent();
            objConAcoes = new conAcoes();
            objCaAcoes = new caAcoes();

            objConTelasAcoes = new conTelasAcoes();
            objCaTelasAcoes = new caTelasAcoes();
        }

        public override void btnConsultar_Click(object sender, EventArgs e)
        {
            if (_cdTela == 0)
            {
                frmConsAcoes form = new frmConsAcoes();
                form.ShowDialog();

                if (form.cdAcao != 0)
                {
                    txtCodigo.Text = form.cdAcao.ToString();
                    txtDescricao.Text = form.deAcao.ToString();
                }
            }
            else
            {
                frmConsAcoesTelas form = new frmConsAcoesTelas();
                form.cdTela = _cdTela;
                form.ShowDialog();

                if (form.cdAcao != 0)
                {
                    txtCodigo.Text = form.cdAcao.ToString();
                    txtDescricao.Text = form.deAcao.ToString();
                }
            }
        }

        public override void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                if (Convert.ToInt32(txtCodigo.Text) >= 0)
                {
                    if (_cdTela == 0)
                    {
                        objConAcoes.objCoAcoes.LimparAtributos();
                        objConAcoes.objCoAcoes.cdAcao = Convert.ToInt32(txtCodigo.Text);
                        objConAcoes.Select();

                        if (objConAcoes.dtDados.Rows.Count > 0)
                        {
                            txtCodigo.Text = objConAcoes.dtDados.Rows[0][objCaAcoes.cdAcao].ToString();
                            txtDescricao.Text = objConAcoes.dtDados.Rows[0][objCaAcoes.deAcao].ToString();
                        }
                        else
                        {
                            LimparCampos();
                            MessageBox.Show(csMensagens.msgErroConsultar);
                        }
                    }
                    else
                    {
                        objConTelasAcoes.objCoTelasAcoes.LimparAtributos();
                        objConTelasAcoes.objCoTelasAcoes.cdAcao = Convert.ToInt32(txtCodigo.Text);
                        objConTelasAcoes.objCoTelasAcoes.cdTela = _cdTela;
                        objConTelasAcoes.Select();

                        if (objConTelasAcoes.dtDados.Rows.Count > 0)
                        {
                            txtCodigo.Text = objConTelasAcoes.dtDados.Rows[0][objCaTelasAcoes.cdAcao].ToString();
                            txtDescricao.Text = objConTelasAcoes.dtDados.Rows[0][objCaTelasAcoes.CC_deAcao].ToString();
                        }
                        else
                        {
                            LimparCampos();
                            MessageBox.Show(csMensagens.msgErroConsultar);
                        }
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
            frmCadAcoes frmCadAcoes = new frmCadAcoes();
            frmCadAcoes.ShowDialog();

            int codigo;

            int.TryParse(frmCadAcoes.txtCodigo.Text, out codigo);

            if (codigo > 0)
            {
                txtCodigo.Text = codigo.ToString();
                txtCodigo_Leave(null, null);
            }
        }
    }
}
