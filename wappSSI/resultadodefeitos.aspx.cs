using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using appSSI;
using System.Text;

namespace wappSSI
{
    public partial class resultadodefeitos : System.Web.UI.Page
    {
        DataTable dtResultados;

        protected void Page_Load(object sender, EventArgs e)
        {
            ltMensagem.Text = "";

            if (!IsPostBack)
            {
                dtResultados = (DataTable)Session["dtResultados"];

                if (dtResultados.Rows.Count > 0)
                {
                    lblAviso.Visible = false;
                    lnkAbrirChamado.Visible = false;

                    lblNenhumDefeito.Visible = true;
                    lnkNenhumDefeito.Visible = true;
                }
                else
                {
                    lblAviso.Visible = true;
                    lnkAbrirChamado.Visible = true;

                    lblNenhumDefeito.Visible = false;
                    lnkNenhumDefeito.Visible = false;
                }

                CarregarDefeitosSolucoes();
            }
        }

        public void CarregarDefeitosSolucoes()
        {
            gvDefeitos.AutoGenerateColumns = false;
            gvDefeitos.DataSource = dtResultados;
            gvDefeitos.DataBind();
        }

        protected void gvDefeitos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["cdDefeito"] = Convert.ToInt32(gvDefeitos.DataKeys[gvDefeitos.SelectedRow.RowIndex]["cdDefeito"].ToString());
            Session["IndiceDefeito"] = gvDefeitos.SelectedRow.RowIndex;
            Session["QtdDefeitos"] = gvDefeitos.Rows.Count;

            Response.Redirect("detalhesdefeito.aspx");
        }

        protected void lnkAbrirChamado_Click(object sender, EventArgs e)
        {
            //InserirOSTask(false);
            Session["bNenhumDefeito"] = "N";
            Response.Redirect("abrirchamado.aspx");
        }

        protected void lnkNenhumDefeito_Click(object sender, EventArgs e)
        {
            //InserirOSTask(true);
            Session["bNenhumDefeito"] = "S";
            Response.Redirect("abrirchamado.aspx");
        }

        public void InserirOSTask(bool bNenhumDefeito)
        {
            //Inserir OS
            //Gerar os e recuperar o código
            conIntegracaoTask objConIntegracaoTask = new conIntegracaoTask();

            objConIntegracaoTask.objCoIntegracaoTask.CC_cdUsuario = Convert.ToInt32(Session["cdUsuario"].ToString());
            objConIntegracaoTask.objCoIntegracaoTask.CC_cdSistema = Convert.ToInt32(Session["cdSistema"].ToString());
            objConIntegracaoTask.objCoIntegracaoTask.CC_cdModelo = Convert.ToInt32(Session["cdModulo"].ToString());
            objConIntegracaoTask.objCoIntegracaoTask.CC_cdTela = Convert.ToInt32(Session["cdTela"].ToString());
            objConIntegracaoTask.objCoIntegracaoTask.CC_descDefeito = Session["descDefeito"].ToString();

            //if (!objConIntegracaoTask.Inserir())
            //{
            //    MostraMensagem(csMensagens.msgPadrao, objConIntegracaoTask.strMensagemErro, "danger");
            //    return;
            //}

            if(!InserirDefeito())
            {
                MostraMensagem(csMensagens.msgPadrao, csMensagens.msgDefeito, "danger");
                return;
            }

            //Inserir Indicador
            //Colocar no Obs do indicador o motivo da não solução
            caParametros objCaParametros = new caParametros();
            conParametros objConParametros = new conParametros();
            caIndicador objCaIndicador = new caIndicador();
            conIndicadores objConIndicadores = new conIndicadores();
            DataTable dtParametros = objConParametros.objCoParametros.RetornaEstruturaDT();

            objConIndicadores.objCoIndicador.cdUsuario = Convert.ToInt32(Session["cdUsuario"].ToString());
            objConIndicadores.objCoIndicador.cdDefeito = 0;
            objConIndicadores.objCoIndicador.cdSolucao = 0;
            objConIndicadores.objCoIndicador.flResultado = 'N';
            objConIndicadores.objCoIndicador.cdOSGerada = objConIntegracaoTask.objCoIntegracaoTask.CD_TAREFA;

            if (bNenhumDefeito)
                objConIndicadores.objCoIndicador.deObservacao = "Nenhum defeito válido.";
            else
                objConIndicadores.objCoIndicador.deObservacao = "Nenhum defeito encontrado.";

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

            objConIndicadores.objCoIndicador.dtParametros = dtParametros;

            if (!objConIndicadores.Inserir())
            {
                MostraMensagem(csMensagens.msgPadrao, objConIndicadores.strMensagemErro, "danger");
                return;
            }

            Session["bOpSucesso"] = true;
            Response.Redirect("consultardefeitos.aspx");
        }

        public bool InserirDefeito()
        {
            conDefeitos objConDefeito = new conDefeitos();
            caDefeitos objCaDefeito = new caDefeitos();
            
            conDefeitoAcaoTela objconDefeitoAcaoTela = new conDefeitoAcaoTela();
            caDefeitoAcaoTela objcaDefeitoAcaoTela = new caDefeitoAcaoTela();

            conImagens objConImagens = new conImagens(csConstantes.cDefeito);
            conSolucoesDefeitos objConSolucoesDefeitos = new conSolucoesDefeitos(csConstantes.cDefeito);

            DataTable dtAcoesTelas = objconDefeitoAcaoTela.objCoDefeitoAcaoTela.RetornaEstruturaDT();
            DataRow dr = dtAcoesTelas.NewRow();

            dr[objcaDefeitoAcaoTela.cdAcao] = Convert.ToInt32(Session["cdAcao"].ToString());
            dr[objcaDefeitoAcaoTela.cdTela] = Convert.ToInt32(Session["cdTela"].ToString());

            dtAcoesTelas.Rows.Add(dr);

            objConDefeito.objCoDefeitos.deDefeito = Session["descDefeito"].ToString();
            objConDefeito.objCoDefeitos.dtDefeitosAcoesTelas = dtAcoesTelas;
            objConDefeito.objCoDefeitos.flEstagio = 'I';
            objConDefeito.objCoDefeitos.dtImgDefeitos = objConImagens.objCoImagensDefeitos.RetornaEstruturaDT();
            objConDefeito.objCoDefeitos.dtSolucoesDefeitos = objConSolucoesDefeitos.objCoSolucoesDefeitos.RetornaEstruturaDT();

            if (!objConDefeito.Inserir())
                return false;

            return true;
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