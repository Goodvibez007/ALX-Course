using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALX_Course.Lessons.M2.L1
{
    public class L1Loops
    {
        public static void RunForeach()
        {
            List<string> names = new List<string>();
            names.Add("Adrian");
            names.Add("Mateusz");
            names.Add("Monika");
            names.Add("Magda");
            names.Add("Adrzej");
            
            foreach (string name in names)
            {
                Console.WriteLine(name.ToLower() + " kursant.");
                Console.WriteLine(name);
            }
        }

        public static void RunFor()
        {
            int[] numbers = new int[12] { 1, 2, 3, 4, 5, 6, 7, 3, 4, 5, 66, 5 };

            for(int i = 0; i< numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine();

            for (int i = numbers.Length -1; i>=0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine();
        }

        public static void RunWhile()
        {
            char c = 'q';
            while(c != 'n')
            {
                Console.WriteLine(" still in the loop!");
                Console.Write("Write a character: ");
                c = Console.ReadKey().KeyChar;
            }
            Console.WriteLine("Outside the loop.");

            string numberFromKeyboard = "0";
            while (Int32.Parse(numberFromKeyboard) < 100000)
            {
                Console.WriteLine(" still in the loop!");
                Console.Write("Write a number: ");
                numberFromKeyboard = Console.ReadLine();
                Console.WriteLine();
            }
            Console.WriteLine("Outside the loop.");
        }

        public static void RunDoWhile()
        {
            Console.Write("Write a character: ");
            var c = Console.ReadKey().KeyChar;
            Console.WriteLine();
            do
            {
                Console.WriteLine("still in the loop!");
                Console.Write("Write a character: ");
                c = Console.ReadKey().KeyChar;
            } while (c != 'n');
            Console.WriteLine("Outside the loop.");
        }

        public static void RunWhile2()
        {
            int[] numbers = new int[12] { 1, 2, 3, 4, 5, 6, 7, 3, 4, 5, 66, 5 };

            int iterator = 0;

            while (iterator < numbers.Length)
            {
                Console.Write(numbers[iterator++]);
            }
            Console.WriteLine();
        }

/*        public static void RunWhileInfinite()
        {
            var rnd = new Random();
        }*/
    }
}
