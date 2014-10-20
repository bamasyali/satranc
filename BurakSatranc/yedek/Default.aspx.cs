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
    public partial class Giris : System.Web.UI.Page
    {
        public static int Masanumarasi;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
           
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ChessTable Yeni = new ChessTable(1, 1,1);
            
            Response.Write(HttpContext.Current.Server.MapPath("BurakChess.mdb"));
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("Oyun.aspx");
        }

        protected void Login1_Authenticate1(object sender, AuthenticateEventArgs e)
        {
            try
            {
                if (Baglanti.KullaniciGirisi(Login1.UserName, Login1.Password))
                {
                    FormsAuthentication.SetAuthCookie(Login1.UserName, true);
                    
                    Response.Redirect("Oyun.aspx");
                }else{
                    Login1.FailureText = "Şifreniz Yanlış.";
                }
            }catch(Exception ex){
                Login1.FailureText=(ex.Message);
            }
        }

        protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            if (Baglanti.BuKullaniciAdiAlinmismi(TextBox1.Text))
            {
                Response.Write("Bu Kullanci İsmi Zaten Var.");
            }
            else
            {
                try
                {
                    Baglanti.SorguGonder("insert into Kullanici (KullaniciAdi,Sifre,EMail) values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox1.Text + "');");
                }
                catch
                {
                    Response.Write("Kullanıcı Eklenemedi");
                }
            }
        }

        protected void Button1_Click2(object sender, EventArgs e)
        {

        }
    }
}
