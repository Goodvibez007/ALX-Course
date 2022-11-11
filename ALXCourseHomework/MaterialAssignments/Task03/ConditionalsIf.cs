using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourseHomework.MaterialAssignments.Task03
{
    public class ConditionalsIf
    {
        public double Price;
        public double FinalPrice;
        public double Discount;

        public void DiscountIf()
        {
            Console.Write("Original price:\t\t");
            var Price = Double.Parse(Console.ReadLine());

            if (Price > 100)
            {
                FinalPrice = Price - (Price * 0.15);
                Console.WriteLine("You received discount:\t15%");
                Console.WriteLine($"Final price:\t\t{FinalPrice}");
            }
            else if ((Price <= 100) & (Price > 60))
            {
                FinalPrice = Price - (Price * 0.05);
                Console.WriteLine("You received discount:\t5%");
                Console.WriteLine($"Final price:\t\t{FinalPrice}");
            }
            else if ((Price <= 60) & (Price >= 0))
            {
                FinalPrice = Price;
                Console.WriteLine("There is no discount for you");
                Console.WriteLine($"Final price:\t\t{FinalPrice}");
            }
            else
            {
                Console.WriteLine("The price is incorrect");
            }
        }

        public void DiscountSwitch()
        {
            Console.Write("Original price:\t\t");
            var Price = Double.Parse(Console.ReadLine());
            
            switch(Price)
            {
                case < 0:
                    Console.WriteLine("The price is incorrect");
                    break;
                case <= 60:
                    FinalPrice = Price;
                    Console.WriteLine("There is no discount for you");
                    Console.WriteLine($"Final price:\t\t{FinalPrice}");
                    break;
                case <= 100:
                    FinalPrice = Price - (Price * 0.05);
                    Console.WriteLine("You received discount:\t5%");
                    Console.WriteLine($"Final price:\t\t{FinalPrice}");
                    break;
                case > 100:
                    FinalPrice = Price - (Price * 0.15);
                    Console.WriteLine("You received discount:\t15%");
                    Console.WriteLine($"Final price:\t\t{FinalPrice}");
                    break;
            }
        }
    }
}
