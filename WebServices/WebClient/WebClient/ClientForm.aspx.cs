using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebClient
{
    public partial class ClientForm : System.Web.UI.Page
    {
        TrailServiceReference1.TrialWebService1SoapClient client =
            new TrailServiceReference1.TrialWebService1SoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnHelloWorld_Click(object sender, EventArgs e)
        {
            lblstatus.Text = client.HelloWorld();
        }

        protected void btnSayHello_Click(object sender, EventArgs e)
        {
            lblstatus.Text = client.SayHello(txtuname.Text);
        }

        protected void btnSqaure_Click(object sender, EventArgs e)
        {
            lblstatus.Text = client.Squareroot(Convert.ToSingle(txtfnum.Text)).ToString();
        }
    }
}