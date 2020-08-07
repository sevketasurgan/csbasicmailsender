using System;

namespace csbasicmailsender
{
   
    class Program
    {
         static void Main(string[] args)
        {
            System.Console.Write("E-mail : ");
            var usermail = Console.ReadLine();
            System.Console.Write("Password : ");
            var pswrd = Console.ReadLine();
           System.Console.Write("MailTo : ");
           var mailto = Console.ReadLine();
           System.Console.Write("Subject : ");
           var subj = Console.ReadLine();
           System.Console.Write("Text : ");
           var txt = Console.ReadLine();      
                try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress(usermail);
                mail.To.Add(mailto);
                mail.Subject = subj;
                mail.Body = txt;
                SmtpServer.Port = 587;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new System.Net.NetworkCredential(usermail, pswrd);
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
               System.Console.WriteLine($"Mail sended to {mailto} Succesfully!");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.ToString());
            }              
        }     
    }
}
