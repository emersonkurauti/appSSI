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
    public partial class detalhesdefeito : System.Web.UI.Page
    {
        DataTable dtSolucoes;
        DataTable dtDefeitos;
        caDefeitos objCaDefeitos = new caDefeitos();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                InicializaPagina();
        }

        public void InicializaPagina()
        {
            ltMensagem.Text = "";

            CarregarPaginacao();
            CarregarDadosDefeito();
            CarregarSolucoes();
        }

        public void CarregarPaginacao()
        {
            int indiceDefeito = Convert.ToInt32(Session["IndiceDefeito"].ToString());
            int qtdDefeitos = Convert.ToInt32(Session["QtdDefeitos"].ToString());

            imgbtnNext.Enabled = true;
            imgbtnPrevious.Enabled = true;

            if (indiceDefeito == (qtdDefeitos - 1))
                imgbtnNext.Enabled = false;

            if (indiceDefeito == 0)
                imgbtnPrevious.Enabled = false;
        }

        public void CarregarDadosDefeito()
        {
            conDefeitos objConDefeitos = new conDefeitos();
            caDefeitos objCaDefeitos = new caDefeitos();

            objConDefeitos.objCoDefeitos.cdDefeito = Convert.ToInt32(Session["cdDefeito"].ToString());

            if (!objConDefeitos.Select())
            {
                MostraMensagem(csMensagens.msgPadrao, objConDefeitos.strMensagemErro, "danger");
                return;
            }

            CarregarImagens();

            lblDescDefeito.Text = objConDefeitos.dtDados.Rows[0][objCaDefeitos.deDefeito].ToString();
        }

        public void CarregarImagens()
        {
            conImagens objConImagens = new conImagens(csConstantes.cDefeito);
            caImagensDefeitos objCaImagensDefeitos = new caImagensDefeitos();
            StringBuilder sbSlide = new StringBuilder();
            StringBuilder sbImagens = new StringBuilder();

            objConImagens.objCoImagensDefeitos.cdDefeito = Convert.ToInt32(Session["cdDefeito"].ToString());

            if (!objConImagens.Select())
            {
                MostraMensagem(csMensagens.msgPadrao, objConImagens.strMensagemErro, "danger");
                return;
            }

            if(objConImagens.dtDados.Rows.Count > 0)
            {
                sbSlide.AppendLine("<li data-target=\"#carouselimagens\" data-slide-to=\"0\" class=\"active\"></li>");

                sbImagens.AppendLine("<div class=\"item active\">");

                sbImagens.AppendLine("<div class=\"alert alert-info\" role=\"alert\">");
                sbImagens.AppendLine(objConImagens.dtDados.Rows[0][objCaImagensDefeitos.deImagem].ToString());
                sbImagens.AppendLine("</div>");

                sbImagens.AppendLine("<input type=\"image\" name=\"ImageBtn\" ID=\"ImageBtn\" onclick=\"Visualizar('" +
                        wappSSI.Properties.Settings.Default.sCaminhoImgDefeitoSvr + objConImagens.dtDados.Rows[0][objCaImagensDefeitos.blImagem].ToString() +
                        "', '700', '700')\" runat=\"server\" style=\"height:250px\" src=\"" +
                        wappSSI.Properties.Settings.Default.sCaminhoImgDefeitoSvr + objConImagens.dtDados.Rows[0][objCaImagensDefeitos.blImagem].ToString() +                    
                        "\" alt=\"" + objConImagens.dtDados.Rows[0][objCaImagensDefeitos.deImagem].ToString() + "\"/>");

                sbImagens.AppendLine("</div>");

                for (int i = 1; i < objConImagens.dtDados.Rows.Count; i++)
                {
                    sbSlide.AppendLine("<li data-target=\"#carouselimagens\" data-slide-to=\"" + i.ToString() + "\"></li>");

                    sbImagens.AppendLine("<div class=\"item\">");

                    sbImagens.AppendLine("<div class=\"alert alert-info\" role=\"alert\">");
                    sbImagens.AppendLine(objConImagens.dtDados.Rows[i][objCaImagensDefeitos.deImagem].ToString());
                    sbImagens.AppendLine("</div>");

                    sbImagens.AppendLine("<input type=\"image\" name=\"ImageBtn\" ID=\"ImageBtn\" onclick=\"Visualizar('" +
                        wappSSI.Properties.Settings.Default.sCaminhoImgDefeitoSvr + objConImagens.dtDados.Rows[i][objCaImagensDefeitos.blImagem].ToString() + 
                        "', '700', '700')\" runat=\"server\" style=\"height:250px\" src=\"" +
                        wappSSI.Properties.Settings.Default.sCaminhoImgDefeitoSvr + objConImagens.dtDados.Rows[i][objCaImagensDefeitos.blImagem].ToString() +
                        "\" alt=\"" + objConImagens.dtDados.Rows[i][objCaImagensDefeitos.deImagem].ToString() + "\"/>");
                    sbImagens.AppendLine("</div>");
                }
            }

            listSlide.Text = sbSlide.ToString();
            listImagem.Text = sbImagens.ToString();
        }

        public void CarregarSolucoes()
        {
            conConsultaDefeitoTelaAcao objConConsultaDefeitoTelaAcao = new conConsultaDefeitoTelaAcao();
            caSolucoes objCaSolucoes = new caSolucoes();

            objConConsultaDefeitoTelaAcao.objCoConsultaDefeitoTelaAcao.cdDefeito = Convert.ToInt32(Session["cdDefeito"].ToString());
            objConConsultaDefeitoTelaAcao.objCoConsultaDefeitoTelaAcao.flTpUsuario = Session["TpUsuario"].ToString()[0];

            if (!objConConsultaDefeitoTelaAcao.SelectSolucaoDefeito())
            {
                MostraMensagem(csMensagens.msgPadrao, objConConsultaDefeitoTelaAcao.strMensagemErro, "danger");
                return;
            }

            dtSolucoes = objConConsultaDefeitoTelaAcao.dtDados;
            Session["dtSolucoes"] = dtSolucoes;

            gvSolucoes.AutoGenerateColumns = false;
            gvSolucoes.DataSource = dtSolucoes;
            gvSolucoes.DataBind();
        }

        protected void gvSolucoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["cdSolucao"] = Convert.ToInt32(gvSolucoes.DataKeys[gvSolucoes.SelectedRow.RowIndex]["cdSolucao"].ToString());
            Session["IndiceSolucao"] = gvSolucoes.SelectedRow.RowIndex;
            Session["QtdSolucoes"] = gvSolucoes.Rows.Count;

            Response.Redirect("detalhessolucao.aspx");
        }

        protected void imgbtnNext_Click(object sender, EventArgs e)
        {
            int qtdDefeitos = Convert.ToInt32(Session["QtdDefeitos"].ToString());
            int indiceDefeito = Convert.ToInt32(Session["IndiceDefeito"].ToString());

            if (indiceDefeito < (qtdDefeitos - 1))
            {
                dtDefeitos = (DataTable)Session["dtResultados"];
                Session["IndiceDefeito"] = ++indiceDefeito;
                Session["cdDefeito"] = Convert.ToInt32(dtDefeitos.Rows[indiceDefeito][objCaDefeitos.cdDefeito].ToString());

                InicializaPagina();

                if (indiceDefeito == (qtdDefeitos - 1))
                {
                    imgbtnNext.Enabled = false;
                    imgbtnPrevious.Enabled = true;
                }
                else
                    imgbtnNext.Enabled = true;
            }
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("resultadodefeitos.aspx");
        }

        protected void imgbtnPrevious_Click(object sender, EventArgs e)
        {
            int indiceDefeito = Convert.ToInt32(Session["IndiceDefeito"].ToString());

            if (indiceDefeito > 0)
            {
                dtDefeitos = (DataTable)Session["dtResultados"];
                Session["IndiceDefeito"] = --indiceDefeito;
                Session["cdDefeito"] = Convert.ToInt32(dtDefeitos.Rows[indiceDefeito][objCaDefeitos.cdDefeito].ToString());

                InicializaPagina();

                if (indiceDefeito == 0)
                {
                    imgbtnPrevious.Enabled = false;
                    imgbtnNext.Enabled = true;
                }
                else
                    imgbtnPrevious.Enabled = true;
            }
        }

        protected void lnkNenhumaSolucaoEncontrada_Click(object sender, EventArgs e)
        {
            //Defeito sem solução - add na observação o motivo da nao solução            
            //Indicar se nenhuma solução foi válida ou se não existe solução cadastrada
            caParametros objCaParametros = new caParametros();
            conParametros objConParametros = new conParametros();
            caIndicador objCaIndicador = new caIndicador();
            conIndicadores objConIndicadores = new conIndicadores();
            DataTable dtParametros = objConParametros.objCoParametros.RetornaEstruturaDT();

            objConIndicadores.objCoIndicador.cdUsuario = Convert.ToInt32(Session["cdUsuario"].ToString());
            objConIndicadores.objCoIndicador.cdDefeito = Convert.ToInt32(Session["cdDefeito"].ToString());
            objConIndicadores.objCoIndicador.cdSolucao = 0;
            objConIndicadores.objCoIndicador.flResultado = 'N';

            dtSolucoes = (DataTable)Session["dtSolucoes"];

            if (dtSolucoes.Rows.Count > 0)
                objConIndicadores.objCoIndicador.deObservacao = "Nenhuma solução válida.";
            else
                objConIndicadores.objCoIndicador.deObservacao = "Nenhuma solução cadastrada.";

            DataRow dr;
            dr = dtParametros.NewRow(); //Sistema
            dr[objCaParametros.nmParametro] = "Sistema";
            dr[objCaParametros.vlParametro] = Session["cdSistema"].ToString();
            dtParametros.Rows.Add(dr);

            dr = dtParametros.NewRow();//Módulo
            dr[objCaParametros.nmParametro] = "Modulo";
            dr[objCaParametros.vlParametro] = Session["cdModulo"].ToString();
            dtParametros.Rows.Add(dr);

            dr = dtParametros.NewRow();//Tela
            dr[objCaParametros.nmParametro] = "Tela";
            dr[objCaParametros.vlParametro] = Session["cdTela"].ToString();
            dtParametros.Rows.Add(dr);

            dr = dtParametros.NewRow();//Ação
            dr[objCaParametros.nmParametro] = "Acao";
            dr[objCaParametros.vlParametro] = Session["cdAcao"].ToString();
            dtParametros.Rows.Add(dr);

            dr = dtParametros.NewRow();//DescDefeito
            dr[objCaParametros.nmParametro] = "DescDefeito";
            dr[objCaParametros.vlParametro] = Session["descDefeito"].ToString();
            dtParametros.Rows.Add(dr);

            dr = dtParametros.NewRow();//Data da consulta
            dr[objCaParametros.nmParametro] = "dtConsulta";
            dr[objCaParametros.vlParametro] = DateTime.Now;
            dtParametros.Rows.Add(dr);

            dr = dtParametros.NewRow();//Usuário
            dr[objCaParametros.nmParametro] = "Usuario";
            dr[objCaParametros.vlParametro] = Session["cdUsuario"];
            dtParametros.Rows.Add(dr);

            objConIndicadores.objCoIndicador.dtParametros = dtParametros;

            if (!objConIndicadores.Inserir())
            {
                MostraMensagem(csMensagens.msgPadrao, objConIndicadores.strMensagemErro, "danger");
                return;
            }

            string strCorpo = "";

            strCorpo = "Código do Defeito: " + objConIndicadores.objCoIndicador.cdDefeito.ToString();
            strCorpo = strCorpo + "\n" + "Sistema: " + Session["cdSistema"].ToString() + " - " + Session["nmSistema"].ToString();
            strCorpo = strCorpo + "\n" + "Modulo: "  + Session["cdModulo"].ToString()  + " - " + Session["nmModulo"].ToString();
            strCorpo = strCorpo + "\n" + "Tela: "    + Session["cdTela"].ToString()    + " - " + Session["nmTela"].ToString();
            strCorpo = strCorpo + "\n" + "Ação: "    + Session["cdAcao"].ToString()    + " - " + Session["deAcao"].ToString();
            strCorpo = strCorpo + "\n" + "Usuário: " + Session["nmUsuario"].ToString();

            //Soluções de nível suporte
            conConsultaDefeitoTelaAcao objConConsultaDefeitoTelaAcao = new conConsultaDefeitoTelaAcao();
            caConsultaDefeitoTelaAcao objCaConsultaDefeitoTelaAcao = new caConsultaDefeitoTelaAcao();

            if (Session["cdDefeito"] != null && Session["cdDefeito"].ToString() != "")
            {
                objConConsultaDefeitoTelaAcao.objCoConsultaDefeitoTelaAcao.cdDefeito = Convert.ToInt32(Session["cdDefeito"].ToString());
                objConConsultaDefeitoTelaAcao.objCoConsultaDefeitoTelaAcao.bSomenteSuporte = true;

                if (!objConConsultaDefeitoTelaAcao.SelectSolucaoDefeito())
                {
                    MostraMensagem(csMensagens.msgPadrao, objConConsultaDefeitoTelaAcao.strMensagemErro, "danger");
                    return;
                }

                if (objConConsultaDefeitoTelaAcao.dtDados.Rows.Count > 0)
                {
                    strCorpo += "\n\n Soluções de nível suporte para o defeito:\n";

                    foreach (DataRow dtr in objConConsultaDefeitoTelaAcao.dtDados.Rows)
                    {
                        strCorpo += "Código: " + dtr[objCaConsultaDefeitoTelaAcao.cdSolucao].ToString() + "\n";
                    }
                }
            }

            EnviarNotificacao("Defeito sem solução", strCorpo);

            Session["bOpSucesso"] = true;
            Response.Redirect("consultardefeitos.aspx");
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
            mail.To.Add(wappSSI.Properties.Settings.Default.emailDestinatario);

            mail.From = new MailAddress(wappSSI.Properties.Settings.Default.emailRemetente, "SSI Notificação", System.Text.Encoding.UTF8);

            mail.Subject = strAssunto;
            mail.SubjectEncoding = System.Text.Encoding.UTF8;
            mail.Body = strCorpo;
            mail.BodyEncoding = System.Text.Encoding.UTF8;
            mail.IsBodyHtml = false;
            mail.Priority = MailPriority.High; //Prioridade do E-Mail 

            SmtpClient client = new SmtpClient();  //Adicionando as credenciais do seu e-mail e senha:
            client.Credentials = new System.Net.NetworkCredential(wappSSI.Properties.Settings.Default.emailRemetente, wappSSI.Properties.Settings.Default.chaveRemetente);
            client.Port = 587; // Esta porta é a utilizada pelo Gmail para envio

            if (wappSSI.Properties.Settings.Default.emailRemetente.IndexOf("@hotmail.com") > 0)
                client.Host = "smtp.live.com"; //Definindo o provedor que irá disparar o e-mail

            if (wappSSI.Properties.Settings.Default.emailRemetente.IndexOf("@gmail.com") > 0)
                client.Host = "smtp.gmail.com"; //Definindo o provedor que irá disparar o e-mail

            if (wappSSI.Properties.Settings.Default.emailRemetente.IndexOf("@db1.com.br") > 0)
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

        protected void gvSolucoes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvSolucoes.PageIndex = e.NewPageIndex;

            gvSolucoes.DataSource = (DataTable)Session["dtSolucoes"];
            gvSolucoes.DataBind();
        }
    }
}