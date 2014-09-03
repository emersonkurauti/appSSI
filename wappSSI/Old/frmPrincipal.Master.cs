using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wappSSI
{
    public partial class SSI : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["cdUsuario"] == null && Session["Senha"] == null && Session["TpUsuario"] == null)
                Response.Redirect("frmLogin.aspx");
        }

        protected void Menu_MenuItemClick(object sender, MenuEventArgs e)
        {
            Response.Redirect(Menu.SelectedValue.ToString());
        }
    }
}