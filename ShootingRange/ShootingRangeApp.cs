using ShootingRange;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourseHomework.ShootingRange
{
    public class ShootingRangeApp
    {
        public static void Run()
        {
            var customer = new Customer();
            var settings = new Settings();
            var shootingRangeServices = new ShootingRangeServices();

            shootingRangeServices.EntryMenu(customer, settings);
           
            Console.WriteLine();
        }
    }
}
