using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVBlog
{
    public partial class about : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.ABOUTTableAdapter dt = new DataSet1TableAdapters.ABOUTTableAdapter();
            txtName.Text = dt.aboutList()[0].NAME;
            txtSurname.Text = dt.aboutList()[0].SURNAME;
            txtAdress.Text = dt.aboutList()[0].ADDRESS;
            txtEmail.Text = dt.aboutList()[0].MAIL;
            txtPhone.Text = dt.aboutList()[0].PHONE;
            txtNotes.Text = dt.aboutList()[0].NOTES;
            txtImg.Text = dt.aboutList()[0].IMAGE;


        }
    }
}