using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using appSSI;
using System.Text;

namespace wappSSI
{
    public partial class login : System.Web.UI.Page
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

        /// <summary>
        /// Autenticação do usuário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            objConUsuarios.objCoUsuarios.LimparAtributos();
            objConUsuarios.objCoUsuarios.deLogin = txtUsuario.Text;
            objConUsuarios.objCoUsuarios.deSenha = txtSenha.Text;

            if (!objConUsuarios.Select())
            {
                MostraMensagem(csMensagens.msgPadrao, csMensagens.msgUsuario, "danger");
                return;
            }

            if (objConUsuarios.dtDados != null && objConUsuarios.dtDados.Rows.Count > 0)
            {
                if (objConUsuarios.dtDados.Rows[0][objCaUsuarios.flAtivo].ToString() == "S")
                {
                    Session["cdUsuario"] = objConUsuarios.dtDados.Rows[0][objCaUsuarios.cdUsuario].ToString();
                    Session["Senha"] = objConUsuarios.dtDados.Rows[0][objCaUsuarios.deSenha].ToString();
                    Session["TpUsuario"] = objConUsuarios.dtDados.Rows[0][objCaUsuarios.flTpUsuario].ToString();
                    Session["cdEmpresa"] = objConUsuarios.dtDados.Rows[0][objCaUsuarios.cdEmpresa].ToString();

                    Response.Redirect("consultardefeitos.aspx");
                    //Response.Redirect("frmConsultarDefeito.aspx");
                }
                else
                    MostraMensagem("Usuário inativo!", "Entre em contato com o suporte.", "danger");
            }
            else
                MostraMensagem("Usuário/Senha inválido!", "Tente novamente.", "warning");
        }

        public void MostraMensagem(string strMensagemTitulo, string strMensagemDesc, string tpMensagem)
        {
            StringBuilder sbMsgSucesso = new StringBuilder();

            sbMsgSucesso.AppendLine("<br />");
            sbMsgSucesso.AppendLine("<div class=\"alert alert-" + tpMensagem + "\" role=\"alert\">");
            sbMsgSucesso.AppendLine("<strong>" + strMensagemTitulo + "</strong>");
            sbMsgSucesso.AppendLine("<br />");
            sbMsgSucesso.AppendLine(strMensagemDesc);
            sbMsgSucesso.AppendLine("</div>");

            ltMensagem.Text = sbMsgSucesso.ToString();
        }
    }
}