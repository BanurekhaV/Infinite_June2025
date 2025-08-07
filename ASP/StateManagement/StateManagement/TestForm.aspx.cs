using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class TestForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //1. viewstate object is not having any valid reference and hence exception

            //lblmsg.Text= "Your Name is : " + ViewState["uname"].ToString() +
            //    " and your Password is : "+ ViewState["pass"].ToString();

            //2. hidden fileds being objects, do not even show up in other pages
            //than where it is declared. Hence throws compilation error.

          //  lblmsg.Text = HiddenField1.Value + " " + HiddenField2.Value;
        }
    }
}