using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Chess;
using System.Data.OleDb;

namespace BurakSatranc
{
    public partial class TheManWhoRuleThisSite : System.Web.UI.Page
    {
        public TheManWhoRuleThisSite()
        {
           
           
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            bool onay=false;
            if (Session["KullaniciAdi"]==null){
                Response.Redirect("KullaniciGirisi.aspx");
            }
            try
            {
                onay = Baglanti.BuMuhteremAdminmi(Session["KullaniciAdi"].ToString());
                   
            }
            catch (System.Exception asdf)
            {
                Session.Add("Hata", asdf.Message);
                Response.Redirect("Hata.aspx");
            }
            if(!onay){
                Session.Add("Hata", "Admin Ol Gel");
                Response.Redirect("Hata.aspx");
                
            }
            GridView1.DataSource = Baglanti.TabloSorgula("Select ID,KullaniciAdi,Ad,EMail,YenmeSayisi,YenilmeSayisi,BeraberlikSayisi,KayitTarihi,SonGirisTarihi,IP from Kullanici;");
            GridView1.DataBind();   
            
            
        }
    }
}
