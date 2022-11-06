using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourseHomework.MailingService
{
    public class Email
    {
        public string From;
        public string To;
        public string Subject;
        public string Message;

        public void SendEmail()
        {
            Console.WriteLine("The email has been sent");
            Console.WriteLine($"From: {From}");
            Console.WriteLine($"To: {To}");
            Console.WriteLine($"Subject: {Subject}");
            Console.WriteLine($"Message: {Message}");
            Console.WriteLine("");
        }
    }
}
