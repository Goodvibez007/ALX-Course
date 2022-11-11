using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourseHomework.MaterialAssignments.Task03
{
    public class MaterialAssignmentsTest03
    {
        public static void Run()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Material Assignment - Task 3");
            Console.WriteLine("----------------------------");

            var shopping = new ConditionalsIf();
            shopping.DiscountIf();

            Console.WriteLine("----------------------------");

            shopping.DiscountSwitch();
        }
    }
}
