using ShootingRange;

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
