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
using Microsoft.Win32;
using WebApp.Business_Logic_Layer;


namespace WebApp.Display_Layer
{
    public partial class DisplayPage : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            try { 
                DetailBLL objbll = new DetailBLL();
                userName.DataSource = objbll.GetDetails();
                userName.DataBind();
            }
            catch {
                throw;
            }
            
        }

    }
}