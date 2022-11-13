using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALX_Course.Assignments.M2.L1
{
    public class Employee
    {
        public string Name;
        public double Salary;
        public int Experience;

        public Employee(string name, double salary, int experience)
        {
            Name = name;
            Salary = salary;
            Experience = experience;
        }
    }
}
