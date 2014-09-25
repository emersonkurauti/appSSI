using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using appSSI;
using System.Data;
using System.Text;

namespace wappSSI
{
    public partial class detalhessolucao : System.Web.UI.Page
    {
        DataTable dtSolucoes;
        caSolucoes objCaSolucoes = new caSolucoes();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                InicializaPagina();
        }

        public void InicializaPagina()
        {
            ltMensagem.Text = "";
            CarregarPaginacao();
            CarregarDadosSolucao();
        }

        public void CarregarDadosSolucao()
        {
            conSolucoes objConSolucoes = new conSolucoes();
            caSolucoes objCaSolucoes = new caSolucoes();

            objConSolucoes.objCoSolucoes.cdSolucao = Convert.ToInt32(Session["cdSolucao"].ToString());

            if (!objConSolucoes.Select())
            {
                MostraMensagem(csMensagens.msgPadrao, objConSolucoes.strMensagemErro, "danger");
                return;
            }

            CarregarImagens();

            lblDescSolucao.Text = objConSolucoes.dtDados.Rows[0][objCaSolucoes.deSolucao].ToString();
        }

        public void CarregarPaginacao()
        {
            int indiceSolucao = Convert.ToInt32(Session["IndiceSolucao"].ToString());
            int qtdSolucoes = Convert.ToInt32(Session["QtdSolucoes"].ToString());

            imgbtnPrevious.Enabled = true;
            imgbtnNext.Enabled = true;

            if (indiceSolucao == (qtdSolucoes - 1))
                imgbtnNext.Enabled = false;

            if (indiceSolucao == 0)
                imgbtnPrevious.Enabled = false;
        }

        public void CarregarImagens()
        {
            conImagens objConImagens = new conImagens(csConstantes.cSolucao);
            caImagensSolucoes objCaImagensSolucoes = new caImagensSolucoes();
            StringBuilder sbSlide = new StringBuilder();
            StringBuilder sbImagens = new StringBuilder();

            objConImagens.objCoImagensSolucoes.cdSolucao = Convert.ToInt32(Session["cdSolucao"].ToString());

            if (!objConImagens.Select())
            {
                MostraMensagem(csMensagens.msgPadrao, objConImagens.strMensagemErro, "danger");
                return;
            }

            if (objConImagens.dtDados.Rows.Count > 0)
            {
                sbSlide.AppendLine("<li data-target=\"#carouselimagens\" data-slide-to=\"0\" class=\"active\"></li>");
                sbImagens.AppendLine("<div class=\"item active\">");

                sbImagens.AppendLine("<div class=\"alert alert-info\" role=\"alert\">");
                sbImagens.AppendLine(objConImagens.dtDados.Rows[0][objCaImagensSolucoes.deImagem].ToString());
                sbImagens.AppendLine("</div>");

                sbImagens.AppendLine("<input type=\"image\" name=\"ImageBtn\" ID=\"ImageBtn\" onclick=\"Visualizar('" +
                        csConstantes.sCaminhoImgSolucoesSvr + objConImagens.dtDados.Rows[0][objCaImagensSolucoes.blImagem].ToString() +
                        "', '700', '700')\" runat=\"server\" style=\"height:250px\" src=\"" +
                        csConstantes.sCaminhoImgSolucoesSvr + objConImagens.dtDados.Rows[0][objCaImagensSolucoes.blImagem].ToString() +
                        "\" alt=\"" + objConImagens.dtDados.Rows[0][objCaImagensSolucoes.deImagem].ToString() + "\"/>");
                sbImagens.AppendLine("</div>");

                for (int i = 1; i < objConImagens.dtDados.Rows.Count; i++)
                {
                    sbSlide.AppendLine("<li data-target=\"#carouselimagens\" data-slide-to=\"" + i.ToString() + "\"></li>");
                    sbImagens.AppendLine("<div class=\"item\">");

                    sbImagens.AppendLine("<div class=\"alert alert-info\" role=\"alert\">");
                    sbImagens.AppendLine(objConImagens.dtDados.Rows[i][objCaImagensSolucoes.deImagem].ToString());
                    sbImagens.AppendLine("</div>");

                    sbImagens.AppendLine("<input type=\"image\" name=\"ImageBtn\" ID=\"ImageBtn\" onclick=\"Visualizar('" +
                        csConstantes.sCaminhoImgSolucoesSvr + objConImagens.dtDados.Rows[i][objCaImagensSolucoes.blImagem].ToString() +
                        "', '700', '700')\" runat=\"server\" style=\"height:250px\" src=\"" +
                        csConstantes.sCaminhoImgSolucoesSvr + objConImagens.dtDados.Rows[i][objCaImagensSolucoes.blImagem].ToString() +
                        "\" alt=\"" + objConImagens.dtDados.Rows[i][objCaImagensSolucoes.deImagem].ToString() + "\"/>");
                    sbImagens.AppendLine("</div>");
                }
            }

            listSlide.Text = sbSlide.ToString();
            listImagem.Text = sbImagens.ToString();
        }

        protected void imgbtnPrevious_Click(object sender, EventArgs e)
        {
            int indiceSolucao = Convert.ToInt32(Session["IndiceSolucao"].ToString());

            if (indiceSolucao > 0)
            {
                dtSolucoes = (DataTable)Session["dtSolucoes"];
                Session["IndiceSolucao"] = --indiceSolucao;
                Session["cdSolucao"] = Convert.ToInt32(dtSolucoes.Rows[indiceSolucao][objCaSolucoes.cdSolucao].ToString());

                InicializaPagina();

                if (indiceSolucao == 0)
                {
                    imgbtnPrevious.Enabled = false;
                    imgbtnNext.Enabled = true;
                }
                else
                    imgbtnPrevious.Enabled = true;
            }
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("detalhesdefeito.aspx");
        }

        protected void imgbtnNext_Click(object sender, EventArgs e)
        {
            int qtdSolucoes = Convert.ToInt32(Session["QtdSolucoes"].ToString());
            int indiceSolucao = Convert.ToInt32(Session["IndiceSolucao"].ToString());

            if (indiceSolucao < (qtdSolucoes - 1))
            {
                dtSolucoes = (DataTable)Session["dtSolucoes"];
                Session["IndiceSolucao"] = ++indiceSolucao;
                Session["cdSolucao"] = Convert.ToInt32(dtSolucoes.Rows[indiceSolucao][objCaSolucoes.cdSolucao].ToString());

                InicializaPagina();

                if (indiceSolucao == (qtdSolucoes - 1))
                {
                    imgbtnNext.Enabled = false;
                    imgbtnPrevious.Enabled = true;
                }
                else
                    imgbtnNext.Enabled = true;
            }
        }

        protected void btnSolucionado_Click(object sender, EventArgs e)
        {
            caParametros objCaParametros = new caParametros();
            conParametros objConParametros = new conParametros();
            caIndicador objCaIndicador = new caIndicador();
            conIndicadores objConIndicadores = new conIndicadores();
            DataTable dtParametros = objConParametros.objCoParametros.RetornaEstruturaDT();

            objConIndicadores.objCoIndicador.cdUsuario = Convert.ToInt32(Session["cdUsuario"].ToString());
            objConIndicadores.objCoIndicador.cdDefeito = Convert.ToInt32(Session["cdDefeito"].ToString());
            objConIndicadores.objCoIndicador.cdSolucao = Convert.ToInt32(Session["cdSolucao"].ToString());
            objConIndicadores.objCoIndicador.flResultado = 'S';
            objConIndicadores.objCoIndicador.deObservacao = "";

            DataRow dr;            
            dr = dtParametros.NewRow(); //Sistema
            dr[objCaParametros.nmParametro] = "Sistema";
            dr[objCaParametros.vlParametro] = Session["cdSistema"].ToString();
            dtParametros.Rows.Add(dr);

            dr = dtParametros.NewRow();//Módulo
            dr[objCaParametros.nmParametro] = "Modulo";
            dr[objCaParametros.vlParametro] = Session["cdDefeito"].ToString();
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

            objConIndicadores.objCoIndicador.dtParametros = dtParametros;

            if (!objConIndicadores.Inserir())
            {
                MostraMensagem(csMensagens.msgPadrao, objConIndicadores.strMensagemErro, "danger");
                return;
            }

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
    }
}