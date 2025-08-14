using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exception_Prj
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //option 1 
            //if (PreviousPage != null)
            //{
            //    lblName.Text = ((TextBox)PreviousPage.FindControl("txtname")).Text;
            //    lblEmail.Text = ((TextBox)PreviousPage.FindControl("txtmail")).Text;
            //}

            //option 2
            System.Collections.Specialized.NameValueCollection nvcprevious =
                Request.Form;
            lblName.Text = nvcprevious["txtname"];
            lblEmail.Text = nvcprevious["txtmail"];
        }

        protected void btnPostBack_Click(object sender, EventArgs e)
        {
            //if(PreviousPage!=null)
            //{
            //    lblName.Text = ((TextBox)PreviousPage.FindControl("txtname")).Text;
            //    lblEmail.Text= ((TextBox)PreviousPage.FindControl("txtmail")).Text;
            //}
            Response.Write("Hi from Webform 2");
        }
    }
}