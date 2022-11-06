using ALXCourseHomework.MaterialAssignments.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourseHomework.MaterialAssignments
{
    public class MaterialAssignmentsTest
    {
        public static void Run()
        {
            var person = new Basics();
            person.Name = "Michal";
            person.Surname = "Nycz";
            person.Age = 38;
            person.Height = 1.87;
            person.Weight = 93;
            person.Sex = "Male";

            person.Present1();
            person.Present2();
            
            Console.WriteLine("--------------------------");


            var day = new Day(12, Months.NOVEMBER, WeekDays.SATURDAY, 2022);
            day.WhatDayItIs();
        }
    }
}
