using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using appSSI;
using System.Text;
using System.Data;

namespace wappSSI
{
    public partial class abrirchamado : System.Web.UI.Page
    {
        private conImagens _objConImagens;
        private caImagensDefeitos _objCaImagensDefeitos;
        private DataTable _dtImagens;

        protected void Page_Load(object sender, EventArgs e)
        {
            ltMensagem.Text = "";

            if (!IsPostBack)
            {
                _objConImagens = new conImagens(csConstantes.cDefeito);
                _objCaImagensDefeitos = new caImagensDefeitos();
                _dtImagens = _objConImagens.objCoImagensDefeitos.RetornaEstruturaDT();
                Session["_dtImagens"] = _dtImagens;
            }
        }

        protected void btnCarregar_Click(object sender, EventArgs e)
        {
            String path = Server.MapPath("~/Imagens/Temp/");

            if (fluImagem.HasFile)
            {
                string fileName = Server.HtmlEncode(fluImagem.FileName).ToLower();
                string extension = System.IO.Path.GetExtension(fileName);

                if ((extension == ".jpeg") || (extension == ".png") || (extension == ".jpg") || (extension == ".gif"))
                {
                    Session["CaminhoImg"] = path;
                    Session["FileName"] = fileName;

                    path += fileName;
                    fluImagem.SaveAs(path);

                    imgUp.ImageUrl = "~/Imagens/Temp/" + fileName;

                }
                else
                {
                    MostraMensagem("", csMensagens.msgExtensaoImagem, "warning");
                }
            }
        }

        protected void btnEnviarImg_Click(object sender, EventArgs e)
        {
            if (txtDescIMG.Text.Trim() != "")
            {
                if (Session["CaminhoImg"] != null)
                {
                    _objCaImagensDefeitos = new caImagensDefeitos();
                    _dtImagens = (DataTable)Session["_dtImagens"];

                    DataRow dr = _dtImagens.NewRow();

                    dr[_objCaImagensDefeitos.deCaminhoImagem] = Session["CaminhoImg"].ToString();
                    dr[_objCaImagensDefeitos.deImagem] = txtDescIMG.Text;
                    dr[_objCaImagensDefeitos.blImagem] = Session["FileName"].ToString();

                    _dtImagens.Rows.Add(dr);

                    Session["_dtImagens"] = _dtImagens;

                    gvImagens.DataSource = null;
                    gvImagens.AutoGenerateColumns = false;
                    gvImagens.DataSource = _dtImagens;
                    gvImagens.DataBind();

                    imgUp.ImageUrl = csConstantes.imgNull;
                    txtDescIMG.Text = "";
                }
            }
            else
            {
                MostraMensagem("", csMensagens.msgImagemSemDesc, "warning");
            }
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtTitulo.Text.Trim() != "")
            {
                if (txtDescDefeito.Text.Trim() != "")
                {
                    //Inserir OS
                    //Gerar os e recuperar o código
                    conIntegracaoTask objConIntegracaoTask = new conIntegracaoTask();

                    objConIntegracaoTask.objCoIntegracaoTask.CC_cdUsuario = Convert.ToInt32(Session["cdUsuario"].ToString());
                    objConIntegracaoTask.objCoIntegracaoTask.CC_cdSistema = Convert.ToInt32(Session["cdSistema"].ToString());
                    objConIntegracaoTask.objCoIntegracaoTask.CC_cdModelo = Convert.ToInt32(Session["cdModulo"].ToString());
                    objConIntegracaoTask.objCoIntegracaoTask.CC_cdTela = Convert.ToInt32(Session["cdTela"].ToString());
                    objConIntegracaoTask.objCoIntegracaoTask.CC_descDefeito = Session["descDefeito"].ToString();
                    objConIntegracaoTask.objCoIntegracaoTask.DS_TAREFA = txtTitulo.Text;

                    //if (!objConIntegracaoTask.Inserir())
                    //{
                    //    MostraMensagem(csMensagens.msgPadrao, objConIntegracaoTask.strMensagemErro, "danger");
                    //    return;
                    //}

                    if (!InserirDefeito())
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

                    if (Session["bNenhumDefeito"].ToString() == "S")
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
                else
                    MostraMensagem("", csMensagens.msgInformeDesc, "warning");
            }
            else
                MostraMensagem("", csMensagens.msgInformeTitulo, "warning");
        }

        public bool InserirDefeito()
        {
            conDefeitos objConDefeito = new conDefeitos();
            caDefeitos objCaDefeito = new caDefeitos();

            conDefeitoAcaoTela objconDefeitoAcaoTela = new conDefeitoAcaoTela();
            caDefeitoAcaoTela objcaDefeitoAcaoTela = new caDefeitoAcaoTela();

            conSolucoesDefeitos objConSolucoesDefeitos = new conSolucoesDefeitos(csConstantes.cDefeito);

            DataTable dtAcoesTelas = objconDefeitoAcaoTela.objCoDefeitoAcaoTela.RetornaEstruturaDT();
            DataRow dr = dtAcoesTelas.NewRow();

            _dtImagens = (DataTable)Session["_dtImagens"];

            dr[objcaDefeitoAcaoTela.cdAcao] = Convert.ToInt32(Session["cdAcao"].ToString());
            dr[objcaDefeitoAcaoTela.cdTela] = Convert.ToInt32(Session["cdTela"].ToString());

            dtAcoesTelas.Rows.Add(dr);

            objConDefeito.objCoDefeitos.deDefeito = txtDescDefeito.Text;
            objConDefeito.objCoDefeitos.dtDefeitosAcoesTelas = dtAcoesTelas;
            objConDefeito.objCoDefeitos.flEstagio = 'I';
            objConDefeito.objCoDefeitos.dtImgDefeitos = _dtImagens;
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

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("consultardefeitos.aspx");
        }

        protected void gvImagens_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            _dtImagens = (DataTable)Session["_dtImagens"];

            _dtImagens.Rows.RemoveAt(e.RowIndex);

            Session["_dtImagens"] = _dtImagens;

            gvImagens.DataSource = null;
            gvImagens.AutoGenerateColumns = false;
            gvImagens.DataSource = _dtImagens;
            gvImagens.DataBind();
        }
    }
}