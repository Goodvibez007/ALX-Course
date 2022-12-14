using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALX_Course.Lessons.M1.L1.Classes
{
    public class Spider
    {
        public string Color;
        public string Species;
        public bool IsVenomous;
        public string Sex;

        public Spider()
        {
        }

        public Spider(string color, string species)
        {
            Color = color;
            Species = species;
            IsVenomous = true;
            Sex = "female";
        }

        public Spider(string color, string species, bool isVenomous, string sex)
        {
            Color = color;
            Species = species;
            IsVenomous = isVenomous;
            Sex = sex;
        }

        public void Present()
        {
            Console.WriteLine($"Here is a new spider");
            Console.WriteLine($"Species: {Species}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Sex: {Sex}");
            Console.WriteLine($"Is venomous?: {IsVenomous}");
        }
    }
}
