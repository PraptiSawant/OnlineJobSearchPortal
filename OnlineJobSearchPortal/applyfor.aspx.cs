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
    public partial class applyfor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Request.QueryString["name"];
            Label2.Text = Request.QueryString["location"];
            

        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                string x = Session["username"].ToString();
                string y = Session["mob"].ToString();
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Connectiondb"].ConnectionString);
                con.Open();
                Response.Write(Session["username"]);
                string insert = "SELECT Id FROM userinfo where firstname='" +x+ "' and mob= '" +y+ "'";
                SqlCommand cmd = new SqlCommand(insert, con);
                SqlDataAdapter sda = new SqlDataAdapter(insert, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cmd.ExecuteNonQuery();
                int uid = Convert.ToInt32(dt.Rows[0][0]);
                string qry = "INSERT INTO apply (cid,uid,resume) VALUES (@firstname,@lastname,@add)";
                SqlCommand cmd1 = new SqlCommand(qry, con);
                cmd1.Parameters.AddWithValue("@firstname", Session["cid"]);
                cmd1.Parameters.AddWithValue("@lastname",uid);
                cmd1.Parameters.AddWithValue("@add", FileUpload1.FileName.ToString());
                cmd1.ExecuteNonQuery();
                Response.Write("<script>window.alert('Application Sent');window.location='WebForm1.aspx';</script");
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }
    }
}