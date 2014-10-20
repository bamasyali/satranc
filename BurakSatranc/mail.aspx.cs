using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web.Mail;

namespace BurakSatranc
{
    public partial class mail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MailMessage Eposta = new MailMessage();

            string strKime = TextBox2.Text;
            string strKimden = TextBox1.Text;
            string strBaslik = "Asp.Net ile ilk e-Posta";

            Eposta.To = strKime;
            Eposta.From = strKimden;
            Eposta.Subject = strBaslik;
            
            SmtpMail.SmtpServer = "mail.salon-tr.com";
            try
            {

                SmtpMail.Send(Eposta);
                Response.Write("e-Posta Gönderdi");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}
