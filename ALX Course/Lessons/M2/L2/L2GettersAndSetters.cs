using ALX_Course.Lessons.M2.L2.Classes;
using Microsoft.VisualBasic;

namespace ALX_Course.Lessons.M2.L2
{
    public class L2GettersAndSetters
    {
        public static void Run()
        {
            var computer = new Computer();
            computer.Brand = "Dell";
            computer.ProcessorFrequency = 3.2;
            computer.NumberOfCores = 3;
            computer.Name = "My Pc";
            PresentComputer(computer);
            Console.WriteLine($"\n");

            var computer1 = new Computer();
            computer1.Brand = "Asus";
            computer1.ProcessorFrequency = 10;
            computer1.NumberOfCores = 12;
            computer1.Name = "My Pc 2";
            PresentComputer(computer1);
        }

        private static void PresentComputer(Computer computer)
        {
            Console.WriteLine($"Name: {computer.Name}");
            Console.WriteLine($"Processor frequency: {computer.ProcessorFrequency}");
            Console.WriteLine($"Number of cores: {computer.NumberOfCores}");
            Console.WriteLine($"Brand: {computer.Brand}");
        }
    }
}
