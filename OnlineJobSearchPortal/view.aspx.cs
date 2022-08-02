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
    public partial class view : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Connectiondb"].ConnectionString);
                con.Open();
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e )
        {
            if (e.CommandName == "Select")
            {
                //Determine the RowIndex of the Row whose Button was clicked.
                int rowIndex = Convert.ToInt32(e.CommandArgument);

                //Reference the GridView Row.
                GridViewRow row = GridView1.Rows[rowIndex];
                Session["cid"]= row.Cells[0].Text;
                string cn = row.Cells[1].Text;
                string loc = row.Cells[2].Text;
                string url;
                url = "applyfor.aspx?name=" + cn + "&location=" +loc;
                Response.Redirect(url);
            }
        }
    }
}