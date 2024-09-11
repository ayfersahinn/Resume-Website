using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVBlog
{
    public partial class adminHobbyAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.HOBBYTableAdapter dt = new DataSet1TableAdapters.HOBBYTableAdapter();
            dt.hobbyAdd(txtHobby.Text);
            Response.Redirect("adminHobby.aspx");
        }
    }
}