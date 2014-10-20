using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;

namespace BurakSatranc
{
    public class Guvenlik
    {

        public string RasgeleSifreUret(int Uzunluk)
        {
            char[] cr = "0123456789abcdefghijklmnopqrstuvwxyz".ToCharArray();
            string result = string.Empty;
            Random r = new Random();
            for (int i = 0; i < Uzunluk; i++)
            {
                result += cr[r.Next(0, cr.Length - 1)].ToString();
            }
            return result;
        }

        public string MD5Sifreleme(string Metin){
            return FormsAuthentication.HashPasswordForStoringInConfigFile(Metin, "md5");
        }


    }
}
