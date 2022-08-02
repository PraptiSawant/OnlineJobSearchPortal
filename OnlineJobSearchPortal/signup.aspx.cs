using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
namespace OnlineJobSearchPortal
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Connectiondb"].ConnectionString);
                con.Open();
                string insert = "INSERT INTO userinfo (firstname,lastname,address,mob,gender,date,skill,exp) VALUES(@firstname,@lastname,@add,@mob,@gender,@date,@skill,@exp)";
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.Parameters.AddWithValue("@firstname", TextBox1.Text);
                cmd.Parameters.AddWithValue("@lastname", TextBox2.Text);
                cmd.Parameters.AddWithValue("@add", TextBox3.Text);
                cmd.Parameters.AddWithValue("@mob", TextBox4.Text);
                cmd.Parameters.AddWithValue("@gender", RadioButtonList1.Text);
                cmd.Parameters.AddWithValue("@date", Calendar1.SelectedDate.ToShortDateString());
                cmd.Parameters.AddWithValue("@skill", DropDownList1.Text);
                cmd.Parameters.AddWithValue("@exp", DropDownList2.Text);
                cmd.ExecuteNonQuery();
                Response.Write("<script>window.alert('Registered Successfully !!!!!');window.location='WebForm1.aspx';</script");
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}