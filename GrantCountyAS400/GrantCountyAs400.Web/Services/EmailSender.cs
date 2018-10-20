using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace GrantCountyAs400.Web.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly IConfiguration _configuration;
        public EmailSender(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public Task SendEmailAsync(string email, string subject, string message)
        {
            MailMessage msg = new MailMessage();
            msg.To.Add(new MailAddress(email, subject));
            msg.From = new MailAddress(_configuration.GetSection("AppSettings")["SupportEmail"], _configuration.GetSection("AppSettings")["SupportEmail"]);
            msg.Subject = "Reset password request";
            msg.Body = message;
            msg.IsBodyHtml = true;
            // Plug in your email service here to send an email.
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            //client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(_configuration.GetSection("AppSettings")["SupportEmail"], _configuration.GetSection("AppSettings")["SupportEmailpassword"]);
            return client.SendMailAsync(msg);
            //return Task.FromResult(0);
        }
    }
}
