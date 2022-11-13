using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALX_Course.Lessons.M2.L2.Interfaces
{
    public interface IHello
    {
        void SayHello();
        void SayHello(string name);
        void SayGoodMorning();
        void SayGoodMorning(string name);
    }
}
