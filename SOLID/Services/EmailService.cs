using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;

namespace SOLID.Services
{
    public class EmailService:IEmailService
    {
        public void SendInvoice(string email, decimal total)
        {
             SmtpClient smtp = new SmtpClient("smtp.gmail.com");

            MailMessage mail = new MailMessage("shop@gmail", email);

            mail.Body = $"Your Total {total:C}";

            smtp.Send(mail);


        }
    }
}
