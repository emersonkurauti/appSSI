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
    public partial class frmDetalhes : System.Web.UI.Page
    {
        DataTable dtSolucoes;
        DataTable dtDefeitos;
        caDefeitos objCaDefeitos = new caDefeitos();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                InicializaPagina();
            else
                CarregarImagensDefeito();
        }

        public void InicializaPagina()
        {
            int indiceDefeito = Convert.ToInt32(Session["IndiceDefeito"].ToString());
            int qtdDefeitos = Convert.ToInt32(Session["QtdDefeitos"].ToString());

            imgbRight.Enabled = true;
            imgbLeft.Enabled = true;

            if (indiceDefeito == (qtdDefeitos - 1))
                imgbRight.Enabled = false;

            if (indiceDefeito == 0)
                imgbLeft.Enabled = false;

            CarregarDadosDefeito();
            CarregarSolucoes();

            lblAviso.Visible = false;

            if (dtSolucoes == null || dtSolucoes.Rows.Count == 0)
                lblAviso.Visible = true;
        }

        public void CarregarDadosDefeito()
        {
            conDefeitos objConDefeitos = new conDefeitos();
            caDefeitos objCaDefeitos = new caDefeitos();

            objConDefeitos.objCoDefeitos.cdDefeito = Convert.ToInt32(Session["cdDefeito"].ToString());

            if (!objConDefeitos.Select())
            {
                Mensagem(objConDefeitos.strMensagemErro, Page);
                return;
            }

            CarregarImagensDefeito();

            lblDescDefeito.Text = objConDefeitos.dtDados.Rows[0][objCaDefeitos.deDefeito].ToString();
        }

        public void CarregarImagensDefeito()
        {
            conImagens objConImagens = new conImagens('D');
            caImagensDefeitos objCaImagensDefeitos = new caImagensDefeitos();
            TableRow linha;
            TableCell celula;
            ImageButton imagem;

            objConImagens.objCoImagensDefeitos.cdDefeito = Convert.ToInt32(Session["cdDefeito"].ToString());

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
                imagem.ImageUrl = csConstantes.sCaminhoImgDefeitoSvr + dr[objCaImagensDefeitos.blImagem].ToString();

                celula.Controls.Add(imagem);
                linha.Cells.Add(celula);
            }

            tbImagens.Rows.Add(linha);
        }

        public void MaximizaImage(object sender, ImageClickEventArgs e)
        {
            Response.Redirect(((ImageButton)sender).ImageUrl);
        }

        public void CarregarSolucoes()
        {
            conConsultaDefeitoTelaAcao objConConsultaDefeitoTelaAcao = new conConsultaDefeitoTelaAcao();
            caSolucoes objCaSolucoes = new caSolucoes();

            objConConsultaDefeitoTelaAcao.objCoConsultaDefeitoTelaAcao.cdDefeito = Convert.ToInt32(Session["cdDefeito"].ToString());

            if(!objConConsultaDefeitoTelaAcao.SelectSolucaoDefeito())
            {
                Mensagem(objConConsultaDefeitoTelaAcao.strMensagemErro, Page);
                return;
            }

            dtSolucoes = objConConsultaDefeitoTelaAcao.dtDados;

            gvSolucoesDefeitos.DataSource = dtSolucoes;
            gvSolucoesDefeitos.DataBind();
        }

        public void Mensagem(string sMensagem, Page Pagina)
        {
            ScriptManager.RegisterStartupScript(Pagina,
                this.GetType(), "Aviso", "<script language='javascript'>alert('" +
                sMensagem + "');</script>", false);
        }

        protected void imgbVoltar_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("frmResultadoConsulta.aspx");
        }

        /// <summary>
        /// Defeito anterior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void imgbLeft_Click(object sender, ImageClickEventArgs e)
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
                    imgbLeft.Enabled = false;
                    imgbRight.Enabled = true;
                }
                else
                    imgbLeft.Enabled = true;
            }
        }

        /// <summary>
        /// Próximo defeito
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void imgbRight_Click(object sender, ImageClickEventArgs e)
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
                    imgbRight.Enabled = false;
                    imgbLeft.Enabled = true;
                }
                else
                    imgbRight.Enabled = true;
            }
        }

        protected void gvSolucoesDefeitos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["dtSolucoes"] = dtSolucoes;
            Session["cdSolucao"] = Convert.ToInt32(gvSolucoesDefeitos.SelectedRow.Cells[0].Text.ToString());
            Session["IndiceSolucao"] = gvSolucoesDefeitos.SelectedRow.RowIndex;
            Session["QtdSolucoes"] = gvSolucoesDefeitos.Rows.Count;

            Response.Redirect("frmDetalhesSolucoes.aspx");
        }
    }
}