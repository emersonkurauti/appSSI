using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using appSSI;

namespace wappSSI
{
    public partial class frmLogin : System.Web.UI.Page
    {
        conUsuarios objConUsuarios = new conUsuarios();
        caUsuarios objCaUsuarios = new caUsuarios();

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["cdUsuario"] = null;
            Session["Senha"] = null;
            Session["TpUsuario"] = null;
            Session["cdEmpresa"] = null;
        }

        public void Mensagem(string sMensagem, Page Pagina)
        {
            ScriptManager.RegisterStartupScript(Pagina,
                this.GetType(), "Aviso", "<script language='javascript'>alert('" +
                sMensagem + "');</script>", false);
        }

        /// <summary>
        /// Autenticação do usuário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Login_Authenticate(object sender, AuthenticateEventArgs e)
        {
            objConUsuarios.objCoUsuarios.LimparAtributos();
            objConUsuarios.objCoUsuarios.deLogin = Login.UserName.ToString();
            objConUsuarios.objCoUsuarios.deSenha = Login.Password.ToString();

            if (!objConUsuarios.Select())
            {
                Mensagem(csMensagens.msgUsuario, Page);
                return;
            }

            if (objConUsuarios.dtDados != null && objConUsuarios.dtDados.Rows.Count > 0)
            {
                if (objConUsuarios.dtDados.Rows[0][objCaUsuarios.flAtivo].ToString() == "S")
                {
                    e.Authenticated = true;
                    Session["cdUsuario"] = objConUsuarios.dtDados.Rows[0][objCaUsuarios.deLogin].ToString();
                    Session["Senha"] = objConUsuarios.dtDados.Rows[0][objCaUsuarios.deSenha].ToString();
                    Session["TpUsuario"] = objConUsuarios.dtDados.Rows[0][objCaUsuarios.flTpUsuario].ToString();
                    Session["cdEmpresa"] = objConUsuarios.dtDados.Rows[0][objCaUsuarios.cdEmpresa].ToString();

                    Response.Redirect("frmConsultarDefeito.aspx");
                }
                else
                {
                    e.Authenticated = false;
                    Login.FailureText = "Usuário inativo.";
                }
            }
            else
                e.Authenticated = false;
        }
    }
}