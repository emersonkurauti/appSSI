using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using appSSI;
using System.Data;
using System.Text;
using System.Net.Mail;

namespace wappSSI
{
    public partial class consultardefeitos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ltMensagem.Text = "";

            if (!IsPostBack)
            {
                InicializaTela();
                CarregarDDLSistemas();
            }
        }

        /// <summary>
        /// Inicializa dropdown list e textbox
        /// </summary>
        public void InicializaTela()
        {
            txtSistema.Visible = false;

            ddlModulo.SelectedIndex = -1;
            txtModulo.Visible = false;

            ddlTela.SelectedIndex = -1;
            txtTela.Visible = false;

            ddlAcao.SelectedIndex = -1;
            txtAcao.Visible = false;

            txtDescDefeito.Text = "";

            if (Session["bOpSucesso"] != null && Convert.ToBoolean(Session["bOpSucesso"].ToString()))
            {
                MostraMensagem("Operação realizada!", "A operação foi realizada com sucesso.", "success");
                Session["bOpSucesso"] = null;
            }
        }

        /// <summary>
        /// Carrega dropdown list de sistemas
        /// </summary>
        public void CarregarDDLSistemas()
        {
            conSistemasEmpresas objConSistemasEmpresas = new conSistemasEmpresas();
            caSistemasEmpresas objCaSistemasEmpresas = new caSistemasEmpresas();

            conSistemas objConSistemas = new conSistemas();
            caSistemas objCaSistemas = new caSistemas();

            string strFiltroEmpresas = "";

            try
            {
                objConSistemasEmpresas.objCoSistemasEmpresas.cdEmpresa = Convert.ToInt32(Session["cdEmpresa"].ToString());

                if (!objConSistemasEmpresas.Select())
                {
                    MostraMensagem(csMensagens.msgPadrao, objConSistemasEmpresas.strMensagemErro, "warning");
                    return;
                }

                strFiltroEmpresas = " where cdSistema in (";

                for (int i = 0; i < objConSistemasEmpresas.dtDados.Rows.Count; i++)
                    strFiltroEmpresas += objConSistemasEmpresas.dtDados.Rows[i][objCaSistemasEmpresas.cdSistema].ToString() + ",";

                strFiltroEmpresas = strFiltroEmpresas.Substring(0, strFiltroEmpresas.Length - 1) + ")";

                objConSistemas.objCoSistemas.strFiltro = strFiltroEmpresas;

                if (!objConSistemas.Select())
                {
                    MostraMensagem(csMensagens.msgPadrao, objConSistemas.strMensagemErro, "warning");
                    return;
                }

                txtSistema.Visible = false;
                if (objConSistemas.dtDados.Rows.Count == 0)
                    txtSistema.Visible = true;

                /*DataRow dr = objConSistemas.dtDados.NewRow();
                dr[objCaSistemas.cdSistema] = 0;
                dr[objCaSistemas.nmSistema] = "Outros";
                objConSistemas.dtDados.Rows.Add(dr);*/

                if (objConSistemas.dtDados != null && objConSistemas.dtDados.Rows.Count > 0)
                {
                    ddlSistema.DataSource = objConSistemas.dtDados;
                    ddlSistema.DataValueField = objCaSistemas.cdSistema;
                    ddlSistema.DataTextField = objCaSistemas.nmSistema;
                    ddlSistema.DataBind();
                    ddlSistema.SelectedIndex = 0;

                    CarregarDDLModulos();
                }
            }
            catch
            {
                MostraMensagem(csMensagens.msgPadrao, csMensagens.msgSistema, "warning");
            }
        }

        /// <summary>
        /// Carrega dropdown list de módulos
        /// </summary>
        public void CarregarDDLModulos()
        {
            conModulos objConModulos = new conModulos();
            caModulos objCaModulos = new caModulos();

            try
            {
                objConModulos.objCoModulos.cdSistema = Convert.ToInt32(ddlSistema.SelectedValue.ToString());

                if (!objConModulos.Select())
                {
                    MostraMensagem(csMensagens.msgPadrao, objConModulos.strMensagemErro, "warning");
                    return;
                }

                if (Convert.ToInt32(ddlSistema.SelectedValue.ToString()) == 0)
                    objConModulos.dtDados.Rows.Clear();

                txtModulo.Visible = false;
                if (objConModulos.dtDados.Rows.Count == 0)
                    txtModulo.Visible = true;

                DataRow dr = objConModulos.dtDados.NewRow();
                dr[objCaModulos.cdModulo] = 0;
                dr[objCaModulos.cdSistema] = 0;
                dr[objCaModulos.nmModulo] = "Outros";
                objConModulos.dtDados.Rows.Add(dr);

                if (objConModulos.dtDados != null && objConModulos.dtDados.Rows.Count > 0)
                {
                    ddlModulo.DataSource = objConModulos.dtDados;
                    ddlModulo.DataValueField = objCaModulos.cdModulo;
                    ddlModulo.DataTextField = objCaModulos.nmModulo;
                    ddlModulo.DataBind();
                    ddlModulo.SelectedIndex = 0;

                    CarregarDDLTelas();
                }
            }
            catch
            {
                MostraMensagem(csMensagens.msgPadrao, csMensagens.msgModulo, "warning");
            }
        }

        /// <summary>
        /// Carrega dropdown list de telas
        /// </summary>
        public void CarregarDDLTelas()
        {
            conTelas objConTelas = new conTelas();
            caTelas objCaTelas = new caTelas();

            try
            {
                objConTelas.objCoTelas.cdModulo = Convert.ToInt32(ddlModulo.SelectedValue.ToString());

                if (!objConTelas.Select())
                {
                    MostraMensagem(csMensagens.msgPadrao, objConTelas.strMensagemErro, "warning");
                    return;
                }

                if (Convert.ToInt32(ddlModulo.SelectedValue.ToString()) == 0)
                    objConTelas.dtDados.Rows.Clear();

                txtTela.Visible = false;
                if (objConTelas.dtDados.Rows.Count == 0)
                    txtTela.Visible = true;

                DataRow dr = objConTelas.dtDados.NewRow();
                dr[objCaTelas.cdTela] = 0;
                dr[objCaTelas.cdModulo] = 0;
                dr[objCaTelas.nmTela] = "Outros";
                objConTelas.dtDados.Rows.Add(dr);

                if (objConTelas.dtDados != null && objConTelas.dtDados.Rows.Count > 0)
                {
                    ddlTela.DataSource = objConTelas.dtDados;
                    ddlTela.DataValueField = objCaTelas.cdTela;
                    ddlTela.DataTextField = objCaTelas.nmTela;
                    ddlTela.DataBind();
                    ddlTela.SelectedIndex = 0;

                    CarregarDDLAcoes();
                }
            }
            catch
            {
                MostraMensagem(csMensagens.msgPadrao, csMensagens.msgTela, "warning");
            }
        }

        /// <summary>
        /// Carrega o dropdown list de ações
        /// </summary>
        public void CarregarDDLAcoes()
        {
            conTelasAcoes objConTelasAcoes = new conTelasAcoes();
            caTelasAcoes objCaTelasAcoes = new caTelasAcoes();

            conAcoes objConAcoes = new conAcoes();
            caAcoes objCaAcoes = new caAcoes();

            string strFiltroAcoes = "";

            try
            {
                objConTelasAcoes.objCoTelasAcoes.cdTela = Convert.ToInt32(ddlTela.SelectedValue.ToString());

                if (!objConTelasAcoes.Select())
                {
                    MostraMensagem(csMensagens.msgPadrao, objConTelasAcoes.strMensagemErro, "warning");
                    return;
                }

                strFiltroAcoes = " where cdAcao in (";

                for (int i = 0; i < objConTelasAcoes.dtDados.Rows.Count; i++)
                    strFiltroAcoes += objConTelasAcoes.dtDados.Rows[i][objCaTelasAcoes.cdAcao].ToString() + ",";

                strFiltroAcoes = strFiltroAcoes.Substring(0, strFiltroAcoes.Length - 1) + ")";

                objConAcoes.objCoAcoes.strFiltro = strFiltroAcoes;

                if (!objConAcoes.Select())
                {
                    MostraMensagem(csMensagens.msgPadrao, objConAcoes.strMensagemErro, "warning");
                    return;
                }

                if (Convert.ToInt32(ddlTela.SelectedValue.ToString()) == 0)
                    objConAcoes.dtDados.Rows.Clear();

                txtAcao.Visible = false;
                if (objConAcoes.dtDados.Rows.Count == 0)
                    txtAcao.Visible = true;

                DataRow dr = objConAcoes.dtDados.NewRow();
                dr[objCaAcoes.cdAcao] = 0;
                dr[objCaAcoes.deAcao] = "Outros";
                objConAcoes.dtDados.Rows.Add(dr);

                if (objConAcoes.dtDados != null && objConAcoes.dtDados.Rows.Count > 0)
                {
                    ddlAcao.DataSource = objConAcoes.dtDados;
                    ddlAcao.DataValueField = objCaAcoes.cdAcao;
                    ddlAcao.DataTextField = objCaAcoes.deAcao;
                    ddlAcao.DataBind();
                    ddlAcao.SelectedIndex = 0;
                }
            }
            catch
            {
                MostraMensagem(csMensagens.msgPadrao, csMensagens.msgAcao, "warning");
            }
        }

        protected void ddlSistema_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlModulo.Items.Clear();
            ddlTela.Items.Clear();
            ddlAcao.Items.Clear();

            txtSistema.Visible = false;
            if (Convert.ToInt32(ddlSistema.SelectedValue.ToString()) == 0)
            {
                txtSistema.Text = "";
                txtSistema.Visible = true;
            }

            CarregarDDLModulos();
        }

        protected void ddlModulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlTela.Items.Clear();
            ddlAcao.Items.Clear();

            txtModulo.Visible = false;
            if (Convert.ToInt32(ddlModulo.SelectedValue.ToString()) == 0)
            {
                txtModulo.Text = "";
                txtModulo.Visible = true;
            }

            CarregarDDLTelas();
        }

        protected void ddlTela_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlAcao.Items.Clear();

            txtTela.Visible = false;
            if (Convert.ToInt32(ddlTela.SelectedValue.ToString()) == 0)
            {
                txtTela.Text = "";
                txtTela.Visible = true;
            }

            CarregarDDLAcoes();
        }

        protected void ddlAcao_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAcao.Visible = false;
            if (Convert.ToInt32(ddlAcao.SelectedValue.ToString()) == 0)
            {
                txtAcao.Text = "";
                txtAcao.Visible = true;
            }
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            conConsultaDefeitoTelaAcao objConConsultaDefeitoTelaAcao = new conConsultaDefeitoTelaAcao();
            caConsultaDefeitoTelaAcao objCaConsultaDefeitoTelaAcao = new caConsultaDefeitoTelaAcao();

            if (ddlTela.SelectedValue.ToString() != "" && ddlAcao.SelectedValue.ToString() != "")
            {
                objConConsultaDefeitoTelaAcao.objCoConsultaDefeitoTelaAcao.cdModulo    = Convert.ToInt32(ddlModulo.SelectedValue.ToString());
                objConConsultaDefeitoTelaAcao.objCoConsultaDefeitoTelaAcao.cdTela      = Convert.ToInt32(ddlTela.SelectedValue.ToString());
                objConConsultaDefeitoTelaAcao.objCoConsultaDefeitoTelaAcao.cdAcao      = Convert.ToInt32(ddlAcao.SelectedValue.ToString());
                objConConsultaDefeitoTelaAcao.objCoConsultaDefeitoTelaAcao.flTpUsuario = Convert.ToChar(Session["TpUsuario"].ToString());
                objConConsultaDefeitoTelaAcao.objCoConsultaDefeitoTelaAcao.deDesricao  = txtDescDefeito.Text;

                if (!objConConsultaDefeitoTelaAcao.Select())
                {
                    MostraMensagem(csMensagens.msgPadrao, objConConsultaDefeitoTelaAcao.strMensagemErro, "warning");
                    return;
                }

                if (((objConConsultaDefeitoTelaAcao.objCoConsultaDefeitoTelaAcao.cdModulo == 0) && 
                     (txtModulo.Text.Trim() != "")) ||
                    ((objConConsultaDefeitoTelaAcao.objCoConsultaDefeitoTelaAcao.cdTela == 0) &&
                     (txtTela.Text.Trim() != "")) ||
                    ((objConConsultaDefeitoTelaAcao.objCoConsultaDefeitoTelaAcao.cdAcao == 0) && 
                     (txtAcao.Text.Trim() != "")))
                {
                    string strCorpo = "";

                    strCorpo = strCorpo + "\n" + "Sistema: " + Convert.ToInt32(ddlSistema.SelectedValue.ToString())
                        + " - " + ddlSistema.SelectedItem.Text.ToString();

                    if ((objConConsultaDefeitoTelaAcao.objCoConsultaDefeitoTelaAcao.cdModulo == 0) &&
                        (txtModulo.Text.Trim() != ""))
                        strCorpo = strCorpo + "\n" + "Módulo: " + txtModulo.Text;
                    else
                        if (objConConsultaDefeitoTelaAcao.objCoConsultaDefeitoTelaAcao.cdModulo != 0)
                        {
                            strCorpo = strCorpo + "\n" + "Módulo: " + Convert.ToInt32(ddlModulo.SelectedValue.ToString())
                                                + " - " + ddlModulo.SelectedItem.Text.ToString();
                        }

                    if ((objConConsultaDefeitoTelaAcao.objCoConsultaDefeitoTelaAcao.cdTela == 0) &&
                        (txtTela.Text.Trim() != ""))
                    {
                        strCorpo = strCorpo + "\n" + "Tela: " + txtTela.Text;
                    }
                    else
                        if (objConConsultaDefeitoTelaAcao.objCoConsultaDefeitoTelaAcao.cdTela != 0)
                        {
                            strCorpo = strCorpo + "\n" + "Tela: " + Convert.ToInt32(ddlTela.SelectedValue.ToString())
                                                + " - " + ddlTela.SelectedItem.Text.ToString();
                        }

                    if ((objConConsultaDefeitoTelaAcao.objCoConsultaDefeitoTelaAcao.cdAcao == 0) &&
                        (txtAcao.Text.Trim() != ""))
                    {
                        strCorpo = strCorpo + "\n" + "Ação: " + txtAcao.Text;
                    }
                    else
                        if (objConConsultaDefeitoTelaAcao.objCoConsultaDefeitoTelaAcao.cdAcao != 0)
                        {
                            strCorpo = strCorpo + "\n" + "Ação: " + Convert.ToInt32(ddlAcao.SelectedValue.ToString())
                                                + " - " + ddlAcao.SelectedItem.Text.ToString();
                        }

                    EnviarNotificacao("Solicitação de cadastro", strCorpo);
                }

                Session["cdSistema"]    = Convert.ToInt32(ddlSistema.SelectedValue.ToString());
                Session["nmSistema"]    = ddlSistema.SelectedItem.Text;
                Session["cdModulo"]     = Convert.ToInt32(ddlModulo.SelectedValue.ToString());
                Session["nmModulo"]     = ddlModulo.SelectedItem.Text;
                Session["OutroModulo"]  = txtModulo.Text;
                Session["cdTela"]       = Convert.ToInt32(ddlTela.SelectedValue.ToString());
                Session["nmTela"]       = ddlTela.SelectedItem.Text;
                Session["OutraTela"]    = txtTela.Text;
                Session["cdAcao"]       = Convert.ToInt32(ddlAcao.SelectedValue.ToString());
                Session["deAcao"]       = ddlAcao.SelectedItem.Text;
                Session["OutraAcao"]    = txtAcao.Text;
                Session["descDefeito"]  = txtDescDefeito.Text;
                Session["dtResultados"] = objConConsultaDefeitoTelaAcao.dtDados;
                Response.Redirect("resultadodefeitos.aspx");
            }
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

        public void EnviarNotificacao(string strAssunto, string strCorpo)
        {
            MailMessage mail = new MailMessage();
            mail.To.Add(csConstantes.emailDestinatario);

            mail.From = new MailAddress(csConstantes.emailRemetente, "SSI Notificação", System.Text.Encoding.UTF8);

            mail.Subject = strAssunto;
            mail.SubjectEncoding = System.Text.Encoding.UTF8;
            mail.Body = strCorpo;
            mail.BodyEncoding = System.Text.Encoding.UTF8;
            mail.IsBodyHtml = false;
            mail.Priority = MailPriority.High; //Prioridade do E-Mail 
            
            SmtpClient client = new SmtpClient();  //Adicionando as credenciais do seu e-mail e senha:
            client.Credentials = new System.Net.NetworkCredential(csConstantes.emailRemetente, csConstantes.senhaEmailRemetente);
            client.Port = 587; // Esta porta é a utilizada pelo Gmail para envio

            if (csConstantes.emailRemetente.IndexOf("@hotmail.com") > 0)
                client.Host = "smtp.live.com"; //Definindo o provedor que irá disparar o e-mail

            if (csConstantes.emailRemetente.IndexOf("@gmail.com") > 0)
                client.Host = "smtp.gmail.com"; //Definindo o provedor que irá disparar o e-mail

            if (csConstantes.emailRemetente.IndexOf("@db1.com.br") > 0)
                client.Host = "mail.db1.com.br"; //Definindo o provedor que irá disparar o e-mail
            
            
            client.EnableSsl = true; //Gmail trabalha com Server Secured Layer

            try
            {
               client.Send(mail);
            }
            catch
            {
            }
        }
    }
}