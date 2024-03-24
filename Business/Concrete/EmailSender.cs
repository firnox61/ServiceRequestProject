using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class EmailSender : IEmailSender
    {
        private readonly string _smtpServer = "smtp.gmail.com"; // SMTP sunucu adresi
        private readonly int _port = 587; // SMTP port numarası
        private readonly string _username = "firnox61@gmail.com"; // E-posta hesabı kullanıcı adı
        private readonly string _password = "Ts.044060"; // E-posta hesabı şifresi

        public async Task SendEmailAsync(string toEmail, string subject, string body)
        {
            using (var message = new MailMessage(_username, toEmail))
            {
                message.Subject = subject;
                message.Body = body;

                using (var client = new SmtpClient(_smtpServer, _port))
                {
                    client.EnableSsl = true;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(_username, _password);

                    await client.SendMailAsync(message);
                }
            }
        }
    }
}
