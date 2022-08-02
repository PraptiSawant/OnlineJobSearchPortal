using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace OnlineJobSearchPortal
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("signup.aspx");
        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Connectiondb"].ConnectionString);
                con.Open();
                string insert = "SELECT COUNT(*) FROM userinfo where firstname='" + TextBox1.Text + "' and mob= '" + TextBox2.Text+ "'";
                SqlCommand cmd = new SqlCommand(insert, con); 
                SqlDataAdapter sda = new SqlDataAdapter(insert,con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Session["username"] = TextBox1.Text;
                Session["mob"] = TextBox2.Text;
                cmd.ExecuteNonQuery();
                if(dt.Rows[0][0].ToString()=="1")
                {
                    Response.Write("<script>window.alert('Successful login');window.location='WebForm1.aspx';</script");
                }
                else
                {
                    Response.Write("<script>alert('error in  login')</script");
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }

        }
    }
}