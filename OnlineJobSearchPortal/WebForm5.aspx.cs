using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace OnlineJobSearchPortal
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            var v = int.Parse(TextBox1.Text);
            var result = v * v * v;
            Label1.Text = result.ToString();
            for (var i=0;i<v;i++)
            {
                CheckBox ch = new CheckBox();
                Panel1.Controls.Add(ch);
            }

        }
    }
}