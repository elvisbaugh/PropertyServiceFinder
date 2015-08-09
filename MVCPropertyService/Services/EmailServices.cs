using MVCPropertyService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MVCPropertyService.Services
{
  public class EmailServices
  {
   
    public async Task<EmailFormModel> SendEmail(EmailFormModel emailFormModel)
    {
      var body = "<p>Email from: {0} ({1})</p><p>Message:</p><p>{2}</p><p>{3}</p>";
      var message = new MailMessage();   
      message.To.Add(new MailAddress("ebaugh.eb@gmail.com"));
      message.Subject = "Property Inquiry";
      message.Body = string.Format(body, emailFormModel.Name, emailFormModel.FromContactPhoneNumber, emailFormModel.MessageBody,                        emailFormModel.Address);
      message.IsBodyHtml = true;

      using (var smtp = new SmtpClient())
      {
        await smtp.SendMailAsync(message);
      }
      return emailFormModel;
    }
  }
}