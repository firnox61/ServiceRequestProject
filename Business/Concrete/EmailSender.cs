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
        private readonly string _username = "veneles123@gmail.com"; // E-posta hesabı kullanıcı adı
        private readonly string _password = "z z g f o a b i hyta i za f"; // E-posta hesabı şifresi

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
