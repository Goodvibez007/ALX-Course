using System;

namespace ALX_Course.Assignments.Classes
{
    public class Tea
    {
        public string Type;
        public bool IsItHot;
        public bool IsItGood;

        public void Drink()
        {
            Console.WriteLine("Yummy!");
        }

        public void Spill()
        {
            Console.WriteLine("Oh no!");
        }

        public void ShowMeYourTea()
        {
            Console.WriteLine($"You have a glass of {Type} tea");
            Console.WriteLine($"Is your tea hot? {IsItHot}");
            Console.WriteLine($"Is your tea tasty? {IsItGood}");
        }
    }
}
