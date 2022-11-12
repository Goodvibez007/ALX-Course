using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALX_Course.Lessons.M2.L1
{
    public class L1Lists
    {
        public static void Run()
        {
            List<string> shoppingList = new List<string>();
            shoppingList.Add("milk");
            ShowList(shoppingList);
            shoppingList.Add("cheese");
            ShowList(shoppingList);
            shoppingList.Add("butter");
            ShowList(shoppingList);
            shoppingList.Add("bread");
            ShowList(shoppingList);
            shoppingList.Add("tomato sauce");
            ShowList(shoppingList);
            shoppingList.Add("apple juice");
            ShowList(shoppingList);

            Console.WriteLine(shoppingList[2]);
            Console.WriteLine();
            shoppingList[3] = "tea";
            ShowList(shoppingList);

/*            shoppingList.Remove("apple juice");
            ShowList(shoppingList);
            shoppingList.Remove("butter");
            ShowList(shoppingList);
            shoppingList.Remove("bread");
            ShowList(shoppingList);
            shoppingList.Remove("milk");
            ShowList(shoppingList);*/
        }

        public static void ShowList(List<string> list)
        {
            Console.WriteLine($"Number of elements: {list.Count}");
            //Console.WriteLine($"Number of elements: {list.Count()}"); //also good
            foreach(string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
