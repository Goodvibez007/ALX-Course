using ALX_Course.Assignments.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALX_Course.Assignments
{
    public class AssignmentsDemo
    {
        public static void Run()
        {
            var tea1 = new Tea();
            tea1.Type = "green";
            tea1.IsItHot = true;
            tea1.IsItGood = true;

            tea1.ShowMeYourTea();
        }
    }
}
