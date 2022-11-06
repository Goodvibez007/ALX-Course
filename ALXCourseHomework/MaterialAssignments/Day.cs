using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourseHomework.MaterialAssignments.Enums
{
    public class Day
    {
        public int DayOfTheMonth;
        public Months Month;
        public WeekDays WeekDay;
        public int Year;

        public Day(int dayOfTheMonth, Months month, WeekDays weekDay, int year)
        {
            DayOfTheMonth = dayOfTheMonth;
            Month = month;
            WeekDay = weekDay;
            Year = year;
        }

        public void WhatDayItIs()
        {
            Console.WriteLine($"It is {WeekDay} today");
            Console.WriteLine($"It is {DayOfTheMonth} day of {Month}");
            Console.WriteLine($"Year: {Year}");
        }
    }
}
