using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVBlog
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.ABOUTTableAdapter dt = new DataSet1TableAdapters.ABOUTTableAdapter();
            Repeater1.DataSource = dt.aboutList();
            Repeater1.DataBind();

            DataSet1TableAdapters.EXPERIENCETableAdapter dt2 = new DataSet1TableAdapters.EXPERIENCETableAdapter();
            Repeater2.DataSource = dt2.ExperienceList();
            Repeater2.DataBind();

            DataSet1TableAdapters.EDUCATIONTableAdapter dt3 = new DataSet1TableAdapters.EDUCATIONTableAdapter();
            Repeater3.DataSource = dt3.EducationList(); 
            Repeater3.DataBind();

            DataSet1TableAdapters.SKILLSTableAdapter dt4 = new DataSet1TableAdapters.SKILLSTableAdapter();
            Repeater4.DataSource=dt4.skillList();
            Repeater4.DataBind();
        }
    }
}