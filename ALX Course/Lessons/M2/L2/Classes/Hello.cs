using ALX_Course.Lessons.M2.L2.Interfaces;

namespace ALX_Course.Lessons.M2.L2.Classes
{
    public class Hello : IHello
    {
        public void SayGoodMorning()
        {
            Console.WriteLine("Googmorning!");
        }

        public void SayGoodMorning(string name)
        {
            Console.WriteLine($"Googmorning {name}!");
        }

        public void SayHello()
        {
            Console.WriteLine("Hello!");
        }

        public void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }
    }
}
