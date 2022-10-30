using System;

namespace ALX_Course.Assignments.Classes
{
    public class Juice
    {
        public string Fruit;
        public bool IsItSweet;
        public int Quantity;

        public Juice(string fruit)
        {
            Fruit = fruit;
        }

        public Juice(string fruit, bool sweetness, int quatity)
        {
            Fruit = fruit;
            IsItSweet = sweetness;
            Quantity = quatity;
        }

        public void Drink()
        {
            Console.WriteLine("Yummy!");
        }

        public void CheckQuantity()
        {
            Console.Write($"There is {Quantity} ml of juice");
        }
    }
}
