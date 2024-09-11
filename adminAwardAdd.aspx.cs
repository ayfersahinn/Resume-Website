using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVBlog
{
    public partial class adminAwardAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.AWARDSTableAdapter dt = new DataSet1TableAdapters.AWARDSTableAdapter();
            dt.awardAdd(txtAward.Text);
            Response.Redirect("adminAward.aspx");
        }
    }
}