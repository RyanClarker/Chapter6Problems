using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Exponent
    {
        public static void Squared(int input)
        {
            Console.WriteLine(input * input);
        }

        public static void Cubed(int input)
        {
            Console.WriteLine(input * input * input);
        }
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            Squared(input);
            Cubed(input);
        }
    }
}
