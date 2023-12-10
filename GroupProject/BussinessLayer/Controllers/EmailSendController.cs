using System.Net;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;

namespace BussinessLayer.Controllers
{
    public class EmailSendController
    {
        private string _emailTo;
        private string emailFrom, emailPass;
        private MailMessage message;
        private SmtpClient smtpClient;
        public EmailSendController(string emailTo, string subject, string messageBody)
        {
            _emailTo = emailTo;
            emailFrom = "mediabazaar464@gmail.com";
            emailPass = "plne tmxx lkfs bpll";

            message = new MailMessage();
            message.Subject = subject;
            message.Body = messageBody;
            message.From = new MailAddress(emailFrom);
            message.To.Add(_emailTo);
            message.CC.Add(emailFrom);

            smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Timeout = 5000;
            smtpClient.Port = 587;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Credentials = new NetworkCredential(emailFrom, emailPass);

        }
        public bool SendEmail()
        {
            try
            {
                smtpClient.Send(message);
                return true;
            }
            catch (SmtpFailedRecipientsException)
            {
                throw new SmtpFailedRecipientsException("There has been an issue with more than one email address");
            }
            catch (SmtpFailedRecipientException) // if email does not exist
            {
                return false;
            }
            catch (SmtpException)
            {
                throw new SmtpException("Server error occurred");
            }
            catch (ArgumentException)
            {
                throw new ArgumentException("A problem occurred");
            }
            catch (Exception)
            {
                throw new Exception("An error occurred. Try again later");
            }
        }
    }
}
