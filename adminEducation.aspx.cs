using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVBlog
{
    public partial class adminEducation : System.Web.UI.Page
    {
        DataSet1TableAdapters.EDUCATIONTableAdapter dt = new DataSet1TableAdapters.EDUCATIONTableAdapter();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = dt.EducationList();
            Repeater1.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}