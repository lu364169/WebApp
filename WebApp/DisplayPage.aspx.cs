using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Configuration;

namespace WebApp
{
    public partial class DisplayPage : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            String CS = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Ding\source\repos\WebApp\WebApp\App_Data\Database1.mdf"";Integrated Security=True";
            SqlConnection conn = new SqlConnection(CS);
            conn.Open();
            string queryStr = "SELECT * FROM [dbo].[Table]";
            SqlCommand cmd = new SqlCommand(queryStr, conn);
            SqlDataReader rd = cmd.ExecuteReader();

            userName.DataSource = rd;
            userName.DataBind();


            conn.Close();
        }
    }
}