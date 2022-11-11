using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourseHomework.MaterialAssignments.Task02
{
    public class Operators
    {
        public double A = 1;
        public double B = 1;
        public double C = 1;
        public double Result;
        public bool Check;
        
        public Operators(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public void Math01()
        {
            Result = (Math.Pow(A,B)/2)%C;
            Console.WriteLine($"A={A}");
            Console.WriteLine($"B={B}");
            Console.WriteLine($"C={C}");
            Console.WriteLine($"Math operation result is: {Result}");
        }
        
        public void Math02()
        {
            Check = Result + 5 > A;
            Console.WriteLine($"Operation result +5 is > than A={A}: {Check}");
        }
    }
}
