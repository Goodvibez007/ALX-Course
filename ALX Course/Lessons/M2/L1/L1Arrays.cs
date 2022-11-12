using ALX_Course.Lessons.M1.L1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ALX_Course.Lessons.M2.L1
{
    public class L1Arrays
    {
        public static void Run1()
        {
            int[] intArray = { 0, 1, 2, 3, 4 };
            int[] intArray2 = new int[5];

            ShowArray(intArray);
            Console.WriteLine("----------------------");

            ShowArray(intArray2);
            Console.WriteLine("----------------------");

            intArray2[2] = 2;
            ShowArray(intArray2);
            Console.WriteLine("----------------------");

            int[] indexArray3 = new int[3] { 1, 2, 3 };
            ShowArray(indexArray3);

            int[,] intMatrix = new int[3, 2];
            int[,] intMatrix1 = { { 1, 2 }, { 3, 4 } };

            int[][] intMultiArray = new int[3][];
            intMultiArray[0] = new int[7];
            intMultiArray[1] = new int[80];
            intMultiArray[2] = new int[12];



            Dog[] dogs = new Dog[3];
            dogs[0] = new Dog();
        }

        public static void Run2()
        {
            string[] shoppingArray = new string[6];
            shoppingArray[0] = "milk";
            ShowArray(shoppingArray);
            shoppingArray[1] = "butter";
            ShowArray(shoppingArray);
            shoppingArray[5] = "apple juice";
            ShowArray(shoppingArray);
        }

        public static void ShowArray(string[] array)
        {
            Console.WriteLine($"Number of elements: {array.Length}");
            foreach(string item in array)
            {
                Console.WriteLine(item);
            }
        }

        public static void ShowArray(int[] array)
        {
            foreach(int i in array)
            {
                Console.WriteLine(i);
            }
        }



        public static void Show2DArray(int[,] matrix)
        {
            for (int iterator=0; iterator<matrix.GetLength(0); iterator++)
            {
                for(int iterator1 = 0; iterator1 < matrix.GetLength(1); iterator1++)
                {
                    Console.WriteLine($"{matrix[iterator,iterator1]}");
                }
                Console.WriteLine();
            }
        }
    }
}
