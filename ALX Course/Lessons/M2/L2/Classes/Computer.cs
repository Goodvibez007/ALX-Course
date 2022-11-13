using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALX_Course.Lessons.M2.L2.Classes
{
    public class Computer
    {
        private string _brand;
        private double _procesorFrequency;

        public string Brand
        {
            get
            {
                Console.WriteLine("Getting computer brand.");
                return _brand;
            }
            set
            {
                _brand = value;
            }
        }

        public string Name { get; set; }

        public double ProcessorFrequency
        {
            get
            {
                Console.WriteLine("Getting processor frequency [GHz]...");
                return _procesorFrequency;
            }
            set
            {
                if (value > 0 && value < 4)
                {
                    Console.WriteLine($"Setting computer's processor clock frequency as {value} [GHz].");
                    _procesorFrequency = value;
                }                    
                else
                {
                    Console.WriteLine("Invalid processor frequency value!");                    
                }                    
            }
        }  
        
        public int NumberOfCores { get; set; }
        public int StorageSpace { get; }
        public readonly string GraphicalCardModel;
    }
}
