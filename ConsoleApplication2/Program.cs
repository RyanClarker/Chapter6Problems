using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Monogram
    {
        public static void DisplayMonogram(char a, char b, char c)
        {
            Console.WriteLine("** " + a + ". " + b + ". " + c + ". **");

        }

        static void Main()
        {
            char a = 'R'; char b = 'J'; char c = 'C'; char d = 'T'; char e = 'J'; char f = 'C';
            DisplayMonogram(a, b, c);
            DisplayMonogram(d, e, f);
        }
    }
}
