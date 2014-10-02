using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace appSSI
{
    public partial class ucModulosCons : KuraFrameWork.Componentes_Visuais.ucConsulta
    {
        conModulos objConModulos;
        caModulos objCaModulos;

        private int _cdSistema;
        public int cdSistema
        {
            get { return _cdSistema; }
            set { _cdSistema = value; }
        }

        public ucModulosCons()
        {
            InitializeComponent();
            objConModulos = new conModulos();
            objCaModulos = new caModulos();
        }

        public override void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsModulos form = new frmConsModulos();
            form.cdSistema = _cdSistema;
            form.ShowDialog();

            if (form.cdModulo != 0)
            {
                txtCodigo.Text = form.cdModulo.ToString();
                txtDescricao.Text = form.nmModulo.ToString();
            }
        }

        public override void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                if (Convert.ToInt32(txtCodigo.Text) >= 0)
                {
                    objConModulos.objCoModulos.LimparAtributos();

                    string strFiltro = RetornaFiltro();

                    if (strFiltro != "")
                    {
                        objConModulos.objCoModulos.strFiltro = strFiltro;
                    }
                    else
                    {
                        objConModulos.objCoModulos.cdModulo = Convert.ToInt32(txtCodigo.Text);
                        objConModulos.objCoModulos.cdSistema = _cdSistema;
                    }
                    objConModulos.Select();

                    if (objConModulos.dtDados.Rows.Count > 0)
                    {
                        txtCodigo.Text = objConModulos.dtDados.Rows[0][objCaModulos.cdModulo].ToString();
                        txtDescricao.Text = objConModulos.dtDados.Rows[0][objCaModulos.nmModulo].ToString();
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
                txtCodigo.Text = "";
                txtDescricao.Text = "";
            }
        }

        public void Carregar()
        {
            txtCodigo_Leave(null, null);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadModulos frmCadModulos = new frmCadModulos();
            frmCadModulos.ShowDialog();
        }

        private string RetornaFiltro()
        {
            string _strCondicao = "";

            if ((Convert.ToInt32(txtCodigo.Text.Trim()) == 0))
            {
                _strCondicao = " WHERE cdModulo = " + txtCodigo.Text.Trim();

                if (_cdSistema != 0)
                    _strCondicao += " AND cdSistema = " + _cdSistema;
            }
            
            return _strCondicao;
        }
    }
}
