using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVBlog
{
    public partial class adminEducationDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.EDUCATIONTableAdapter dt = new DataSet1TableAdapters.EDUCATIONTableAdapter();
            int id = Convert.ToInt16(Request.QueryString["ID"]);
            dt.educationDelete(Convert.ToInt16(id));
            Response.Redirect("adminEducation.aspx");
        }
    }
}