using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebControls.pages
{
    public partial class Soft : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void Button_Click(object sender, EventArgs e)
        protected void Button_Click(object sender, EventArgs e, string url)
        {
            Response.Redirect(url);
            //Response.Write("<script language='javascript'>window.open('" + url + "');</script>");
        }
    }
}