﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourseHomework.MaterialAssignments
{
    public class Basics
    {
        public string Name;
        public string Surname;
        public int Age;
        public double Height;
        public double Weight;
        public string Sex;

        public void Present1()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Name:    \t" + Name);
            Console.WriteLine("Surname: \t" + Surname);
            Console.WriteLine($"Age:    \t{Age} years");
            Console.WriteLine($"Height: \t{Height} m");
            Console.WriteLine($"Weight: \t{Weight} kg");
            Console.WriteLine("Sex:     \t" + Sex);
        }

        public void Present2()
        {
            double cmHeight = Height*100;

            Console.WriteLine("--------------------------");
            Console.WriteLine("Name:    \t" + Name);
            Console.WriteLine("Surname: \t" + Surname);
            Console.WriteLine($"Age:    \t{Age} years");
            Console.WriteLine($"Height: \t{(int)cmHeight} cm");
            Console.WriteLine($"Weight: \t{Weight} kg");
            Console.WriteLine("Sex:     \t" + Sex);
        }

    }
}
