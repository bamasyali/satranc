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
    public partial class MasaOlustur : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["KullaniciAdi"] == null)
            {

                Response.Redirect("KullaniciGirisi.aspx");
               
              
            }         
            
            ListBox1.Items.Add("BOS");
            
            string cumle =("select KullaniciAdi from Kullanici order by KullaniciAdi;");
            try
            {
                Baglanti.Connect();
                OleDbCommand myCommand = new OleDbCommand(cumle, Baglanti.DataBaseconnection);
                OleDbDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    try
                    {
                        
                        ListBox1.Items.Add(myReader.GetString(0));
                    }
                    catch
                    {
                    	
                    }
                   
                }
            }
            catch (Exception ex)
            {
                
                Response.Redirect("Hata.aspx");
            }
            finally
            {
                Baglanti.DisConnect();
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox1.Text == null)
                {
                    Label1.Text = "Butün Kutuları Doldurunuz";
                    return;
                }
                if(Convert.ToInt32(TextBox1.Text)<1)
                {
                    Label1.Text = "Süreler 1 gün den az olamaz";
                    return;
                }

                if (TextBox2.Text == null)
                {
                    Label1.Text = "Butün Kutuları Doldurunuz";
                    return;
                }
                if (Convert.ToInt32(TextBox2.Text) < 1)
                {
                    Label1.Text = "Süreler 1 gün den az olamaz";
                    return;
                }

                if (ListBox1.SelectedValue == string.Empty)
                {
                    Label1.Text = "Butün Kutuları Doldurunuz";
                    return;
                }
                
            }catch{
                Label1.Text = "Butün Kutuları Doldurunuz";
                return;
            }
            
            try
            {

                int rakip;
                if (ListBox1.SelectedValue == "BOS")
                {
                    rakip = 0;
                }
                else
                {
                    rakip = Baglanti.IDBul(ListBox1.SelectedValue);
                }
                if (Convert.ToInt32(Session["KullaniciID"]) != rakip)
                {
                    if (CheckBox1.Checked)
                    {
                        SatrancFramework asd = new SatrancFramework(rakip, Convert.ToInt32(Session["KullaniciID"]), Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text),Convert.ToInt32(Session["KullaniciID"]),CheckBox2.Checked);
                    }
                    else
                    {
                        SatrancFramework asd = new SatrancFramework(Convert.ToInt32(Session["KullaniciID"]), rakip, Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text), Convert.ToInt32(Session["KullaniciID"]),CheckBox2.Checked);
                    }
                }else{
                    Session.Add("Hata", "kendi Kendinizle Stranç Oynayamazsınız");
                    Response.Redirect("Hata.aspx");
                }
            }catch{
                Response.Redirect("Hata.aspx");
            }
            Response.Redirect("Anasayfa.aspx");
        }
    }
}
