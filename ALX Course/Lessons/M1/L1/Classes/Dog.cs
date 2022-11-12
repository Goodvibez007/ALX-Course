using System;

namespace ALX_Course.Lessons.M1.L1.Classes
{
    public class Dog
    {
        public string Name;
        public int Age;
        public string Race;
        public bool Goodboy;

        public void Jump()
        {
            Console.WriteLine("Boing! Boing!");
        }

        public void Bark()
        {
            Console.WriteLine("Woof! Woof!");
        }

        public static void Eat()
        {
            Console.WriteLine("Yum! Yum!");
        }

        public int GetOlderAge()
        {
            return Age + 1;
        }

        public void GrowOlder(int numberOfYears)
        {
            Age = Age + numberOfYears;
        }

        public int Add(int x, int y)
        {
            return x + y;
        }

        public DogOffspringStats Breed()
        {
            DogOffspringStats offspring = new DogOffspringStats();
            offspring.NumberOfMalePups = 2;
            offspring.NumberOfFemalePups = 4;
            return offspring;
        }

        public void Present()
        {
            Console.WriteLine("Attention, here is dog " + Name);
            Console.WriteLine("Race: " + Race);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Is he a good boy?: " + Goodboy);
        }
    }
}
