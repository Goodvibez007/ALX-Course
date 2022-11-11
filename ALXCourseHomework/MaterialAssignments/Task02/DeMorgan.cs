using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourseHomework.MaterialAssignments.Task02
{
    public class DeMorgan
    {
        public bool P;
        public bool Q;
        public bool DeMorganResult;

        public DeMorgan(bool p, bool q)
        {
            P = p;
            Q = q;
        }

        public void DeMorganOperation()
        {
            DeMorganResult = !(P & Q) == (!P | !Q);
            Console.WriteLine($"De Morgan law for P={P} \tand Q={Q} \tequals: {DeMorganResult}");
        }
    }
}
