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
    public partial class Onayla : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["KullaniciAdi"] == null)
            {

                Response.Redirect("KullaniciGirisi.aspx");
            } 
            try
            {
                SatrancFramework yeni = new SatrancFramework(Convert.ToInt32(Request.Params["ID"]));
                Baglanti.SorguGonder("update Masa set BaslamaTarihi = Now,SonHamleTarihi = Now,Onay = True where ID = " + Convert.ToInt32(Request.Params["ID"]) + " and (BeyazOyuncuID = " + Session["KullaniciID"] + " or SiyahOyuncuID = " + Session["KullaniciID"] + " ) and NOT Kurucu ="+Session["KullaniciID"]+" ;");

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
