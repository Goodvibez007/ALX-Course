using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALX_Course.Assignments.M2.L1
{
    public class SeniorityService
    {
        public List<Employee> JuniorEmployees;
        public List<Employee> MidEmployees;
        public List<Employee> SeniorEmployees;

        public SeniorityService()
        {
            JuniorEmployees = new List<Employee>();
            MidEmployees = new List<Employee>();
            SeniorEmployees = new List<Employee>();
        }

        public void ClassifySeniorityBySalary(Employee employee)
        {
            if (employee.Salary < 4000)
            {
                JuniorEmployees.Add(employee);
            }
            else if (employee.Salary >= 4000 & employee.Salary < 8000)
            {
                MidEmployees.Add(employee);
            }
            else
            {
                SeniorEmployees.Add(employee);
            }
        }

        public void ClassifySeniorityByExperience(Employee employee)
        {
            if (employee.Experience < 2)
            {
                JuniorEmployees.Add(employee);
            }
            else if (employee.Experience >= 2 & employee.Experience < 4)
            {
                MidEmployees.Add(employee);
            }
            else
            {
                SeniorEmployees.Add(employee);
            }
        }

        public void ClearLists()
        {
            JuniorEmployees.Clear();
            MidEmployees.Clear();
            SeniorEmployees.Clear();
        }
    }
}
