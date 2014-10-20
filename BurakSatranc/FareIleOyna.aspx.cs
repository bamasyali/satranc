using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using Chess;

namespace BurakSatranc
{
    public partial class FareIleOyna : System.Web.UI.Page
    {
        static System.Drawing.Color Beyaz = System.Drawing.Color.Red;
        static System.Drawing.Color Siyah = System.Drawing.Color.Red;
        
        public void Oynayanlar()
        {
            try
            {
                Baglanti.Connect();
                OleDbCommand myCommand = new OleDbCommand("SELECT (select Kullanici.KullaniciAdi from Kullanici Where Kullanici.ID = Masa.SiyahOyuncuID),(select Kullanici.KullaniciAdi from Kullanici Where Kullanici.ID = Masa.BeyazOyuncuID),Uluslararasi FROM Masa where ID=" + Convert.ToUInt32(Request.Params["ID"]) + ";", Baglanti.DataBaseconnection);
                OleDbDataReader myReader = myCommand.ExecuteReader();
                myReader.Read();
                string siyah, bayaz;
                siyah = myReader.GetString(0);
                bayaz = myReader.GetString(1);
                string yazi;
                if(myReader.GetBoolean(2)){
                    yazi = "Uluslararasi";
                }else{
                    yazi="Normal";
                }
                Baglanti.DisConnect();
                Response.Write("Siyah Oyuncu = <br>" + (siyah) + "<br><br>Beyaz Oyuncu=<br>" + (bayaz)+"<br><br> Sure Turu <br>"+yazi );

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
            if (Beyaz ==System.Drawing.Color.Red)
            {
                Beyaz = ImageButton1.BackColor;
                Siyah = ImageButton2.BackColor;
            }
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
                if (masam.Uluslararasi)
                {
                    int Kat=1;
                    
                    int HamleSayisi = Convert.ToInt32(Baglanti.BuMasadaKacHamleYapilmis(masam.masaID) / 2);

                    if (HamleSayisi >= masam.HamlegunLimiti)
                    {
                        Kat = Convert.ToInt32(HamleSayisi / masam.HamlegunLimiti) + 1;
                      
                    }
                    HamleLimiti.Text = (masam.HamlegunLimiti * Kat).ToString();
                    OyunSuresi.Text = (masam.ToplamgunLimiti * Kat).ToString();
                }
                else
                {
                    HamleLimiti.Text = masam.HamlegunLimiti.ToString();
                    OyunSuresi.Text = masam.ToplamgunLimiti.ToString();
                }
            }

            catch (Exception hata)
            {
                Sorun.Text = hata.StackTrace;
            }

        }
        protected void RenkleriSıfırla()
        {
            ImageButton1.BackColor = Beyaz;
            ImageButton2.BackColor = Siyah;
            ImageButton3.BackColor = Beyaz;
            ImageButton4.BackColor = Siyah;
            ImageButton5.BackColor = Beyaz;
            ImageButton6.BackColor = Siyah;
            ImageButton7.BackColor = Beyaz;
            ImageButton8.BackColor = Siyah;

            ImageButton9.BackColor = Siyah;
            ImageButton10.BackColor = Beyaz;
            ImageButton11.BackColor = Siyah;
            ImageButton12.BackColor = Beyaz;
            ImageButton13.BackColor = Siyah;
            ImageButton14.BackColor = Beyaz;
            ImageButton15.BackColor = Siyah;
            ImageButton16.BackColor = Beyaz;

            ImageButton17.BackColor = Beyaz;
            ImageButton18.BackColor = Siyah;
            ImageButton19.BackColor = Beyaz;
            ImageButton20.BackColor = Siyah;
            ImageButton21.BackColor = Beyaz;
            ImageButton22.BackColor = Siyah;
            ImageButton23.BackColor = Beyaz;
            ImageButton24.BackColor = Siyah;

            ImageButton25.BackColor = Siyah;
            ImageButton26.BackColor = Beyaz;
            ImageButton27.BackColor = Siyah;
            ImageButton28.BackColor = Beyaz;
            ImageButton29.BackColor = Siyah;
            ImageButton30.BackColor = Beyaz;
            ImageButton31.BackColor = Siyah;
            ImageButton32.BackColor = Beyaz;

            ImageButton33.BackColor = Beyaz;
            ImageButton34.BackColor = Siyah;
            ImageButton35.BackColor = Beyaz;
            ImageButton36.BackColor = Siyah;
            ImageButton37.BackColor = Beyaz;
            ImageButton38.BackColor = Siyah;
            ImageButton39.BackColor = Beyaz;
            ImageButton40.BackColor = Siyah;

            ImageButton41.BackColor = Siyah;
            ImageButton42.BackColor = Beyaz;
            ImageButton43.BackColor = Siyah;
            ImageButton44.BackColor = Beyaz;
            ImageButton45.BackColor = Siyah;
            ImageButton46.BackColor = Beyaz;
            ImageButton47.BackColor = Siyah;
            ImageButton48.BackColor = Beyaz;

            ImageButton49.BackColor = Beyaz;
            ImageButton50.BackColor = Siyah;
            ImageButton51.BackColor = Beyaz;
            ImageButton52.BackColor = Siyah;
            ImageButton53.BackColor = Beyaz;
            ImageButton54.BackColor = Siyah;
            ImageButton55.BackColor = Beyaz;
            ImageButton56.BackColor = Siyah;

            ImageButton57.BackColor = Siyah;
            ImageButton58.BackColor = Beyaz;
            ImageButton59.BackColor = Siyah;
            ImageButton60.BackColor = Beyaz;
            ImageButton61.BackColor = Siyah;
            ImageButton62.BackColor = Beyaz;
            ImageButton63.BackColor = Siyah;
            ImageButton64.BackColor = Beyaz;
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
            RenkleriSıfırla();
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
            if (masam.SiyahkullaniciID == 0|masam.BeyazkullaniciID == 0)
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
        protected string ParametreDegistir(string x){
            if (x == "A" | x == "a")
            {
                return "h";
            }
            else if (x == "B" | x == "b")
            {
                return "g";
            }
            else if (x == "C" | x == "c")
            {
                return "f";
            }
            else if (x == "D" | x == "d")
            {
                return "e";
            }
            else if (x == "E" | x == "e")
            {
                return "d";
            }
            else if (x == "F" | x == "f")
            {
                return "c";
            }
            else if (x == "G" | x == "g")
            {
                return "b";
            }
            else if (x == "H" | x == "h")
            {
                return "a";
            }
            return null;
        }
        protected string SiyahParametreDegistir(string x){
            return ParametreDegistir(x.Substring(0, 1)) + x.Substring(1, 1);

        }
        protected void ParametreYaz(string Koordinat){
             if(Session["Renk"]=="Siyah"){
                 Koordinat = SiyahParametreDegistir(Koordinat);
             }

             if (TextBox1.Text == string.Empty)
                {
                    TextBox1.Text = Koordinat;
                }
                else
                {
                    if (TextBox2.Text == string.Empty)
                    {
                        TextBox2.Text = Koordinat;                        
                    }
                    else
                    {
                        TextBox1.Text = string.Empty;
                        TextBox2.Text = string.Empty;                        
                        RenkleriSıfırla();
                        
                    }
                }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton1.BackColor = System.Drawing.Color.Red ;
                ParametreYaz("a8");
            }else{
                ImageButton1.BackColor = System.Drawing.Color.Red;
                ParametreYaz("a1");
                
            }
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton2.BackColor = System.Drawing.Color.Red;
                ParametreYaz("B8");
            }
            else
            {
                ImageButton2.BackColor = System.Drawing.Color.Red;
                ParametreYaz("b1");

            }
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton3.BackColor = System.Drawing.Color.Red;
                ParametreYaz("c8");
            }
            else
            {
                ImageButton3.BackColor = System.Drawing.Color.Red;
                ParametreYaz("c1");

            }
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton4.BackColor = System.Drawing.Color.Red;
                ParametreYaz("d8");
            }
            else
            {
                ImageButton4.BackColor = System.Drawing.Color.Red;
                ParametreYaz("d1");

            }
        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton5.BackColor = System.Drawing.Color.Red;
                ParametreYaz("e8");
            }
            else
            {
                ImageButton5.BackColor = System.Drawing.Color.Red;
                ParametreYaz("e1");

            }
        }

        protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton6.BackColor = System.Drawing.Color.Red;
                ParametreYaz("f8");
            }
            else
            {
                ImageButton6.BackColor = System.Drawing.Color.Red;
                ParametreYaz("f1");

            }
        }

        protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton7.BackColor = System.Drawing.Color.Red;
                ParametreYaz("g8");
            }
            else
            {
                ImageButton7.BackColor = System.Drawing.Color.Red;
                ParametreYaz("g1");

            }
        }

        protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton8.BackColor = System.Drawing.Color.Red;
                ParametreYaz("h8");
            }
            else
            {
                ImageButton8.BackColor = System.Drawing.Color.Red;
                ParametreYaz("h1");

            }
        }

        protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton9.BackColor = System.Drawing.Color.Red;
                ParametreYaz("a7");
            }
            else
            {
                ImageButton9.BackColor = System.Drawing.Color.Red;
                ParametreYaz("a2");

            }
        }

        protected void ImageButton10_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton10.BackColor = System.Drawing.Color.Red;
                ParametreYaz("b7");
            }
            else
            {
                ImageButton10.BackColor = System.Drawing.Color.Red;
                ParametreYaz("b2");

            }
        }

        protected void ImageButton11_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton11.BackColor = System.Drawing.Color.Red;
                ParametreYaz("c7");
            }
            else
            {
                ImageButton11.BackColor = System.Drawing.Color.Red;
                ParametreYaz("c2");

            }
        }

        protected void ImageButton12_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton12.BackColor = System.Drawing.Color.Red;
                ParametreYaz("d7");
            }
            else
            {
                ImageButton12.BackColor = System.Drawing.Color.Red;
                ParametreYaz("d2");

            }
        }

        protected void ImageButton13_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton13.BackColor = System.Drawing.Color.Red;
                ParametreYaz("e7");
            }
            else
            {
                ImageButton13.BackColor = System.Drawing.Color.Red;
                ParametreYaz("e2");

            }
        }

        protected void ImageButton14_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton14.BackColor = System.Drawing.Color.Red;
                ParametreYaz("f7");
            }
            else
            {
                ImageButton14.BackColor = System.Drawing.Color.Red;
                ParametreYaz("f2");

            }
        }

        protected void ImageButton15_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton15.BackColor = System.Drawing.Color.Red;
                ParametreYaz("g7");
            }
            else
            {
                ImageButton15.BackColor = System.Drawing.Color.Red;
                ParametreYaz("g2");

            }
        }

        protected void ImageButton16_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton16.BackColor = System.Drawing.Color.Red;
                ParametreYaz("h7");
            }
            else
            {
                ImageButton16.BackColor = System.Drawing.Color.Red;
                ParametreYaz("h2");

            }
        }

        protected void ImageButton17_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton17.BackColor = System.Drawing.Color.Red;
                ParametreYaz("a6");
            }
            else
            {
                ImageButton17.BackColor = System.Drawing.Color.Red;
                ParametreYaz("a3");

            }
        }

        protected void ImageButton18_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton18.BackColor = System.Drawing.Color.Red;
                ParametreYaz("b6");
            }
            else
            {
                ImageButton18.BackColor = System.Drawing.Color.Red;
                ParametreYaz("b3");

            }
        }

        protected void ImageButton19_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton19.BackColor = System.Drawing.Color.Red;
                ParametreYaz("c6");
            }
            else
            {
                ImageButton19.BackColor = System.Drawing.Color.Red;
                ParametreYaz("c3");

            }
        }

        protected void ImageButton20_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton20.BackColor = System.Drawing.Color.Red;
                ParametreYaz("d6");
            }
            else
            {
                ImageButton20.BackColor = System.Drawing.Color.Red;
                ParametreYaz("d3");

            }
        }

        protected void ImageButton21_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton21.BackColor = System.Drawing.Color.Red;
                ParametreYaz("e6");
            }
            else
            {
                ImageButton21.BackColor = System.Drawing.Color.Red;
                ParametreYaz("e3");

            }
        }

        protected void ImageButton22_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton22.BackColor = System.Drawing.Color.Red;
                ParametreYaz("f6");
            }
            else
            {
                ImageButton22.BackColor = System.Drawing.Color.Red;
                ParametreYaz("f3");

            }
        }

        protected void ImageButton23_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton23.BackColor = System.Drawing.Color.Red;
                ParametreYaz("g6");
            }
            else
            {
                ImageButton23.BackColor = System.Drawing.Color.Red;
                ParametreYaz("g3");

            }
        }

        protected void ImageButton24_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton24.BackColor = System.Drawing.Color.Red;
                ParametreYaz("h6");
            }
            else
            {
                ImageButton24.BackColor = System.Drawing.Color.Red;
                ParametreYaz("h3");

            }
        }

        protected void ImageButton25_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton25.BackColor = System.Drawing.Color.Red;
                ParametreYaz("a5");
            }
            else
            {
                ImageButton25.BackColor = System.Drawing.Color.Red;
                ParametreYaz("a4");

            }
        }

        protected void ImageButton26_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton26.BackColor = System.Drawing.Color.Red;
                ParametreYaz("b5");
            }
            else
            {
                ImageButton26.BackColor = System.Drawing.Color.Red;
                ParametreYaz("b4");

            }
        }

        protected void ImageButton27_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton27.BackColor = System.Drawing.Color.Red;
                ParametreYaz("c5");
            }
            else
            {
                ImageButton27.BackColor = System.Drawing.Color.Red;
                ParametreYaz("c4");

            }
        }

        protected void ImageButton28_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton28.BackColor = System.Drawing.Color.Red;
                ParametreYaz("d5");
            }
            else
            {
                ImageButton28.BackColor = System.Drawing.Color.Red;
                ParametreYaz("d4");

            }
        }

        protected void ImageButton29_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton29.BackColor = System.Drawing.Color.Red;
                ParametreYaz("e5");
            }
            else
            {
                ImageButton29.BackColor = System.Drawing.Color.Red;
                ParametreYaz("e4");

            }
        }

        protected void ImageButton30_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton30.BackColor = System.Drawing.Color.Red;
                ParametreYaz("f5");
            }
            else
            {
                ImageButton30.BackColor = System.Drawing.Color.Red;
                ParametreYaz("f4");

            }
        }

        protected void ImageButton31_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton31.BackColor = System.Drawing.Color.Red;
                ParametreYaz("g5");
            }
            else
            {
                ImageButton31.BackColor = System.Drawing.Color.Red;
                ParametreYaz("g4");

            }
        }

        protected void ImageButton32_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton32.BackColor = System.Drawing.Color.Red;
                ParametreYaz("h5");
            }
            else
            {
                ImageButton32.BackColor = System.Drawing.Color.Red;
                ParametreYaz("h4");

            }
        }

        protected void ImageButton33_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton33.BackColor = System.Drawing.Color.Red;
                ParametreYaz("a4");
            }
            else
            {
                ImageButton33.BackColor = System.Drawing.Color.Red;
                ParametreYaz("a5");

            }
        }

        protected void ImageButton34_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton34.BackColor = System.Drawing.Color.Red;
                ParametreYaz("b4");
            }
            else
            {
                ImageButton34.BackColor = System.Drawing.Color.Red;
                ParametreYaz("b5");

            }
        }

        protected void ImageButton35_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton35.BackColor = System.Drawing.Color.Red;
                ParametreYaz("c4");
            }
            else
            {
                ImageButton35.BackColor = System.Drawing.Color.Red;
                ParametreYaz("c5");

            }
        }

        protected void ImageButton36_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton36.BackColor = System.Drawing.Color.Red;
                ParametreYaz("d4");
            }
            else
            {
                ImageButton36.BackColor = System.Drawing.Color.Red;
                ParametreYaz("d5");

            }
        }

        protected void ImageButton37_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton37.BackColor = System.Drawing.Color.Red;
                ParametreYaz("e4");
            }
            else
            {
                ImageButton37.BackColor = System.Drawing.Color.Red;
                ParametreYaz("e5");

            }
        }

        protected void ImageButton38_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton38.BackColor = System.Drawing.Color.Red;
                ParametreYaz("f4");
            }
            else
            {
                ImageButton38.BackColor = System.Drawing.Color.Red;
                ParametreYaz("f5");

            }
        }

        protected void ImageButton39_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton39.BackColor = System.Drawing.Color.Red;
                ParametreYaz("g4");
            }
            else
            {
                ImageButton39.BackColor = System.Drawing.Color.Red;
                ParametreYaz("g5");

            }
        }

        protected void ImageButton40_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton40.BackColor = System.Drawing.Color.Red;
                ParametreYaz("h4");
            }
            else
            {
                ImageButton40.BackColor = System.Drawing.Color.Red;
                ParametreYaz("h5");

            }
        }

        protected void ImageButton41_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton41.BackColor = System.Drawing.Color.Red;
                ParametreYaz("a3");
            }
            else
            {
                ImageButton41.BackColor = System.Drawing.Color.Red;
                ParametreYaz("a6");

            }
        }

        protected void ImageButton42_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton42.BackColor = System.Drawing.Color.Red;
                ParametreYaz("b3");
            }
            else
            {
                ImageButton42.BackColor = System.Drawing.Color.Red;
                ParametreYaz("b6");

            }
        }

        protected void ImageButton43_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton43.BackColor = System.Drawing.Color.Red;
                ParametreYaz("c3");
            }
            else
            {
                ImageButton43.BackColor = System.Drawing.Color.Red;
                ParametreYaz("c6");

            }
        }

        protected void ImageButton44_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton44.BackColor = System.Drawing.Color.Red;
                ParametreYaz("d3");
            }
            else
            {
                ImageButton44.BackColor = System.Drawing.Color.Red;
                ParametreYaz("d6");

            }
        }

        protected void ImageButton45_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton45.BackColor = System.Drawing.Color.Red;
                ParametreYaz("e3");
            }
            else
            {
                ImageButton45.BackColor = System.Drawing.Color.Red;
                ParametreYaz("e6");

            }
        }

        protected void ImageButton46_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton46.BackColor = System.Drawing.Color.Red;
                ParametreYaz("f3");
            }
            else
            {
                ImageButton46.BackColor = System.Drawing.Color.Red;
                ParametreYaz("f6");

            }
        }

        protected void ImageButton47_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton47.BackColor = System.Drawing.Color.Red;
                ParametreYaz("g3");
            }
            else
            {
                ImageButton47.BackColor = System.Drawing.Color.Red;
                ParametreYaz("g6");

            }
        }

        protected void ImageButton48_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton48.BackColor = System.Drawing.Color.Red;
                ParametreYaz("h3");
            }
            else
            {
                ImageButton48.BackColor = System.Drawing.Color.Red;
                ParametreYaz("h6");

            }
        }

        protected void ImageButton49_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton49.BackColor = System.Drawing.Color.Red;
                ParametreYaz("a2");
            }
            else
            {
                ImageButton49.BackColor = System.Drawing.Color.Red;
                ParametreYaz("a7");

            }
        }

        protected void ImageButton50_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton50.BackColor = System.Drawing.Color.Red;
                ParametreYaz("b2");
            }
            else
            {
                ImageButton50.BackColor = System.Drawing.Color.Red;
                ParametreYaz("b7");

            }
        }

        protected void ImageButton51_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton51.BackColor = System.Drawing.Color.Red;
                ParametreYaz("c2");
            }
            else
            {
                ImageButton51.BackColor = System.Drawing.Color.Red;
                ParametreYaz("c7");

            }
        }

        protected void ImageButton52_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton52.BackColor = System.Drawing.Color.Red;
                ParametreYaz("d2");
            }
            else
            {
                ImageButton52.BackColor = System.Drawing.Color.Red;
                ParametreYaz("d7");

            }
        }

        protected void ImageButton53_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton53.BackColor = System.Drawing.Color.Red;
                ParametreYaz("e2");
            }
            else
            {
                ImageButton53.BackColor = System.Drawing.Color.Red;
                ParametreYaz("e7");

            }
        }

        protected void ImageButton54_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton54.BackColor = System.Drawing.Color.Red;
                ParametreYaz("f2");
            }
            else
            {
                ImageButton54.BackColor = System.Drawing.Color.Red;
                ParametreYaz("f7");

            }
        }

        protected void ImageButton55_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton55.BackColor = System.Drawing.Color.Red;
                ParametreYaz("g2");
            }
            else
            {
                ImageButton55.BackColor = System.Drawing.Color.Red;
                ParametreYaz("g7");

            }
        }

        protected void ImageButton56_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton56.BackColor = System.Drawing.Color.Red;
                ParametreYaz("h2");
            }
            else
            {
                ImageButton56.BackColor = System.Drawing.Color.Red;
                ParametreYaz("h7");

            }
        }

        protected void ImageButton57_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton57.BackColor = System.Drawing.Color.Red;
                ParametreYaz("a1");
            }
            else
            {
                ImageButton57.BackColor = System.Drawing.Color.Red;
                ParametreYaz("a8");

            }
        }

        protected void ImageButton58_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton58.BackColor = System.Drawing.Color.Red;
                ParametreYaz("b1");
            }
            else
            {
                ImageButton58.BackColor = System.Drawing.Color.Red;
                ParametreYaz("b8");

            }
        }

        protected void ImageButton59_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton59.BackColor = System.Drawing.Color.Red;
                ParametreYaz("c1");
            }
            else
            {
                ImageButton59.BackColor = System.Drawing.Color.Red;
                ParametreYaz("c8");

            }
        }

        protected void ImageButton60_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton60.BackColor = System.Drawing.Color.Red;
                ParametreYaz("d1");
            }
            else
            {
                ImageButton60.BackColor = System.Drawing.Color.Red;
                ParametreYaz("d8");

            }
        }

        protected void ImageButton61_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton61.BackColor = System.Drawing.Color.Red;
                ParametreYaz("e1");
            }
            else
            {
                ImageButton61.BackColor = System.Drawing.Color.Red;
                ParametreYaz("e8");

            }
        }

        protected void ImageButton62_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton62.BackColor = System.Drawing.Color.Red;
                ParametreYaz("f1");
            }
            else
            {
                ImageButton62.BackColor = System.Drawing.Color.Red;
                ParametreYaz("f8");

            }
        }

        protected void ImageButton63_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton63.BackColor = System.Drawing.Color.Red;
                ParametreYaz("g1");
            }
            else
            {
                ImageButton63.BackColor = System.Drawing.Color.Red;
                ParametreYaz("g8");

            }
        }

        protected void ImageButton64_Click(object sender, ImageClickEventArgs e)
        {
            if (Session["Renk"] == "Beyaz")
            {
                ImageButton64.BackColor = System.Drawing.Color.Red;
                ParametreYaz("h1");
            }
            else
            {
                ImageButton64.BackColor = System.Drawing.Color.Red;
                ParametreYaz("h8");

            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Oyna();
        }
    }
}
