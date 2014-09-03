using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using appSSI;
using System.Data;

namespace wappSSI
{
    public partial class frmConsultarDefeito : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InicializaTela();
                CarregarDDLSistemas();
            }
        }

        public void InicializaTela()
        {
            txtSistema.Visible = false;

            ddlModulos.SelectedIndex = -1;
            txtModulo.Visible = false;
            //ddlModulos.Enabled = false;

            ddlTelas.SelectedIndex = -1;
            txtTela.Visible = false;
            //ddlTelas.Enabled = false;

            ddlAcoes.SelectedIndex = -1;
            txtAcao.Visible = false;
            //ddlAcoes.Enabled = false;

            txtDescDefeito.Text = "";
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            conConsultaDefeitoTelaAcao objConConsultaDefeitoTelaAcao = new conConsultaDefeitoTelaAcao();
            caConsultaDefeitoTelaAcao objCaConsultaDefeitoTelaAcao = new caConsultaDefeitoTelaAcao();

            if (ddlTelas.SelectedValue.ToString() != "" && ddlAcoes.SelectedValue.ToString() != "")
            {
                objConConsultaDefeitoTelaAcao.objCoConsultaDefeitoTelaAcao.cdTela = Convert.ToInt32(ddlTelas.SelectedValue.ToString());
                objConConsultaDefeitoTelaAcao.objCoConsultaDefeitoTelaAcao.cdAcao = Convert.ToInt32(ddlAcoes.SelectedValue.ToString());
                objConConsultaDefeitoTelaAcao.objCoConsultaDefeitoTelaAcao.flTpUsuario = Convert.ToChar(Session["TpUsuario"].ToString());
                objConConsultaDefeitoTelaAcao.objCoConsultaDefeitoTelaAcao.deDesricao = txtDescDefeito.Text;

                if (!objConConsultaDefeitoTelaAcao.Select())
                {
                    Mensagem(objConConsultaDefeitoTelaAcao.strMensagemErro, Page);
                    return;
                }

                Session["dtResultados"] = objConConsultaDefeitoTelaAcao.dtDados;
                Response.Redirect("frmResultadoConsulta.aspx");
            }
        }

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
                    Mensagem(objConSistemasEmpresas.strMensagemErro, Page);
                    return;
                }

                strFiltroEmpresas = " where cdSistema in (";

                for (int i = 0; i < objConSistemasEmpresas.dtDados.Rows.Count; i++)
                    strFiltroEmpresas += objConSistemasEmpresas.dtDados.Rows[i][objCaSistemasEmpresas.cdSistema].ToString() + ",";

                strFiltroEmpresas = strFiltroEmpresas.Substring(0, strFiltroEmpresas.Length - 1) + ")";

                objConSistemas.objCoSistemas.strFiltro = strFiltroEmpresas;

                if (!objConSistemas.Select())
                {
                    Mensagem(objConSistemas.strMensagemErro, Page);
                    return;
                }

                txtSistema.Visible = false;
                if (objConSistemas.dtDados.Rows.Count == 0)
                    txtSistema.Visible = true;

                DataRow dr = objConSistemas.dtDados.NewRow();
                dr[objCaSistemas.cdSistema] = 0;
                dr[objCaSistemas.nmSistema] = "Outros";
                objConSistemas.dtDados.Rows.Add(dr);

                if (objConSistemas.dtDados != null && objConSistemas.dtDados.Rows.Count > 0)
                {
                    ddlSistemas.DataSource = objConSistemas.dtDados;
                    ddlSistemas.DataValueField = objCaSistemas.cdSistema;
                    ddlSistemas.DataTextField = objCaSistemas.nmSistema;
                    ddlSistemas.DataBind();
                    ddlSistemas.SelectedIndex = 0;

                    CarregarDDLModulos();
                }
            }
            catch
            {
                Mensagem(csMensagens.msgSistema, Page);
            }
        }

        public void CarregarDDLModulos()
        {
            conModulos objConModulos = new conModulos();
            caModulos objCaModulos = new caModulos();

            try
            {
                objConModulos.objCoModulos.cdSistema = Convert.ToInt32(ddlSistemas.SelectedValue.ToString());

                if (!objConModulos.Select())
                {
                    Mensagem(objConModulos.strMensagemErro, Page);
                    return;
                }

                if(Convert.ToInt32(ddlSistemas.SelectedValue.ToString()) == 0)
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
                    ddlModulos.DataSource = objConModulos.dtDados;
                    ddlModulos.DataValueField = objCaModulos.cdModulo;
                    ddlModulos.DataTextField = objCaModulos.nmModulo;
                    ddlModulos.DataBind();
                    ddlModulos.SelectedIndex = 0;

                    CarregarDDLTelas();
                }
            }
            catch
            {
                Mensagem(csMensagens.msgModulo, Page);
            }
        }

        public void CarregarDDLTelas()
        {
            conTelas objConTelas = new conTelas();
            caTelas objCaTelas = new caTelas();

            try
            {
                objConTelas.objCoTelas.cdModulo = Convert.ToInt32(ddlModulos.SelectedValue.ToString());

                if (!objConTelas.Select())
                {
                    Mensagem(objConTelas.strMensagemErro, Page);
                    return;
                }

                if (Convert.ToInt32(ddlModulos.SelectedValue.ToString()) == 0)
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
                    ddlTelas.DataSource = objConTelas.dtDados;
                    ddlTelas.DataValueField = objCaTelas.cdTela;
                    ddlTelas.DataTextField = objCaTelas.nmTela;
                    ddlTelas.DataBind();
                    ddlTelas.SelectedIndex = 0;

                    CarregarDDLAcoes();
                }
            }
            catch
            {
                Mensagem(csMensagens.msgTela, Page);
            }
        }

        public void CarregarDDLAcoes()
        {
            conTelasAcoes objConTelasAcoes = new conTelasAcoes();
            caTelasAcoes objCaTelasAcoes = new caTelasAcoes();

            conAcoes objConAcoes = new conAcoes();
            caAcoes objCaAcoes = new caAcoes();

            string strFiltroAcoes = "";

            try
            {
                objConTelasAcoes.objCoTelasAcoes.cdTela = Convert.ToInt32(ddlTelas.SelectedValue.ToString());

                if (!objConTelasAcoes.Select())
                {
                    Mensagem(objConTelasAcoes.strMensagemErro, Page);
                    return;
                }

                strFiltroAcoes = " where cdAcao in (";

                for (int i = 0; i < objConTelasAcoes.dtDados.Rows.Count; i++)
                    strFiltroAcoes += objConTelasAcoes.dtDados.Rows[i][objCaTelasAcoes.cdAcao].ToString() + ",";

                strFiltroAcoes = strFiltroAcoes.Substring(0, strFiltroAcoes.Length - 1) + ")";

                objConAcoes.objCoAcoes.strFiltro = strFiltroAcoes;

                if (!objConAcoes.Select())
                {
                    Mensagem(objConAcoes.strMensagemErro, Page);
                    return;
                }

                if (Convert.ToInt32(ddlTelas.SelectedValue.ToString()) == 0)
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
                    ddlAcoes.DataSource = objConAcoes.dtDados;
                    ddlAcoes.DataValueField = objCaAcoes.cdAcao;
                    ddlAcoes.DataTextField = objCaAcoes.deAcao;
                    ddlAcoes.DataBind();
                    ddlAcoes.SelectedIndex = 0;
                }
            }
            catch
            {
                Mensagem(csMensagens.msgAcao, Page);
            }
        }

        protected void ddlSistemas_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlModulos.Items.Clear();
            ddlTelas.Items.Clear();
            ddlAcoes.Items.Clear();

            txtSistema.Visible = false;
            if (Convert.ToInt32(ddlSistemas.SelectedValue.ToString()) == 0)
            {
                txtSistema.Text = "";
                txtSistema.Visible = true;
            }

            CarregarDDLModulos();
        }

        protected void ddlModulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlTelas.Items.Clear();
            ddlAcoes.Items.Clear();

            txtModulo.Visible = false;
            if (Convert.ToInt32(ddlModulos.SelectedValue.ToString()) == 0)
            {
                txtModulo.Text = "";
                txtModulo.Visible = true;
            }

            CarregarDDLTelas();
        }

        protected void ddlTelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlAcoes.Items.Clear();

            txtTela.Visible = false;
            if (Convert.ToInt32(ddlTelas.SelectedValue.ToString()) == 0)
            {
                txtTela.Text = "";
                txtTela.Visible = true;
            }
            
            CarregarDDLAcoes();
        }

        protected void ddlAcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAcao.Visible = false;
            if (Convert.ToInt32(ddlAcoes.SelectedValue.ToString()) == 0)
            {
                txtAcao.Text = "";
                txtAcao.Visible = true;
            }
        }

        public void Mensagem(string sMensagem, Page Pagina)
        {
            ScriptManager.RegisterStartupScript(Pagina,
                this.GetType(), "Aviso", "<script language='javascript'>alert('" +
                sMensagem + "');</script>", false);
        }
    }
}