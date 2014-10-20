using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.OleDb;

namespace Chess
{
    public class SatrancFramework : SatrancTemelKurallari
    {
        private bool UluslarArasi;
        public bool Uluslararasi{
            get { return UluslarArasi; }
        }
        private bool Onay;
        public bool onay{
            get { return Onay; }
        }
        private int HamleGunLimiti, ToplamGunLimiti;
        public int HamlegunLimiti
        {
            get { return HamleGunLimiti; }
        }
        public int ToplamgunLimiti{
            get { return ToplamGunLimiti; }
        }
        private int BeyazKullaniciID;
        private int SiyahKullaniciID;
        private int MasaID;
        private int HamleSayisi;
        private int OyunTuru;
        private DateTime BaslamaTarihi;
        private DateTime SonHamle;
        public int BeyazkullaniciID { get { return BeyazKullaniciID; } }
        public int SiyahkullaniciID { get { return SiyahKullaniciID; } }
        public int masaID { get { return MasaID; } }
        public DateTime Baslamatarihi { get { return BaslamaTarihi; } }
        public DateTime Sonhamle { get { return SonHamle; } }
        private long TarihKarsilastir(DateTime Baslama,DateTime Bitis){
            long Fark = (Baslama.Year - Bitis.Year) * 365 * 24 * 60 * 60;
            Fark += (Baslama.Month - Bitis.Month) * 30 * 24 * 60 * 60;
            Fark += (Baslama.Day - Bitis.Day) * 24 * 60 * 60;
            Fark += (Baslama.Hour - Bitis.Hour) * 60 * 60;
            Fark += (Baslama.Minute - Bitis.Minute) * 60;
            Fark += (Baslama.Second - Bitis.Second);
            return Fark;
        }
        public SatrancFramework(int MasaID):base(){            
            this.MasaID = MasaID;
            VeriTabanindanVeriAl();
            if (Onay)
            {
                if (!UluslarArasi)
                {
                    if (oyunDurumu != Sonuc.Mat & oyunDurumu != Sonuc.Pat & SiyahKullaniciID != 0 & BeyazKullaniciID !=0)
                    {
                        if (TarihKarsilastir(DateTime.Now, Baslamatarihi) > ToplamGunLimiti * 24 * 60 * 60)
                        {
                            oyunDurumu = Sonuc.Mat;
                            Baglanti.SorguGonder("update Masa set OyunDurumu = 1 where ID = " + this.MasaID + ";");
                            OyunMatKazananaPuanVer();
                        }

                        if (TarihKarsilastir(DateTime.Now, SonHamle) > HamleGunLimiti * 24 * 60 * 60)
                        {
                            oyunDurumu = Sonuc.Mat;
                            Baglanti.SorguGonder("update Masa set OyunDurumu = 1 where ID = " + this.MasaID + ";");
                            OyunMatKazananaPuanVer();
                        }
                    }
                }else
                {
                    if (oyunDurumu != Sonuc.Mat & oyunDurumu != Sonuc.Pat & SiyahKullaniciID != 0 & BeyazKullaniciID != 0)
                    {
                        int YeniOyunLimiti = HamleGunLimiti;                       
                        
                        int HamleSayisi = Convert.ToInt32(Baglanti.BuMasadaKacHamleYapilmis(MasaID) / 2);

                        if (HamleSayisi >= HamleGunLimiti)
                        {
                            int Kat = Convert.ToInt32(HamleSayisi / HamleGunLimiti) + 1;
                            YeniOyunLimiti = Kat * ToplamGunLimiti;                            
                        }                       

                        if (TarihKarsilastir(DateTime.Now, Baslamatarihi) > YeniOyunLimiti * 24 * 60 * 60)
                        {
                            oyunDurumu = Sonuc.Mat;
                            Baglanti.SorguGonder("update Masa set OyunDurumu = 1 where ID = " + this.MasaID + ";");
                            OyunMatKazananaPuanVer();
                        }
                    }
                }
            }else{
               
                if (TarihKarsilastir(DateTime.Now, Baslamatarihi) >  24 * 60 * 60)
                {
                    
                    Baglanti.SorguGonder("delete from Masa where ID = " + this.MasaID + ";");
                    Exception sure = new Exception("Onaylama Suresi Gecti");
                    throw sure;
                }               
                
            }
        }
        public SatrancFramework(int BeyazKullaniciID,int SiyahKullaniciID,int HamleGunLimiti,int ToplamGunLimiti,int Kurucu,bool Uluslararasi)            
        {
            
            this.HamleGunLimiti = HamleGunLimiti;
            this.ToplamGunLimiti = ToplamGunLimiti;            
            this.BeyazKullaniciID = BeyazKullaniciID;
            this.SiyahKullaniciID = SiyahkullaniciID;
            this.UluslarArasi = Uluslararasi;
            YeniOyun();
            SiraBeyazdami = true;
            oyunDurumu = Sonuc.SiraBeyazda;
            BiElOncekiHamle = "0000";

            string SqlCumle = "insert into Masa (ToplamGunLimiti,HamleGunLimiti,BaslamaTarihi,SonHamleTarihi,SiraBeyazdami,OyunDurumu,BiOncekiHamle,BeyazOyuncuID,SiyahOyuncuID,K00,K01,K02,K03,K04,K05,K06,K07,K10,K11,K12,K13,K14,K15,K16,K17,K20,K21,K22,K23,K24,K25,K26,K27,K30,K31,K32,K33,K34,K35,K36,K37,K40,K41,K42,K43,K44,K45,K46,K47,K50,K51,K52,K53,K54,K55,K56,K57,K60,K61,K62,K63,K64,K65,K66,K67,K70,K71,K72,K73,K74,K75,K76,K77,SagBKaleOynadimi,SolBKaleOynadimi,SagSKaleOynadimi,SolSKaleOynadimi,BeyazSahOynadimi,SiyahSahOynadimi,Kurucu,Uluslararasi) values "+
                " ("+ToplamGunLimiti+","+HamleGunLimiti+",Now,Now," + SiraBeyazdami + "," + (int)oyunDurumu + ",'" + BiElOncekiHamle + "'," + BeyazKullaniciID + "," + SiyahKullaniciID + "," +          (int)MasaKareleri[0, 0].getDBDegeri() + "," + (int)MasaKareleri[0, 1].getDBDegeri() + "," + (int)MasaKareleri[0, 2].getDBDegeri() + "," + (int)MasaKareleri[0, 3].getDBDegeri() + "," + (int)MasaKareleri[0, 4].getDBDegeri() +
                "," + (int)MasaKareleri[0, 5].getDBDegeri() + "," + (int)MasaKareleri[0, 6].getDBDegeri() + "," + (int)MasaKareleri[0, 7].getDBDegeri() + "," + (int)MasaKareleri[1, 0].getDBDegeri() + "," + (int)MasaKareleri[1, 1].getDBDegeri() + "," + (int)MasaKareleri[1, 2].getDBDegeri() + "," + (int)MasaKareleri[1, 3].getDBDegeri() + "," + (int)MasaKareleri[1, 4].getDBDegeri() +
                "," + (int)MasaKareleri[1, 5].getDBDegeri() + "," + (int)MasaKareleri[1, 6].getDBDegeri() + "," + (int)MasaKareleri[1, 7].getDBDegeri() + "," + (int)MasaKareleri[2, 0].getDBDegeri() + "," + (int)MasaKareleri[2, 1].getDBDegeri() + "," + (int)MasaKareleri[2, 2].getDBDegeri() + "," + (int)MasaKareleri[2, 3].getDBDegeri() + "," + (int)MasaKareleri[2, 4].getDBDegeri() +
                "," + (int)MasaKareleri[2, 5].getDBDegeri() + "," + (int)MasaKareleri[2, 6].getDBDegeri() + "," + (int)MasaKareleri[2, 7].getDBDegeri() + "," + (int)MasaKareleri[3, 0].getDBDegeri() + "," + (int)MasaKareleri[3, 1].getDBDegeri() + "," + (int)MasaKareleri[3, 2].getDBDegeri() + "," + (int)MasaKareleri[3, 3].getDBDegeri() + "," + (int)MasaKareleri[3, 4].getDBDegeri() +
                "," + (int)MasaKareleri[3, 5].getDBDegeri() + "," + (int)MasaKareleri[3, 6].getDBDegeri() + "," + (int)MasaKareleri[3, 7].getDBDegeri() + "," + (int)MasaKareleri[4, 0].getDBDegeri() + "," + (int)MasaKareleri[4, 1].getDBDegeri() + "," + (int)MasaKareleri[4, 2].getDBDegeri() + "," + (int)MasaKareleri[4, 3].getDBDegeri() + "," + (int)MasaKareleri[4, 4].getDBDegeri() +
                "," + (int)MasaKareleri[4, 5].getDBDegeri() + "," + (int)MasaKareleri[4, 6].getDBDegeri() + "," + (int)MasaKareleri[4, 7].getDBDegeri() + "," + (int)MasaKareleri[5, 0].getDBDegeri() + "," + (int)MasaKareleri[5, 1].getDBDegeri() + "," + (int)MasaKareleri[5, 2].getDBDegeri() + "," + (int)MasaKareleri[5, 3].getDBDegeri() + "," + (int)MasaKareleri[5, 4].getDBDegeri() +
                "," + (int)MasaKareleri[5, 5].getDBDegeri() + "," + (int)MasaKareleri[5, 6].getDBDegeri() + "," + (int)MasaKareleri[5, 7].getDBDegeri() + "," + (int)MasaKareleri[6, 0].getDBDegeri() + "," + (int)MasaKareleri[6, 1].getDBDegeri() + "," + (int)MasaKareleri[6, 2].getDBDegeri() + "," + (int)MasaKareleri[6, 3].getDBDegeri() + "," + (int)MasaKareleri[6, 4].getDBDegeri() +
                "," + (int)MasaKareleri[6, 5].getDBDegeri() + "," + (int)MasaKareleri[6, 6].getDBDegeri() + "," + (int)MasaKareleri[6, 7].getDBDegeri() + "," + (int)MasaKareleri[7, 0].getDBDegeri() + "," + (int)MasaKareleri[7, 1].getDBDegeri() + "," + (int)MasaKareleri[7, 2].getDBDegeri() + "," + (int)MasaKareleri[7, 3].getDBDegeri() + "," + (int)MasaKareleri[7, 4].getDBDegeri() +
                "," + (int)MasaKareleri[7, 5].getDBDegeri() + "," + (int)MasaKareleri[7, 6].getDBDegeri() + "," + (int)MasaKareleri[7, 7].getDBDegeri() +
                "," + SagBeyazKaleOynadimi + "," + SolBeyazKaleOynadimi + "," + SagSiyahKaleOynadimi + "," + SolSiyahKaleOynadimi + "," + BeyazSahOynadimi + "," +SiyahSahOynadimi+ ","+Kurucu+","+Uluslararasi+");";
            
            try
            {
                
                Baglanti.SorguGonder(SqlCumle);
                this.MasaID = Baglanti.MaxID;

            }
            catch (System.Exception ex)
            {
               
                throw ex;
            }
        }
        public void VeriTabanindanVeriAl()
        {

            
            string cumle = "SELECT * FROM Masa WHERE ID=" + MasaID + ";";

            try
            {
                Baglanti.Connect();  
                OleDbCommand myCommand = new OleDbCommand(cumle, Baglanti.DataBaseconnection);
                OleDbDataReader myReader = myCommand.ExecuteReader();
                myReader.Read();
                SiraBeyazdami = myReader.GetBoolean(1);
                oyunDurumu = (Sonuc)myReader.GetInt32(2);
                BiElOncekiHamle = myReader.GetString(3);
                BeyazKullaniciID = myReader.GetInt32(4);
                SiyahKullaniciID = myReader.GetInt32(5);
                BaslamaTarihi = myReader.GetDateTime(6);
                SonHamle = myReader.GetDateTime(7);
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        MasaKareleri[i, j].setDBDegeri((DBTasEnum)myReader.GetInt32(9 + i * 8 + j));
                    }
                }
                SagBeyazKaleOynadimi = myReader.GetBoolean(73);
                SolBeyazKaleOynadimi = myReader.GetBoolean(74);
                SagSiyahKaleOynadimi = myReader.GetBoolean(75);
                SolSiyahKaleOynadimi = myReader.GetBoolean(76);
                BeyazSahOynadimi = myReader.GetBoolean(77);
                SiyahSahOynadimi = myReader.GetBoolean(78);
                ToplamGunLimiti = myReader.GetInt32(79);
                HamleGunLimiti = myReader.GetInt32(80);
                Onay = myReader.GetBoolean(81);
                UluslarArasi = myReader.GetBoolean(83);
                
            }
            catch (System.Exception e)
            {
                throw e;
            }
            finally
            {
                Baglanti.DisConnect();
            }
        }
        private string KoordinatDondur(int x){
            if(x==1){
                 return "A";   
            }else if(x==2){
                 return "B";   
            }else if(x==3){
                 return "C";   
            }else if(x==4){
                 return "D";   
            }else if(x==5){
                 return "E";   
            }else if(x==6){
                 return "F";   
            }else if(x==7){
                 return "G";   
            }else if(x==8){
                 return "H";   
            }else{
                return "Ğ";
            }
        }
        private void OyunMatKazananaPuanVer(){
            int Kazanan, Kaybeden;
            if(SiraBeyazdami){
                Kazanan = SiyahKullaniciID;
                Kaybeden = BeyazKullaniciID;
            }else{
                Kazanan = BeyazKullaniciID;
                Kaybeden =SiyahKullaniciID;
            }
            string Cumle = "update Kullanici set YenmeSayisi = (YenmeSayisi + 1) where ID =" + Kazanan + " ;";
            string Cumle2 = "update Kullanici set YenilmeSayisi = (YenilmeSayisi + 1) where ID =" + Kaybeden + " ;";
            Baglanti.SorguGonder(Cumle);
            Baglanti.SorguGonder(Cumle2);
        }
        private void OyunPatPuanVer(){
            string Cumle = "update Kullanici set BeraberlikSayisi = (BeraberlikSayisi + 1) where ID =" + BeyazKullaniciID + " or ID = "+SiyahKullaniciID+" ;";
            Baglanti.SorguGonder(Cumle);
        }
        public void Oynat(int TasinYeriX, int TasinYeriY, int GidecegiYerX, int GidecegiYerY,TurEnum YukselecekTas){
            if(oyunDurumu==Sonuc.Mat|oyunDurumu==Sonuc.Pat){
                return;            
            }          
            
            try{
                HamleYap(TasinYeriX, TasinYeriY, GidecegiYerX, GidecegiYerY, YukselecekTas);
                string SqlCumle = "UPDATE Masa SET SonHamleTarihi = Now, SiraBeyazdami=" + SiraBeyazdami + ",OyunDurumu=" + (int)oyunDurumu + ",BiOncekiHamle='" + BiElOncekiHamle + "'," +
                    "K00=" + (int)MasaKareleri[0, 0].getDBDegeri() + ",K01=" + (int)MasaKareleri[0, 1].getDBDegeri() + ",K02=" + (int)MasaKareleri[0, 2].getDBDegeri() + ",K03=" + (int)MasaKareleri[0, 3].getDBDegeri() + ",K04=" + (int)MasaKareleri[0, 4].getDBDegeri() + ",K05=" + (int)MasaKareleri[0, 5].getDBDegeri() + ",K06=" + (int)MasaKareleri[0, 6].getDBDegeri() + ",K07=" + (int)MasaKareleri[0, 7].getDBDegeri() +
                    ",K10=" + (int)MasaKareleri[1, 0].getDBDegeri() + ",K11=" + (int)MasaKareleri[1, 1].getDBDegeri() + ",K12=" + (int)MasaKareleri[1, 2].getDBDegeri() + ",K13=" + (int)MasaKareleri[1, 3].getDBDegeri() + ",K14=" + (int)MasaKareleri[1, 4].getDBDegeri() + ",K15=" + (int)MasaKareleri[1, 5].getDBDegeri() + ",K16=" + (int)MasaKareleri[1, 6].getDBDegeri() + ",K17=" + (int)MasaKareleri[1, 7].getDBDegeri() +
                    ",K20=" + (int)MasaKareleri[2, 0].getDBDegeri() + ",K21=" + (int)MasaKareleri[2, 1].getDBDegeri() + ",K22=" + (int)MasaKareleri[2, 2].getDBDegeri() + ",K23=" + (int)MasaKareleri[2, 3].getDBDegeri() + ",K24=" + (int)MasaKareleri[2, 4].getDBDegeri() + ",K25=" + (int)MasaKareleri[2, 5].getDBDegeri() + ",K26=" + (int)MasaKareleri[2, 6].getDBDegeri() + ",K27=" + (int)MasaKareleri[2, 7].getDBDegeri() +
                    ",K30=" + (int)MasaKareleri[3, 0].getDBDegeri() + ",K31=" + (int)MasaKareleri[3, 1].getDBDegeri() + ",K32=" + (int)MasaKareleri[3, 2].getDBDegeri() + ",K33=" + (int)MasaKareleri[3, 3].getDBDegeri() + ",K34=" + (int)MasaKareleri[3, 4].getDBDegeri() + ",K35=" + (int)MasaKareleri[3, 5].getDBDegeri() + ",K36=" + (int)MasaKareleri[3, 6].getDBDegeri() + ",K37=" + (int)MasaKareleri[3, 7].getDBDegeri() +
                    ",K40=" + (int)MasaKareleri[4, 0].getDBDegeri() + ",K41=" + (int)MasaKareleri[4, 1].getDBDegeri() + ",K42=" + (int)MasaKareleri[4, 2].getDBDegeri() + ",K43=" + (int)MasaKareleri[4, 3].getDBDegeri() + ",K44=" + (int)MasaKareleri[4, 4].getDBDegeri() + ",K45=" + (int)MasaKareleri[4, 5].getDBDegeri() + ",K46=" + (int)MasaKareleri[4, 6].getDBDegeri() + ",K47=" + (int)MasaKareleri[4, 7].getDBDegeri() +
                    ",K50=" + (int)MasaKareleri[5, 0].getDBDegeri() + ",K51=" + (int)MasaKareleri[5, 1].getDBDegeri() + ",K52=" + (int)MasaKareleri[5, 2].getDBDegeri() + ",K53=" + (int)MasaKareleri[5, 3].getDBDegeri() + ",K54=" + (int)MasaKareleri[5, 4].getDBDegeri() + ",K55=" + (int)MasaKareleri[5, 5].getDBDegeri() + ",K56=" + (int)MasaKareleri[5, 6].getDBDegeri() + ",K57=" + (int)MasaKareleri[5, 7].getDBDegeri() +
                    ",K60=" + (int)MasaKareleri[6, 0].getDBDegeri() + ",K61=" + (int)MasaKareleri[6, 1].getDBDegeri() + ",K62=" + (int)MasaKareleri[6, 2].getDBDegeri() + ",K63=" + (int)MasaKareleri[6, 3].getDBDegeri() + ",K64=" + (int)MasaKareleri[6, 4].getDBDegeri() + ",K65=" + (int)MasaKareleri[6, 5].getDBDegeri() + ",K66=" + (int)MasaKareleri[6, 6].getDBDegeri() + ",K67=" + (int)MasaKareleri[6, 7].getDBDegeri() +
                    ",K70=" + (int)MasaKareleri[7, 0].getDBDegeri() + ",K71=" + (int)MasaKareleri[7, 1].getDBDegeri() + ",K72=" + (int)MasaKareleri[7, 2].getDBDegeri() + ",K73=" + (int)MasaKareleri[7, 3].getDBDegeri() + ",K74=" + (int)MasaKareleri[7, 4].getDBDegeri() + ",K75=" + (int)MasaKareleri[7, 5].getDBDegeri() + ",K76=" + (int)MasaKareleri[7, 6].getDBDegeri() + ",K77=" + (int)MasaKareleri[7, 7].getDBDegeri() + 
                     ",SagBKaleOynadimi="+SagBeyazKaleOynadimi+",SolBKaleOynadimi="+SolBeyazKaleOynadimi+ ",SagSKaleOynadimi="+SagSiyahKaleOynadimi+",SolSKaleOynadimi=" +SolSiyahKaleOynadimi + ",BeyazSahOynadimi="+BeyazSahOynadimi +",SiyahSahOynadimi=" + SiyahSahOynadimi   +  " where ID = "+MasaID+";";

                string HamleCumle= "insert into Hamle (MasaID,Hamle) values ("+MasaID+",'"+KoordinatDondur(Convert.ToInt32(TasinYeriY+1))+Convert.ToUInt32(TasinYeriX+1)+KoordinatDondur(Convert.ToInt32(GidecegiYerY)+1)+Convert.ToUInt32(GidecegiYerX+1)+"' );";
                Baglanti.SorguGonder(SqlCumle);
                Baglanti.SorguGonder(HamleCumle);
                if(oyunDurumu==Sonuc.Mat){
                    OyunMatKazananaPuanVer();
                }else if(oyunDurumu==Sonuc.Pat){
                    OyunPatPuanVer();
                }

            }catch(Exception hata){
                throw hata;
            }
        }
        
        
    }
}
