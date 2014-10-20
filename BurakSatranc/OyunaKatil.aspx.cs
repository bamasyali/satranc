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
using System.Data.OleDb;
using System.Net;
using System.IO;
using System.Text;
using Chess;

namespace BurakSatranc
{
    public partial class OyunaKatil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["KullaniciAdi"] == null)
            {

                Response.Redirect("KullaniciGirisi.aspx");
            } 
            try
            {
                Baglanti.SorguGonder("update Masa set SiyahOyuncuID = " + Session["KullaniciID"] + ", BaslamaTarihi = Now,SonHamleTarihi = Now,Onay = True where SiyahOyuncuID = 0 and ID = " + Convert.ToInt32(Request.Params["ID"]) + " and not BeyazOyuncuID = "+ Session["KullaniciID"]+" ;");
                Baglanti.SorguGonder("update Masa set BeyazOyuncuID = " + Session["KullaniciID"] + ", BaslamaTarihi = Now,SonHamleTarihi = Now,Onay = True where BeyazOyuncuID = 0 and ID = " + Convert.ToInt32(Request.Params["ID"]) + " and not SiyahOyuncuID = " + Session["KullaniciID"] + " ;");
            }
            catch (Exception hata1)
            {
                Session.Add("Hata", hata1.Message);
                Response.Redirect("Hata.aspx");

            }
            Response.Redirect("Anasayfa.aspx");
        }
    }
}
