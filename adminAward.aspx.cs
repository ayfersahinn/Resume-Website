using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVBlog
{
    public partial class adminAward : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.AWARDSTableAdapter dt = new DataSet1TableAdapters.AWARDSTableAdapter();
            Repeater1.DataSource = dt.awardsList();
            Repeater1.DataBind();
        }
    }
}