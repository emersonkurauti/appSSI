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
    public partial class frmDetalhesSolucoes : System.Web.UI.Page
    {
        DataTable dtSolucoes;
        caSolucoes objCaSolucoes = new caSolucoes();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                InicializaPagina();
            else
                CarregarImagens();
        }

        public void InicializaPagina()
        {
            int indiceSolucao = Convert.ToInt32(Session["IndiceSolucao"].ToString());
            int qtdSolucoes = Convert.ToInt32(Session["QtdSolucoes"].ToString());

            imgbPrevious.Enabled = true;
            imgbNext.Enabled = true;

            if (indiceSolucao == (qtdSolucoes - 1))
                imgbNext.Enabled = false;

            if (indiceSolucao == 0)
                imgbPrevious.Enabled = false;

            CarregarDadosSolucao();
        }

        public void CarregarDadosSolucao()
        {
            conSolucoes objConSolucoes = new conSolucoes();
            caSolucoes objCaSolucoes = new caSolucoes();

            objConSolucoes.objCoSolucoes.cdSolucao = Convert.ToInt32(Session["cdSolucao"].ToString());

            if (!objConSolucoes.Select())
            {
                Mensagem(objConSolucoes.strMensagemErro, Page);
                return;
            }

            CarregarImagens();

            lblDescSolucao.Text = objConSolucoes.dtDados.Rows[0][objCaSolucoes.deSolucao].ToString();
        }

        public void CarregarImagens()
        {
            conImagens objConImagens = new conImagens('S');
            caImagensSolucoes objCaImagensSolucoes = new caImagensSolucoes();
            TableRow linha;
            TableCell celula;
            ImageButton imagem;

            objConImagens.objCoImagensSolucoes.cdSolucao = Convert.ToInt32(Session["cdSolucao"].ToString());

            if (!objConImagens.Select())
            {
                Mensagem(objConImagens.strMensagemErro, Page);
                return;
            }


            tbImagens.Rows.Clear();
            linha = new TableRow();

            foreach (DataRow dr in objConImagens.dtDados.Rows)
            {
                celula = new TableCell();

                imagem = new ImageButton();
                imagem.Click += new ImageClickEventHandler(this.MaximizaImage);
                imagem.Height = 120;
                imagem.Width = 120;
                imagem.ImageUrl = csConstantes.sCaminhoImgSolucoesSvr + dr[objCaImagensSolucoes.blImagem].ToString();

                celula.Controls.Add(imagem);
                linha.Cells.Add(celula);
            }

            tbImagens.Rows.Add(linha);
        }

        public void MaximizaImage(object sender, ImageClickEventArgs e)
        {
            Response.Redirect(((ImageButton)sender).ImageUrl);
        }

        public void Mensagem(string sMensagem, Page Pagina)
        {
            ScriptManager.RegisterStartupScript(Pagina,
                this.GetType(), "Aviso", "<script language='javascript'>alert('" +
                sMensagem + "');</script>", false);
        }

        protected void imgbPrevious_Click(object sender, ImageClickEventArgs e)
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
                    imgbPrevious.Enabled = false;
                    imgbNext.Enabled = true;
                }
                else
                    imgbPrevious.Enabled = true;
            }
        }

        protected void imgbNext_Click(object sender, ImageClickEventArgs e)
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
                    imgbNext.Enabled = false;
                    imgbPrevious.Enabled = true;
                }
                else
                    imgbNext.Enabled = true;
            }
        }

        protected void imgbBack_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("frmDetalhesDefeitos.aspx");
        }

        protected void imgbSolucionado_Click(object sender, ImageClickEventArgs e)
        {
        }
    }
}