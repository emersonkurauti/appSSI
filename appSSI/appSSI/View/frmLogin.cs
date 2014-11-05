using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace appSSI
{
    public partial class frmLogin : KuraFrameWork.Formularios.ucLogin
    {
        private coUsuarios _objUsuario;
        private conUsuarios objConUsuario;

        public coUsuarios objUsuario
        {
            get { return _objUsuario; }
            set { _objUsuario = value; }
        }

        public frmLogin()
        {
            InitializeComponent();
            objConUsuario = new conUsuarios();
        }

        public override void btnConfirmar_Click(object sender, EventArgs e)
        {
            objConUsuario.objCoUsuarios.deLogin = txtUsuario.Text.Trim();
            objConUsuario.objCoUsuarios.deSenha = txtSenha.Text.Trim();

            objConUsuario.ValidarUsuario();

            if (objConUsuario.dtDados == null || objConUsuario.dtDados.Rows.Count == 0)
            {
                MessageBox.Show(objConUsuario.strMensagemErro);

                txtUsuario.Clear();
                txtSenha.Clear();
                txtUsuario.Focus();
            }
            else
            {
                if (objConUsuario.objCoUsuarios.flTpUsuario == csConstantes.cCliente)
                {
                    MessageBox.Show(csMensagens.msgUsuarioSemPermissao);

                    txtUsuario.Clear();
                    txtSenha.Clear();
                    txtUsuario.Focus();
                }
                else
                {
                    _objUsuario = objConUsuario.RetornaObjUsuario(objConUsuario.dtDados);
                    _objUsuario = objConUsuario.objCoUsuarios;
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

    }
}
