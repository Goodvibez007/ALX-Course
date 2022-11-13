using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALX_Course.Assignments.M2.L1
{
    public class SeniorityServiceTest
    {
        public static void Run()
        {
            var employee1 = new Employee("Adam Adamski", 6000, 3);
            var employee2 = new Employee("Barbara Rabarbar", 9000, 7);
            var employee3 = new Employee("Krzysztof Krzysztofik", 3000, 1);
            var employee4 = new Employee("Zenon Ksenon", 5000, 2);
            var employee5 = new Employee("Natalia Batalia", 3500, 3);


            var seniorityService = new SeniorityService();

            seniorityService.ClassifySeniorityBySalary(employee1);
            seniorityService.ClassifySeniorityBySalary(employee2);
            seniorityService.ClassifySeniorityBySalary(employee3);
            seniorityService.ClassifySeniorityBySalary(employee4);
            seniorityService.ClassifySeniorityBySalary(employee5);

            Console.WriteLine("Employees classified by Salary:");
            Console.WriteLine("----------------------");
            Console.WriteLine("Juniors: ");
            PresentEmployees(seniorityService.JuniorEmployees);
            Console.WriteLine("----------------------");
            Console.WriteLine("Mids: ");
            PresentEmployees(seniorityService.MidEmployees);
            Console.WriteLine("----------------------");
            Console.WriteLine("Seniors: ");
            PresentEmployees(seniorityService.SeniorEmployees);
            Console.WriteLine("----------------------");

            seniorityService.ClearLists();

            seniorityService.ClassifySeniorityByExperience(employee1);
            seniorityService.ClassifySeniorityByExperience(employee2);
            seniorityService.ClassifySeniorityByExperience(employee3);
            seniorityService.ClassifySeniorityByExperience(employee4);
            seniorityService.ClassifySeniorityByExperience(employee5);

            Console.WriteLine("Employees classified by Experience:");
            Console.WriteLine("----------------------");
            Console.WriteLine("Juniors: ");
            PresentEmployees(seniorityService.JuniorEmployees);
            Console.WriteLine("----------------------");
            Console.WriteLine("Mids: ");
            PresentEmployees(seniorityService.MidEmployees);
            Console.WriteLine("----------------------");
            Console.WriteLine("Seniors: ");
            PresentEmployees(seniorityService.SeniorEmployees);
            Console.WriteLine("----------------------");
        }

        public static void PresentEmployees(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"Employee:{employee.Name}");
            }
        }
    }
}
