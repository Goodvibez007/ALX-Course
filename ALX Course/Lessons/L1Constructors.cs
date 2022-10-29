using ALX_Course.Lessons.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALX_Course.Lessons
{
    public class L1Constructors
    {
        public static void Test()
        {
            var spider = new Spider();
            spider.Color = "black";
            spider.Species = "Black Widow";
            spider.IsVenomous = true;
            spider.Sex = "female";

            var redSpider = new Spider("red", "tarantula", false, "male");

            var blueSpider = new Spider("blue", "Goliath");
        }
    }
}
