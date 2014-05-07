using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InchesToFeet
{
    class InchesToFeet
    {
        public static void ToFeet(int inches)
        {
            Console.WriteLine("{0} feet and {1} inches", inches / 12, inches % 12);
        }

        public static void Yards(int inches)
        {
            Console.WriteLine("{0} yards and {1} feet and {2} inches", inches / 12 / 3, inches / 12 % 3, inches % 12);
 
        }
        public static void Main()
        {
            int inches = 79;
            ToFeet(inches);
            Yards(inches);
        }
    }
}
