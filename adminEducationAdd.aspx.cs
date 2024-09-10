using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVBlog
{
    public partial class adminEducationAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.EDUCATIONTableAdapter dt = new DataSet1TableAdapters.EDUCATIONTableAdapter();
            dt.educationAdd(txtTopic.Text,txtSubtitle.Text,txtDesc.Text,txtGPA.Text,txtDate.Text);
            Response.Redirect("adminEducation.aspx");
        }
    }
}