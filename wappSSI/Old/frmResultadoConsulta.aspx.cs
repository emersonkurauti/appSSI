using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using appSSI;

namespace wappSSI
{
    public partial class frmResultadoConsulta : System.Web.UI.Page
    {
        DataTable dtResultados;
 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dtResultados = (DataTable)Session["dtResultados"];

                if (dtResultados.Rows.Count > 0)
                {
                    lbl1.Visible = false;
                    lbl2.Visible = false;
                    lnkbtnAbrirChamado.Visible = false;
                    CarregarDefeitosSolucoes();
                }
                else
                {
                    lbl1.Visible = true;
                    lbl2.Visible = true;
                    lnkbtnAbrirChamado.Visible = true;
                }
            }
        }

        public void CarregarDefeitosSolucoes()
        {
            gvDefeitosSolucoes.AutoGenerateColumns = false;
            gvDefeitosSolucoes.DataSource = dtResultados;
            gvDefeitosSolucoes.DataBind();
        }

        protected void gvDefeitosSolucoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["cdDefeito"] = Convert.ToInt32(gvDefeitosSolucoes.SelectedRow.Cells[1].Text.ToString());
            Session["IndiceDefeito"] = gvDefeitosSolucoes.SelectedRow.RowIndex;
            Session["QtdDefeitos"] = gvDefeitosSolucoes.Rows.Count;

            Response.Redirect("frmDetalhesDefeitos.aspx");
        }
    }
}