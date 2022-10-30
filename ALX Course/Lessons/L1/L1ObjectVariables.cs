using ALX_Course.Lessons.L1.Classes;
using System;

namespace ALX_Course.Lessons.L1
{
    public class L1ObjectVariables
    {
        public static void Run1()
        {
            Console.WriteLine("Variables");
            Dog dog1 = new Dog();
            dog1.Jump();
            dog1.Bark();
            dog1.Name = "Burek";
            dog1.Race = "Golden Retriever";
            dog1.Age = 2;
            Console.WriteLine("Attention, here is dog " + dog1.Name);
            Console.WriteLine("Race: " + dog1.Race);
            Console.WriteLine("Age: " + dog1.Age);

            Dog.Eat();
        }

        public static void Run2()
        {
            Dog dogAzor = new Dog();
            dogAzor.Race = "Labrador";
            dogAzor.Age = 5;
            dogAzor.Name = "Azor";
            dogAzor.Goodboy = true;
            dogAzor.Present();
            dogAzor.Bark();
            dogAzor.Jump();
            DogOffspringStats offspring = dogAzor.Breed();
            Console.WriteLine("Number of female pups: " + offspring.NumberOfFemalePups);
            Console.WriteLine("Number of male pups: " + dogAzor.Breed().NumberOfMalePups);
            Dog.Eat();
            Console.WriteLine("Dog adds 2 and 3: " + dogAzor.Add(2, 3));
            dogAzor.GrowOlder(2);
            Console.WriteLine("Age after getting older by 2 years: " + dogAzor.Age);
        }

        public static void WriteSth()
        {
            Console.WriteLine("Something");
        }
    }
}
