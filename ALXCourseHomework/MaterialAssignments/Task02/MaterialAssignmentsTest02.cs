using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourseHomework.MaterialAssignments.Task02
{
    public class MaterialAssignmentsTest02
    {
        public static void Run()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Material Assignment - Task 2");
            Console.WriteLine("----------------------------");

            var operation = new Operators(3, 6, 15);
            operation.Math01();
            operation.Math02();

            Console.WriteLine("----------------------------");

            var deMorgan11 = new DeMorgan(true, true);
            deMorgan11.DeMorganOperation();
            var deMorgan10 = new DeMorgan(true, false);
            deMorgan10.DeMorganOperation();
            var deMorgan01 = new DeMorgan(false, true);
            deMorgan01.DeMorganOperation();
            var deMorgan00 = new DeMorgan(false, false);
            deMorgan00.DeMorganOperation();
        }
    }
}
