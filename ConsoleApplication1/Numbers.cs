using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Numbers
    {
        static void Sum(int q, int t)
        {
            Console.WriteLine(q + t);
        }

        static void Difference(int q, int t)
        {
            Console.WriteLine(q - t);
        }

       public static int Product(int q, int t)
        {
            return q * t;
        }

        static void Main(string[] args)
        {
            int q = 7; int t = 8;
            Sum(q, t);
            Difference(q, t);
            int result = Product(q,t);
            Console.WriteLine(result);
        }
    }
}
