using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALX_Course.Lessons.M1.L2
{
    public class L2Conditionals
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            var number = Int32.Parse(Console.ReadLine()); 
            Console.Write("Enter first limit: ");
            var limit1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second limit: ");
            var limit2 = Int32.Parse(Console.ReadLine());
            CheckNumberWithinLimits(number, limit1, limit2);
        }

        private static void CheckIfNumberIsEven(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"The number {number} is an even number.");
            }
            else
            {
                Console.WriteLine($"The number {number} is an odd number.");
            }
        }

        private static void CheckNumberWithinLimits(int number, int limit1, int limit2)
        {
            if (number < limit1)
            {
                Console.WriteLine($"Number {number} is smaller than {limit1}");
            }
            else if (number > limit2)
            {
                Console.WriteLine($"Number {number} is greater than {limit1}");
            }
            else
            {
                Console.WriteLine($"Number {number} is equal to {limit1} or equal to {limit1} or somewhere in between");
            }
        }
    }
}
