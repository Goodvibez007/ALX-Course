using ALX_Course.Assignments.M2.L2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ALX_Course.Assignments.M2.L2
{
    public class BookStorageApp
    {
        public static void Run()
        {
            //create book - console readline
            //classify book (BookStorageService)
            //present shelves
            
            var book = new Book();
            Console.WriteLine("Fill in the book data:");
            Console.Write("Author: ");
            book.Author = Console.ReadLine();
            Console.Write("Title: ");
            book.Title = Console.ReadLine();
            Console.Write("Genre: ");
           // book.Genre = (BookGenre)Int32.Parse(Console.ReadLine());
            Console.Write("Description: ");
            book.Description = Console.ReadLine();
            Console.Write("Quantity: ");
            book.Quantity = Int32.Parse(Console.ReadLine());                        
        }
    }
}
