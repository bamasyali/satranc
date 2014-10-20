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
    public partial class SifreDegistir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["KullaniciAdi"] == null)
            {

                Response.Redirect("KullaniciGirisi.aspx");
            } 
        }

        protected void EskiSifre1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(Sifre0.Text!=Sifre1.Text){
                Label1.Text = "Yeni Şifrenizi 2. Girişte Yanlış Girdiniz.";
                return;
            }
            string eskisifre = EskiSifre.Text;
            string Yenisifre = Sifre1.Text;
            Yenisifre = Yenisifre.Replace("'", "");
            Yenisifre = Yenisifre.Replace(")", "");
            Yenisifre = Yenisifre.Replace("(", "");
            Yenisifre = Yenisifre.Replace("-", "");
            Yenisifre = Yenisifre.Replace("<", "");
            Yenisifre = Yenisifre.Replace(">", "");
            Yenisifre = Yenisifre.Replace("=", "");

            eskisifre = eskisifre.Replace("'", "");
            eskisifre = eskisifre.Replace(")", "");
            eskisifre = eskisifre.Replace("(", "");
            eskisifre = eskisifre.Replace("-", "");
            eskisifre = eskisifre.Replace("<", "");
            eskisifre = eskisifre.Replace(">", "");
            eskisifre = eskisifre.Replace("=", "");
            try
            {
                if (Baglanti.KullaniciGirisi(Session["KullaniciAdi"].ToString(), FormsAuthentication.HashPasswordForStoringInConfigFile(eskisifre, "md5")))
                {
                    string cumle = "update Kullanici set Sifre = '" + FormsAuthentication.HashPasswordForStoringInConfigFile(Yenisifre, "md5") + "' where KullaniciAdi = '"+Session["KullaniciAdi"].ToString()+"';";
                    Baglanti.SorguGonder(cumle);
                    Response.Redirect("Basari.aspx");
                }
                else
                {
                    Label1.Text = "Eski Şifrenizi Yanlış Girdiniz.";
                }
            }catch{
                Label1.Text = "Veritabanında Bir Sorun Oluştu.";
            }
        }
    }
}
