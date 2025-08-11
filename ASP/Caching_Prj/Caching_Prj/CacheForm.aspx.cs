using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace Caching_Prj
{
    public partial class CacheForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                GetProductsByName("All");
                Response.Cache.SetExpires(DateTime.Now.AddSeconds(30)); //duration
                Response.Cache.VaryByParams["None"] = true;  //varyby param
                Response.Cache.SetCacheability(HttpCacheability.ServerAndPrivate); //location
            }
            else
            {
                //Response.Cache.SetExpires(DateTime.Now.AddSeconds(30)); //duration
                //Response.Cache.VaryByParams["None"] = true;  //varyby param
                //Response.Cache.SetCacheability(HttpCacheability.ServerAndPrivate); //location
            }
            lblmsg.Text = "This Page is Cached at : " + DateTime.Now.ToString();
        }

        private void GetProductsByName(string productname)
        {
            SqlConnection con = new SqlConnection("Data source=laptop-tjj7d977; initial catalog=infinitedb;" +
                "trusted_connection=true;");
          //  con.Open();
            SqlDataAdapter da = new SqlDataAdapter("spGetProductsByName", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter param1 = new SqlParameter();
            param1.ParameterName = "@productname";
            param1.Value = productname;
            da.SelectCommand.Parameters.Add(param1);

            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void DDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetProductsByName(DDL.SelectedValue);
        }
    }
}