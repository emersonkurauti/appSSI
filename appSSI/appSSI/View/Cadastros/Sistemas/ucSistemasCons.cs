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

        private int _cdEmpresa;
        public int cdEmpresa
        {
            get { return _cdEmpresa; }
            set { _cdEmpresa = value; }
        }

        public ucSistemasCons()
        {
            InitializeComponent();
            objConSistemas = new conSistemas();
            objCaSistemas = new caSistemas();
        }

        public override void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsSistemas form = new frmConsSistemas();
            form.strFiltro = RetornaFiltroListaSistemas();
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

                    string strFiltro = RetornaFiltroListaSistemas();

                    if (strFiltro == "")
                        objConSistemas.objCoSistemas.cdSistema = Convert.ToInt32(txtCodigo.Text);
                    else
                        objConSistemas.objCoSistemas.strFiltro = strFiltro;

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

        private string RetornaFiltroListaSistemas()
        {
            string _sListaSistemas = "";
            string _strCondicao = "";

            if (_cdEmpresa != 0)
            {
                conSistemasEmpresas objconSistemasEmpresas = new conSistemasEmpresas();
                caSistemasEmpresas objcaSistemasEmpresas = new caSistemasEmpresas();

                objconSistemasEmpresas.objCoSistemasEmpresas.cdEmpresa = _cdEmpresa;

                if (!objconSistemasEmpresas.Select())
                {
                    MessageBox.Show(objconSistemasEmpresas.strMensagemErro);
                    return "";
                }

                if (objconSistemasEmpresas.dtDados.Rows.Count > 0)
                {
                    _sListaSistemas = "";
                    _strCondicao = " where cdSistema in (";

                    for (int i = 0; i < objconSistemasEmpresas.dtDados.Rows.Count; i++)
                    {
                        _sListaSistemas += objconSistemasEmpresas.dtDados.Rows[i][objcaSistemasEmpresas.cdSistema].ToString() + ",";
                    }

                    _sListaSistemas = _sListaSistemas.Substring(0, _sListaSistemas.Length - 1);

                    _sListaSistemas += ")";

                    if (txtCodigo.Text.Trim() != "")
                        _sListaSistemas += " AND cdSistema = " + txtCodigo.Text.Trim();

                    _strCondicao += _sListaSistemas;
                }
            }

            return _strCondicao;
        }
    }
}
