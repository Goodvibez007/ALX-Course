using CommonFunctionalities.Services;

namespace ALX_Course.Lessons.M2.L2
{
    internal class L2Encapsulation
    {
        public static void Run()
        {
            var taxService = new TaxService();
            var income = 5000;
            var tax = taxService.CalculateTax(income);

            Present(tax, income);
        }

        private static void Present(double tax, double income)
        {
            Console.WriteLine($"Income: {income}");
            Console.WriteLine($"Tax: {tax}");
            Console.WriteLine($"Netto: {income - tax}");
        }
    }
}
