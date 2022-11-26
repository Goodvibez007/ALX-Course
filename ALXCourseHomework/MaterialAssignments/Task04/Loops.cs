namespace ALXCourseHomework.MaterialAssignments.Task04
{
    public class Loops
    {
        public void CountStorageValue(Product product)
        {
            double storageValueNetto = Math.Round(product.PriceNetto * product.QuantityInBox * product.BoxCount, 2);
            double storageValueBrutto = Math.Round(product.PriceBrutto * product.QuantityInBox * product.BoxCount, 2);
            Console.WriteLine($"Storage value netto of product Id:  \t{product.Id} is \t{storageValueNetto} zł");
            Console.WriteLine($"Storage value brutto of product Id: \t{product.Id} is \t{storageValueBrutto} zł");
        }

        public void PriceTag(Product product)
        {
            Console.WriteLine();
            Console.WriteLine("Product price tag:");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine($"Product Id: \t\t\t{product.Id}");
            Console.WriteLine($"Price netto: \t\t\t{product.PriceNetto} zł");
            Console.WriteLine($"Tax: \t\t\t\t{product.Tax * 100} %");
            Console.WriteLine($"Price brutto: \t\t\t{product.PriceBrutto} zł");
            Console.WriteLine($"Price brutto for a box: \t{Math.Round(product.PriceBrutto * product.QuantityInBox, 2)} zł");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine();
        }

        public void Dividers()
        {
            Console.Write("Choose your number: ");
            int limit = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Your numbers dividers:\n");

            for (int i = 1; i <= limit; i++)
            {
                if (limit % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
