using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WebApp
{
    public partial class Default : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void insertEventMethod(object sender, EventArgs e)
        {
            insertData();
           
        }

        private void insertData() {

            String CS = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Ding\source\repos\WebApp\WebApp\App_Data\Database1.mdf"";Integrated Security=True";
            SqlConnection conn = new SqlConnection(CS);
            conn.Open();
           
           

            string queryStr = "INSERT INTO[dbo].[Table] (name, age, address)" + "VALUES('" + nameTextBox.Text + "','" + ageTextBox.Text + "','" + addressTextBox.Text + "')";
            SqlCommand cmd = new SqlCommand(queryStr, conn);
            SqlDataReader rd = cmd.ExecuteReader();

            conn.Close();
           
            

        }

    }
}