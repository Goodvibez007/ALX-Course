using System;

namespace ALX_Course.Lessons.M1.L1
{
    public class L1Strings
    {
        public static void Run()
        {
            string name = "Mateusz";
            Console.WriteLine(name);
            name = "Ala";
            Console.WriteLine(name);
            name = name + " ma kota";
            Console.WriteLine(name);

            ExpandString(name, "hello, ");
            Console.WriteLine(name);

            ExpandString(name, "world");
            Console.WriteLine(name);
        }
        public static void ExpandString(string word, string extention)
        {
            word = word + extention;
        }

        public static void ConcatenationTest()
        {
            string word1 = "Ala ma";
            string word2 = "koty dwa";

            string concat1 = word1 + word2;
            Console.WriteLine(concat1);

            string concat2 = word1 + " " + word2;
            Console.WriteLine(concat2);

            string concat3 = $"{word1} {word2} i dobrze się ma";
            Console.WriteLine(concat3);
        }
    }
}
