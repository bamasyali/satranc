 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Runtime.Serialization;
using System.IO;
using System.Data.OleDb;
using System.Collections;
using System.Web;


using System.Runtime.Serialization.Formatters.Binary;


namespace Chess
{
    public class Baglanti
        {
        private static string DataBaseWord = "Provider=Microsoft.Jet.OLEDB.4.0;data source=";
        private static string DataBaseURL = HttpContext.Current.Server.MapPath("BurakChess.mdb");
        //private static string DataBaseURL = "C:\\BurakChess.mdb";
        private static string DataBasePassword = ";Jet OLEDB:Database Password=chessmaster";
        public static string ConnectionString{
            get { return DataBaseWord + DataBaseURL + DataBasePassword; }
        }
        private static OleDbCommand com;
        private static OleDbConnection DataBaseConnection;
        public static OleDbConnection DataBaseconnection{
            get { return DataBaseConnection; }
        } 
       
        static Baglanti(){
            com = new OleDbCommand();
           
                try{
                    DataBaseConnection = new OleDbConnection(DataBaseWord+DataBaseURL+DataBasePassword);
                    Connect();                                      
                }
                catch(Exception ex){              
                    throw ex;
                }finally{
                    DisConnect();
                }
            
        }       
        public  static void Connect()
        {            
            try
            {
                DataBaseConnection.Open();                
            }
            catch
            {
                Exception BaglantiHatasi = new Exception("Veritabanina Baglanilirken Bir Sorunla Karşılaşıldı.");
                throw BaglantiHatasi;
            }                                  
        }
        public static void DisConnect()
        {
            try
            {
                DataBaseConnection.Close();
            }
            catch
            {
                Exception BaglantiHatasi = new Exception("Veritabani Baglantisi Kesilirken Bir Sorunla Karşılaşıldı.");
                throw BaglantiHatasi;
            }            
        }

        public static DataTable TabloSorgula(string sorgu)
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                com.Connection = DataBaseConnection;
                com.CommandText = sorgu;
                OleDbDataAdapter adp = new OleDbDataAdapter(com);
                adp.Fill(dt);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect();
            }
            return dt;

        }
        public static void SorguGonder(string sorgu)
        {
            try
            {
                Connect();
                com.Connection = DataBaseConnection;
                com.CommandText = sorgu;
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {                
                throw ex;
            }
            finally
            {
                DisConnect();
            }
        }
        public static bool KullaniciGirisi(String KullaniciAdi,String Sifre){
            try{
                Connect();
                OleDbCommand myCommand = new OleDbCommand("SELECT Sifre FROM Kullanici where KullaniciAdi='" + KullaniciAdi + "';", DataBaseConnection);
                OleDbDataReader myReader = myCommand.ExecuteReader();
                myReader.Read();
                return myReader.GetString(0) == Sifre;

            }catch{
                Exception hata1 = new Exception("Böyle Bir Kullanıcı Yok.");
                throw hata1;
            }finally{
                DisConnect();
            }            
        }
        public static bool BuKullaniciAdiAlinmismi(string KullaniciAdi){
            try
            {
                Connect();
                OleDbCommand myCommand = new OleDbCommand("SELECT * FROM Kullanici where KullaniciAdi = '"+KullaniciAdi+"' ;", DataBaseConnection);
                OleDbDataReader myReader = myCommand.ExecuteReader();
                myReader.Read();
                string asd = myReader.GetString(1);
                return true;
                
            }
            catch
            {
                return false;
            }
            finally
            {
                DisConnect();
            }       
        }
        public static int BuMasadaKacHamleYapilmis(int MasaID){
            try
            {
                Connect();
                OleDbCommand myCommand = new OleDbCommand("SELECT count(*) as ToplamHamle FROM Hamle where MasaID = "+MasaID+" ;", DataBaseConnection);
                OleDbDataReader myReader = myCommand.ExecuteReader();
                myReader.Read();
                return myReader.GetInt32(0);             

            }
            catch(Exception asd)
            {
                throw asd;
            }
            finally
            {
                DisConnect();
            }       
        }
        
        
        public static int MaxID{
            get{
                try
                {
                    Connect();
                    OleDbCommand myCommand = new OleDbCommand("SELECT MAX(ID) AS burak FROM Masa;", DataBaseConnection);
                    OleDbDataReader myReader = myCommand.ExecuteReader();
                    myReader.Read();
                    return myReader.GetInt32(0);

                }
                catch (Exception hata1)
                {
                    throw hata1;
                }
                finally
                {
                    DisConnect();
                }            
            }
        }
        public static int IDBul(string KullaniciAdi){
            try
            {
                Connect();
                OleDbCommand myCommand = new OleDbCommand("SELECT ID FROM Kullanici where KullaniciAdi='"+KullaniciAdi+"';", DataBaseConnection);
                OleDbDataReader myReader = myCommand.ExecuteReader();
                myReader.Read();
                return myReader.GetInt32(0);

            }
            catch (Exception hata1)
            {
                throw hata1;
            }
            finally
            {
                DisConnect();
            }            
        }
        public static string KullaniciAdiBul(int id)
        {
            try
            {
                Connect();
                OleDbCommand myCommand = new OleDbCommand("SELECT KullaniciAdi FROM Kullanici where ID=" + id+ ";", DataBaseConnection);
                OleDbDataReader myReader = myCommand.ExecuteReader();
                myReader.Read();
                return myReader.GetString(0);

            }
            catch (Exception hata1)
            {
                throw hata1;
            }
            finally
            {
                DisConnect();
            }
        }
        public static bool BuMuhteremAdminmi(string KullaniciAdi){
            try
            {
                Connect();
                OleDbCommand myCommand = new OleDbCommand("SELECT admin FROM Kullanici where KullaniciAdi='" + KullaniciAdi + "';", DataBaseConnection);
                OleDbDataReader myReader = myCommand.ExecuteReader();
                myReader.Read();
                return myReader.GetBoolean(0);

            }
            catch (Exception hata1)
            {
                throw hata1;
            }
            finally
            {
                DisConnect();
            }            
        }
        
        public static  ArrayList Firmalar()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT ID,FirmaAdi FROM Musteri order by FirmaAdi;", DataBaseConnection);
            Connect();
            OleDbDataReader rsAutors = cmd.ExecuteReader();
            ArrayList Authors = new ArrayList();

            while (rsAutors.Read())
            {
                Authors.Add(rsAutors.GetString(1));
                

            }
            rsAutors.Close();
            DisConnect();
            return Authors;

            
        }
        
        public static int BiSonrakiMusteri
        {
            get
            {
                int sonuc;
                Connect();
                OleDbCommand myCommand = new OleDbCommand("SELECT MAX(ID) AS MAXID FROM Musteri;", DataBaseConnection);
                OleDbDataReader myReader = myCommand.ExecuteReader();

                try
                {
                    myReader.Read();
                    sonuc = myReader.GetInt32(0) + 1;
                }
                catch
                {
                    sonuc = 1;

                }
                finally
                {
                    DisConnect();
                }
                return sonuc;
            }
        }
        public static int BiSonrakiKayit
        {
            get
            {
                int sonuc;
                Connect();

                OleDbCommand myCommand = new OleDbCommand("SELECT MAX(ID) AS BUYUK FROM BaskiTakip;", DataBaseConnection);
                OleDbDataReader myReader = myCommand.ExecuteReader();

                try
                {
                    myReader.Read();
                    sonuc = myReader.GetInt32(0) + 1;
                }
                catch
                {
                    sonuc = 1;

                }
                finally
                {
                    DisConnect();
                }
                return sonuc;
            }
        }
    }
}
