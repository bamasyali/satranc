using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BurakSatranc
{
    public partial class Hata : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void Hatayaz(){

            if (Session["Hata"] != null)
            {
                Response.Write(Session["Hata"]);
            }
            else
            {
                Response.Write("Bilinmiyor");
            }
            Session.Remove("Hata"); 
        }
    }
}
