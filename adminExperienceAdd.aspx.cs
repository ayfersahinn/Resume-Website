using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVBlog
{
    public partial class adminExperienceAdd : System.Web.UI.Page
    {
        DataSet1TableAdapters.EXPERIENCETableAdapter dt = new DataSet1TableAdapters.EXPERIENCETableAdapter();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        

        protected void btnSave_Click1(object sender, EventArgs e)
        {
            dt.experienceAdd(txtTopic.Text, txtSubtitle.Text, txtDesc.Text, txtDate.Text);
            Response.Redirect("adminExperience.aspx");
        }
    }
}