using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BurakSatranc
{
    public partial class GuvenliCikis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.RemoveAll();
            
            Response.Redirect("Basari.aspx");
        }
    }
}
