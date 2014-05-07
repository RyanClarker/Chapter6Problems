using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Monogram
    {
        public static void DisplayMonogram(char a, char b, char c, char d, char e, char f)
        {
            Console.WriteLine("** " + a + ". " + b + ". " + c + ". **");
            Console.WriteLine("** " + d + ". " + e + ". " + f + ". **");
        }

        static void Main()
        {
            char a = 'R'; char b = 'J'; char c = 'C'; char d = 'T'; char e = 'J'; char f = 'C';
            DisplayMonogram(a, b, c, d, e, f);

        }
    }
}
