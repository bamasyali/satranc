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
    public partial class KullaniciGirisi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["KullaniciAdi"] != null)
            {
                Session.Add("Hata", "Daha önce Giriş Yaptınız.");
                Response.Redirect("Hata.aspx");
            }
        }
        protected void Giris_Click(object sender, EventArgs e)
        {
           
            if(Session["GirisDeneme"]==null){
                Session.Add("GirisDeneme", "1");
            }else{
                if(Convert.ToInt32(Session["GirisDeneme"].ToString())>3){
                    Label1.Text = "3 Kezden Fazla Şifreinizi Yanlış Girdiniz. 20 dk bekleyiniz.";
                    return;
                }
            }


            string Kullaniciadi = KullaniciAdi.Text;
            string sifre = Sifre.Text;

            Kullaniciadi = Kullaniciadi.Replace("'", "");
            Kullaniciadi = Kullaniciadi.Replace(")", "");
            Kullaniciadi = Kullaniciadi.Replace("(", "");
            Kullaniciadi = Kullaniciadi.Replace("-", "");
            Kullaniciadi = Kullaniciadi.Replace("<", "");
            Kullaniciadi = Kullaniciadi.Replace(">", "");
            Kullaniciadi = Kullaniciadi.Replace("=", "");
            sifre = sifre.Replace("'", "");
            sifre = sifre.Replace(")", "");
            sifre = sifre.Replace("(", "");
            sifre = sifre.Replace("-", "");
            sifre = sifre.Replace("<", "");
            sifre = sifre.Replace(">", "");
            sifre = sifre.Replace("=", "");


            if (Kullaniciadi == string.Empty || sifre == string.Empty)
            {
               Label1.Text=("Kullanici Adini Ve Sifresini Giriniz.");
            }
            else
            {
                try
                {
                    if (Baglanti.KullaniciGirisi(Kullaniciadi, FormsAuthentication.HashPasswordForStoringInConfigFile(sifre, "md5")))
                    {
                       
                        Session.Add("KullaniciAdi", Kullaniciadi);
                        Session.Add("KullaniciID", Baglanti.IDBul(Kullaniciadi));                   
                        Baglanti.SorguGonder("update Kullanici set SonGirisTarihi=Now, IP = '" + Request.UserHostAddress.ToString() + "'  where KullaniciAdi ='" + Kullaniciadi + "';");
                        Session.Remove("GirisDeneme");
                        Response.Redirect("Basari.aspx");
                    }
                    else
                    {
                        Session["GirisDeneme"]=Convert.ToInt32(Session["GirisDeneme"].ToString()) + 1;
                        Label1.Text=("Şifreniz Yanlış.");
                    }
                }
                catch (Exception ex)
                {
                    Label1.Text = "Böyle Bir Kullanıcı Mevcut Değil.";
                }

            }
        }
    }
}
