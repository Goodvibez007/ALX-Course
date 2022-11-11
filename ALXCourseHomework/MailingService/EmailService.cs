using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourseHomework.MailingService
{
    public class EmailService
    {
        public void SendEmail(Email email)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("The email has been sent");
            Console.WriteLine($"From: {email.From}");
            Console.WriteLine($"To: {email.To}");
            Console.WriteLine($"Subject: {email.Subject}");
            Console.WriteLine($"Message: {email.Message}");
        }
    }
}
