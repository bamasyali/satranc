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
    public partial class OyunBul : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["KullaniciAdi"] == null)
            {

                Response.Redirect("KullaniciGirisi.aspx");
            } 
        }
        public void BosMaclariYaz()
        {
            Response.Write("OYUNID - BeyazOyuncu - <br><br>");
            string oyuncu;


            string cumle = "SELECT ID,(Select Kullanici.KullaniciAdi from Kullanici where Kullanici.ID = Masa.BeyazOyuncuID) AS BeyazOyuncu,(Select Kullanici.KullaniciAdi from Kullanici where Kullanici.ID = Masa.SiyahOyuncuID) AS SiyahOyuncu,ToplamGunLimiti,HamleGunLimiti,Uluslararasi FROM Masa where SiyahOyuncuID = 0 or BeyazOyuncuID = 0;";
            try
            {
                Baglanti.Connect();
                OleDbCommand myCommand = new OleDbCommand(cumle, Baglanti.DataBaseconnection);
                OleDbDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    try{
                        oyuncu = "Beyaz Oyuncu = " + myReader.GetString(1);
                       
                    }catch{
                        oyuncu = "Siyah Oyuncu = " + myReader.GetString(2);
                    }                    
                    try
                    {
                        Response.Write("<a href='OyunaKatil.aspx?ID=" + myReader.GetInt32(0) + "'>" + myReader.GetInt32(0) + "  -   " + oyuncu + "  - Oyun Süresi = " + myReader.GetInt32(3) + "  - Hamle Süresi =  " + myReader.GetInt32(4));
                        if (myReader.GetBoolean(5))
                        {
                            Response.Write(" - (U)<br>");
                        }
                        else
                        {
                            Response.Write("<br>");
                        }
                    }
                    catch
                    {
                        Response.Write("Hatalı Kayıt<br>");
                    }
                }
            }
            catch (Exception ex)
            {
                Session.Add("Hata", "Boş maçları Yazarken " );
                Response.Redirect("Hata.aspx");
            }
            finally
            {
                Baglanti.DisConnect();
            }

        }
    }
}
