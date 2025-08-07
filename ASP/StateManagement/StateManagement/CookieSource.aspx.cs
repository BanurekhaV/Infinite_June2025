using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class CookieSource : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnredirect_Click(object sender, EventArgs e)
        {
            //1. using persistent cookie
            //HttpCookie hc = new HttpCookie("OurCookie"); //cookie with a name
            //hc["d1"] = txtusername.Text;
            //hc["d2"] = txtpassword.Text;
            //hc.Expires = DateTime.Now.AddMinutes(2);
            //Response.Cookies.Add(hc);
            //Response.Redirect("CookieDestination.aspx");

            //2. Non-persistent
            Response.Cookies["un"].Value = txtusername.Text;
            Response.Cookies["pwd"].Value = txtpassword.Text;
            Response.Redirect("CookieDestination.aspx");
        }
    }
}