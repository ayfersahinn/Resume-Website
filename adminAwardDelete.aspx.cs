using Azure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVBlog
{
    public partial class adminAwardDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.AWARDSTableAdapter dt = new DataSet1TableAdapters.AWARDSTableAdapter();
            int id = Convert.ToInt16(Request.QueryString["ID"]);
            dt.awardDelete(Convert.ToInt16(id));
            Response.Redirect("adminAward.aspx");
        }
    }
}