using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using appSSI;
using System.Text;
using System.Data;
using System.Net.Mail;

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

                CarregarDDLSistemas();

                InicializaTela();
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

            txtDescDefeito.Text = Session["descDefeito"].ToString();

            ddlSistema.SelectedValue = Session["cdSistema"].ToString();
            ddlSistema_SelectedIndexChanged(ddlSistema, null);

            ddlModulo.SelectedValue = Session["cdModulo"].ToString();
            ddlModulo_SelectedIndexChanged(ddlModulo, null);
            txtModulo.Text = Session["OutroModulo"].ToString();

            ddlTela.SelectedValue = Session["cdTela"].ToString();
            ddlTela_SelectedIndexChanged(ddlTela, null);
            txtTela.Text = Session["OutraTela"].ToString();

            ddlAcao.SelectedValue = Session["cdAcao"].ToString();
            ddlAcao_SelectedIndexChanged(ddlAcao, null);
            txtAcao.Text = Session["OutraAcao"].ToString();
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

        protected void btnCarregar_Click(object sender, EventArgs e)
        {
            String path = Server.MapPath("../Imagens/Temp/");

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

                    imgUp.ImageUrl = "../Imagens/Temp/" + fileName;

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

                    imgUp.ImageUrl = wappSSI.Properties.Settings.Default.imgNULL;
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
            if (((Convert.ToInt32(ddlModulo.SelectedValue.ToString()) == 0) && (txtModulo.Text == "")) ||
                ((Convert.ToInt32(ddlTela.SelectedValue.ToString()) == 0) && (txtTela.Text == "")) ||
                ((Convert.ToInt32(ddlAcao.SelectedValue.ToString()) == 0) && (txtAcao.Text == "")))
            {
                MostraMensagem("", csMensagens.msgInformeOutros, "warning");
                return;
            }

            if (txtTitulo.Text.Trim() != "")
            {
                if (txtDescDefeito.Text.Trim() != "")
                {
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

                    //Inserir OS
                    //Gerar os e recuperar o código
                    conIntegracaoTask objConIntegracaoTask = new conIntegracaoTask();

                    objConIntegracaoTask.objCoIntegracaoTask.CC_cdUsuario = Convert.ToInt32(Session["cdUsuario"].ToString());
                    objConIntegracaoTask.objCoIntegracaoTask.CC_cdSistema = Convert.ToInt32(Session["cdSistema"].ToString());
                    objConIntegracaoTask.objCoIntegracaoTask.CC_cdModelo = Convert.ToInt32(Session["cdModulo"].ToString());
                    objConIntegracaoTask.objCoIntegracaoTask.CC_cdTela = Convert.ToInt32(Session["cdTela"].ToString());

                    string strDefeito = Session["descDefeito"].ToString();

                    string strParamtros = "";
                    strParamtros += "\n\n" +
                        "Sistema: " + Session["cdSistema"].ToString() + " - " + Session["nmSistema"].ToString() + "\n" +
                        "Módulo:  " + Session["cdModulo"].ToString() + " - " + Session["nmModulo"].ToString() + "\n" +
                        "Tela:    " + Session["cdTela"].ToString() + " - " + Session["nmTela"].ToString() + "\n" +
                        "Acao:    " + Session["cdAcao"].ToString() + " - " + Session["deAcao"].ToString() + "\n";

                    string strOutros = "";
                    if (Convert.ToInt32(Session["cdModulo"].ToString()) == 0)
                        strOutros += "\n" + "Módulo - " + Session["OutroModulo"].ToString();

                    if (Convert.ToInt32(Session["cdTela"].ToString()) == 0)
                        strOutros += "\n" + "Tela - " + Session["OutraTela"].ToString();

                    if (Convert.ToInt32(Session["cdAcao"].ToString()) == 0)
                        strOutros += "\n" + "Ação - " + Session["OutraAcao"].ToString();

                    objConIntegracaoTask.objCoIntegracaoTask.CC_descDefeito = strDefeito + strParamtros + strOutros;
                    objConIntegracaoTask.objCoIntegracaoTask.DS_TAREFA = txtTitulo.Text;

                    if (!objConIntegracaoTask.Inserir())
                    {
                        MostraMensagem(csMensagens.msgPadrao, objConIntegracaoTask.strMensagemErro, "danger");
                        return;
                    }

                    if ((Convert.ToInt32(ddlAcao.SelectedValue.ToString()) == 0) &&
                       (Convert.ToInt32(ddlTela.SelectedValue.ToString()) != 0))
                    {
                        Session["cdTela"] = 0;
                        Session["OutraTela"] = ddlTela.SelectedItem.Text;

                        strOutros += "\n\n" + "Atenção!" +
                            "\n Alterar a tela para: " + ddlSistema.SelectedValue.ToString() + " - " + ddlTela.SelectedItem.Text;
                    }

                    if (!InserirDefeito())
                    {
                        MostraMensagem(csMensagens.msgPadrao, csMensagens.msgDefeito, "danger");
                        return;
                    }

                    if ((Convert.ToInt32(ddlModulo.SelectedValue.ToString()) == 0) ||
                        (Convert.ToInt32(ddlTela.SelectedValue.ToString()) == 0) ||
                        (Convert.ToInt32(ddlAcao.SelectedValue.ToString()) == 0))
                    {
                        strOutros = "Cadastrar os dados e vincular ao defeito de código " + Session["cdDefeito"].ToString() 
                            + "\n\n"
                            + strOutros;
                        EnviarNotificacao("Solicitação de cadastro", strOutros);
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

            Session["cdDefeito"] = objConDefeito.objCoDefeitos.cdDefeito;

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

        protected void gvImagens_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvImagens.PageIndex = e.NewPageIndex;
            gvImagens.DataSource = (DataTable)Session["_dtImagens"];
            gvImagens.DataBind();
        }
    }
}