using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebControls.pages
{
    public class Procduct
    {
        public string Id;
        public string Name;

        public Procduct(string Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
    public partial class DateTime : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //var procducts = new List<Procduct>()
            //{
            //    new Procduct("1", "N72"),
            //    new Procduct("2", "N97")
            //};

            //MultipleDropdownList1.DataSource = procducts;
            //MultipleDropdownList1.DataTextField = "Name";
            //MultipleDropdownList1.DataValueField = "Id";
            //MultipleDropdownList1.DataBind();

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}