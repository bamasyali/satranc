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
using BurakSatranc;

namespace Chess
{
    public partial class _Default : System.Web.UI.Page
    {
        
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        public string resimbul(Taslar x){
            if(x.renk == RenkEnum.Beyaz){
                if(x.tur==TurEnum.At){
                    return "Resimler/bat.gif";
                }else if(x.tur==TurEnum.Fil){
                    return "Resimler/bfil.gif";
                }else if(x.tur==TurEnum.Kale){
                    return "Resimler/bkale.gif";
                }else if(x.tur==TurEnum.Vezir){
                    return "Resimler/bvezir.gif";
                }else if(x.tur==TurEnum.Piyon){
                    return "Resimler/bpiyon.gif";
                }else if(x.tur==TurEnum.Sah){
                    return "Resimler/bsah.gif";
                }
            }else if(x.renk ==RenkEnum.Siyah){
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
        public void Ekran(ChessTable masam){

            ImageButton1.ImageUrl= resimbul(masam.masaKareleri[7, 0]);
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

            
            if (masam.OyunDurumu == Sonuc.Mat)
            {
                TextBox8.Text = "OYUN BITMIŞTIR";
                if (masam.sirabeyazdami)
                    TextBox8.Text += ". Siyah Kazandı.";
                else
                    TextBox8.Text += ". Beyaz Kazandı.";
            }
            else if (masam.OyunDurumu == Sonuc.SiraBeyazda)
            {
                TextBox8.Text = "Hamle Sırası Beyazlarda";

            }
            else if (masam.OyunDurumu == Sonuc.SiraSiyahta)
            {
                TextBox8.Text = "Hamle Sırası Siyahlarda";

            }
            else if (masam.OyunDurumu == Sonuc.SahCekti)
            {
                TextBox8.Text = "Şah Çeken Oyuncu";
                if (masam.sirabeyazdami)
                    TextBox8.Text += " Siyah Oyuncu";
                else
                    TextBox8.Text += " Beyaz Oyuncu";
            }else if(masam.OyunDurumu == Sonuc.Pat){
                TextBox8.Text = "OYUN BERABERE";
            }
            
        }
        static _Default(){

          
               
           
            
        }
        public  void Masaolustur(){
            ChessTable masam = new ChessTable(Convert.ToInt32(TextBox9.Text));
            Ekran(masam);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {

        }
        public int KoordinatBul(string x){
            if(x=="A"|x=="a"){
                return 0;
            }else if(x=="B"|x=="b"){
                return 1;
            }else if(x=="C"|x=="c"){
                return 2;
            }else if(x=="D"|x=="d"){
                return 3;
            }else if(x=="E"|x=="e"){
                return 4;
            }else if(x=="F"|x=="f"){
                return 5;
            }else if(x=="G"|x=="g"){
                return 6;
            }else if(x=="H"|x=="h"){
                return 7;
            }else{
                Exception OlmayanKoordinat = new Exception("Olmayan Bir Koordinat Girdiniz.");
                throw OlmayanKoordinat;
            }

        }
        protected void Button1_Click1(object sender, EventArgs e)
        {
            ChessTable masam;
            try
            {
                masam = new ChessTable(Convert.ToInt32(TextBox9.Text));
                Oyna();
                TextBox1.Text = String.Empty;
                TextBox4.Text = String.Empty;
            }catch(Exception asfsa){
                TextBox5.Text = asfsa.Message;
            }
        }
        public void Oyna()
        {
            ChessTable masam = new ChessTable(Convert.ToInt32(TextBox9.Text));
            try
            {
                masam.Oynat(Convert.ToInt32(TextBox1.Text.Substring(1, 1)) - 1, KoordinatBul(TextBox1.Text.Substring(0, 1)), Convert.ToInt32(TextBox4.Text.Substring(1, 1)) - 1, KoordinatBul(TextBox4.Text.Substring(0, 1)),TurEnum.Vezir);
                TextBox5.Text = String.Empty;

            }
            catch (Exception ex)
            {
                TextBox5.Text= (ex.Message);

            }
            try{
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;
                Ekran(masam);    
            }catch(Exception asdf){
                TextBox5.Text = asdf.Message;
            }
            
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ChessTable masam;
            try
            {
               masam = new ChessTable(Convert.ToInt32(TextBox9.Text));
               Ekran(masam);
            }
            catch (Exception hata)
            {
                sorun.Text= hata.StackTrace;
            }
        }       

        protected void ImageButton57_Click(object sender, ImageClickEventArgs e)
        {
            
            if (TextBox1.Text != string.Empty)
            {

                TextBox4.Text = "A1";
                Oyna();
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;
                ImageButton57.BackColor = System.Drawing.Color.Black;
            }
            else
            {
                TextBox1.Text = "A1";
                ImageButton57.BackColor = System.Drawing.Color.Blue;
            }
           
        }

        protected void ImageButton58_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "b1";
                Oyna();}else
                    TextBox1.Text = "b1";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton59_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "c1";
                Oyna();}else
                    TextBox1.Text = "c1";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton60_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "d1";
                Oyna();}else
                    TextBox1.Text = "d1";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton61_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "e1";
                Oyna();}else
                    TextBox1.Text = "e1";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton62_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "f1";
                Oyna();}else
                    TextBox1.Text = "f1";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton63_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "g1";
                Oyna();}else
                    TextBox1.Text = "g1";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton64_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "h1";
                Oyna();}else
                    TextBox1.Text = "h1";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton49_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "A2";
                Oyna();}else
                    TextBox1.Text = "A2";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton50_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "b2";
                Oyna();}else
                    TextBox1.Text = "b2";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton51_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "c2";
                Oyna();}else
                    TextBox1.Text = "c2";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton52_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "d2";
                Oyna();}else
                    TextBox1.Text = "d2";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton53_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "e2";
                Oyna();}else
                    TextBox1.Text = "e2";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton54_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "f2";
                Oyna();}else
                    TextBox1.Text = "f2";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton55_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "g2";
                Oyna();}else
                    TextBox1.Text = "g2";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton56_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "h2";
                Oyna();}else
                    TextBox1.Text = "h2";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton41_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "A3";
                Oyna();}else
                    TextBox1.Text = "A3";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton42_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "b3";
                Oyna();}else
                    TextBox1.Text = "b3";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton43_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "c3";
                Oyna();}else
                    TextBox1.Text = "c3";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton44_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "d3";
                Oyna();}else
                    TextBox1.Text = "d3";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton45_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "e3";
                Oyna();}else
                    TextBox1.Text = "e3";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton46_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "f3";
                Oyna();}else
                    TextBox1.Text = "f3";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton47_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "g3";
                Oyna();}else
                    TextBox1.Text = "g3";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton48_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "h3";
                Oyna();}else
                    TextBox1.Text = "h3";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton33_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "A4";
                Oyna();}else
                    TextBox1.Text = "A4";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton34_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "b4";
                Oyna();}else
                    TextBox1.Text = "b4";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton35_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "c4";
                Oyna();}else
                    TextBox1.Text = "c4";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton36_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "d4";
                Oyna();}else
                    TextBox1.Text = "d4";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton37_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "e4";
                Oyna();}else
                    TextBox1.Text = "e4";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton38_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "f4";
                Oyna();}else
                    TextBox1.Text = "f4";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton39_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "g4";
                Oyna();}else
                    TextBox1.Text = "g4";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton40_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "h4";
                Oyna();}else
                    TextBox1.Text = "h4";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton25_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "A5";
                Oyna();}else
                    TextBox1.Text = "A5";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton26_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "b5";
                Oyna();}else
                    TextBox1.Text = "b5";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton27_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "c5";
                Oyna();}else
                    TextBox1.Text = "c5";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton28_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "d5";
                Oyna();}else
                    TextBox1.Text = "d5";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton29_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "e5";
                Oyna();}else
                    TextBox1.Text = "e5";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton30_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "f5";
                Oyna();}else
                    TextBox1.Text = "f5";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton31_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "g5";
                Oyna();}else
                    TextBox1.Text = "g5";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton32_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "h5";
                Oyna();}else
                    TextBox1.Text = "h5";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton17_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "A6";
                Oyna();}else
                    TextBox1.Text = "A6";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton18_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "b6";
                Oyna();}else
                    TextBox1.Text = "b6";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton19_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "c6";
                Oyna();}else
                    TextBox1.Text = "c6";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton20_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "d6";
                Oyna();}else
                    TextBox1.Text = "d6";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton21_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "e6";
                Oyna();}else
                    TextBox1.Text = "e6";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton22_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "f6";
                Oyna();}else
                    TextBox1.Text = "f6";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton23_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "g6";
                Oyna();}else
                    TextBox1.Text = "g6";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton24_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "h6";
                Oyna();}else
                    TextBox1.Text = "h6";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "A7";
                Oyna();}else
                    TextBox1.Text = "A7";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton10_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "b7";
                Oyna();}else
                    TextBox1.Text = "b7";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton11_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "c7";
                Oyna();}else
                    TextBox1.Text = "c7";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton12_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "d7";
                Oyna();}else
                    TextBox1.Text = "d7";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton13_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "e7";
                Oyna();}else
                    TextBox1.Text = "e7";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton14_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "f7";
                Oyna();}else
                    TextBox1.Text = "f7";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton15_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "g7";
                Oyna();}else
                    TextBox1.Text = "g7";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton16_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "h7";
                Oyna();}else
                    TextBox1.Text = "h7";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "A8";
                Oyna();}else
                    TextBox1.Text = "A8";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "b8";
                Oyna();}else
                    TextBox1.Text = "b8";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "c8";
                Oyna();}else
                    TextBox1.Text = "c8";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "d8";
                Oyna();}else
                    TextBox1.Text = "d8";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "e8";
                Oyna();}else
                    TextBox1.Text = "e8";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "f8";
                Oyna();}else
                    TextBox1.Text = "f8";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "g8";
                Oyna();}else
                    TextBox1.Text = "g8";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
        {
            if (TextBox4.Text == string.Empty)
            {
                if (TextBox1.Text != string.Empty)
                    {TextBox4.Text = "h8";
                Oyna();}else
                    TextBox1.Text = "h8";
            }
            else
            {
                TextBox1.Text = string.Empty;
                TextBox4.Text = string.Empty;

            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
