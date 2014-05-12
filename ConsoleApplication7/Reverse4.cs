using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication7
{
    class Reverse4
    {
        public static void Reverse(ref int a, ref int b, ref int c, ref int d)
        {
            int temp = a; int temp2 = b;
            a = d;
            b = c;
            c = temp2;
            d = temp; 
        }
        static void Main(string[] args)
        {
            int a = 1, b = 2, c = 3, d = 4;
            Reverse(ref a, ref b, ref c, ref d);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}
