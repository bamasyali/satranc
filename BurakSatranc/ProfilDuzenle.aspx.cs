using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using Chess;

namespace BurakSatranc
{
    public partial class ProfilDuzenle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["KullaniciAdi"] == null)
            {
                Response.Redirect("KullaniciGirisi.aspx");
            } 
            KullanıcıAdı.Text = Session["KullaniciAdi"].ToString();
            string cumle = "select * from Kullanici where KullaniciAdi = '" + Session["KullaniciAdi"].ToString() + "';";
            try
            {
                Baglanti.Connect();
                OleDbCommand myCommand = new OleDbCommand(cumle, Baglanti.DataBaseconnection);
                OleDbDataReader myReader = myCommand.ExecuteReader();
                myReader.Read();
                ID.Text = myReader.GetInt32(0).ToString();
                KullanıcıAdı.Text = myReader.GetString(1);
                if(ad.Text==string.Empty)
                    ad.Text = myReader.GetString(3);
                if(mail.Text==string.Empty)
                    mail.Text = myReader.GetString(4);
                Label2.Text = myReader.GetInt32(5).ToString();
                Label3.Text = myReader.GetInt32(6).ToString();
                Label4.Text = myReader.GetInt32(7).ToString();
                Label3.Text = myReader.GetInt32(6).ToString();
                Label4.Text = myReader.GetInt32(7).ToString();
                Label5.Text = myReader.GetDateTime(8).ToString();
                Label6.Text = myReader.GetDateTime(9).ToString();


                
                
            }
            catch (Exception ex)
            {
                Session.Add("Hata", "Veritabanı Hatasi" );
                Response.Redirect("Hata.aspx");
            }
            finally
            {
                Baglanti.DisConnect();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string email,adi;
            email=mail.Text;
            adi=ad.Text;
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
            if(adi==string.Empty|email==string.Empty){
                Label1.Text = "Lütfen Büteün Kutucukları Doldurunuz.";
                return;
            }
            try
            {
                string cumle = "update Kullanici set Ad = '" + adi + "',EMail ='" + email + "' where KullaniciAdi = '" + Session["KullaniciAdi"].ToString() + "' ;";
                Baglanti.SorguGonder(cumle);
                Response.Redirect("Basari.aspx");
            }catch(Exception ex){
                Label1.Text = "Veritabanında Bir Sorunla Karşılaşıldı.";
            }
        }

       
    }
}
