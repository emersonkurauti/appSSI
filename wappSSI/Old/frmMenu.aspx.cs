using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wappSSI
{
    public partial class frmMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void menu_MenuItemClick(object sender, MenuEventArgs e)
        {
            if (menu.SelectedValue.ToString() == "frmLogin.aspx")
                Response.Redirect(menu.SelectedValue.ToString());
            else
            {
                //HtmlIframe frame = (HtmlIframe)pnFrame.FindControl("frame");
                //frame.Attributes.Add("src", menu.SelectedValue.ToString());
            }
        }
    }
}