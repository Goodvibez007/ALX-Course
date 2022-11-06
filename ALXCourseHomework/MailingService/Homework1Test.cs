using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourseHomework.MailingService
{
    internal class Homework1Test
    {
        public static void Run()
        {
            var email1 = new Email();
            email1.From = "You";
            email1.To = "anna@gmail.com";
            email1.Subject = "Hello";
            email1.Message = "Hi, How are you?";

            var email2 = new Email();
            email2.From = "You";
            email2.To = "ola@gmail.com";
            email2.Subject = "Hola";
            email2.Message = "Hola. Como estas?";

            var email3 = new Email();
            email3.From = "You";
            email3.To = "adam@gmail.com";
            email3.Subject = "Hej";
            email3.Message = "Hej. Co u Ciebie?";

            var email4 = new Email();
            email4.From = "You";
            email4.To = "henryk@gmail.com";
            email4.Subject = "Ciao";
            email4.Message = "Ciao. Come va?";

            var email5 = new Email();
            email5.From = "You";
            email5.To = "joanna@gmail.com";
            email5.Subject = "Hallo";
            email5.Message = "Hallo. Wie gehts?";

            //Email.SendEmail(email1);


        }

    }
}
