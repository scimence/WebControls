using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebControls.pages
{
    public partial class UserCenter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBoxAccount.Text = "Account";
            TextBoxPhone.Text = "130***756";
            TextBoxID.Text = "340**456";
            TextBoxAli.Text = "alixxxx";
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}