using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVBlog
{
    public partial class adminExperience : System.Web.UI.Page
    {
        DataSet1TableAdapters.EXPERIENCETableAdapter dt = new DataSet1TableAdapters.EXPERIENCETableAdapter();
        protected void Page_Load(object sender, EventArgs e)
        {
           Repeater1.DataSource = dt.ExperienceList();
           Repeater1.DataBind();   
        }
    }
}