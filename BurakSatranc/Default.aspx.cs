using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Chess;

namespace BurakSatranc
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = Baglanti.TabloSorgula("Select KullaniciAdi,YenmeSayisi,YenilmeSayisi,BeraberlikSayisi,SonGirisTarihi from Kullanici where YenmeSayisi >0 or YenilmeSayisi > 0 or BeraberlikSayisi > 0 order by YenmeSayisi desc,YenilmeSayisi asc,BeraberlikSayisi desc;");
            GridView1.DataBind();
        
        }

        protected void YeniUye_Click(object sender, EventArgs e)
        {
            Response.Redirect("YeniUye.aspx");
        }

        
    }
}
