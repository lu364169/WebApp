using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebApp.Data_Layer
{
    public partial class DetailDAL : System.Web.UI.Page
    {

        //Establish Connection using Cs stored inside the web.config file
        SqlConnection conn = new SqlConnection(connectionString: ConfigurationManager.ConnectionStrings["localdb"].ConnectionString);
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        public void Insert(string name2, string age2, string address2) {

            if (ConnectionState.Closed == conn.State)
                conn.Open();

            try
            {
                string queryStr = "INSERT INTO[dbo].[Table] (name, age, address)" + "VALUES('" + name2 + "','" + age2 + "','" + address2 + "')";
                SqlCommand cmd = new SqlCommand(queryStr, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch
            {
                throw;
            }

        }
           
                

        //Read menthod to obtain data from DB
        public DataTable Read() {

            if (ConnectionState.Closed == conn.State)
                conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[Table]", conn);
            try {

                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                conn.Close();
                return dt;
            }
            catch
            {
                throw;
            }
        }
        
    }
}
