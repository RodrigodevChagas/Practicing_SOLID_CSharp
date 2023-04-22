using Practicing_SOLID_CSharp._5___DIP.Solução.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Practicing_SOLID_CSharp._5___DIP.Solução.Services
{
    public class EmailService : IEmailService
    {
        public bool IsEmailValid(string Email)
        {
            return Email.Contains("@");
        }

        public void SendEmail (string Email)
        {
            var mail = new MailMessage("empresa@empresa.com", Email);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = "Bem Vindo.";
            mail.Body = "Parabéns! Você está cadastrado.";
            client.Send(mail);
        }
    }
}
