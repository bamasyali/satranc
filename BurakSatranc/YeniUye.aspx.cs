using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Drawing;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Chess;

namespace BurakSatranc
{
    public partial class YeniUye : System.Web.UI.Page
    {
        private Random random = new Random();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["KullaniciAdi"] != null)
            {
                Session.Add("Hata", "Daha önce Giriş Yaptınız.");
                Response.Redirect("Hata.aspx");
            }
            if (Session["CaptchaImageText"] == null)
            {
                Session.Add("CaptchaImageText", GenerateRandomCode());
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
                       
            if(TextBox1.Text != Session["CaptchaImageText"].ToString()){
                Label6.Text = "Resimdeki Şifreyi Yanlış Girdiniz.";
                Session["CaptchaImageText"] = GenerateRandomCode();
                return;
            }
            string Kullaniciadi = KADI.Text;
            string sifre = Sifre.Text;
            string email = EMail.Text;
            string adi = Adi.Text;
            if(Sifre.Text!=Sifre0.Text){
                Label6.Text = "Şifreniz Doğrulanamadı.";
                return;
            }
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
            email= email.Replace("'", "");
            email = email.Replace(")", "");
            email = email.Replace("(", "");
            email = email.Replace("-", "");
            email = email.Replace("<", "");
            email = email.Replace(">", "");
            email = email.Replace("=", "");
            adi=adi.Replace("'", "");
            adi = adi.Replace(")", "");
            adi = adi.Replace("(", "");
            adi = adi.Replace("-", "");
            adi = adi.Replace("<", "");
            adi = adi.Replace(">", "");
            adi = adi.Replace("=", "");
            if (Kullaniciadi == string.Empty | sifre == string.Empty | email == string.Empty | adi == string.Empty)
            {
                Label6.Text=("Butun Kutuları Doldurunuz");
            }
            else
            {
                if (Baglanti.BuKullaniciAdiAlinmismi(Kullaniciadi))
                {
                    Label6.Text = ("Bu Kullanci İsmi Zaten Var.");
                }
                else
                {
                    try
                    {
                        Baglanti.SorguGonder("insert into Kullanici (KullaniciAdi,Sifre,EMail,AD,KayitTarihi,IP,YenmeSayisi,YenilmeSayisi,BeraberlikSayisi,SonGirisTarihi) values ('" + Kullaniciadi + "','" + FormsAuthentication.HashPasswordForStoringInConfigFile(sifre, "md5") + "','" + email + "','" + adi + "',Now,'" + Request.UserHostAddress.ToString() + "',0,0,0,Now);");
                        Response.Redirect("Basari.aspx");
                    }
                    catch
                    {
                        Label6.Text = ("Kullanıcı Eklenemedi");
                    }
                }
            }
        }
        private string GenerateRandomCode()
        {
            string s = "";
            for (int i = 0; i < 6; i++)
                s = String.Concat(s, this.random.Next(10).ToString());
            return s;
        }
       
    }
}
