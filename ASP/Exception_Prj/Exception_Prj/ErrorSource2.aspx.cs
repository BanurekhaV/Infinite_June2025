using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exception_Prj
{
    public partial class ErrorSource2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    //Response.Redirect("Hello.aspx");
            //    Server.Transfer("Hello.aspx");

            //}
            //catch(Exception ex)
            //{
            //    Lblerrormsg.Text = "Error Encountered..";
            //}
            
        }

        protected void Btn1_Click(object sender, EventArgs e)
        {
             //Server.Transfer("~/hello.aspx");
            Response.Redirect("~/Hello.aspx");
        }

        //protected void Page_Error(Object sender, EventArgs e)
        //{
        //    Exception ex = Server.GetLastError();
        //    Server.ClearError();
        //    // Lblerrormsg.Text = "Some Error Happened.. Contact admin";
        //    Server.Transfer("~/ErrorPage.aspx");
        //}

    }
}