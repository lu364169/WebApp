using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using WebApp.Data_Layer;

namespace WebApp.Business_Logic_Layer
{
    public partial class DetailBLL : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public DataTable GetDetails() {
            try
            {
                DetailDAL objdal = new DetailDAL();
                return objdal.Read();
            }
            catch {
                throw;
            }
            
        }

        public void InsertDetail(string name, string age, string address)
        {
            try
            {
                DetailDAL insertdal = new DetailDAL();
                insertdal.Insert(name,age,address);
            }
            catch {
                throw;
            }
        }
    }
}