using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;


namespace Chess
{    
    public enum Sonuc{//Bir Satranç oyununun o andaki durumunu tutabilen enum
        SahCekti,Mat,Pat,SiraBeyazda,SiraSiyahta
    }
    public enum TurEnum//Satranç taşlarının türlerini tutabilen enum
    {
        Piyon, Fil, At, Kale, Vezir, Sah, Bos
    }
    public enum RenkEnum//Satranç taşlarının renklerini belirleyen enum
    {
        Beyaz, Siyah, Bos
    }
    public enum DBTasEnum{//Veritabanına Taşları kaydettiğimiz enum
        BOS,BeyazPiyon,BeyazKale,BeyazAt,BeyazFil,BeyazVezir,BeyazSah,SiyahPiyon,SiyahKale,SiyahAt,SiyahFil,SiyahVezir,SiyahSah
    }
    public class SatrancTasi//Bir Satranç taşının özelliklerine sahip nesne sınıfı.
    {
        public TurEnum tur;//Taşın türü. şah, vezir ..
        public RenkEnum renk;//Taşın rengi. siyah , beyaz ..
        public SatrancTasi(TurEnum tur, RenkEnum renk)
        {
            this.tur = tur;
            this.renk = renk;
        }//İstenilen bir taş'ı oluşturmak için kullanılan constructor.
        public SatrancTasi()
        {
            this.tur = TurEnum.Bos;
            this.renk = RenkEnum.Bos;

        }//Boş bir taş yani boş kare oluşturmak için kullanılan constuctor.
        public void PiyonYukselt(TurEnum IstenenTas)
        {
            if (this.tur == TurEnum.Piyon)
            {
                if (IstenenTas == TurEnum.At | IstenenTas == TurEnum.Fil | IstenenTas == TurEnum.Vezir | IstenenTas == TurEnum.Kale)
                {
                    this.tur = IstenenTas;
                }
                else
                {
                    Exception Turhatasi = new Exception("Piyonlar piyona yada Sah'a Yukselemez.");
                    throw Turhatasi;
                }
            }
            else
            {
                Exception TurHatasi = new Exception("Piyon Harici SatrancTasi Yukseltilemez.");
                throw TurHatasi;
            }
        }//Bir piyon en ileri hatta ilerlediğinden istenilen bir taş'a dönüşür. şah, kale,fil,at.
        public int KoordinatX, KoordinatY;//Piyon'un tahtadaki Koordinatları.
        public void TasKaybet()
        {
            this.tur = TurEnum.Bos;
            this.renk = RenkEnum.Bos;
        } //O taşı yoketmek yani boş kare yapmak için kullanılan fonksyon.
        public DBTasEnum getDBDegeri(){
            if(renk==RenkEnum.Bos){
                return DBTasEnum.BOS;
            }else if(renk==RenkEnum.Beyaz){
                if(tur==TurEnum.Piyon){
                    return DBTasEnum.BeyazPiyon;
                }else if(tur==TurEnum.Kale){
                    return DBTasEnum.BeyazKale;
                }else if(tur==TurEnum.At){
                    return DBTasEnum.BeyazAt;
                }else if(tur==TurEnum.Fil){
                    return DBTasEnum.BeyazFil;
                }else if(tur==TurEnum.Vezir){
                    return DBTasEnum.BeyazVezir;
                }else if(tur==TurEnum.Sah){
                    return DBTasEnum.BeyazSah;
                }
            }else{
                if (tur == TurEnum.Piyon)
                {
                    return DBTasEnum.SiyahPiyon;
                }
                else if (tur == TurEnum.Kale)
                {
                    return DBTasEnum.SiyahKale;
                }
                else if (tur == TurEnum.At)
                {
                    return DBTasEnum.SiyahAt;
                }
                else if (tur == TurEnum.Fil)
                {
                    return DBTasEnum.SiyahFil;
                }
                else if (tur == TurEnum.Vezir)
                {
                    return DBTasEnum.SiyahVezir;
                }
                else if (tur == TurEnum.Sah)
                {
                    return DBTasEnum.SiyahSah;
                }
            }
            return DBTasEnum.BOS;
        }//Taşın veritabanına yazılacak int değeri dönderir.
        public void setDBDegeri(DBTasEnum TAS)
        {
            if (TAS == DBTasEnum.BOS)
            {
                tur = TurEnum.Bos;
                renk = RenkEnum.Bos;
            }
            else if (TAS == DBTasEnum.BeyazPiyon)
            {
                tur = TurEnum.Piyon;
                renk = RenkEnum.Beyaz;
            }
            else if (TAS == DBTasEnum.BeyazKale)
            {
                tur = TurEnum.Kale;
                renk = RenkEnum.Beyaz;
            }
            else if (TAS == DBTasEnum.BeyazAt)
            {
                tur = TurEnum.At;
                renk = RenkEnum.Beyaz;
            }
            else if (TAS == DBTasEnum.BeyazFil)
            {
                tur = TurEnum.Fil;
                renk = RenkEnum.Beyaz;
            }
            else if (TAS == DBTasEnum.BeyazVezir)
            {
                tur = TurEnum.Vezir;
                renk = RenkEnum.Beyaz;
            }
            else if (TAS == DBTasEnum.BeyazSah)
            {
                tur = TurEnum.Sah;
                renk = RenkEnum.Beyaz;
            }
            else if (TAS == DBTasEnum.SiyahPiyon)
            {
                tur = TurEnum.Piyon;
                renk = RenkEnum.Siyah;
            }
            else if (TAS == DBTasEnum.SiyahKale)
            {
                tur = TurEnum.Kale;
                renk = RenkEnum.Siyah;
            }
            else if (TAS == DBTasEnum.SiyahAt)
            {
                tur = TurEnum.At;
                renk = RenkEnum.Siyah;
            }
            else if (TAS == DBTasEnum.SiyahFil)
            {
                tur = TurEnum.Fil;
                renk = RenkEnum.Siyah;
            }
            else if (TAS == DBTasEnum.SiyahVezir)
            {
                tur = TurEnum.Vezir;
                renk = RenkEnum.Siyah;
            }
            else if (TAS == DBTasEnum.SiyahSah)
            {
                tur = TurEnum.Sah;
                renk = RenkEnum.Siyah;
            }
            
        }//Veritabanından alınan sayısal değeri alıp taş'ı cinsini ve rengini belirler.
    }    
    public abstract class SatrancTemelKurallari
    {
        protected bool SiraBeyazdami=true;//Siranın beyazda olup olmadığının tutan ikili değişken.
        protected Sonuc oyunDurumu=Sonuc.SiraBeyazda;//oyun durumunu tutan değişken. Default Sirabeyazda olmasının sebebi satranç'da oyunda beyaz oyuncunun başlaması.
        public bool sirabeyazdami{
            get { return SiraBeyazdami; }
        }//Sirabeyazdami değişkeninin dışarından erişilebilen readonly değişkeni.
        public Sonuc OyunDurumu
        {
            get { return oyunDurumu; }
        }//Oyundurumunun dışarıdan erişilebilen readonly değişkeni.
        protected SatrancTasi[,] MasaKareleri;//Bir satranç tahtasındaji 64 kareyi tutan SatrancTasi dizisi.
        public SatrancTasi[,] masaKareleri{
            get{return MasaKareleri;}
        }//Dizinin public readonly değişkeni.
        public SatrancTemelKurallari()
        {
            MasaKareleri = new SatrancTasi[8, 8];
            
            BiOncekiX= new SatrancTasi();
            BiOncekiY = new SatrancTasi();           
           
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    MasaKareleri[i, j] = new SatrancTasi();
                }
            }
            
        }//Constructor. 64 boş kare oluşturur ve masaya yerleştirir.
        protected string BiElOncekiHamle;//Bi önceki hamleyi tutan değişken.
        private SatrancTasi BiOncekiX,BiOncekiY;//Geçici taşlar.
        private SatrancTasi YiyerekGecilen=null;//Yiyerek geçilen taş.
        public void YeniOyun(){

            
            #region Siyahları Yerleştir

            MasaKareleri[7, 0].tur = TurEnum.Kale;
            MasaKareleri[7, 0].renk = RenkEnum.Siyah;
            MasaKareleri[7, 1].tur = TurEnum.At;
            MasaKareleri[7, 1].renk = RenkEnum.Siyah;
            MasaKareleri[7, 2].tur = TurEnum.Fil;
            MasaKareleri[7, 2].renk = RenkEnum.Siyah;
            MasaKareleri[7, 3].tur = TurEnum.Vezir;
            MasaKareleri[7, 3].renk = RenkEnum.Siyah;
            MasaKareleri[7, 4].tur = TurEnum.Sah;
            MasaKareleri[7, 4].renk = RenkEnum.Siyah;
            MasaKareleri[7, 5].tur = TurEnum.Fil;
            MasaKareleri[7, 5].renk = RenkEnum.Siyah;
            MasaKareleri[7, 6].tur = TurEnum.At;
            MasaKareleri[7, 6].renk = RenkEnum.Siyah;
            MasaKareleri[7, 7].tur = TurEnum.Kale;
            MasaKareleri[7, 7].renk = RenkEnum.Siyah;
            MasaKareleri[6, 0].tur = TurEnum.Piyon;
            MasaKareleri[6, 0].renk = RenkEnum.Siyah;
            MasaKareleri[6, 1].tur = TurEnum.Piyon;
            MasaKareleri[6, 1].renk = RenkEnum.Siyah;
            MasaKareleri[6, 2].tur = TurEnum.Piyon;
            MasaKareleri[6, 2].renk = RenkEnum.Siyah;
            MasaKareleri[6, 3].tur = TurEnum.Piyon;
            MasaKareleri[6, 3].renk = RenkEnum.Siyah;
            MasaKareleri[6, 4].tur = TurEnum.Piyon;
            MasaKareleri[6, 4].renk = RenkEnum.Siyah;
            MasaKareleri[6, 5].tur = TurEnum.Piyon;
            MasaKareleri[6, 5].renk = RenkEnum.Siyah;
            MasaKareleri[6, 6].tur = TurEnum.Piyon;
            MasaKareleri[6, 6].renk = RenkEnum.Siyah;
            MasaKareleri[6, 7].tur = TurEnum.Piyon;
            MasaKareleri[6, 7].renk = RenkEnum.Siyah;
            #endregion

            #region Beyazları Yerleştir
            MasaKareleri[0, 0].tur = TurEnum.Kale;
            MasaKareleri[0, 0].renk = RenkEnum.Beyaz;
            MasaKareleri[0, 1].tur = TurEnum.At;
            MasaKareleri[0, 1].renk = RenkEnum.Beyaz;
            MasaKareleri[0, 2].tur = TurEnum.Fil;
            MasaKareleri[0, 2].renk = RenkEnum.Beyaz;
            MasaKareleri[0, 3].tur = TurEnum.Vezir;
            MasaKareleri[0, 3].renk = RenkEnum.Beyaz;
            MasaKareleri[0, 4].tur = TurEnum.Sah;
            MasaKareleri[0, 4].renk = RenkEnum.Beyaz;
            MasaKareleri[0, 5].tur = TurEnum.Fil;
            MasaKareleri[0, 5].renk = RenkEnum.Beyaz;
            MasaKareleri[0, 6].tur = TurEnum.At;
            MasaKareleri[0, 6].renk = RenkEnum.Beyaz;
            MasaKareleri[0, 7].tur = TurEnum.Kale;
            MasaKareleri[0, 7].renk = RenkEnum.Beyaz;
            MasaKareleri[1, 0].tur = TurEnum.Piyon;
            MasaKareleri[1, 0].renk = RenkEnum.Beyaz;
            MasaKareleri[1, 1].tur = TurEnum.Piyon;
            MasaKareleri[1, 1].renk = RenkEnum.Beyaz;
            MasaKareleri[1, 2].tur = TurEnum.Piyon;
            MasaKareleri[1, 2].renk = RenkEnum.Beyaz;
            MasaKareleri[1, 3].tur = TurEnum.Piyon;
            MasaKareleri[1, 3].renk = RenkEnum.Beyaz;
            MasaKareleri[1, 4].tur = TurEnum.Piyon;
            MasaKareleri[1, 4].renk = RenkEnum.Beyaz;
            MasaKareleri[1, 5].tur = TurEnum.Piyon;
            MasaKareleri[1, 5].renk = RenkEnum.Beyaz;
            MasaKareleri[1, 6].tur = TurEnum.Piyon;
            MasaKareleri[1, 6].renk = RenkEnum.Beyaz;
            MasaKareleri[1, 7].tur = TurEnum.Piyon;
            MasaKareleri[1, 7].renk = RenkEnum.Beyaz;
            #endregion     

            #region Boslari Yerkestir
            for (int i = 2; i < 6; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    MasaKareleri[i , j].renk = RenkEnum.Bos;
                    MasaKareleri[i , j].tur = TurEnum.Bos;
                }
            } 
            #endregion
            SagBeyazKaleOynadimi = false;
            SolBeyazKaleOynadimi = false;
            BeyazSahOynadimi = false;
            SagSiyahKaleOynadimi = false;
            SolSiyahKaleOynadimi = false;
            SiyahSahOynadimi = false;
            SiraBeyazdami = true;
            oyunDurumu = Sonuc.SiraBeyazda;
            
        }       //64 kareye taşları kurallara göre yerleştiren fonksyon.
        private bool BuTasTehlikedemi(int KoordinatX, int KoordinatY, RenkEnum renk)
        {
            int i, j;
            
            #region Rakip rengini belirle
            RenkEnum RakipRenk;
            if (renk == RenkEnum.Beyaz)
            {
                RakipRenk = RenkEnum.Siyah;
            }
            else
            {
                RakipRenk = RenkEnum.Beyaz;
            }
            #endregion
            #region Piyon Kontrol
            if (renk == RenkEnum.Beyaz)
            {
                if (KoordinatX < 7)
                {
                    if (KoordinatY == 0)
                    {
                        if (MasaKareleri[KoordinatX + 1, KoordinatY + 1].tur == TurEnum.Piyon & MasaKareleri[KoordinatX + 1, KoordinatY + 1].renk == RakipRenk)
                        {

                            return true;
                        }
                    }
                    else if (KoordinatY == 7)
                    {
                        if (MasaKareleri[KoordinatX + 1, KoordinatY - 1].tur == TurEnum.Piyon & MasaKareleri[KoordinatX + 1, KoordinatY - 1].renk == RakipRenk)
                        {

                            return true;
                        }
                    }
                    else
                    {
                        if (MasaKareleri[KoordinatX + 1, KoordinatY - 1].tur == TurEnum.Piyon & MasaKareleri[KoordinatX + 1, KoordinatY - 1].renk == RakipRenk)
                        {

                            return true;
                        }
                        if (MasaKareleri[KoordinatX + 1, KoordinatY + 1].tur == TurEnum.Piyon & MasaKareleri[KoordinatX + 1, KoordinatY + 1].renk == RakipRenk)
                        {

                            return true;
                        }
                    }
                }
            }
            else
            {
                if (KoordinatX > 0)
                {
                    if (KoordinatY == 0)
                    {
                        if (MasaKareleri[KoordinatX - 1, KoordinatY + 1].tur == TurEnum.Piyon & MasaKareleri[KoordinatX - 1, KoordinatY + 1].renk == RakipRenk)
                        {

                            return true;
                        }
                    }
                    else if (KoordinatY == 7)
                    {
                        if (MasaKareleri[KoordinatX - 1, KoordinatY - 1].tur == TurEnum.Piyon & MasaKareleri[KoordinatX - 1, KoordinatY - 1].renk == RakipRenk)
                        {

                            return true;
                        }
                    }
                    else
                    {
                        if (MasaKareleri[KoordinatX - 1, KoordinatY - 1].tur == TurEnum.Piyon & MasaKareleri[KoordinatX - 1, KoordinatY - 1].renk == RakipRenk)
                        {

                            return true;
                        }
                        if (MasaKareleri[KoordinatX - 1, KoordinatY + 1].tur == TurEnum.Piyon & MasaKareleri[KoordinatX - 1, KoordinatY + 1].renk == RakipRenk)
                        {

                            return true;
                        }
                    }
                }
            }
            #endregion
            #region Sol Yatay Kontrol
            for (i = KoordinatY - 1; i >= 0; i--)
            {
                if (MasaKareleri[KoordinatX, i].renk == renk)
                {
                    break;
                }
                else if (MasaKareleri[KoordinatX, i].renk == RakipRenk)
                {
                    if (MasaKareleri[KoordinatX, i].tur == TurEnum.Sah & MutlakDeger(KoordinatY - i) == 1)
                        return true;
                    if (MasaKareleri[KoordinatX, i].tur == TurEnum.Vezir | MasaKareleri[KoordinatX, i].tur == TurEnum.Kale )
                    {

                        return true;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            #endregion
            #region sag Yatay Kontrol
            for (i = KoordinatY + 1; i < 8; i++)
            {
                if (MasaKareleri[KoordinatX, i].renk == renk)
                {
                    break;
                }
                else if (MasaKareleri[KoordinatX, i].renk == RakipRenk)
                {
                    if (MasaKareleri[KoordinatX, i].tur == TurEnum.Sah & MutlakDeger(KoordinatY - i) == 1)
                        return true;
                    if (MasaKareleri[KoordinatX, i].tur == TurEnum.Vezir | MasaKareleri[KoordinatX, i].tur == TurEnum.Kale)
                    {

                        return true;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            #endregion
            #region Yukarı Dik Kontrol
            for (i = KoordinatX - 1; i >= 0; i--)
            {
                if (MasaKareleri[i, KoordinatY].renk == renk)
                {
                    break;
                }
                else if (MasaKareleri[i, KoordinatY].renk == RakipRenk)
                {
                    if (MasaKareleri[KoordinatX, i].tur == TurEnum.Sah & MutlakDeger(KoordinatY - i) == 1)
                        return true;
                    if (MasaKareleri[i, KoordinatY].tur == TurEnum.Vezir | MasaKareleri[i, KoordinatY].tur == TurEnum.Kale )
                    {

                        return true;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            #endregion
            #region Asagi Dik Kontrol
            i = KoordinatX;
            j = KoordinatY;
            for (i = KoordinatX + 1; i < 8; i++)
            {
                if (MasaKareleri[i, j].renk == renk)
                {
                    break;
                }
                else if (MasaKareleri[i, j].renk == RakipRenk)
                {
                    if (MasaKareleri[KoordinatX, i].tur == TurEnum.Sah & MutlakDeger(KoordinatY - i) == 1)
                        return true;
                    if (MasaKareleri[i, KoordinatY].tur == TurEnum.Vezir | MasaKareleri[i, KoordinatY].tur == TurEnum.Kale)
                    {

                        return true;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            #endregion
            #region Yukari Sag Capraz Kontrol
            i = KoordinatX;
            j = KoordinatY;
            while (true)
            {
                i--;
                j++;
                if (i < 0 | j > 7)
                {
                    break;
                }
                if (MasaKareleri[i, j].renk == renk)
                {
                    break;
                }
                else if (MasaKareleri[i, j].renk == RakipRenk)
                {
                    if (MasaKareleri[i,j].tur == TurEnum.Sah & MutlakDeger(KoordinatY - j) == 1)
                        return true;
                    if (MasaKareleri[i, j].tur == TurEnum.Vezir | MasaKareleri[i, j].tur == TurEnum.Fil )
                    {

                        return true;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            #endregion
            #region Asagi Sag Capraz Kontrol
            i = KoordinatX;
            j = KoordinatY;
            while (true)
            {
                i++;
                j++;
                if (i > 7 | j > 7)
                {
                    break;
                }
                if (MasaKareleri[i, j].renk == renk)
                {
                    break;
                }
                else if (MasaKareleri[i, j].renk == RakipRenk)
                {
                    if (MasaKareleri[i, j].tur == TurEnum.Sah & MutlakDeger(KoordinatY - j) == 1)
                        return true;
                    if (MasaKareleri[i, j].tur == TurEnum.Vezir | MasaKareleri[i, j].tur == TurEnum.Fil )
                    {

                        return true;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            #endregion
            #region Asagi sol Capraz Kontrol
            i = KoordinatX;
            j = KoordinatY;
            while (true)
            {
                i++;
                j--;
                if (i > 7 | j < 0)
                {
                    break;
                }
                if (MasaKareleri[i, j].renk == renk)
                {
                    break;
                }
                else if (MasaKareleri[i, j].renk == RakipRenk)
                {
                    if (MasaKareleri[i, j].tur == TurEnum.Sah & MutlakDeger(KoordinatY - j) == 1)
                        return true;
                    if (MasaKareleri[i, j].tur == TurEnum.Vezir | MasaKareleri[i, j].tur == TurEnum.Fil )
                    {

                        return true;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            #endregion
            #region Yukari sol Capraz Kontrol
            i = KoordinatX;
            j = KoordinatY;
            while (true)
            {
                i--;
                j--;
                if (i < 0 | j < 0)
                {
                    break;
                }
                if (MasaKareleri[i, j].renk == renk)
                {
                    break;
                }
                else if (MasaKareleri[i, j].renk == RakipRenk)
                {
                    if (MasaKareleri[i, j].tur == TurEnum.Sah & MutlakDeger(KoordinatY - j) == 1)
                        return true;
                    if (MasaKareleri[i, j].tur == TurEnum.Vezir | MasaKareleri[i, j].tur == TurEnum.Fil )
                    {

                        return true;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            #endregion
            #region AT Kontrol
            if (KoordinatX > 1 & KoordinatY > 0)
            {
                if (MasaKareleri[KoordinatX - 2, KoordinatY - 1].tur == TurEnum.At & MasaKareleri[KoordinatX - 2, KoordinatY - 1].renk == RakipRenk)
                {

                    return true;
                }
            }
            if (KoordinatX > 0 & KoordinatY > 1)
            {
                if (MasaKareleri[KoordinatX - 1, KoordinatY - 2].tur == TurEnum.At & MasaKareleri[KoordinatX - 1, KoordinatY - 2].renk == RakipRenk)
                {

                    return true;
                }
            }
            if (KoordinatX < 7 & KoordinatY > 1)
            {
                if (MasaKareleri[KoordinatX + 1, KoordinatY - 2].tur == TurEnum.At & MasaKareleri[KoordinatX + 1, KoordinatY - 2].renk == RakipRenk)
                {

                    return true;
                }
            }
            if (KoordinatX < 6 & KoordinatY > 0)
            {
                if (MasaKareleri[KoordinatX + 2, KoordinatY - 1].tur == TurEnum.At & MasaKareleri[KoordinatX + 2, KoordinatY - 1].renk == RakipRenk)
                {

                    return true;
                }
            }
            if (KoordinatX > 1 & KoordinatY < 7)
            {
                if (MasaKareleri[KoordinatX - 2, KoordinatY + 1].tur == TurEnum.At & MasaKareleri[KoordinatX - 2, KoordinatY + 1].renk == RakipRenk)
                {

                    return true;
                }
            }
            if (KoordinatX > 0 & KoordinatY < 6)
            {
                if (MasaKareleri[KoordinatX - 1, KoordinatY + 2].tur == TurEnum.At & MasaKareleri[KoordinatX - 1, KoordinatY + 2].renk == RakipRenk)
                {

                    return true;
                }
            }
            if (KoordinatX < 7 & KoordinatY < 6)
            {
                if (MasaKareleri[KoordinatX + 1, KoordinatY + 2].tur == TurEnum.At & MasaKareleri[KoordinatX + 1, KoordinatY + 2].renk == RakipRenk)
                {

                    return true;
                }
            }
            if (KoordinatX < 6 & KoordinatY < 7)
            {
                if (MasaKareleri[KoordinatX + 2, KoordinatY + 1].tur == TurEnum.At & MasaKareleri[KoordinatX + 2, KoordinatY + 1].renk == RakipRenk)
                {

                    return true;
                }
            }


            #endregion
          
            return false;
        }//Koordinatlarına göre bir karenin rakip renk tarafından tehdit edilip edilmediğini kontrol eder.
        private bool BuTasTehlikedemiSahHaric(int KoordinatX, int KoordinatY, RenkEnum renk)
        {
            int i, j;
           
            #region Rakip rengini belirle
            RenkEnum RakipRenk;
            if (renk == RenkEnum.Beyaz)
            {
                RakipRenk = RenkEnum.Siyah;
            }
            else
            {
                RakipRenk = RenkEnum.Beyaz;
            }
            #endregion
            #region Piyon Kontrol
            if (renk == RenkEnum.Beyaz)
            {
                if (KoordinatX < 7)
                {
                    if (KoordinatY == 0)
                    {
                        if (MasaKareleri[KoordinatX + 1, KoordinatY + 1].tur == TurEnum.Piyon & MasaKareleri[KoordinatX + 1, KoordinatY + 1].renk == RakipRenk)
                        {

                            return true;
                        }
                    }
                    else if (KoordinatY == 7)
                    {
                        if (MasaKareleri[KoordinatX + 1, KoordinatY - 1].tur == TurEnum.Piyon & MasaKareleri[KoordinatX + 1, KoordinatY - 1].renk == RakipRenk)
                        {

                            return true;
                        }
                    }
                    else
                    {
                        if (MasaKareleri[KoordinatX + 1, KoordinatY - 1].tur == TurEnum.Piyon & MasaKareleri[KoordinatX + 1, KoordinatY - 1].renk == RakipRenk)
                        {

                            return true;
                        }
                        if (MasaKareleri[KoordinatX + 1, KoordinatY + 1].tur == TurEnum.Piyon & MasaKareleri[KoordinatX + 1, KoordinatY + 1].renk == RakipRenk)
                        {

                            return true;
                        }
                    }
                }
            }
            else
            {
                if (KoordinatX > 0)
                {
                    if (KoordinatY == 0)
                    {
                        if (MasaKareleri[KoordinatX - 1, KoordinatY + 1].tur == TurEnum.Piyon & MasaKareleri[KoordinatX - 1, KoordinatY + 1].renk == RakipRenk)
                        {

                            return true;
                        }
                    }
                    else if (KoordinatY == 7)
                    {
                        if (MasaKareleri[KoordinatX - 1, KoordinatY - 1].tur == TurEnum.Piyon & MasaKareleri[KoordinatX - 1, KoordinatY - 1].renk == RakipRenk)
                        {

                            return true;
                        }
                    }
                    else
                    {
                        if (MasaKareleri[KoordinatX - 1, KoordinatY - 1].tur == TurEnum.Piyon & MasaKareleri[KoordinatX - 1, KoordinatY - 1].renk == RakipRenk)
                        {

                            return true;
                        }
                        if (MasaKareleri[KoordinatX - 1, KoordinatY + 1].tur == TurEnum.Piyon & MasaKareleri[KoordinatX - 1, KoordinatY + 1].renk == RakipRenk)
                        {

                            return true;
                        }
                    }
                }
            }
            #endregion
            #region Sol Yatay Kontrol
            for (i = KoordinatY - 1; i >= 0; i--)
            {
                if (MasaKareleri[KoordinatX, i].renk == renk)
                {
                    break;
                }
                else if (MasaKareleri[KoordinatX, i].renk == RakipRenk)
                {
                    if (MasaKareleri[KoordinatX, i].tur == TurEnum.Vezir | MasaKareleri[KoordinatX, i].tur == TurEnum.Kale )
                    {
                       
                        return true;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            #endregion
            #region sag Yatay Kontrol
            for (i = KoordinatY + 1; i < 8; i++)
            {
                if (MasaKareleri[KoordinatX, i].renk == renk)
                {
                    break;
                }
                else if (MasaKareleri[KoordinatX, i].renk == RakipRenk)
                {
                    if (MasaKareleri[KoordinatX, i].tur == TurEnum.Vezir | MasaKareleri[KoordinatX, i].tur == TurEnum.Kale )
                    {
                        
                        return true;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            #endregion
            #region Yukarı Dik Kontrol
            for (i = KoordinatX - 1; i >= 0; i--)
            {
                if (MasaKareleri[i, KoordinatY].renk == renk)
                {
                    break;
                }
                else if (MasaKareleri[i, KoordinatY].renk == RakipRenk)
                {
                    if (MasaKareleri[i, KoordinatY].tur == TurEnum.Vezir | MasaKareleri[i, KoordinatY].tur == TurEnum.Kale )
                    {
                        
                        return true;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            #endregion
            #region Asagi Dik Kontrol
            i = KoordinatX;
            j = KoordinatY;
            for (i = KoordinatX + 1; i < 8; i++)
            {
                if (MasaKareleri[i, j].renk == renk)
                {
                    break;
                }
                else if (MasaKareleri[i, j].renk == RakipRenk)
                {
                    if (MasaKareleri[i, KoordinatY].tur == TurEnum.Vezir | MasaKareleri[i, KoordinatY].tur == TurEnum.Kale)
                    {
                        
                        return true;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            #endregion
            #region Yukari Sag Capraz Kontrol
            i = KoordinatX;
            j = KoordinatY;
            while (true)
            {
                i--;
                j++;
                if (i < 0 | j > 7)
                {
                    break;
                }
                if (MasaKareleri[i, j].renk == renk)
                {
                    break;
                }
                else if (MasaKareleri[i, j].renk == RakipRenk)
                {
                    if (MasaKareleri[i, j].tur == TurEnum.Vezir | MasaKareleri[i, j].tur == TurEnum.Fil )
                    {
                       
                        return true;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            #endregion
            #region Asagi Sag Capraz Kontrol
            i = KoordinatX;
            j = KoordinatY;
            while (true)
            {
                i++;
                j++;
                if (i > 7 | j > 7)
                {
                    break;
                }
                if (MasaKareleri[i, j].renk == renk)
                {
                    break;
                }
                else if (MasaKareleri[i, j].renk == RakipRenk)
                {
                    if (MasaKareleri[i, j].tur == TurEnum.Vezir | MasaKareleri[i, j].tur == TurEnum.Fil )
                    {
                       
                        return true;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            #endregion
            #region Asagi sol Capraz Kontrol
            i = KoordinatX;
            j = KoordinatY;
            while (true)
            {
                i++;
                j--;
                if (i > 7 | j < 0)
                {
                    break;
                }
                if (MasaKareleri[i, j].renk == renk)
                {
                    break;
                }
                else if (MasaKareleri[i, j].renk == RakipRenk)
                {
                    if (MasaKareleri[i, j].tur == TurEnum.Vezir | MasaKareleri[i, j].tur == TurEnum.Fil )
                    {
                       
                        return true;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            #endregion
            #region Yukari sol Capraz Kontrol
            i = KoordinatX;
            j = KoordinatY;
            while (true)
            {
                i--;
                j--;
                if (i < 0 | j < 0)
                {
                    break;
                }
                if (MasaKareleri[i, j].renk == renk)
                {
                    break;
                }
                else if (MasaKareleri[i, j].renk == RakipRenk)
                {
                    if (MasaKareleri[i, j].tur == TurEnum.Vezir | MasaKareleri[i, j].tur == TurEnum.Fil)
                    {
                        
                        return true;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            #endregion
            #region AT Kontrol
            if (KoordinatX > 1 & KoordinatY > 0)
            {
                if (MasaKareleri[KoordinatX - 2, KoordinatY - 1].tur == TurEnum.At & MasaKareleri[KoordinatX - 2, KoordinatY - 1].renk == RakipRenk)
                {
                    
                    return true;
                }
            }
            if (KoordinatX > 0 & KoordinatY > 1)
            {
                if (MasaKareleri[KoordinatX - 1, KoordinatY - 2].tur == TurEnum.At & MasaKareleri[KoordinatX - 1, KoordinatY - 2].renk == RakipRenk)
                {
                    
                    return true;
                }
            }
            if (KoordinatX < 7 & KoordinatY > 1)
            {
                if (MasaKareleri[KoordinatX + 1, KoordinatY - 2].tur == TurEnum.At & MasaKareleri[KoordinatX + 1, KoordinatY - 2].renk == RakipRenk)
                {
                    
                    return true;
                }
            }
            if (KoordinatX < 6 & KoordinatY > 0)
            {
                if (MasaKareleri[KoordinatX + 2, KoordinatY - 1].tur == TurEnum.At & MasaKareleri[KoordinatX + 2, KoordinatY - 1].renk == RakipRenk)
                {
                   
                    return true;
                }
            }
            if (KoordinatX > 1 & KoordinatY < 7)
            {
                if (MasaKareleri[KoordinatX - 2, KoordinatY + 1].tur == TurEnum.At & MasaKareleri[KoordinatX - 2, KoordinatY + 1].renk == RakipRenk)
                {
                   
                    return true;
                }
            }
            if (KoordinatX > 0 & KoordinatY < 6)
            {
                if (MasaKareleri[KoordinatX - 1, KoordinatY + 2].tur == TurEnum.At & MasaKareleri[KoordinatX - 1, KoordinatY + 2].renk == RakipRenk)
                {
                   
                    return true;
                }
            }
            if (KoordinatX < 7 & KoordinatY < 6)
            {
                if (MasaKareleri[KoordinatX + 1, KoordinatY + 2].tur == TurEnum.At & MasaKareleri[KoordinatX + 1, KoordinatY + 2].renk == RakipRenk)
                {
                   
                    return true;
                }
            }
            if (KoordinatX < 6 & KoordinatY < 7)
            {
                if (MasaKareleri[KoordinatX + 2, KoordinatY + 1].tur == TurEnum.At & MasaKareleri[KoordinatX + 2, KoordinatY + 1].renk == RakipRenk)
                {
                   
                    return true;
                }
            }


            #endregion
           
            return false;
        }
        private bool BuTasTehlikedemiSahPiyonHaric(int KoordinatX, int KoordinatY, RenkEnum renk)
        {
            int i, j;

            #region Rakip rengini belirle
            RenkEnum RakipRenk;
            if (renk == RenkEnum.Beyaz)
            {
                RakipRenk = RenkEnum.Siyah;
            }
            else
            {
                RakipRenk = RenkEnum.Beyaz;
            }
            #endregion
            #region Piyon Kontrol
            if (renk == RenkEnum.Beyaz)
            {
                if (KoordinatX < 7)
                {

                    if (MasaKareleri[KoordinatX + 1, KoordinatY].tur == TurEnum.Piyon & MasaKareleri[KoordinatX + 1, KoordinatY].renk == RakipRenk)
                    {

                        return true;
                    }


                }
            }
            else
            {
                if (KoordinatX > 0)
                {

                    if (MasaKareleri[KoordinatX - 1, KoordinatY].tur == TurEnum.Piyon & MasaKareleri[KoordinatX - 1, KoordinatY].renk == RakipRenk)
                    {

                        return true;
                    }


                }
            }
            #endregion
            #region Sol Yatay Kontrol
            for (i = KoordinatY - 1; i >= 0; i--)
            {
                if (MasaKareleri[KoordinatX, i].renk == renk)
                {
                    break;
                }
                else if (MasaKareleri[KoordinatX, i].renk == RakipRenk)
                {
                    if (MasaKareleri[KoordinatX, i].tur == TurEnum.Vezir | MasaKareleri[KoordinatX, i].tur == TurEnum.Kale)
                    {
                        
                        return true;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            #endregion
            #region sag Yatay Kontrol
            for (i = KoordinatY + 1; i < 8; i++)
            {
                if (MasaKareleri[KoordinatX, i].renk == renk)
                {
                    break;
                }
                else if (MasaKareleri[KoordinatX, i].renk == RakipRenk)
                {
                    if (MasaKareleri[KoordinatX, i].tur == TurEnum.Vezir | MasaKareleri[KoordinatX, i].tur == TurEnum.Kale)
                    {
                        
                        return true;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            #endregion
            #region Yukarı Dik Kontrol
            for (i = KoordinatX - 1; i >= 0; i--)
            {
                if (MasaKareleri[i, KoordinatY].renk == renk)
                {
                    break;
                }
                else if (MasaKareleri[i, KoordinatY].renk == RakipRenk)
                {
                    if (MasaKareleri[i, KoordinatY].tur == TurEnum.Vezir | MasaKareleri[i, KoordinatY].tur == TurEnum.Kale)
                    {
                      
                        return true;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            #endregion
            #region Asagi Dik Kontrol
            i = KoordinatX;
            j = KoordinatY;
            for (i = KoordinatX + 1; i < 8; i++)
            {
                if (MasaKareleri[i, j].renk == renk)
                {
                    break;
                }
                else if (MasaKareleri[i, j].renk == RakipRenk)
                {
                    if (MasaKareleri[i, KoordinatY].tur == TurEnum.Vezir | MasaKareleri[i, KoordinatY].tur == TurEnum.Kale)
                    {
                       
                        return true;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            #endregion
            #region Yukari Sag Capraz Kontrol
            i = KoordinatX;
            j = KoordinatY;
            while (true)
            {
                i--;
                j++;
                if (i < 0 | j > 7)
                {
                    break;
                }
                if (MasaKareleri[i, j].renk == renk)
                {
                    break;
                }
                else if (MasaKareleri[i, j].renk == RakipRenk)
                {
                    if (MasaKareleri[i, j].tur == TurEnum.Vezir | MasaKareleri[i, j].tur == TurEnum.Fil)
                    {
                        
                        return true;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            #endregion
            #region Asagi Sag Capraz Kontrol
            i = KoordinatX;
            j = KoordinatY;
            while (true)
            {
                i++;
                j++;
                if (i > 7 | j > 7)
                {
                    break;
                }
                if (MasaKareleri[i, j].renk == renk)
                {
                    break;
                }
                else if (MasaKareleri[i, j].renk == RakipRenk)
                {
                    if (MasaKareleri[i, j].tur == TurEnum.Vezir | MasaKareleri[i, j].tur == TurEnum.Fil)
                    {
                        
                        return true;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            #endregion
            #region Asagi sol Capraz Kontrol
            i = KoordinatX;
            j = KoordinatY;
            while (true)
            {
                i++;
                j--;
                if (i > 7 | j < 0)
                {
                    break;
                }
                if (MasaKareleri[i, j].renk == renk)
                {
                    break;
                }
                else if (MasaKareleri[i, j].renk == RakipRenk)
                {
                    if (MasaKareleri[i, j].tur == TurEnum.Vezir | MasaKareleri[i, j].tur == TurEnum.Fil)
                    {
                        
                        return true;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            #endregion
            #region Yukari sol Capraz Kontrol
            i = KoordinatX;
            j = KoordinatY;
            while (true)
            {
                i--;
                j--;
                if (i < 0 | j < 0)
                {
                    break;
                }
                if (MasaKareleri[i, j].renk == renk)
                {
                    break;
                }
                else if (MasaKareleri[i, j].renk == RakipRenk)
                {
                    if (MasaKareleri[i, j].tur == TurEnum.Vezir | MasaKareleri[i, j].tur == TurEnum.Fil)
                    {
                       
                        return true;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            #endregion
            #region AT Kontrol
            if (KoordinatX > 1 & KoordinatY > 0)
            {
                if (MasaKareleri[KoordinatX - 2, KoordinatY - 1].tur == TurEnum.At & MasaKareleri[KoordinatX - 2, KoordinatY - 1].renk == RakipRenk)
                {
                    
                    return true;
                }
            }
            if (KoordinatX > 0 & KoordinatY > 1)
            {
                if (MasaKareleri[KoordinatX - 1, KoordinatY - 2].tur == TurEnum.At & MasaKareleri[KoordinatX - 1, KoordinatY - 2].renk == RakipRenk)
                {
                    
                    return true;
                }
            }
            if (KoordinatX < 7 & KoordinatY > 1)
            {
                if (MasaKareleri[KoordinatX + 1, KoordinatY - 2].tur == TurEnum.At & MasaKareleri[KoordinatX + 1, KoordinatY - 2].renk == RakipRenk)
                {
                   
                    return true;
                }
            }
            if (KoordinatX < 6 & KoordinatY > 0)
            {
                if (MasaKareleri[KoordinatX + 2, KoordinatY - 1].tur == TurEnum.At & MasaKareleri[KoordinatX + 2, KoordinatY - 1].renk == RakipRenk)
                {
                    

                    return true;
                }
            }
            if (KoordinatX > 1 & KoordinatY < 7)
            {
                if (MasaKareleri[KoordinatX - 2, KoordinatY + 1].tur == TurEnum.At & MasaKareleri[KoordinatX - 2, KoordinatY + 1].renk == RakipRenk)
                {
                    
                    return true;
                }
            }
            if (KoordinatX > 0 & KoordinatY < 6)
            {
                if (MasaKareleri[KoordinatX - 1, KoordinatY + 2].tur == TurEnum.At & MasaKareleri[KoordinatX - 1, KoordinatY + 2].renk == RakipRenk)
                {
                    
                    return true;
                }
            }
            if (KoordinatX < 7 & KoordinatY < 6)
            {
                if (MasaKareleri[KoordinatX + 1, KoordinatY + 2].tur == TurEnum.At & MasaKareleri[KoordinatX + 1, KoordinatY + 2].renk == RakipRenk)
                {
                    
                    return true;
                }
            }
            if (KoordinatX < 6 & KoordinatY < 7)
            {
                if (MasaKareleri[KoordinatX + 2, KoordinatY + 1].tur == TurEnum.At & MasaKareleri[KoordinatX + 2, KoordinatY + 1].renk == RakipRenk)
                {
                    
                    return true;
                }
            }


            #endregion
           
            return false;
        }
        private bool SahTeklikedemi(RenkEnum renk){

            #region Renk Kontrol Et
            if (renk == RenkEnum.Bos)
            {
                Exception BosHatasi = new Exception("Bos Cinsinin Sah'ı olamaz");
                throw BosHatasi;
            }
            #endregion
            #region Sah ın Yerini Belirle

            int KoordinatX=0, KoordinatY=0,i,j;
            bool AllowBreak = false;
            for(i =0;i<8;i++){
                for(j=0;j<8;j++){
                    if(MasaKareleri[i,j].renk==renk){
                        if(MasaKareleri[i,j].tur==TurEnum.Sah){
                            KoordinatX = i;
                            KoordinatY = j;
                            AllowBreak = true;
                            break;
                        }
                    }
                }
                if (AllowBreak)
                {
                    break;
                }
            }
            #endregion
            return BuTasTehlikedemi(KoordinatX, KoordinatY,renk); 
                
            
        }
        private int BuTasiKacKisiTehditEdiyor(int KoordinatX, int KoordinatY, RenkEnum renk)
        {
            int i, j;
            int sonuc = 0;
            #region Rakip rengini belirle
            RenkEnum RakipRenk;
            if (renk == RenkEnum.Beyaz)
            {
                RakipRenk = RenkEnum.Siyah;
            }
            else
            {
                RakipRenk = RenkEnum.Beyaz;
            }
            #endregion
            #region Piyon Kontrol
            if (renk == RenkEnum.Beyaz)
            {
                if (KoordinatX < 7)
                {
                    if (KoordinatY == 0)
                    {
                        if (MasaKareleri[KoordinatX + 1, KoordinatY + 1].tur == TurEnum.Piyon & MasaKareleri[KoordinatX + 1, KoordinatY + 1].renk == RakipRenk)
                        {

                            sonuc++;
                        }
                    }
                    else if (KoordinatY == 7)
                    {
                        if (MasaKareleri[KoordinatX + 1, KoordinatY - 1].tur == TurEnum.Piyon & MasaKareleri[KoordinatX + 1, KoordinatY - 1].renk == RakipRenk)
                        {

                            sonuc++;
                        }
                    }
                    else
                    {
                        if (MasaKareleri[KoordinatX + 1, KoordinatY - 1].tur == TurEnum.Piyon & MasaKareleri[KoordinatX + 1, KoordinatY - 1].renk == RakipRenk)
                        {

                            sonuc++;
                        }
                        if (MasaKareleri[KoordinatX + 1, KoordinatY + 1].tur == TurEnum.Piyon & MasaKareleri[KoordinatX + 1, KoordinatY + 1].renk == RakipRenk)
                        {

                            sonuc++;
                        }
                    }
                }
            }
            else
            {
                if (KoordinatX > 0)
                {
                    if (KoordinatY == 0)
                    {
                        if (MasaKareleri[KoordinatX - 1, KoordinatY + 1].tur == TurEnum.Piyon & MasaKareleri[KoordinatX - 1, KoordinatY + 1].renk == RakipRenk)
                        {

                            sonuc++;
                        }
                    }
                    else if (KoordinatY == 7)
                    {
                        if (MasaKareleri[KoordinatX - 1, KoordinatY - 1].tur == TurEnum.Piyon & MasaKareleri[KoordinatX - 1, KoordinatY - 1].renk == RakipRenk)
                        {

                            sonuc++;
                        }
                    }
                    else
                    {
                        if (MasaKareleri[KoordinatX - 1, KoordinatY - 1].tur == TurEnum.Piyon & MasaKareleri[KoordinatX - 1, KoordinatY - 1].renk == RakipRenk)
                        {

                            sonuc++;
                        }
                        if (MasaKareleri[KoordinatX - 1, KoordinatY + 1].tur == TurEnum.Piyon & MasaKareleri[KoordinatX - 1, KoordinatY + 1].renk == RakipRenk)
                        {

                            sonuc++;
                        }
                    }
                }
            }
            #endregion
            #region Sol Yatay Kontrol
            for (i = KoordinatY - 1; i >= 0; i--)
            {
                if (MasaKareleri[KoordinatX, i].renk == renk)
                {
                    break;
                }
                else if (MasaKareleri[KoordinatX, i].renk == RakipRenk)
                {
                    if (MasaKareleri[KoordinatX, i].tur == TurEnum.Vezir | MasaKareleri[KoordinatX, i].tur == TurEnum.Kale)
                    {

                        sonuc++;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            #endregion
            #region sag Yatay Kontrol
            for (i = KoordinatY + 1; i < 8; i++)
            {
                if (MasaKareleri[KoordinatX, i].renk == renk)
                {
                    break;
                }
                else if (MasaKareleri[KoordinatX, i].renk == RakipRenk)
                {
                    if (MasaKareleri[KoordinatX, i].tur == TurEnum.Vezir | MasaKareleri[KoordinatX, i].tur == TurEnum.Kale)
                    {

                        sonuc++;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            #endregion
            #region Yukarı Dik Kontrol
            for (i = KoordinatX - 1; i >= 0; i--)
            {
                if (MasaKareleri[i, KoordinatY].renk == renk)
                {
                    break;
                }
                else if (MasaKareleri[i, KoordinatY].renk == RakipRenk)
                {
                    if (MasaKareleri[i, KoordinatY].tur == TurEnum.Vezir | MasaKareleri[i, KoordinatY].tur == TurEnum.Kale )
                    {

                        sonuc++;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            #endregion
            #region Asagi Dik Kontrol
            i = KoordinatX;
            j = KoordinatY;
            for (i = KoordinatX + 1; i < 8; i++)
            {
                if (MasaKareleri[i, j].renk == renk)
                {
                    break;
                }
                else if (MasaKareleri[i, j].renk == RakipRenk)
                {
                    if (MasaKareleri[i, KoordinatY].tur == TurEnum.Vezir | MasaKareleri[i, KoordinatY].tur == TurEnum.Kale )
                    {

                        sonuc++;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            #endregion
            #region Yukari Sag Capraz Kontrol
            i = KoordinatX;
            j = KoordinatY;
            while (true)
            {
                i--;
                j++;
                if (i < 0 | j > 7)
                {
                    break;
                }
                if (MasaKareleri[i, j].renk == renk)
                {
                    break;
                }
                else if (MasaKareleri[i, j].renk == RakipRenk)
                {
                    if (MasaKareleri[i, j].tur == TurEnum.Vezir | MasaKareleri[i, j].tur == TurEnum.Fil)
                    {

                        sonuc++;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            #endregion
            #region Asagi Sag Capraz Kontrol
            i = KoordinatX;
            j = KoordinatY;
            while (true)
            {
                i++;
                j++;
                if (i > 7 | j > 7)
                {
                    break;
                }
                if (MasaKareleri[i, j].renk == renk)
                {
                    break;
                }
                else if (MasaKareleri[i, j].renk == RakipRenk)
                {
                    if (MasaKareleri[i, j].tur == TurEnum.Vezir | MasaKareleri[i, j].tur == TurEnum.Fil )
                    {

                        sonuc++;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            #endregion
            #region Asagi sol Capraz Kontrol
            i = KoordinatX;
            j = KoordinatY;
            while (true)
            {
                i++;
                j--;
                if (i > 7 | j < 0)
                {
                    break;
                }
                if (MasaKareleri[i, j].renk == renk)
                {
                    break;
                }
                else if (MasaKareleri[i, j].renk == RakipRenk)
                {
                    if (MasaKareleri[i, j].tur == TurEnum.Vezir | MasaKareleri[i, j].tur == TurEnum.Fil )
                    {

                        sonuc++;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            #endregion
            #region Yukari sol Capraz Kontrol
            i = KoordinatX;
            j = KoordinatY;
            while (true)
            {
                i--;
                j--;
                if (i < 0 | j < 0)
                {
                    break;
                }
                if (MasaKareleri[i, j].renk == renk)
                {
                    break;
                }
                else if (MasaKareleri[i, j].renk == RakipRenk)
                {
                    if (MasaKareleri[i, j].tur == TurEnum.Vezir | MasaKareleri[i, j].tur == TurEnum.Fil )
                    {

                        sonuc++;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            #endregion
            #region AT Kontrol
            if (KoordinatX > 1 & KoordinatY > 0)
            {
                if (MasaKareleri[KoordinatX - 2, KoordinatY - 1].tur == TurEnum.At & MasaKareleri[KoordinatX - 2, KoordinatY - 1].renk == RakipRenk)
                {

                    sonuc++;
                }
            }
            if (KoordinatX > 0 & KoordinatY > 1)
            {
                if (MasaKareleri[KoordinatX - 1, KoordinatY - 2].tur == TurEnum.At & MasaKareleri[KoordinatX - 1, KoordinatY - 2].renk == RakipRenk)
                {

                    sonuc++;
                }
            }
            if (KoordinatX < 7 & KoordinatY > 1)
            {
                if (MasaKareleri[KoordinatX + 1, KoordinatY - 2].tur == TurEnum.At & MasaKareleri[KoordinatX + 1, KoordinatY - 2].renk == RakipRenk)
                {

                    sonuc++;
                }
            }
            if (KoordinatX < 6 & KoordinatY > 0)
            {
                if (MasaKareleri[KoordinatX + 2, KoordinatY - 1].tur == TurEnum.At & MasaKareleri[KoordinatX + 2, KoordinatY - 1].renk == RakipRenk)
                {

                    sonuc++;
                }
            }
            if (KoordinatX > 1 & KoordinatY < 7)
            {
                if (MasaKareleri[KoordinatX - 2, KoordinatY + 1].tur == TurEnum.At & MasaKareleri[KoordinatX - 2, KoordinatY + 1].renk == RakipRenk)
                {

                    sonuc++;
                }
            }
            if (KoordinatX > 0 & KoordinatY < 6)
            {
                if (MasaKareleri[KoordinatX - 1, KoordinatY + 2].tur == TurEnum.At & MasaKareleri[KoordinatX - 1, KoordinatY + 2].renk == RakipRenk)
                {

                    sonuc++;
                }
            }
            if (KoordinatX < 7 & KoordinatY < 6)
            {
                if (MasaKareleri[KoordinatX + 1, KoordinatY + 2].tur == TurEnum.At & MasaKareleri[KoordinatX + 1, KoordinatY + 2].renk == RakipRenk)
                {

                    sonuc++;
                }
            }
            if (KoordinatX < 6 & KoordinatY < 7)
            {
                if (MasaKareleri[KoordinatX + 2, KoordinatY + 1].tur == TurEnum.At & MasaKareleri[KoordinatX + 2, KoordinatY + 1].renk == RakipRenk)
                {

                    sonuc++;
                }
            }


            #endregion

            return sonuc;
        }
        private SatrancTasi TehditKim(int KoordinatX, int KoordinatY, RenkEnum renk)
        {
            int i, j;
            SatrancTasi Tehdit = new SatrancTasi();
            #region Rakip rengini belirle
            RenkEnum RakipRenk;
            if (renk == RenkEnum.Beyaz)
            {
                RakipRenk = RenkEnum.Siyah;
            }
            else
            {
                RakipRenk = RenkEnum.Beyaz;
            }
            #endregion
            #region Piyon Kontrol
            if (renk == RenkEnum.Beyaz)
            {
                if (KoordinatX < 7)
                {
                    if (KoordinatY == 0)
                    {
                        if (MasaKareleri[KoordinatX + 1, KoordinatY + 1].tur == TurEnum.Piyon & MasaKareleri[KoordinatX + 1, KoordinatY + 1].renk == RakipRenk)
                        {

                            Tehdit.KoordinatX = KoordinatX + 1;
                            Tehdit.KoordinatY = KoordinatY + 1;
                            return Tehdit;
                        }
                    }
                    else if (KoordinatY == 7)
                    {
                        if (MasaKareleri[KoordinatX + 1, KoordinatY - 1].tur == TurEnum.Piyon & MasaKareleri[KoordinatX + 1, KoordinatY - 1].renk == RakipRenk)
                        {

                            Tehdit.KoordinatX = KoordinatX + 1;
                            Tehdit.KoordinatY = KoordinatY - 1;
                            return Tehdit;
                        }
                    }
                    else
                    {
                        if (MasaKareleri[KoordinatX + 1, KoordinatY - 1].tur == TurEnum.Piyon & MasaKareleri[KoordinatX + 1, KoordinatY - 1].renk == RakipRenk)
                        {

                            Tehdit.KoordinatX = KoordinatX + 1;
                            Tehdit.KoordinatY = KoordinatY - 1;
                            return Tehdit;
                        }
                        if (MasaKareleri[KoordinatX + 1, KoordinatY + 1].tur == TurEnum.Piyon & MasaKareleri[KoordinatX + 1, KoordinatY + 1].renk == RakipRenk)
                        {

                            Tehdit.KoordinatX = KoordinatX + 1;
                            Tehdit.KoordinatY = KoordinatY + 1;
                            return Tehdit;
                        }
                    }
                }
            }
            else
            {
                if (KoordinatX > 0)
                {
                    if (KoordinatY == 0)
                    {
                        if (MasaKareleri[KoordinatX - 1, KoordinatY + 1].tur == TurEnum.Piyon & MasaKareleri[KoordinatX - 1, KoordinatY + 1].renk == RakipRenk)
                        {

                            Tehdit.KoordinatX = KoordinatX - 1;
                            Tehdit.KoordinatY = KoordinatY + 1;
                            return Tehdit;
                        }
                    }
                    else if (KoordinatY == 7)
                    {
                        if (MasaKareleri[KoordinatX - 1, KoordinatY - 1].tur == TurEnum.Piyon & MasaKareleri[KoordinatX - 1, KoordinatY - 1].renk == RakipRenk)
                        {

                            Tehdit.KoordinatX = KoordinatX - 1;
                            Tehdit.KoordinatY = KoordinatY - 1;
                            return Tehdit;
                        }
                    }
                    else
                    {
                        if (MasaKareleri[KoordinatX - 1, KoordinatY - 1].tur == TurEnum.Piyon & MasaKareleri[KoordinatX - 1, KoordinatY - 1].renk == RakipRenk)
                        {

                            Tehdit.KoordinatX = KoordinatX - 1;
                            Tehdit.KoordinatY = KoordinatY - 1;
                            return Tehdit;
                        }
                        if (MasaKareleri[KoordinatX - 1, KoordinatY + 1].tur == TurEnum.Piyon & MasaKareleri[KoordinatX - 1, KoordinatY + 1].renk == RakipRenk)
                        {

                            Tehdit.KoordinatX = KoordinatX - 1;
                            Tehdit.KoordinatY = KoordinatY + 1;
                            return Tehdit;
                        }
                    }
                }
            }
            #endregion
            #region Sol Yatay Kontrol
            for (i = KoordinatY - 1; i >= 0; i--)
            {
                if (MasaKareleri[KoordinatX, i].renk == renk)
                {
                    break;
                }
                else if (MasaKareleri[KoordinatX, i].renk == RakipRenk)
                {
                    if (MasaKareleri[KoordinatX, i].tur == TurEnum.Vezir | MasaKareleri[KoordinatX, i].tur == TurEnum.Kale | MasaKareleri[KoordinatX, i].tur == TurEnum.Sah)
                    {

                        Tehdit.KoordinatX = KoordinatX;
                        Tehdit.KoordinatY =i;
                        return Tehdit;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            #endregion
            #region sag Yatay Kontrol
            for (i = KoordinatY + 1; i < 8; i++)
            {
                if (MasaKareleri[KoordinatX, i].renk == renk)
                {
                    break;
                }
                else if (MasaKareleri[KoordinatX, i].renk == RakipRenk)
                {
                    if (MasaKareleri[KoordinatX, i].tur == TurEnum.Vezir | MasaKareleri[KoordinatX, i].tur == TurEnum.Kale | MasaKareleri[KoordinatX, i].tur == TurEnum.Sah)
                    {

                        Tehdit.KoordinatX = KoordinatX;
                        Tehdit.KoordinatY = i;
                        return Tehdit;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            #endregion
            #region Yukarı Dik Kontrol
            for (i = KoordinatX - 1; i >= 0; i--)
            {
                if (MasaKareleri[i, KoordinatY].renk == renk)
                {
                    break;
                }
                else if (MasaKareleri[i, KoordinatY].renk == RakipRenk)
                {
                    if (MasaKareleri[i, KoordinatY].tur == TurEnum.Vezir | MasaKareleri[i, KoordinatY].tur == TurEnum.Kale | MasaKareleri[i, KoordinatY].tur == TurEnum.Sah)
                    {

                        Tehdit.KoordinatX = i;
                        Tehdit.KoordinatY = KoordinatY ;
                        return Tehdit;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            #endregion
            #region Asagi Dik Kontrol
            i = KoordinatX;
            j = KoordinatY;
            for (i = KoordinatX + 1; i < 8; i++)
            {
                if (MasaKareleri[i, j].renk == renk)
                {
                    break;
                }
                else if (MasaKareleri[i, j].renk == RakipRenk)
                {
                    if (MasaKareleri[i, KoordinatY].tur == TurEnum.Vezir | MasaKareleri[i, KoordinatY].tur == TurEnum.Kale | MasaKareleri[i, KoordinatY].tur == TurEnum.Sah)
                    {

                        Tehdit.KoordinatX = i;
                        Tehdit.KoordinatY = KoordinatY;
                        return Tehdit;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            #endregion
            #region Yukari Sag Capraz Kontrol
            i = KoordinatX;
            j = KoordinatY;
            while (true)
            {
                i--;
                j++;
                if (i < 0 | j > 7)
                {
                    break;
                }
                if (MasaKareleri[i, j].renk == renk)
                {
                    break;
                }
                else if (MasaKareleri[i, j].renk == RakipRenk)
                {
                    if (MasaKareleri[i, j].tur == TurEnum.Vezir | MasaKareleri[i, j].tur == TurEnum.Fil | MasaKareleri[i, j].tur == TurEnum.Sah)
                    {

                        Tehdit.KoordinatX = i;
                        Tehdit.KoordinatY = j;
                        return Tehdit;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            #endregion
            #region Asagi Sag Capraz Kontrol
            i = KoordinatX;
            j = KoordinatY;
            while (true)
            {
                i++;
                j++;
                if (i > 7 | j > 7)
                {
                    break;
                }
                if (MasaKareleri[i, j].renk == renk)
                {
                    break;
                }
                else if (MasaKareleri[i, j].renk == RakipRenk)
                {
                    if (MasaKareleri[i, j].tur == TurEnum.Vezir | MasaKareleri[i, j].tur == TurEnum.Fil | MasaKareleri[i, j].tur == TurEnum.Sah)
                    {

                        Tehdit.KoordinatX = i;
                        Tehdit.KoordinatY = j;
                        return Tehdit;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            #endregion
            #region Asagi sol Capraz Kontrol
            i = KoordinatX;
            j = KoordinatY;
            while (true)
            {
                i++;
                j--;
                if (i > 7 | j < 0)
                {
                    break;
                }
                if (MasaKareleri[i, j].renk == renk)
                {
                    break;
                }
                else if (MasaKareleri[i, j].renk == RakipRenk)
                {
                    if (MasaKareleri[i, j].tur == TurEnum.Vezir | MasaKareleri[i, j].tur == TurEnum.Fil | MasaKareleri[i, j].tur == TurEnum.Sah)
                    {

                        Tehdit.KoordinatX = i;
                        Tehdit.KoordinatY = j;
                        return Tehdit;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            #endregion
            #region Yukari sol Capraz Kontrol
            i = KoordinatX;
            j = KoordinatY;
            while (true)
            {
                i--;
                j--;
                if (i < 0 | j < 0)
                {
                    break;
                }
                if (MasaKareleri[i, j].renk == renk)
                {
                    break;
                }
                else if (MasaKareleri[i, j].renk == RakipRenk)
                {
                    if (MasaKareleri[i, j].tur == TurEnum.Vezir | MasaKareleri[i, j].tur == TurEnum.Fil | MasaKareleri[i, j].tur == TurEnum.Sah)
                    {

                        Tehdit.KoordinatX = i;
                        Tehdit.KoordinatY = j;
                        return Tehdit;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            #endregion
            #region AT Kontrol
            if (KoordinatX > 1 & KoordinatY > 0)
            {
                if (MasaKareleri[KoordinatX - 2, KoordinatY - 1].tur == TurEnum.At & MasaKareleri[KoordinatX - 2, KoordinatY - 1].renk == RakipRenk)
                {

                    Tehdit.KoordinatX = KoordinatX - 2;
                    Tehdit.KoordinatY = KoordinatY - 1;
                    return Tehdit;
                }
            }
            if (KoordinatX > 0 & KoordinatY > 1)
            {
                if (MasaKareleri[KoordinatX - 1, KoordinatY - 2].tur == TurEnum.At & MasaKareleri[KoordinatX - 1, KoordinatY - 2].renk == RakipRenk)
                {

                    Tehdit.KoordinatX = KoordinatX - 1;
                    Tehdit.KoordinatY = KoordinatY - 2;
                    return Tehdit;
                }
            }
            if (KoordinatX < 7 & KoordinatY > 1)
            {
                if (MasaKareleri[KoordinatX + 1, KoordinatY - 2].tur == TurEnum.At & MasaKareleri[KoordinatX + 1, KoordinatY - 2].renk == RakipRenk)
                {

                    Tehdit.KoordinatX = KoordinatX + 1;
                    Tehdit.KoordinatY = KoordinatY - 2;
                    return Tehdit;
                }
            }
            if (KoordinatX < 6 & KoordinatY > 0)
            {
                if (MasaKareleri[KoordinatX + 2, KoordinatY - 1].tur == TurEnum.At & MasaKareleri[KoordinatX + 2, KoordinatY - 1].renk == RakipRenk)
                {

                    Tehdit.KoordinatX = KoordinatX + 2;
                    Tehdit.KoordinatY = KoordinatY - 1;
                    return Tehdit;
                }
            }
            if (KoordinatX > 1 & KoordinatY < 7)
            {
                if (MasaKareleri[KoordinatX - 2, KoordinatY + 1].tur == TurEnum.At & MasaKareleri[KoordinatX - 2, KoordinatY + 1].renk == RakipRenk)
                {

                    Tehdit.KoordinatX = KoordinatX -2;
                    Tehdit.KoordinatY = KoordinatY + 1;
                    return Tehdit;
                }
            }
            if (KoordinatX > 0 & KoordinatY < 6)
            {
                if (MasaKareleri[KoordinatX - 1, KoordinatY + 2].tur == TurEnum.At & MasaKareleri[KoordinatX - 1, KoordinatY + 2].renk == RakipRenk)
                {

                    Tehdit.KoordinatX = KoordinatX - 1;
                    Tehdit.KoordinatY = KoordinatY + 2;
                    return Tehdit;
                }
            }
            if (KoordinatX < 7 & KoordinatY < 6)
            {
                if (MasaKareleri[KoordinatX + 1, KoordinatY + 2].tur == TurEnum.At & MasaKareleri[KoordinatX + 1, KoordinatY + 2].renk == RakipRenk)
                {

                    Tehdit.KoordinatX = KoordinatX + 1;
                    Tehdit.KoordinatY = KoordinatY + 2;
                    return Tehdit;
                }
            }
            if (KoordinatX < 6 & KoordinatY < 7)
            {
                if (MasaKareleri[KoordinatX + 2, KoordinatY + 1].tur == TurEnum.At & MasaKareleri[KoordinatX + 2, KoordinatY + 1].renk == RakipRenk)
                {

                    Tehdit.KoordinatX = KoordinatX + 2;
                    Tehdit.KoordinatY = KoordinatY + 1;
                    return Tehdit;
                }
            }


            #endregion

            return Tehdit;
        }
        private bool BeyazKucukRokTehlikedemi{
            get {
                if (SagBeyazKaleOynadimi | BeyazSahOynadimi)
                    return true;
                if (MasaKareleri[0, 6].renk == RenkEnum.Bos & MasaKareleri[0, 5].renk == RenkEnum.Bos)
                    return (BuTasTehlikedemi(0, 7,RenkEnum.Beyaz) | BuTasTehlikedemi(0, 6,RenkEnum.Beyaz) | BuTasTehlikedemi(0, 5,RenkEnum.Beyaz) | BuTasTehlikedemi(0, 4,RenkEnum.Beyaz));
                else
                    return true;
            }
        }
        private bool BeyazBuyukRokTehlikedemi
        {
            
                get {
                    if (SolBeyazKaleOynadimi | BeyazSahOynadimi)
                        return true;
                    if (MasaKareleri[0, 1].renk == RenkEnum.Bos & MasaKareleri[0, 2].renk == RenkEnum.Bos & MasaKareleri[0, 3].renk == RenkEnum.Bos)
                        return (BuTasTehlikedemi(0, 0, RenkEnum.Beyaz) | BuTasTehlikedemi(0, 1, RenkEnum.Beyaz) | BuTasTehlikedemi(0, 2, RenkEnum.Beyaz) | BuTasTehlikedemi(0, 3, RenkEnum.Beyaz) | BuTasTehlikedemi(0, 4, RenkEnum.Beyaz));
                    else
                        return true;                
                }
            
        }
        private bool SiyahKucukRokTehlikedemi
        {
            get {
                if (SagSiyahKaleOynadimi | SiyahSahOynadimi)
                    return true;
                if (MasaKareleri[7, 5].renk == RenkEnum.Bos & MasaKareleri[7, 6].renk == RenkEnum.Bos)
                    return (BuTasTehlikedemi(7, 7, RenkEnum.Siyah) | BuTasTehlikedemi(7, 6, RenkEnum.Siyah) | BuTasTehlikedemi(7, 5, RenkEnum.Siyah) | BuTasTehlikedemi(7, 4, RenkEnum.Siyah));
                else
                    return true;
            }
        }
        private bool SiyahBuyukRokTehlikedemi
        {
            get {
                if (SiyahSahOynadimi | SolBeyazKaleOynadimi)
                    return true;
                if (MasaKareleri[7, 1].renk == RenkEnum.Bos & MasaKareleri[7, 3].renk == RenkEnum.Bos & MasaKareleri[7, 2].renk == RenkEnum.Bos)
                    return (BuTasTehlikedemi(7, 0, RenkEnum.Siyah) | BuTasTehlikedemi(7, 1, RenkEnum.Siyah) | BuTasTehlikedemi(7, 2, RenkEnum.Siyah) | BuTasTehlikedemi(7, 3, RenkEnum.Siyah) | BuTasTehlikedemi(7, 4, RenkEnum.Siyah));
                else
                    return true;
            }
        }
        protected bool SagBeyazKaleOynadimi = false, SolBeyazKaleOynadimi = false, BeyazSahOynadimi = false, SagSiyahKaleOynadimi = false, SolSiyahKaleOynadimi = false, SiyahSahOynadimi = false;
        protected int MutlakDeger(int x){
            if(x<0){
                return -x;
            }else{
                return x;
            }
        }
        private void GeriAl(int TasinYeriX, int TasinYeriY, int GidecegiYerX, int GidecegiYerY)
        {


            MasaKareleri[TasinYeriX, TasinYeriY].renk = BiOncekiX.renk; 
            MasaKareleri[TasinYeriX, TasinYeriY].tur=BiOncekiX.tur ;
            MasaKareleri[GidecegiYerX, GidecegiYerY].renk=BiOncekiY.renk;
            MasaKareleri[GidecegiYerX, GidecegiYerY].tur=BiOncekiY.tur;
            try{
                MasaKareleri[YiyerekGecilen.KoordinatX, YiyerekGecilen.KoordinatY].renk = YiyerekGecilen.renk;
                MasaKareleri[YiyerekGecilen.KoordinatX, YiyerekGecilen.KoordinatY].tur = YiyerekGecilen.tur;
               
            }catch{

            }
        }
        private void AtOyna(int TasinYeriX, int TasinYeriY, int GidecegiYerX, int GidecegiYerY)
        {
            int XFark = MutlakDeger(TasinYeriX - GidecegiYerX);
            int YFark = MutlakDeger(TasinYeriY - GidecegiYerY);
           
            if(XFark==2&YFark==1|XFark==1&YFark==2){
                
                BiOncekiX.renk = MasaKareleri[TasinYeriX, TasinYeriY].renk;
                BiOncekiX.tur = MasaKareleri[TasinYeriX, TasinYeriY].tur;
                BiOncekiY.renk = MasaKareleri[GidecegiYerX, GidecegiYerY].renk;
                BiOncekiY.tur = MasaKareleri[GidecegiYerX, GidecegiYerY].tur;
                MasaKareleri[GidecegiYerX, GidecegiYerY].renk = MasaKareleri[TasinYeriX, TasinYeriY].renk;
                MasaKareleri[GidecegiYerX, GidecegiYerY].tur = MasaKareleri[TasinYeriX, TasinYeriY].tur;
                MasaKareleri[TasinYeriX, TasinYeriY].renk=RenkEnum.Bos;
                MasaKareleri[TasinYeriX, TasinYeriY].tur=TurEnum.Bos;
                return;            
            }
            Exception Oynayamaz = new Exception("At Oraya Oynamaz.");
            throw Oynayamaz;
        }
        private void FilOyna(int TasinYeriX, int TasinYeriY, int GidecegiYerX, int GidecegiYerY)
        {
            int XFark = MutlakDeger(TasinYeriX - GidecegiYerX);
            int YFark = MutlakDeger(TasinYeriY - GidecegiYerY);
            if (XFark != YFark)
            {
                Exception CaprazGider = new Exception("Fil Sadece Capraz Gider.");
                throw CaprazGider;
            }
            int j=TasinYeriY;
            for (int i = TasinYeriX; i != GidecegiYerX; )
            {
                if(TasinYeriX-GidecegiYerX<0){
                    i++;
                }else{
                    i--;
                }
                if (TasinYeriY - GidecegiYerY < 0)
                {
                    j++;
                }
                else
                {
                    j--;
                }
                if(i==GidecegiYerX){
                    break;
                }
                if(MasaKareleri[i,j].renk!=RenkEnum.Bos){
                    Exception AradaTasVar = new Exception("Fil ile gideceği yer arasında Taşlar var.");
                    throw AradaTasVar;
                }
            }
            
            BiOncekiX.renk = MasaKareleri[TasinYeriX, TasinYeriY].renk;
            BiOncekiX.tur = MasaKareleri[TasinYeriX, TasinYeriY].tur;
            BiOncekiY.renk = MasaKareleri[GidecegiYerX, GidecegiYerY].renk;
            BiOncekiY.tur = MasaKareleri[GidecegiYerX, GidecegiYerY].tur;
            MasaKareleri[GidecegiYerX, GidecegiYerY].renk = MasaKareleri[TasinYeriX, TasinYeriY].renk;
            MasaKareleri[GidecegiYerX, GidecegiYerY].tur = MasaKareleri[TasinYeriX, TasinYeriY].tur;
            MasaKareleri[TasinYeriX, TasinYeriY].renk = RenkEnum.Bos;
            MasaKareleri[TasinYeriX, TasinYeriY].tur = TurEnum.Bos;
        }
        private void KaleOyna(int TasinYeriX, int TasinYeriY, int GidecegiYerX, int GidecegiYerY)
        {
            if(GidecegiYerX==TasinYeriX|GidecegiYerY==TasinYeriY){
                int i = TasinYeriX;
                int j = TasinYeriY;
                while(true){
                    if(TasinYeriY==GidecegiYerY){
                        if (TasinYeriX - GidecegiYerX < 0)
                            i++;
                        else
                            i--;

                    }else{
                        if (TasinYeriY - GidecegiYerY < 0)
                            j++;
                        else
                            j--;
                    }
                    if (TasinYeriX == GidecegiYerX)
                    {
                        if (j == GidecegiYerY)
                            break;
                    }
                    else
                    {
                        if (i == GidecegiYerX)
                            break;
                    }
                    if(MasaKareleri[i,j].renk!=RenkEnum.Bos){
                        Exception KaleYatayGider = new Exception("Kale ile Hedef Arasinda Tas Var.");
                        throw KaleYatayGider;
                    }
                    
                }

            }else{
                Exception KaleYatayGider = new Exception("Kale Yatay Gider.");
                throw KaleYatayGider;
            }


           
            BiOncekiX.renk = MasaKareleri[TasinYeriX, TasinYeriY].renk;
            BiOncekiX.tur = MasaKareleri[TasinYeriX, TasinYeriY].tur;
            BiOncekiY.renk = MasaKareleri[GidecegiYerX, GidecegiYerY].renk;
            BiOncekiY.tur = MasaKareleri[GidecegiYerX, GidecegiYerY].tur;
            MasaKareleri[GidecegiYerX, GidecegiYerY].renk = MasaKareleri[TasinYeriX, TasinYeriY].renk;
            MasaKareleri[GidecegiYerX, GidecegiYerY].tur = MasaKareleri[TasinYeriX, TasinYeriY].tur;
            MasaKareleri[TasinYeriX, TasinYeriY].renk = RenkEnum.Bos;
            MasaKareleri[TasinYeriX, TasinYeriY].tur = TurEnum.Bos;
            
        }
        private void SahOyna(int TasinYeriX, int TasinYeriY, int GidecegiYerX, int GidecegiYerY)
        {
            if ((TasinYeriX == 0|TasinYeriX==7) & TasinYeriY == 4)
            {
                if (MasaKareleri[TasinYeriX, TasinYeriY].renk == RenkEnum.Beyaz)
                {
                    if (GidecegiYerX == 0)
                    {
                        if (GidecegiYerY == 2)
                        {
                            if(!BeyazBuyukRokTehlikedemi){
                                MasaKareleri[0, 0].TasKaybet();
                                MasaKareleri[0, 4].TasKaybet();
                                MasaKareleri[0, 2].renk = RenkEnum.Beyaz;
                                MasaKareleri[0, 2].tur = TurEnum.Sah;
                                MasaKareleri[0, 3].renk = RenkEnum.Beyaz;
                                MasaKareleri[0, 3].tur = TurEnum.Kale;
                                return;
                            }else{
                                Exception rok = new Exception("Buyuk Rok Yapılamaz.");
                                throw rok;
                            }
                        }
                        else if (GidecegiYerY == 6)
                        {
                            if (!BeyazKucukRokTehlikedemi)
                            {
                                MasaKareleri[0, 7].TasKaybet();
                                MasaKareleri[0, 4].TasKaybet();
                                MasaKareleri[0, 6].renk = RenkEnum.Beyaz;
                                MasaKareleri[0, 6].tur = TurEnum.Sah;
                                MasaKareleri[0, 5].renk = RenkEnum.Beyaz;
                                MasaKareleri[0, 5].tur = TurEnum.Kale;
                                return;
                            }else{
                                Exception rok = new Exception("Küçük Rok Yapılamaz.");
                                throw rok;
                            }

                        }
                    }
                }
                else
                {
                    if (GidecegiYerX == 7)
                    {
                        if (GidecegiYerY == 2)
                        {
                            if (!SiyahBuyukRokTehlikedemi)
                            {
                                MasaKareleri[7, 0].TasKaybet();
                                MasaKareleri[7, 4].TasKaybet();
                                MasaKareleri[7, 2].renk = RenkEnum.Siyah;
                                MasaKareleri[7, 2].tur = TurEnum.Sah;
                                MasaKareleri[7, 3].renk = RenkEnum.Siyah;
                                MasaKareleri[7, 3].tur = TurEnum.Kale;
                                return;
                            }
                            else
                            {
                                Exception rok = new Exception("Buyuk Rok Yapılamaz.");
                                throw rok;
                            }
                        }
                        else if (GidecegiYerY == 6)
                        {
                            if (!SiyahKucukRokTehlikedemi)
                            {
                                MasaKareleri[7, 7].TasKaybet();
                                MasaKareleri[7, 4].TasKaybet();
                                MasaKareleri[7, 6].renk = RenkEnum.Siyah;
                                MasaKareleri[7, 6].tur = TurEnum.Sah;
                                MasaKareleri[7, 5].renk = RenkEnum.Siyah;
                                MasaKareleri[7, 5].tur = TurEnum.Kale;
                                return;
                            }
                            else
                            {
                                Exception rok = new Exception("Küçük Rok Yapılamaz.");
                                throw rok;
                            }
                        }
                    }
                }
            }
            if(MutlakDeger(GidecegiYerX-TasinYeriX)>1|MutlakDeger(GidecegiYerY-TasinYeriY)>1){
                Exception SahOynamaz = new Exception("Sah Sadece 1 Kare ilerleyebilir.");
                throw SahOynamaz;
            }
                        
            
            BiOncekiX.renk = MasaKareleri[TasinYeriX, TasinYeriY].renk;
            BiOncekiX.tur = MasaKareleri[TasinYeriX, TasinYeriY].tur;
            BiOncekiY.renk = MasaKareleri[GidecegiYerX, GidecegiYerY].renk;
            BiOncekiY.tur = MasaKareleri[GidecegiYerX, GidecegiYerY].tur;
            MasaKareleri[GidecegiYerX, GidecegiYerY].renk = MasaKareleri[TasinYeriX, TasinYeriY].renk;
            MasaKareleri[GidecegiYerX, GidecegiYerY].tur = MasaKareleri[TasinYeriX, TasinYeriY].tur;
            MasaKareleri[TasinYeriX, TasinYeriY].renk = RenkEnum.Bos;
            MasaKareleri[TasinYeriX, TasinYeriY].tur = TurEnum.Bos;           
            
        }
        private void PiyonOyna(int TasinYeriX, int TasinYeriY, int GidecegiYerX, int GidecegiYerY,TurEnum YukselecekTas)
        {
          
            if(MasaKareleri[TasinYeriX,TasinYeriY].renk==RenkEnum.Beyaz){
                if (TasinYeriX == 1&GidecegiYerX==3)
                {
                    if(MasaKareleri[2,TasinYeriY].renk!=RenkEnum.Bos|MasaKareleri[3,TasinYeriY].renk!=RenkEnum.Bos){
                        Exception Piyongidemez = new Exception("Pİyonun Oynayacağı yerde taş var.");
                        throw Piyongidemez;
                    }
                    if (TasinYeriY != GidecegiYerY)
                    {
                        Exception Piyongidemez = new Exception("Piyon oraya gidemez.");
                        throw Piyongidemez;
                    }
                }
                else if (GidecegiYerX - TasinYeriX == 1)
                {
                    if (TasinYeriY == GidecegiYerY)
                    {
                        if(MasaKareleri[GidecegiYerX,GidecegiYerY].renk!=RenkEnum.Bos){
                            Exception PiyonOnundeTasVar = new Exception("Piyonun Önünde Taş Var");
                            throw PiyonOnundeTasVar;
                        }
                    }
                    else if (MutlakDeger(TasinYeriY - GidecegiYerY) == 1)
                    {
                        if (MasaKareleri[GidecegiYerX, GidecegiYerY].renk != RenkEnum.Siyah)
                        {
                            if (BiElOncekiHamle != ((GidecegiYerX + 1).ToString() + GidecegiYerY.ToString() + (GidecegiYerX - 1).ToString() + GidecegiYerY.ToString()))
                            {
                                Exception PiyonOnundeTasVar = new Exception("Olmayan Tasi Yiyemez");
                                throw PiyonOnundeTasVar;
                            }else{
                                YiyerekGecilen = new SatrancTasi();
                                YiyerekGecilen.renk = MasaKareleri[GidecegiYerX - 1, GidecegiYerY].renk;
                                YiyerekGecilen.tur = MasaKareleri[GidecegiYerX - 1, GidecegiYerY].tur;
                                YiyerekGecilen.KoordinatX = GidecegiYerX - 1;
                                YiyerekGecilen.KoordinatY = GidecegiYerY;
                                MasaKareleri[GidecegiYerX - 1, GidecegiYerY].TasKaybet();
                            }
                        }
                    }
                    else
                    {
                        Exception PiyonOnundeTasVar = new Exception("Piyon Oraya Oynayamaz");
                        throw PiyonOnundeTasVar;
                    }
                }else{
                    Exception PiyonOnundeTasVar = new Exception("Piyon ileri ilerler çapraz yer.");
                    throw PiyonOnundeTasVar;
                }

            }else{
                if (TasinYeriX == 6 & GidecegiYerX == 4)
                {
                    if (MasaKareleri[5, TasinYeriY].renk != RenkEnum.Bos | MasaKareleri[4, TasinYeriY].renk != RenkEnum.Bos)
                    {
                        Exception Piyongidemez = new Exception("Pİyonun Oynayacağı yerde taş var.");
                        throw Piyongidemez;
                    }
                    if (TasinYeriY != GidecegiYerY)
                    {
                        Exception Piyongidemez = new Exception("Piyon oraya gidemez.");
                        throw Piyongidemez;
                    }
                }else if (TasinYeriX-GidecegiYerX   == 1)
                {
                    if (TasinYeriY == GidecegiYerY)
                    {
                        if (MasaKareleri[GidecegiYerX, GidecegiYerY].renk != RenkEnum.Bos)
                        {
                            Exception PiyonOnundeTasVar = new Exception("Piyonun Önünde Taş Var");
                            throw PiyonOnundeTasVar;
                        }
                    }
                    else if (MutlakDeger(GidecegiYerY-TasinYeriY) == 1)
                    {
                        if (MasaKareleri[GidecegiYerX, GidecegiYerY].renk != RenkEnum.Beyaz)
                        {
                            if (BiElOncekiHamle != ((GidecegiYerX - 1).ToString() + GidecegiYerY.ToString() + (GidecegiYerX + 1).ToString() + GidecegiYerY.ToString()))
                            {
                                Exception PiyonOnundeTasVar = new Exception("Olmayan Tasi Yiyemez");
                                throw PiyonOnundeTasVar;
                            }else{
                                YiyerekGecilen = new SatrancTasi();
                                YiyerekGecilen.renk = MasaKareleri[GidecegiYerX + 1, GidecegiYerY].renk;
                                YiyerekGecilen.tur = MasaKareleri[GidecegiYerX + 1, GidecegiYerY].tur;
                                YiyerekGecilen.KoordinatX = GidecegiYerX + 1;
                                YiyerekGecilen.KoordinatY = GidecegiYerY;
                                MasaKareleri[GidecegiYerX + 1, GidecegiYerY].TasKaybet();
                            }
                        }
                    }
                    else
                    {
                        Exception PiyonOnundeTasVar = new Exception("Piyon Oraya Oynayamaz");
                        throw PiyonOnundeTasVar;
                    }
                }
                else
                {
                    Exception PiyonOnundeTasVar = new Exception("Piyon ileri ilerler çapraz yer.");
                    throw PiyonOnundeTasVar;
                }

            }
            
            BiOncekiX.renk = MasaKareleri[TasinYeriX, TasinYeriY].renk;
            BiOncekiX.tur = MasaKareleri[TasinYeriX, TasinYeriY].tur;
            BiOncekiY.renk = MasaKareleri[GidecegiYerX, GidecegiYerY].renk;
            BiOncekiY.tur = MasaKareleri[GidecegiYerX, GidecegiYerY].tur;
            MasaKareleri[GidecegiYerX, GidecegiYerY].renk = MasaKareleri[TasinYeriX, TasinYeriY].renk;
            MasaKareleri[GidecegiYerX, GidecegiYerY].tur = MasaKareleri[TasinYeriX, TasinYeriY].tur;
            MasaKareleri[TasinYeriX, TasinYeriY].renk = RenkEnum.Bos;
            MasaKareleri[TasinYeriX, TasinYeriY].tur = TurEnum.Bos;
            if(GidecegiYerX==0|GidecegiYerX==7){
                try
                {
                    MasaKareleri[GidecegiYerX, GidecegiYerY].PiyonYukselt(YukselecekTas);
                }catch(Exception hata){
                    throw hata;
                }
            }
        }
        private void PiyonOyna(int TasinYeriX, int TasinYeriY, int GidecegiYerX, int GidecegiYerY)
        {

            if (MasaKareleri[TasinYeriX, TasinYeriY].renk == RenkEnum.Beyaz)
            {
                if (TasinYeriX == 1 & GidecegiYerX == 3)
                {
                    if (MasaKareleri[2, TasinYeriY].renk != RenkEnum.Bos | MasaKareleri[3, TasinYeriY].renk != RenkEnum.Bos)
                    {
                        Exception Piyongidemez = new Exception("Pİyonun Oynayacağı yerde taş var.");
                        throw Piyongidemez;
                    }
                }
                else if (GidecegiYerX - TasinYeriX == 1)
                {
                    if (TasinYeriY == GidecegiYerY)
                    {
                        if (MasaKareleri[GidecegiYerX, GidecegiYerY].renk != RenkEnum.Bos)
                        {
                            Exception PiyonOnundeTasVar = new Exception("Piyonun Önünde Taş Var");
                            throw PiyonOnundeTasVar;
                        }
                    }
                    else if (MutlakDeger(TasinYeriY - GidecegiYerY) == 1)
                    {
                        if (MasaKareleri[GidecegiYerX, GidecegiYerY].renk != RenkEnum.Siyah)
                        {
                            if (BiElOncekiHamle != ((GidecegiYerX + 1).ToString() + GidecegiYerY.ToString() + (GidecegiYerX - 1).ToString() + GidecegiYerY.ToString()))
                            {
                                Exception PiyonOnundeTasVar = new Exception("Olmayan Tasi Yiyemez");
                                throw PiyonOnundeTasVar;
                            }
                            else
                            {
                                YiyerekGecilen = new SatrancTasi();
                                YiyerekGecilen.renk = MasaKareleri[GidecegiYerX - 1, GidecegiYerY].renk;
                                YiyerekGecilen.tur = MasaKareleri[GidecegiYerX - 1, GidecegiYerY].tur;
                                YiyerekGecilen.KoordinatX = GidecegiYerX - 1;
                                YiyerekGecilen.KoordinatY = GidecegiYerY;
                                MasaKareleri[GidecegiYerX - 1, GidecegiYerY].TasKaybet();
                            }
                        }
                    }
                    else
                    {
                        Exception PiyonOnundeTasVar = new Exception("Piyon Oraya Oynayamaz");
                        throw PiyonOnundeTasVar;
                    }
                }
                else
                {
                    Exception PiyonOnundeTasVar = new Exception("Piyon ileri ilerler çapraz yer.");
                    throw PiyonOnundeTasVar;
                }

            }
            else
            {
                if (TasinYeriX == 6 & GidecegiYerX == 4)
                {
                    if (MasaKareleri[5, TasinYeriY].renk != RenkEnum.Bos | MasaKareleri[4, TasinYeriY].renk != RenkEnum.Bos)
                    {
                        Exception Piyongidemez = new Exception("Pİyonun Oynayacağı yerde taş var.");
                        throw Piyongidemez;
                    }
                }
                else if (TasinYeriX - GidecegiYerX == 1)
                {
                    if (TasinYeriY == GidecegiYerY)
                    {
                        if (MasaKareleri[GidecegiYerX, GidecegiYerY].renk != RenkEnum.Bos)
                        {
                            Exception PiyonOnundeTasVar = new Exception("Piyonun Önünde Taş Var");
                            throw PiyonOnundeTasVar;
                        }
                    }
                    else if (MutlakDeger(GidecegiYerY - TasinYeriY) == 1)
                    {
                        if (MasaKareleri[GidecegiYerX, GidecegiYerY].renk != RenkEnum.Beyaz)
                        {
                            if (BiElOncekiHamle != ((GidecegiYerX - 1).ToString() + GidecegiYerY.ToString() + (GidecegiYerX + 1).ToString() + GidecegiYerY.ToString()))
                            {
                                Exception PiyonOnundeTasVar = new Exception("Olmayan Tasi Yiyemez");
                                throw PiyonOnundeTasVar;
                            }
                            else
                            {
                                YiyerekGecilen = new SatrancTasi();
                                YiyerekGecilen.renk = MasaKareleri[GidecegiYerX + 1, GidecegiYerY].renk;
                                YiyerekGecilen.tur = MasaKareleri[GidecegiYerX + 1, GidecegiYerY].tur;
                                YiyerekGecilen.KoordinatX = GidecegiYerX + 1;
                                YiyerekGecilen.KoordinatY = GidecegiYerY;
                                MasaKareleri[GidecegiYerX + 1, GidecegiYerY].TasKaybet();
                            }
                        }
                    }
                    else
                    {
                        Exception PiyonOnundeTasVar = new Exception("Piyon Oraya Oynayamaz");
                        throw PiyonOnundeTasVar;
                    }
                }
                else
                {
                    Exception PiyonOnundeTasVar = new Exception("Piyon ileri ilerler çapraz yer.");
                    throw PiyonOnundeTasVar;
                }

            }

            BiOncekiX.renk = MasaKareleri[TasinYeriX, TasinYeriY].renk;
            BiOncekiX.tur = MasaKareleri[TasinYeriX, TasinYeriY].tur;
            BiOncekiY.renk = MasaKareleri[GidecegiYerX, GidecegiYerY].renk;
            BiOncekiY.tur = MasaKareleri[GidecegiYerX, GidecegiYerY].tur;
            MasaKareleri[GidecegiYerX, GidecegiYerY].renk = MasaKareleri[TasinYeriX, TasinYeriY].renk;
            MasaKareleri[GidecegiYerX, GidecegiYerY].tur = MasaKareleri[TasinYeriX, TasinYeriY].tur;
            MasaKareleri[TasinYeriX, TasinYeriY].renk = RenkEnum.Bos;
            MasaKareleri[TasinYeriX, TasinYeriY].tur = TurEnum.Bos;
            
        }
        private void VezirOyna(int TasinYeriX, int TasinYeriY, int GidecegiYerX, int GidecegiYerY)
        {
            if (MutlakDeger(GidecegiYerX -TasinYeriX )== MutlakDeger(GidecegiYerY - TasinYeriY))
            {
                try
                {
                    FilOyna(TasinYeriX, TasinYeriY, GidecegiYerX, GidecegiYerY);
                }
                catch (System.Exception e)
                {
                    //e.Message = "Vezir Çapraz Giderken Önüne Taaş Çıktı.";
                    throw e;
                }
               
            }
            else if (GidecegiYerX == TasinYeriX | GidecegiYerY == TasinYeriY)
            {
                try
                {
                    KaleOyna(TasinYeriX, TasinYeriY, GidecegiYerX, GidecegiYerY);
                }
                catch (System.Exception e)
                {
                    //e.Message = "Vezir Yatay-Dİkey Giderken Önüne Taş Çktı.";
                    throw e;
                }
               
            }else{
                Exception VezirHata = new Exception("Vezir Yatay - Dikey Ve Çapraz Gidebilir");
                throw VezirHata;
            }            
        }
        private void TasOyna(int TasinYeriX, int TasinYeriY, int GidecegiYerX, int GidecegiYerY, TurEnum YukselecekTas)
        {
            RenkEnum rengim = MasaKareleri[TasinYeriX, TasinYeriY].renk;
            
            try
            {
                if (MasaKareleri[TasinYeriX, TasinYeriY].tur == TurEnum.At)
                {
                    AtOyna(TasinYeriX, TasinYeriY, GidecegiYerX, GidecegiYerY);
                }
                else if (MasaKareleri[TasinYeriX, TasinYeriY].tur == TurEnum.Fil)
                {
                    FilOyna(TasinYeriX, TasinYeriY, GidecegiYerX, GidecegiYerY);
                }
                else if (MasaKareleri[TasinYeriX, TasinYeriY].tur == TurEnum.Kale)
                {
                    KaleOyna(TasinYeriX, TasinYeriY, GidecegiYerX, GidecegiYerY);
                    
                }
                else if (MasaKareleri[TasinYeriX, TasinYeriY].tur == TurEnum.Piyon)
                {
                    PiyonOyna(TasinYeriX, TasinYeriY, GidecegiYerX, GidecegiYerY,YukselecekTas);
                }
                else if (MasaKareleri[TasinYeriX, TasinYeriY].tur == TurEnum.Sah)
                {
                    SahOyna(TasinYeriX, TasinYeriY, GidecegiYerX, GidecegiYerY);
                    
                }
                else if (MasaKareleri[TasinYeriX, TasinYeriY].tur == TurEnum.Vezir)
                {
                    VezirOyna(TasinYeriX, TasinYeriY, GidecegiYerX, GidecegiYerY);
                }
            }
            catch(Exception HerhangiHata){
                throw HerhangiHata;
            }
            if (SahTeklikedemi(rengim))
            {
                Exception SahTehlikede = new Exception(MasaKareleri[GidecegiYerX,GidecegiYerY].renk.ToString()+ " Şah Tehlikede.");
                GeriAl(TasinYeriX, TasinYeriY, GidecegiYerX, GidecegiYerY);
                throw SahTehlikede;
            }

            BiElOncekiHamle = TasinYeriX.ToString() + TasinYeriY.ToString() + GidecegiYerX.ToString() + GidecegiYerY.ToString();
          
            YiyerekGecilen = null;
        }
        private void TasOyna(int TasinYeriX, int TasinYeriY, int GidecegiYerX, int GidecegiYerY)
        {
            RenkEnum rengim = MasaKareleri[TasinYeriX, TasinYeriY].renk;

            try
            {
                if (MasaKareleri[TasinYeriX, TasinYeriY].tur == TurEnum.At)
                {
                    AtOyna(TasinYeriX, TasinYeriY, GidecegiYerX, GidecegiYerY);
                }
                else if (MasaKareleri[TasinYeriX, TasinYeriY].tur == TurEnum.Fil)
                {
                    FilOyna(TasinYeriX, TasinYeriY, GidecegiYerX, GidecegiYerY);
                }
                else if (MasaKareleri[TasinYeriX, TasinYeriY].tur == TurEnum.Kale)
                {
                    KaleOyna(TasinYeriX, TasinYeriY, GidecegiYerX, GidecegiYerY);
                    
                }
                else if (MasaKareleri[TasinYeriX, TasinYeriY].tur == TurEnum.Piyon)
                {
                    PiyonOyna(TasinYeriX, TasinYeriY, GidecegiYerX, GidecegiYerY);
                }
                else if (MasaKareleri[TasinYeriX, TasinYeriY].tur == TurEnum.Sah)
                {
                    SahOyna(TasinYeriX, TasinYeriY, GidecegiYerX, GidecegiYerY);                    
                    
                }
                else if (MasaKareleri[TasinYeriX, TasinYeriY].tur == TurEnum.Vezir)
                {
                    VezirOyna(TasinYeriX, TasinYeriY, GidecegiYerX, GidecegiYerY);
                }
            }
            catch (Exception HerhangiHata)
            {
                throw HerhangiHata;
            }
            if (SahTeklikedemi(rengim))
            {
                Exception SahTehlikede = new Exception(MasaKareleri[GidecegiYerX, GidecegiYerY].renk.ToString() + " Şah Tehlikede.");
                GeriAl(TasinYeriX, TasinYeriY, GidecegiYerX, GidecegiYerY);
                throw SahTehlikede;
            }

            BiElOncekiHamle = TasinYeriX.ToString() + TasinYeriY.ToString() + GidecegiYerX.ToString() + GidecegiYerY.ToString();

            YiyerekGecilen = null;
        }    
        private bool MatOldumu(RenkEnum renk){
                    
                    #region Sah ın Yerini Belirle
        
                    int KoordinatX = 0, KoordinatY = 0, i, j;
                    bool AllowBreak = false;
                    for (i = 0; i < 8; i++)
                    {
                        for (j = 0; j < 8; j++)
                        {
                            if (MasaKareleri[i, j].renk == renk)
                            {
                                if (MasaKareleri[i, j].tur == TurEnum.Sah)
                                {
                                    KoordinatX = i;
                                    KoordinatY = j;
                                    AllowBreak = true;
                                    break;
                                }
                            }
                        }
                        if (AllowBreak)
                        {
                            break;
                        }
                    }
                    #endregion
                    int sayac1, sayac2,TehditSayisi;
                    RenkEnum RakipRenk;
                    if(renk==RenkEnum.Beyaz){
                       RakipRenk=RenkEnum.Siyah;
                    }else{
                        RakipRenk=RenkEnum.Beyaz;
                    }
                    TehditSayisi = BuTasiKacKisiTehditEdiyor(KoordinatX,KoordinatY,renk);
                    if (TehditSayisi > 1)
                    {
                        for (i = -1; i < 2; i++)
                        {
                            for (j = -1; j < 2; j++)
                            {
                                if (i == 0 & j == 0)
                                    continue;
                                if ((KoordinatX + i < 0) | (KoordinatX + i > 7) | (KoordinatY + j < 0) | (KoordinatY + j > 7))
                                {
                                    continue;
                                }
                                if (MasaKareleri[KoordinatX + i, KoordinatY + j].renk == renk)
                                {
                                    continue;
                                }
                                else if (MasaKareleri[KoordinatX + i, KoordinatY + j].renk != RenkEnum.Bos)
                                {
                                    MasaKareleri[KoordinatX, KoordinatY].tur = TurEnum.Bos;
                                    MasaKareleri[KoordinatX, KoordinatY].renk = RenkEnum.Bos;
                                    if (!BuTasTehlikedemi(KoordinatX + i, KoordinatY + j, renk))
                                    {
                                        MasaKareleri[KoordinatX, KoordinatY].tur = TurEnum.Sah;
                                        MasaKareleri[KoordinatX, KoordinatY].renk = renk;
                                        return false;
                                    }
                                    MasaKareleri[KoordinatX, KoordinatY].tur = TurEnum.Sah;
                                    MasaKareleri[KoordinatX, KoordinatY].renk = renk;
                                    //if (BuTasTehlikedemiSahHaric(KoordinatX + i, KoordinatY + j, RakipRenk))
                                    //    return false;
                                }
                                else
                                {
                                    if (!BuTasTehlikedemi(KoordinatX + i, KoordinatY + j, renk))
                                        return false;
                                }
                            }
                        }
                        return true;
                    }
                    else
                    {
                        SatrancTasi tehditeden = TehditKim(KoordinatX, KoordinatY, renk);
                        if (BuTasTehlikedemiSahHaric(tehditeden.KoordinatX, tehditeden.KoordinatY, RakipRenk))
                            return false;

                        for (i = -1; i < 2; i++)
                        {
                            for (j = -1; j < 2; j++)
                            {
                                if (i == 0 & j == 0)
                                    continue;
                                if ((KoordinatX + i < 0) | (KoordinatX + i > 7) | (KoordinatY + j < 0) | (KoordinatY + j > 7))
                                {
                                    continue;
                                }
                                if (MasaKareleri[KoordinatX + i, KoordinatY + j].renk == renk)
                                {
                                    continue;
                                }
                                else if (MasaKareleri[KoordinatX + i, KoordinatY + j].renk != RenkEnum.Bos)
                                {
                                    MasaKareleri[KoordinatX, KoordinatY].tur = TurEnum.Bos;
                                    MasaKareleri[KoordinatX, KoordinatY].renk = RenkEnum.Bos;
                                    if (!BuTasTehlikedemi(KoordinatX + i, KoordinatY + j, renk))
                                    {
                                        MasaKareleri[KoordinatX, KoordinatY].tur = TurEnum.Sah;
                                        MasaKareleri[KoordinatX, KoordinatY].renk = renk;
                                        return false;
                                    }
                                    MasaKareleri[KoordinatX, KoordinatY].tur = TurEnum.Sah;
                                    MasaKareleri[KoordinatX, KoordinatY].renk = renk;                                  
                                }
                                else
                                {
                                    MasaKareleri[KoordinatX, KoordinatY].tur = TurEnum.Bos;
                                    MasaKareleri[KoordinatX, KoordinatY].renk = RenkEnum.Bos;
                                    if (!BuTasTehlikedemi(KoordinatX + i, KoordinatY + j, renk))
                                    {
                                        MasaKareleri[KoordinatX, KoordinatY].tur = TurEnum.Sah;
                                        MasaKareleri[KoordinatX, KoordinatY].renk = renk;
                                        return false;
                                    }
                                    MasaKareleri[KoordinatX, KoordinatY].tur = TurEnum.Sah;
                                    MasaKareleri[KoordinatX, KoordinatY].renk = renk;
                                    
                                    sayac1 = KoordinatX;
                                    sayac2 = KoordinatY;
                                    if (MutlakDeger(KoordinatX - tehditeden.KoordinatX) == MutlakDeger(KoordinatY - tehditeden.KoordinatY))
                                    {
                                        while (true)
                                        {
                                            if (KoordinatX > tehditeden.KoordinatX)
                                            {
                                                sayac1--;
                                            }
                                            else
                                            {
                                                sayac1++;
                                            }
                                            if (KoordinatY > tehditeden.KoordinatY)
                                            {
                                                sayac2--;
                                            }
                                            else
                                            {
                                                sayac2++;
                                            }
                                            if (sayac1 == tehditeden.KoordinatX & sayac2 == tehditeden.KoordinatY)
                                                break;
                                            if (BuTasTehlikedemiSahPiyonHaric(sayac1, sayac2, RakipRenk))
                                                return false;
                                        }

                                    }
                                    else if ((KoordinatX == tehditeden.KoordinatX | KoordinatY == tehditeden.KoordinatY))
                                    {
                                        while (true)
                                        {
                                            if (KoordinatX > tehditeden.KoordinatX)
                                            {
                                                sayac1--;
                                            }
                                            else if (KoordinatX < tehditeden.KoordinatX)
                                            {
                                                sayac1++;
                                            }
                                            if (KoordinatY > tehditeden.KoordinatY)
                                            {
                                                sayac2--;
                                            }
                                            else if (KoordinatY < tehditeden.KoordinatY)
                                            {
                                                sayac2++;
                                            }
                                            if (sayac1 == tehditeden.KoordinatX & sayac2 == tehditeden.KoordinatY)
                                                break;
                                            if (BuTasTehlikedemiSahPiyonHaric(sayac1, sayac2, RakipRenk))
                                                return false;
                                        }
                                    }
                                }
                            }
                        }
                        return true;
                    }
                    return true;
                }        
        private bool PiyonOynarmi(int KoordinatX,int KoordinatY,RenkEnum Renk){
            if(Renk==RenkEnum.Beyaz){
                try
                {
                    TasOyna(KoordinatX, KoordinatY, KoordinatX + 1, KoordinatY);
                    GeriAl(KoordinatX, KoordinatY, KoordinatX + 1, KoordinatY);
                    return true;
                }
                catch
                {

                }
                try
                {
                    TasOyna(KoordinatX, KoordinatY, KoordinatX + 1, KoordinatY+1);
                    GeriAl(KoordinatX, KoordinatY, KoordinatX + 1, KoordinatY+1);
                    return true;
                }
                catch
                {

                }
                try
                {
                    TasOyna(KoordinatX, KoordinatY, KoordinatX + 1, KoordinatY-1);
                    GeriAl(KoordinatX, KoordinatY, KoordinatX + 1, KoordinatY-1);
                    return true;
                }
                catch
                {

                }      
            }else{
                try
                {
                    TasOyna(KoordinatX, KoordinatY, KoordinatX - 1, KoordinatY);
                    GeriAl(KoordinatX, KoordinatY, KoordinatX - 1, KoordinatY);
                    return true;
                }
                catch
                {

                }
                try
                {
                    TasOyna(KoordinatX, KoordinatY, KoordinatX - 1, KoordinatY + 1);
                    GeriAl(KoordinatX, KoordinatY, KoordinatX - 1, KoordinatY + 1);
                    return true;
                }
                catch
                {

                }
                try
                {
                    TasOyna(KoordinatX, KoordinatY, KoordinatX - 1, KoordinatY - 1);
                    GeriAl(KoordinatX, KoordinatY, KoordinatX - 1, KoordinatY - 1);
                    return true;
                }
                catch
                {

                }      
            }
            return false;
        }
        private bool KaleOynarmi(int KoordinatX,int KoordinatY)
        {
           if(KoordinatX>0){
               try{
                   TasOyna(KoordinatX, KoordinatY, KoordinatX - 1, KoordinatY);
                   GeriAl(KoordinatX, KoordinatY, KoordinatX - 1, KoordinatY);
                   return true;               
               }catch{

               }             
           }
           if (KoordinatX < 7)
           {
               try
               {
                   TasOyna(KoordinatX, KoordinatY, KoordinatX + 1, KoordinatY);
                   GeriAl(KoordinatX, KoordinatY, KoordinatX + 1, KoordinatY);
                   return true;
               }
               catch
               {

               }
           }
           if (KoordinatY > 0)
           {
               try
               {
                   TasOyna(KoordinatX, KoordinatY, KoordinatX , KoordinatY-1);
                   GeriAl(KoordinatX, KoordinatY, KoordinatX , KoordinatY-1);
                   return true;
               }
               catch
               {

               }
           }
           if (KoordinatY <7)
           {
               try
               {
                   TasOyna(KoordinatX, KoordinatY, KoordinatX, KoordinatY + 1);
                   GeriAl(KoordinatX, KoordinatY, KoordinatX, KoordinatY + 1);
                   return true;
               }
               catch
               {

               }
           }

           return false;
        }
        private bool AtOynarmi(int KoordinatX, int KoordinatY)
        {
            for (int i = -2; i < 3; i++)
            {
                for (int j = -2; j < 3; j++)
                {
                    if ((MutlakDeger(i) == 2 & MutlakDeger(j) == 1) | (MutlakDeger(i) == 1 & MutlakDeger(j) == 2)){
                        if ((KoordinatX + i < 0 & KoordinatX + i > 7) | (KoordinatY + j < 0 & KoordinatY + j > 7))
                            continue;
                        try
                        {
                            TasOyna(KoordinatX, KoordinatY, KoordinatX + i, KoordinatY+j);
                            GeriAl(KoordinatX, KoordinatY, KoordinatX + i, KoordinatY+j);
                            return true;
                        }
                        catch
                        {

                        }
                    }
                }
            }
            
            return false;
        }
        private bool FilOynarmi(int KoordinatX, int KoordinatY)
        {
            if (KoordinatY > 0& KoordinatX>0)
            {
                try
                {
                    TasOyna(KoordinatX, KoordinatY, KoordinatX-1, KoordinatY - 1);
                    GeriAl(KoordinatX, KoordinatY, KoordinatX-1, KoordinatY - 1);
                    return true;
                }
                catch
                {

                }
            }
            if (KoordinatY < 7 & KoordinatX > 0)
            {
                try
                {
                    TasOyna(KoordinatX, KoordinatY, KoordinatX - 1, KoordinatY + 1);
                    GeriAl(KoordinatX, KoordinatY, KoordinatX - 1, KoordinatY + 1);
                    return true;
                }
                catch
                {

                }
            }
            if (KoordinatY <7 & KoordinatX <7)
            {
                try
                {
                    TasOyna(KoordinatX, KoordinatY, KoordinatX + 1, KoordinatY + 1);
                    GeriAl(KoordinatX, KoordinatY, KoordinatX + 1, KoordinatY + 1);
                    return true;
                }
                catch
                {

                }
            }
            if (KoordinatY > 0 & KoordinatX <7)
            {
                try
                {
                    TasOyna(KoordinatX, KoordinatY, KoordinatX + 1, KoordinatY - 1);
                    GeriAl(KoordinatX, KoordinatY, KoordinatX + 1, KoordinatY - 1);
                    return true;
                }
                catch
                {

                }
            }
            return false;
        }
        private bool VezirOynarmi(int KoordinatX, int KoordinatY)
        {
            
            return KaleOynarmi(KoordinatX,KoordinatY)|FilOynarmi(KoordinatX,KoordinatY);
        }
        private bool SahOynarmi(int KoordinatX, int KoordinatY)
        {
            return KaleOynarmi(KoordinatX, KoordinatY) | FilOynarmi(KoordinatX, KoordinatY);

        }
        private bool BeyazYenemez(){
            int Filsayisi=0, AtSayisi=0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if(MasaKareleri[i,j].renk==RenkEnum.Beyaz){
                        if(MasaKareleri[i,j].tur==TurEnum.Kale|MasaKareleri[i,j].tur==TurEnum.Vezir|MasaKareleri[i,j].tur==TurEnum.Piyon){
                            return false;
                        }
                        if (MasaKareleri[i, j].tur == TurEnum.At)
                            AtSayisi++;
                        if (MasaKareleri[i, j].tur == TurEnum.Fil)
                            Filsayisi++;

                    }
                }
            }
            if(Filsayisi>1|AtSayisi>1)
                return false;
            if (Filsayisi == 0 | AtSayisi == 0)
                return true;
            else
                return false;

        }
        private bool SiyahYenemez(){
            int Filsayisi=0, AtSayisi=0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (MasaKareleri[i, j].renk == RenkEnum.Siyah)
                    {
                        if (MasaKareleri[i, j].tur == TurEnum.Kale | MasaKareleri[i, j].tur == TurEnum.Vezir | MasaKareleri[i, j].tur == TurEnum.Piyon)
                        {
                            return false;
                        }
                        if (MasaKareleri[i, j].tur == TurEnum.At)
                            AtSayisi++;
                        if (MasaKareleri[i, j].tur == TurEnum.Fil)
                            Filsayisi++;

                    }
                }
            }
            if (Filsayisi > 1 | AtSayisi > 1)
                return false;
            if (Filsayisi == 0 | AtSayisi == 0)
                return true;
            else
                return false;
        }
        private bool PatOldumu(RenkEnum renk){
            int i ,j;
            if (BeyazYenemez() & SiyahYenemez())
                return true;
            if(renk == RenkEnum.Beyaz){
                for(i=0;i<8;i++){
                    for(j=0;j<8;j++){
                        if (MasaKareleri[i, j].renk == renk){
                            if(MasaKareleri[i, j].tur==TurEnum.Piyon){
                                if (PiyonOynarmi(i,j,renk))
                                    return false;
                            }else if(MasaKareleri[i, j].tur==TurEnum.Kale){
                                if (KaleOynarmi(i,j))
                                    return false;
                            }else if(MasaKareleri[i, j].tur==TurEnum.At){
                                if (AtOynarmi(i, j))
                                    return false;
                            }else if(MasaKareleri[i, j].tur==TurEnum.Fil){
                                if (FilOynarmi(i, j))
                                    return false;
                            }else if(MasaKareleri[i, j].tur==TurEnum.Vezir){
                                if (VezirOynarmi(i, j))
                                    return false;
                            }else if(MasaKareleri[i, j].tur==TurEnum.Sah){
                                if (SahOynarmi(i, j))
                                    return false;
                            } 
                        }                            
                    }
                }
            }else{
                for (i = 7; i >0; i--)
                {
                    for (j = 0; j < 8; j++)
                    {
                        if (MasaKareleri[i, j].renk == renk)
                        {
                            if (MasaKareleri[i, j].tur == TurEnum.Piyon)
                            {
                                if (PiyonOynarmi(i, j,renk))
                                    return false;
                            }
                            else if (MasaKareleri[i, j].tur == TurEnum.Kale)
                            {
                                if (KaleOynarmi(i, j))
                                    return false;
                            }
                            else if (MasaKareleri[i, j].tur == TurEnum.At)
                            {
                                if (AtOynarmi(i, j))
                                    return false;
                            }
                            else if (MasaKareleri[i, j].tur == TurEnum.Fil)
                            {
                                if (FilOynarmi(i, j))
                                    return false;
                            }
                            else if (MasaKareleri[i, j].tur == TurEnum.Vezir)
                            {
                                if (VezirOynarmi(i, j))
                                    return false;
                            }
                            else if (MasaKareleri[i, j].tur == TurEnum.Sah)
                            {
                                if (SahOynarmi(i, j))
                                    return false;
                            }
                        }
                    }
                }
            }
            return true;
        }
        protected Sonuc HamleYap(int TasinYeriX, int TasinYeriY, int GidecegiYerX, int GidecegiYerY,TurEnum YukselecekTas)
        {
            if (oyunDurumu == Sonuc.Mat)
            {
                return Sonuc.Mat;
            }
            if (oyunDurumu == Sonuc.Pat)
            {
                return Sonuc.Pat;
            }
            if (TasinYeriX < 0 | TasinYeriX > 7 | TasinYeriY < 0 | TasinYeriY > 7 | GidecegiYerX < 0 | GidecegiYerX > 7 | GidecegiYerY < 0 | GidecegiYerY > 7)
            {
                Exception OlmayanKare = new Exception("Saha 64 Karedir. 0 - 7");
                throw OlmayanKare;
            }
            if (MasaKareleri[TasinYeriX, TasinYeriY].renk == RenkEnum.Bos)
            {
                Exception OlmayanTas = new Exception("Olmayan Bir Taş Atılamaz");
                throw OlmayanTas;
            }
            if (GidecegiYerX == TasinYeriX & GidecegiYerY == TasinYeriY)
            {
                Exception OlduguYerde = new Exception("Tas Aynı Yerde");
                throw OlduguYerde;
            }            
            if (MasaKareleri[GidecegiYerX, GidecegiYerY].renk == MasaKareleri[TasinYeriX, TasinYeriY].renk)
            {
                Exception KendiTasiniYiyemez = new Exception("Gidecegi Yerde Kendi Tasi Var");
                throw KendiTasiniYiyemez;
            }
            RenkEnum rakiprenk;
            if (MasaKareleri[TasinYeriX, TasinYeriY].renk == RenkEnum.Beyaz)
            {
                rakiprenk = RenkEnum.Siyah;
            }
            else
            {
                rakiprenk = RenkEnum.Beyaz;
            }
            if (SiraBeyazdami)
            {
                if(MasaKareleri[TasinYeriX,TasinYeriY].renk!=RenkEnum.Beyaz){
                    Exception SiraHatasi = new Exception("Sıra Beyazda Siyah Oynayamaz.");
                    throw SiraHatasi;
                }
                
            }else{
                if (MasaKareleri[TasinYeriX, TasinYeriY].renk == RenkEnum.Beyaz)
                {
                    Exception SiraHatasi = new Exception("Sıra Siyahta Beyaz Oynayamaz.");
                    throw SiraHatasi;
                }
            }
            try
            {
                TasOyna(TasinYeriX, TasinYeriY, GidecegiYerX, GidecegiYerY,YukselecekTas);
                SiraBeyazdami = !SiraBeyazdami;
            }
            catch (Exception Hamlehatasi)
            {
                throw Hamlehatasi;
            }
            SatrancTasi SahiTehditEden = new SatrancTasi() ;
            String OncekiHamle = BiElOncekiHamle;
            #region Rok Kontrolleri
            if (TasinYeriX == 0)
            {
                if (TasinYeriY == 0)
                {
                    SolBeyazKaleOynadimi = true;
                }
                else if (TasinYeriY == 7)
                {
                    SagBeyazKaleOynadimi = true;
                }
            }
            else if (TasinYeriX == 7)
            {
                if (TasinYeriY == 0)
                {
                    SolSiyahKaleOynadimi = true;
                }
                else if (TasinYeriY == 7)
                {
                    SagSiyahKaleOynadimi = true;
                }
            }
            if (MasaKareleri[GidecegiYerX, GidecegiYerY].tur == TurEnum.Sah)
            {
                if (MasaKareleri[GidecegiYerX, GidecegiYerY].renk == RenkEnum.Beyaz)
                {
                    BeyazSahOynadimi = true;
                }
                else
                {
                    SiyahSahOynadimi = true;
                }
            }
            #endregion
            if(SahTeklikedemi(rakiprenk)){               
                if (MatOldumu(rakiprenk))
                {
                    oyunDurumu = Sonuc.Mat;
                    return Sonuc.Mat;
                }
                else
                {
                    oyunDurumu = Sonuc.SahCekti;
                    return Sonuc.SahCekti;
                }  
            }else{
                if(PatOldumu(rakiprenk)){
                    oyunDurumu = Sonuc.Pat;
                    return Sonuc.Pat;
                }
            }
            BiElOncekiHamle = OncekiHamle;
            if (SiraBeyazdami)
            {
                oyunDurumu = Sonuc.SiraBeyazda;
                return Sonuc.SiraBeyazda;
            }
            else
            {
                oyunDurumu = Sonuc.SiraSiyahta;
                return Sonuc.SiraSiyahta;
            }
        }
    }   
}
