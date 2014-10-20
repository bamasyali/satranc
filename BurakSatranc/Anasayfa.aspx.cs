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
    public partial class Anasayfa : System.Web.UI.Page
    {
      
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["KullaniciAdi"] == null)
            {
               
                Response.Redirect("KullaniciGirisi.aspx");
            }
            
            
        }
        public string KullaniciAdi{
            get { return Session["KullaniciAdi"].ToString(); }
        }
        public void SiraBendeOlanMaclariYaz()
        {
            string Hedef;
            if(CheckBox1.Checked){
                Hedef = "Yazismali.aspx";
            }else{
                Hedef = "FareIleOyna.aspx";
            }

            string cumle = "SELECT ID,(Select Kullanici.KullaniciAdi from Kullanici where Kullanici.ID = Masa.BeyazOyuncuID) AS BeyazOyuncu,(Select Kullanici.KullaniciAdi from Kullanici where Kullanici.ID = Masa.SiyahOyuncuID) AS SiyahOyuncu,Uluslararasi FROM Masa where (BeyazOyuncuID = " + Session["KullaniciID"] + " or SiyahOyuncuID = " + Session["KullaniciID"] + ") and Masa.BeyazOyuncuID > 0 and Masa.SiyahOyuncuID > 0 and ((BeyazOyuncuID=" + Session["KullaniciID"] + " and SiraBeyazdami = true) or (SiyahOyuncuID=" + Session["KullaniciID"] + " and SiraBeyazdami = false)) and Masa.SiyahOyuncuID > 0 and (OyunDurumu = 0 or Oyundurumu = 3 or OyunDurumu = 4) and Onay = True ;";
            try
            {
                Baglanti.Connect();
                OleDbCommand myCommand = new OleDbCommand(cumle, Baglanti.DataBaseconnection);
                OleDbDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    try
                    {
                        Response.Write("<a href='"+Hedef+"?ID=" + myReader.GetInt32(0) + "'>" + myReader.GetInt32(0) + "   -   " + myReader.GetString(1) + "   -   " + myReader.GetString(2) + "</a>");
                        if (myReader.GetBoolean(3))
                        {
                            Response.Write(" - (U)<br>");
                        }
                        else
                        {
                            Response.Write("<br>");
                        }
                    }
                    catch (Exception hata)
                    {
                        Response.Write("hatalı Kayit" + hata.Message + "<br>");
                    }
                }
            }
            catch (Exception ex)
            {
                Session.Add("Hata", "Maçları Yazarken " + ex.Message);
                Response.Redirect("Hata.aspx");
            }
            finally
            {
                Baglanti.DisConnect();
            }

        }
        public void OnayBekleyenMaclariYaz()
        {
            string Hedef;
            
            

            string cumle = "SELECT ID,(Select Kullanici.KullaniciAdi from Kullanici where Kullanici.ID = Masa.BeyazOyuncuID) AS BeyazOyuncu,(Select Kullanici.KullaniciAdi from Kullanici where Kullanici.ID = Masa.SiyahOyuncuID) AS SiyahOyuncu,Uluslararasi FROM Masa where (BeyazOyuncuID = " + Session["KullaniciID"] + " or SiyahOyuncuID = " + Session["KullaniciID"] + ") and Masa.BeyazOyuncuID > 0 and Masa.SiyahOyuncuID > 0 and Onay = false ;";
            try
            {
                Baglanti.Connect();
                OleDbCommand myCommand = new OleDbCommand(cumle, Baglanti.DataBaseconnection);
                OleDbDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    try
                    {
                        
                        
                        Response.Write("<a href='Onayla.aspx?ID=" + myReader.GetInt32(0) + "'>" + myReader.GetInt32(0) + "   -   " + myReader.GetString(1) + "   -   " + myReader.GetString(2) + "</a>");
                        if (myReader.GetBoolean(3))
                        {
                            Response.Write(" - (U)<br>");
                        }
                        else
                        {
                            Response.Write("<br>");
                        }
                    }
                    catch (Exception hata)
                    {
                        Response.Write("hatalı Kayit" + hata.Message + "<br>");
                    }
                }
            }
            catch (Exception ex)
            {
                Session.Add("Hata", "Maçları Yazarken " + ex.Message);
                Response.Redirect("Hata.aspx");
            }
            finally
            {
                Baglanti.DisConnect();
            }

        }
        public void DevamEdenMaclariYaz()
        {

            string Hedef;
            if (CheckBox1.Checked)
            {
                Hedef = "Yazismali.aspx";
            }
            else
            {
                Hedef = "FareIleOyna.aspx";
            }
            string cumle = "SELECT ID,(Select Kullanici.KullaniciAdi from Kullanici where Kullanici.ID = Masa.BeyazOyuncuID) AS BeyazOyuncu,(Select Kullanici.KullaniciAdi from Kullanici where Kullanici.ID = Masa.SiyahOyuncuID) AS SiyahOyuncu,Uluslararasi FROM Masa where (BeyazOyuncuID = " + Session["KullaniciID"] + " or SiyahOyuncuID = " + Session["KullaniciID"] + ") and Masa.BeyazOyuncuID > 0 and Masa.SiyahOyuncuID > 0 and (OyunDurumu = 0 or Oyundurumu = 3 or OyunDurumu = 4) and Onay = True ;";
            try
            {
                Baglanti.Connect();
                OleDbCommand myCommand = new OleDbCommand(cumle, Baglanti.DataBaseconnection);
                OleDbDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    try
                    {
                        Response.Write("<a href='"+Hedef+"?ID=" + myReader.GetInt32(0) + "'>" + myReader.GetInt32(0) + "   -   " + myReader.GetString(1) + "   -   " + myReader.GetString(2) + "</a>");
                        if (myReader.GetBoolean(3))
                        {
                            Response.Write(" - (U)<br>");
                        }
                        else
                        {
                            Response.Write("<br>");
                        }
                    }
                    catch(Exception hata)
                    {
                        Response.Write("hatalı Kayit" + hata.Message + "<br>");
                    }
                }
            }
            catch (Exception ex)
            {
                Session.Add("Hata","Maçları Yazarken " + ex.Message);
                Response.Redirect("Hata.aspx");
            }
            finally
            {
                Baglanti.DisConnect();
            }
          
        }
        public void EskiMaclariYaz()
        {
            string Hedef;
            if (CheckBox1.Checked)
            {
                Hedef = "Yazismali.aspx";
            }
            else
            {
                Hedef = "FareIleOyna.aspx";
            }

            string cumle = "SELECT ID,(Select Kullanici.KullaniciAdi from Kullanici where Kullanici.ID = Masa.BeyazOyuncuID) AS BeyazOyuncu,(Select Kullanici.KullaniciAdi from Kullanici where Kullanici.ID = Masa.SiyahOyuncuID) AS SiyahOyuncu,Uluslararasi FROM Masa where (BeyazOyuncuID = " + Session["KullaniciID"] + " or SiyahOyuncuID = " + Session["KullaniciID"] + ") and Masa.BeyazOyuncuID > 0 and Masa.SiyahOyuncuID > 0 and (OyunDurumu = 1 or Oyundurumu = 2) ;";
            try
            {
                Baglanti.Connect();
                OleDbCommand myCommand = new OleDbCommand(cumle, Baglanti.DataBaseconnection);
                OleDbDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    try
                    {
                        Response.Write("<a href='"+Hedef+"?ID=" + myReader.GetInt32(0) + "'>" + myReader.GetInt32(0) + "   -   " + myReader.GetString(1) + "   -   " + myReader.GetString(2) + "</a>");
                        if (myReader.GetBoolean(3))
                        {
                            Response.Write(" - (U)<br>");
                        }else{
                            Response.Write("<br>");
                        }
                    }
                    catch (Exception hata)
                    {
                        Response.Write("hatalı Kayit" + hata.Message + "<br>");
                    }
                }
            }
            catch (Exception ex)
            {
                Session.Add("Hata", "Maçları Yazarken " + ex.Message);
                Response.Redirect("Hata.aspx");
            }
            finally
            {
                Baglanti.DisConnect();
            }

        }
        public void ButunMaclariYaz()
        {
            string Hedef;
            if (CheckBox1.Checked)
            {
                Hedef = "Yazismali.aspx";
            }
            else
            {
                Hedef = "FareIleOyna.aspx";
            }

            string cumle = "SELECT ID,(Select Kullanici.KullaniciAdi from Kullanici where Kullanici.ID = Masa.BeyazOyuncuID) AS BeyazOyuncu,(Select Kullanici.KullaniciAdi from Kullanici where Kullanici.ID = Masa.SiyahOyuncuID) AS SiyahOyuncu,Uluslararasi FROM Masa where Masa.BeyazOyuncuID > 0 and Masa.SiyahOyuncuID > 0 and (OyunDurumu = 0 or Oyundurumu = 3 or OyunDurumu = 4) and Onay = True ;";
            try
            {
                Baglanti.Connect();
                OleDbCommand myCommand = new OleDbCommand(cumle, Baglanti.DataBaseconnection);
                OleDbDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    try
                    {
                        Response.Write("<a href='"+Hedef+"?ID=" + myReader.GetInt32(0) + "'>" + myReader.GetInt32(0) + "   -   " + myReader.GetString(1) + "   -   " + myReader.GetString(2) + "</a>");
                        if (myReader.GetBoolean(3))
                        {
                            Response.Write(" - (U)<br>");
                        }
                        else
                        {
                            Response.Write("<br>");
                        }
                    }
                    catch (Exception hata)
                    {
                        Response.Write("hatalı Kayit" + hata.Message + "<br>");
                    }
                }
            }
            catch (Exception ex)
            {
                Session.Add("Hata", "Maçları Yazarken " + ex.Message);
                Response.Redirect("Hata.aspx");
            }
            finally
            {
                
                Baglanti.DisConnect();
            }

        }
        public void ButunBitenMaclariYaz()
        {
            string Hedef;
            if (CheckBox1.Checked)
            {
                Hedef = "Yazismali.aspx";
            }
            else
            {
                Hedef = "FareIleOyna.aspx";
            }

            string cumle = "SELECT ID,(Select Kullanici.KullaniciAdi from Kullanici where Kullanici.ID = Masa.BeyazOyuncuID) AS BeyazOyuncu,(Select Kullanici.KullaniciAdi from Kullanici where Kullanici.ID = Masa.SiyahOyuncuID) AS SiyahOyuncu,Uluslararasi FROM Masa where Masa.BeyazOyuncuID > 0 and Masa.SiyahOyuncuID > 0 and (OyunDurumu = 2 or Oyundurumu = 1);";
            try
            {
                Baglanti.Connect();
                OleDbCommand myCommand = new OleDbCommand(cumle, Baglanti.DataBaseconnection);
                OleDbDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    try
                    {
                        Response.Write("<a href='"+Hedef+"?ID=" + myReader.GetInt32(0) + "'>" + myReader.GetInt32(0) + "   -   " + myReader.GetString(1) + "   -   " + myReader.GetString(2) + "</a>");
                        if (myReader.GetBoolean(3))
                        {
                            Response.Write(" - (U)<br>");
                        }
                        else
                        {
                            Response.Write("<br>");
                        }
                    }
                    catch (Exception hata)
                    {
                        Response.Write("hatalı Kayit" + hata.Message + "<br>");
                    }
                }
            }
            catch (Exception ex)
            {
                Session.Add("Hata", "Maçları Yazarken " + ex.Message);
                Response.Redirect("Hata.aspx");
            }
            finally
            {
                Baglanti.DisConnect();
            }

        }
      
        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
           
            
            return;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("MasaOlustur.aspx");
        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
           
            CheckBox2.Checked = CheckBox1.Checked;
            CheckBox1.Checked = !CheckBox1.Checked;
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox1.Checked = CheckBox2.Checked;
            CheckBox2.Checked = !CheckBox2.Checked;
        }
    }
}
