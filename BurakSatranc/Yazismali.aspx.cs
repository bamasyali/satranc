using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using Chess;

namespace BurakSatranc
{
    public partial class Yazismali : System.Web.UI.Page
    {
        public void Oynayanlar()
        {
            try
            {
                Baglanti.Connect();
                OleDbCommand myCommand = new OleDbCommand("SELECT SiyahOyuncuID,BeyazOyuncuID FROM Masa where ID=" + Convert.ToUInt32(Request.Params["ID"]) + ";", Baglanti.DataBaseconnection);
                OleDbDataReader myReader = myCommand.ExecuteReader();
                myReader.Read();
                int siyah, bayaz;
                siyah = myReader.GetInt32(0);
                bayaz = myReader.GetInt32(1);
                Baglanti.DisConnect();
                Response.Write("Siyah Oyuncu = <br>" + Baglanti.KullaniciAdiBul(siyah) + "<br><br>Beyaz Oyuncu=<br>" + Baglanti.KullaniciAdiBul(bayaz));

            }
            catch (Exception asd)
            {

            }

        }
        private bool BuMasaBuKisininmi()
        {
            try
            {
                Baglanti.Connect();
                OleDbCommand myCommand = new OleDbCommand("SELECT SiyahOyuncuID,BeyazOyuncuID FROM Masa where ID=" + Convert.ToUInt32(Request.Params["ID"]) + ";", Baglanti.DataBaseconnection);
                OleDbDataReader myReader = myCommand.ExecuteReader();
                myReader.Read();
                int siyah, bayaz;
                siyah = myReader.GetInt32(0);
                bayaz = myReader.GetInt32(1);
                Baglanti.DisConnect();
                return (siyah == Convert.ToInt32(Session["KullaniciID"]) | (bayaz == Convert.ToInt32(Session["KullaniciID"])));

            }
            catch (Exception asd)
            {
                Session.Add("Hata", asd.Message);
                Response.Redirect("Hata.aspx");
            }
            return false;

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["KullaniciAdi"] == null)
            {
                Response.Redirect("Default.aspx");
            }
           

            int sayi;
            try
            {
                sayi = Convert.ToInt32(Request.Params["ID"]);
            }
            catch
            {
                Response.Redirect("Anasayfa.aspx");
            }

            SatrancFramework masam;
            try
            {
                masam = new SatrancFramework(Convert.ToInt32(Request.Params["ID"]));
                Ekran(masam);
                SonHamleTarihi.Text = masam.Sonhamle.ToString();
                BaslamaTarihi.Text = masam.Baslamatarihi.ToString();
                HamleLimiti.Text = masam.HamlegunLimiti.ToString();
                OyunSuresi.Text = masam.ToplamgunLimiti.ToString();
            }
            
            catch (Exception hata)
            {
                Sorun.Text = hata.StackTrace;
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Oyna();
        }
        public string resimbul(SatrancTasi x)
        {
            if (x.renk == RenkEnum.Beyaz)
            {
                if (x.tur == TurEnum.At)
                {
                    return "Resimler/bat.gif";
                }
                else if (x.tur == TurEnum.Fil)
                {
                    return "Resimler/bfil.gif";
                }
                else if (x.tur == TurEnum.Kale)
                {
                    return "Resimler/bkale.gif";
                }
                else if (x.tur == TurEnum.Vezir)
                {
                    return "Resimler/bvezir.gif";
                }
                else if (x.tur == TurEnum.Piyon)
                {
                    return "Resimler/bpiyon.gif";
                }
                else if (x.tur == TurEnum.Sah)
                {
                    return "Resimler/bsah.gif";
                }
            }
            else if (x.renk == RenkEnum.Siyah)
            {
                if (x.tur == TurEnum.At)
                {
                    return "Resimler/sat.gif";
                }
                else if (x.tur == TurEnum.Fil)
                {
                    return "Resimler/sfil.gif";
                }
                else if (x.tur == TurEnum.Kale)
                {
                    return "Resimler/skale.gif";
                }
                else if (x.tur == TurEnum.Vezir)
                {
                    return "Resimler/svezir.gif";
                }
                else if (x.tur == TurEnum.Piyon)
                {
                    return "Resimler/spiyon.gif";
                }
                else if (x.tur == TurEnum.Sah)
                {
                    return "Resimler/ssah.gif";
                }
            }
            return "Resimler/back1.gif";

        }
        public void Ekran(SatrancFramework masam)
        {
            if (Convert.ToInt32(Session["KullaniciID"]) == masam.BeyazkullaniciID)
            {
                Session.Add("Renk", "Beyaz");
                ImageButton1.ImageUrl = resimbul(masam.masaKareleri[7, 0]);
                ImageButton2.ImageUrl = resimbul(masam.masaKareleri[7, 1]);
                ImageButton3.ImageUrl = resimbul(masam.masaKareleri[7, 2]);
                ImageButton4.ImageUrl = resimbul(masam.masaKareleri[7, 3]);
                ImageButton5.ImageUrl = resimbul(masam.masaKareleri[7, 4]);
                ImageButton6.ImageUrl = resimbul(masam.masaKareleri[7, 5]);
                ImageButton7.ImageUrl = resimbul(masam.masaKareleri[7, 6]);
                ImageButton8.ImageUrl = resimbul(masam.masaKareleri[7, 7]);
                ImageButton9.ImageUrl = resimbul(masam.masaKareleri[6, 0]);
                ImageButton10.ImageUrl = resimbul(masam.masaKareleri[6, 1]);
                ImageButton11.ImageUrl = resimbul(masam.masaKareleri[6, 2]);
                ImageButton12.ImageUrl = resimbul(masam.masaKareleri[6, 3]);
                ImageButton13.ImageUrl = resimbul(masam.masaKareleri[6, 4]);
                ImageButton14.ImageUrl = resimbul(masam.masaKareleri[6, 5]);
                ImageButton15.ImageUrl = resimbul(masam.masaKareleri[6, 6]);
                ImageButton16.ImageUrl = resimbul(masam.masaKareleri[6, 7]);
                ImageButton17.ImageUrl = resimbul(masam.masaKareleri[5, 0]);
                ImageButton18.ImageUrl = resimbul(masam.masaKareleri[5, 1]);
                ImageButton19.ImageUrl = resimbul(masam.masaKareleri[5, 2]);
                ImageButton20.ImageUrl = resimbul(masam.masaKareleri[5, 3]);
                ImageButton21.ImageUrl = resimbul(masam.masaKareleri[5, 4]);
                ImageButton22.ImageUrl = resimbul(masam.masaKareleri[5, 5]);
                ImageButton23.ImageUrl = resimbul(masam.masaKareleri[5, 6]);
                ImageButton24.ImageUrl = resimbul(masam.masaKareleri[5, 7]);
                ImageButton25.ImageUrl = resimbul(masam.masaKareleri[4, 0]);
                ImageButton26.ImageUrl = resimbul(masam.masaKareleri[4, 1]);
                ImageButton27.ImageUrl = resimbul(masam.masaKareleri[4, 2]);
                ImageButton28.ImageUrl = resimbul(masam.masaKareleri[4, 3]);
                ImageButton29.ImageUrl = resimbul(masam.masaKareleri[4, 4]);
                ImageButton30.ImageUrl = resimbul(masam.masaKareleri[4, 5]);
                ImageButton31.ImageUrl = resimbul(masam.masaKareleri[4, 6]);
                ImageButton32.ImageUrl = resimbul(masam.masaKareleri[4, 7]);
                ImageButton33.ImageUrl = resimbul(masam.masaKareleri[3, 0]);
                ImageButton34.ImageUrl = resimbul(masam.masaKareleri[3, 1]);
                ImageButton35.ImageUrl = resimbul(masam.masaKareleri[3, 2]);
                ImageButton36.ImageUrl = resimbul(masam.masaKareleri[3, 3]);
                ImageButton37.ImageUrl = resimbul(masam.masaKareleri[3, 4]);
                ImageButton38.ImageUrl = resimbul(masam.masaKareleri[3, 5]);
                ImageButton39.ImageUrl = resimbul(masam.masaKareleri[3, 6]);
                ImageButton40.ImageUrl = resimbul(masam.masaKareleri[3, 7]);
                ImageButton41.ImageUrl = resimbul(masam.masaKareleri[2, 0]);
                ImageButton42.ImageUrl = resimbul(masam.masaKareleri[2, 1]);
                ImageButton43.ImageUrl = resimbul(masam.masaKareleri[2, 2]);
                ImageButton44.ImageUrl = resimbul(masam.masaKareleri[2, 3]);
                ImageButton45.ImageUrl = resimbul(masam.masaKareleri[2, 4]);
                ImageButton46.ImageUrl = resimbul(masam.masaKareleri[2, 5]);
                ImageButton47.ImageUrl = resimbul(masam.masaKareleri[2, 6]);
                ImageButton48.ImageUrl = resimbul(masam.masaKareleri[2, 7]);
                ImageButton49.ImageUrl = resimbul(masam.masaKareleri[1, 0]);
                ImageButton50.ImageUrl = resimbul(masam.masaKareleri[1, 1]);
                ImageButton51.ImageUrl = resimbul(masam.masaKareleri[1, 2]);
                ImageButton52.ImageUrl = resimbul(masam.masaKareleri[1, 3]);
                ImageButton53.ImageUrl = resimbul(masam.masaKareleri[1, 4]);
                ImageButton54.ImageUrl = resimbul(masam.masaKareleri[1, 5]);
                ImageButton55.ImageUrl = resimbul(masam.masaKareleri[1, 6]);
                ImageButton56.ImageUrl = resimbul(masam.masaKareleri[1, 7]);
                ImageButton57.ImageUrl = resimbul(masam.masaKareleri[0, 0]);
                ImageButton58.ImageUrl = resimbul(masam.masaKareleri[0, 1]);
                ImageButton59.ImageUrl = resimbul(masam.masaKareleri[0, 2]);
                ImageButton60.ImageUrl = resimbul(masam.masaKareleri[0, 3]);
                ImageButton61.ImageUrl = resimbul(masam.masaKareleri[0, 4]);
                ImageButton62.ImageUrl = resimbul(masam.masaKareleri[0, 5]);
                ImageButton63.ImageUrl = resimbul(masam.masaKareleri[0, 6]);
                ImageButton64.ImageUrl = resimbul(masam.masaKareleri[0, 7]);
            }
            else
            {
                Session.Add("Renk", "Siyah");
                ImageButton1.ImageUrl = resimbul(masam.masaKareleri[0, 7]);
                ImageButton2.ImageUrl = resimbul(masam.masaKareleri[0, 6]);
                ImageButton3.ImageUrl = resimbul(masam.masaKareleri[0, 5]);
                ImageButton4.ImageUrl = resimbul(masam.masaKareleri[0, 4]);
                ImageButton5.ImageUrl = resimbul(masam.masaKareleri[0, 3]);
                ImageButton6.ImageUrl = resimbul(masam.masaKareleri[0, 2]);
                ImageButton7.ImageUrl = resimbul(masam.masaKareleri[0, 1]);
                ImageButton8.ImageUrl = resimbul(masam.masaKareleri[0, 0]);
                ImageButton9.ImageUrl = resimbul(masam.masaKareleri[1, 7]);
                ImageButton10.ImageUrl = resimbul(masam.masaKareleri[1, 6]);
                ImageButton11.ImageUrl = resimbul(masam.masaKareleri[1, 5]);
                ImageButton12.ImageUrl = resimbul(masam.masaKareleri[1, 3]);
                ImageButton13.ImageUrl = resimbul(masam.masaKareleri[1, 3]);
                ImageButton14.ImageUrl = resimbul(masam.masaKareleri[1, 2]);
                ImageButton15.ImageUrl = resimbul(masam.masaKareleri[1, 1]);
                ImageButton16.ImageUrl = resimbul(masam.masaKareleri[1, 0]);
                ImageButton17.ImageUrl = resimbul(masam.masaKareleri[2, 7]);
                ImageButton18.ImageUrl = resimbul(masam.masaKareleri[2, 6]);
                ImageButton19.ImageUrl = resimbul(masam.masaKareleri[2, 5]);
                ImageButton20.ImageUrl = resimbul(masam.masaKareleri[2, 4]);
                ImageButton21.ImageUrl = resimbul(masam.masaKareleri[2, 3]);
                ImageButton22.ImageUrl = resimbul(masam.masaKareleri[2, 2]);
                ImageButton23.ImageUrl = resimbul(masam.masaKareleri[2, 1]);
                ImageButton24.ImageUrl = resimbul(masam.masaKareleri[2, 0]);
                ImageButton25.ImageUrl = resimbul(masam.masaKareleri[3, 7]);
                ImageButton26.ImageUrl = resimbul(masam.masaKareleri[3, 6]);
                ImageButton27.ImageUrl = resimbul(masam.masaKareleri[3, 5]);
                ImageButton28.ImageUrl = resimbul(masam.masaKareleri[3, 4]);
                ImageButton29.ImageUrl = resimbul(masam.masaKareleri[3, 3]);
                ImageButton30.ImageUrl = resimbul(masam.masaKareleri[3, 2]);
                ImageButton31.ImageUrl = resimbul(masam.masaKareleri[3, 1]);
                ImageButton32.ImageUrl = resimbul(masam.masaKareleri[3, 0]);
                ImageButton33.ImageUrl = resimbul(masam.masaKareleri[4, 7]);
                ImageButton34.ImageUrl = resimbul(masam.masaKareleri[4, 6]);
                ImageButton35.ImageUrl = resimbul(masam.masaKareleri[4, 5]);
                ImageButton36.ImageUrl = resimbul(masam.masaKareleri[4, 4]);
                ImageButton37.ImageUrl = resimbul(masam.masaKareleri[4, 3]);
                ImageButton38.ImageUrl = resimbul(masam.masaKareleri[4, 2]);
                ImageButton39.ImageUrl = resimbul(masam.masaKareleri[4, 1]);
                ImageButton40.ImageUrl = resimbul(masam.masaKareleri[4, 0]);
                ImageButton41.ImageUrl = resimbul(masam.masaKareleri[5, 7]);
                ImageButton42.ImageUrl = resimbul(masam.masaKareleri[5, 6]);
                ImageButton43.ImageUrl = resimbul(masam.masaKareleri[5, 5]);
                ImageButton44.ImageUrl = resimbul(masam.masaKareleri[5, 4]);
                ImageButton45.ImageUrl = resimbul(masam.masaKareleri[5, 3]);
                ImageButton46.ImageUrl = resimbul(masam.masaKareleri[5, 2]);
                ImageButton47.ImageUrl = resimbul(masam.masaKareleri[5, 1]);
                ImageButton48.ImageUrl = resimbul(masam.masaKareleri[5, 0]);
                ImageButton49.ImageUrl = resimbul(masam.masaKareleri[6, 7]);
                ImageButton50.ImageUrl = resimbul(masam.masaKareleri[6, 6]);
                ImageButton51.ImageUrl = resimbul(masam.masaKareleri[6, 5]);
                ImageButton52.ImageUrl = resimbul(masam.masaKareleri[6, 4]);
                ImageButton53.ImageUrl = resimbul(masam.masaKareleri[6, 3]);
                ImageButton54.ImageUrl = resimbul(masam.masaKareleri[6, 2]);
                ImageButton55.ImageUrl = resimbul(masam.masaKareleri[6, 1]);
                ImageButton56.ImageUrl = resimbul(masam.masaKareleri[6, 0]);
                ImageButton57.ImageUrl = resimbul(masam.masaKareleri[7, 7]);
                ImageButton58.ImageUrl = resimbul(masam.masaKareleri[7, 6]);
                ImageButton59.ImageUrl = resimbul(masam.masaKareleri[7, 5]);
                ImageButton60.ImageUrl = resimbul(masam.masaKareleri[7, 4]);
                ImageButton61.ImageUrl = resimbul(masam.masaKareleri[7, 3]);
                ImageButton62.ImageUrl = resimbul(masam.masaKareleri[7, 2]);
                ImageButton63.ImageUrl = resimbul(masam.masaKareleri[7, 1]);
                ImageButton64.ImageUrl = resimbul(masam.masaKareleri[7, 0]);
                Image65.ImageUrl = "Resimler\\spc4.gif";
                Image66.ImageUrl = "Resimler\\spc7.gif";
            }

            if (masam.OyunDurumu == Sonuc.Mat)
            {
                Durum.Text = "OYUN BITMIŞTIR";
                if (masam.sirabeyazdami)
                    Durum.Text += ". Siyah Kazandı.";
                else
                    Durum.Text += ". Beyaz Kazandı.";
            }
            else if (masam.OyunDurumu == Sonuc.SiraBeyazda)
            {
                Durum.Text = "Hamle Sırası Beyazlarda";

            }
            else if (masam.OyunDurumu == Sonuc.SiraSiyahta)
            {
                Durum.Text = "Hamle Sırası Siyahlarda";

            }
            else if (masam.OyunDurumu == Sonuc.SahCekti)
            {
                Durum.Text = "Şah Çeken Oyuncu";
                if (masam.sirabeyazdami)
                    Durum.Text += " Siyah Oyuncu";
                else
                    Durum.Text += " Beyaz Oyuncu";
            }
            else if (masam.OyunDurumu == Sonuc.Pat)
            {
                Durum.Text = "OYUN BERABERE";
            }
            string cumle = " SELECT (SELECT COUNT(*) FROM Hamle WHERE Hamle.ID <= e.ID and MasaID = " + masam.masaID + " ) AS HamleSirasi,Hamle  FROM Hamle e WHERE MasaID = " + masam.masaID + ";";
            GridView1.DataSource = Baglanti.TabloSorgula(cumle);
            GridView1.DataBind();

        }
        public int KoordinatBul(string x)
        {
            if (x == "A" | x == "a")
            {
                return 0;
            }
            else if (x == "B" | x == "b")
            {
                return 1;
            }
            else if (x == "C" | x == "c")
            {
                return 2;
            }
            else if (x == "D" | x == "d")
            {
                return 3;
            }
            else if (x == "E" | x == "e")
            {
                return 4;
            }
            else if (x == "F" | x == "f")
            {
                return 5;
            }
            else if (x == "G" | x == "g")
            {
                return 6;
            }
            else if (x == "H" | x == "h")
            {
                return 7;
            }
            else
            {
                Exception OlmayanKoordinat = new Exception("Olmayan Bir Koordinat Girdiniz.");
                throw OlmayanKoordinat;
            }

        }
        public void Oyna()
        {
            if (!BuMasaBuKisininmi())
            {
                Sorun.Text = "Siz Bu Masada Oynamıyorsunuz.";
                return;
            }
            SatrancFramework masam = new SatrancFramework(Convert.ToInt32(Request.Params["ID"]));
            if (!masam.onay)
            {
                Sorun.Text = "Rakip Oyun Henüz Bu Oyunu Onaylamadı.";
                return;
            }
            if (masam.SiyahkullaniciID == 0 | masam.BeyazkullaniciID == 0)
            {
                Sorun.Text = "Rakip Oyuncu Yok.";
                return;
            }
            if (masam.sirabeyazdami)
            {
                try
                {
                    Baglanti.Connect();
                    OleDbCommand myCommand = new OleDbCommand("SELECT BeyazOyuncuID FROM Masa where ID = " + Convert.ToUInt32(Request.Params["ID"]) + " ;", Baglanti.DataBaseconnection);
                    OleDbDataReader myReader = myCommand.ExecuteReader();
                    myReader.Read();
                    int sayi = myReader.GetInt32(0);
                    Baglanti.DisConnect();
                    if (Convert.ToUInt32(Session["KullaniciID"]) != sayi)
                    {
                        Sorun.Text = ("Siranizi Bekleyin.");
                        return;
                    }
                }
                catch (Exception hata1)
                {
                    Sorun.Text = hata1.Message;
                    return;
                }
            }
            else
            {
                try
                {
                    Baglanti.Connect();
                    OleDbCommand myCommand = new OleDbCommand("SELECT SiyahOyuncuID FROM Masa where ID = " + Convert.ToUInt32(Request.Params["ID"]) + " ;", Baglanti.DataBaseconnection);
                    OleDbDataReader myReader = myCommand.ExecuteReader();
                    myReader.Read();
                    int sayi = myReader.GetInt32(0);
                    Baglanti.DisConnect();
                    if (Convert.ToUInt32(Session["KullaniciID"]) != sayi)
                    {
                        Sorun.Text = ("Siranizi Bekleyin.");
                        return;
                    }
                }
                catch (Exception hata1)
                {
                    Sorun.Text = hata1.Message;
                    return;
                }
            }
            try
            {
                masam.Oynat(Convert.ToInt32(TextBox1.Text.Substring(1, 1)) - 1, KoordinatBul(TextBox1.Text.Substring(0, 1)), Convert.ToInt32(TextBox2.Text.Substring(1, 1)) - 1, KoordinatBul(TextBox2.Text.Substring(0, 1)), TurEnum.Vezir);
                Sorun.Text = String.Empty;
            }
            catch (Exception ex)
            {
                Sorun.Text = (ex.Message);
            }
            try
            {
                TextBox1.Text = string.Empty;
                TextBox2.Text = string.Empty;
                Ekran(masam);
            }
            catch (Exception asdf)
            {
                Sorun.Text = asdf.Message;
            }


        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            return;
        }

        

       
    }
}
