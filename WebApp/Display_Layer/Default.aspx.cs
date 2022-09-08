using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using WebApp.Business_Logic_Layer;

namespace WebApp.Display_Layer
{
    public partial class Default : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void InsertEventMethod(object sender, EventArgs e)
        {
            try
            {
                UploadData();
                Response.Redirect("DisplayPage.aspx");
            }
            catch {
                throw;
            }
            
        }

        private void UploadData() {

            try
            {
                DetailBLL insert = new DetailBLL();
                insert.InsertDetail(nameTextBox.Text, ageTextBox.Text, addressTextBox.Text);
                
            }
            catch
            {
                throw;
            }
        }
    }
}