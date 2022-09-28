using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VaccineMangmentApp.Database;

namespace VaccineMangmentApp
{
    public partial class ForgetPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                VaccineMasterEntities1 db = new VaccineMasterEntities1();
                bool isEmail = Regex.IsMatch(txtUserEmailID.Value, @"\A(?:[a-z0-9!#$%&'+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'+/=?^_`{|}~-]+)@(?:[a-z0-9](?:[a-z0-9-][a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
                if (!isEmail)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Invalid Email ID')", true);
                    ErrorMsg.InnerText = "Invalid Email Address";
                    return;
                } // end if
                else
                {
                    string Custemail = txtUserEmailID.Value;
                    var list = db.UserMasters.ToList();
                    if (list.Any(x => x.EmailID == Custemail))
                    {
                        var name = list.FirstOrDefault(x => x.EmailID == Custemail);
                        SendMail(Custemail, name.Password);
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Email Send Successfully')", true);
                        ErrorMsg.InnerText = "Send Passwod to Email Successfully";
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Customer Not FOund')", true);
                        ErrorMsg.InnerText = "Customer Not Found";
                    }
                }

            }
            catch (Exception Ex)
            {
                //throw;
                ErrorMsg.InnerText = Ex.Message;
            }
        }
        void SendMail(string toemail, string password)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("kavyashree8787@gmail.com");
                message.To.Add(new MailAddress(toemail));
                message.Subject = "CoWin Vaccination System Login Password";
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = "your Password Is : " + password;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = new NetworkCredential("kavyashree8787@gmail.com", "Admin@22");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception ex)
            {
            }
        }
    }
}