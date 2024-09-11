using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVBlog
{
    public partial class adminHobbyDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.HOBBYTableAdapter dt = new DataSet1TableAdapters.HOBBYTableAdapter();
            int id = Convert.ToInt16(Request.QueryString["ID"]);
            dt.hobbyDelete(Convert.ToInt16(id));
            Response.Redirect("adminHobby.aspx");
        }
    }
}