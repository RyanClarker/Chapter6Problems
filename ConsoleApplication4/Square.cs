using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Square
    {
        public static void Square(int i)
        {
            i * i;
        }
        static void Main(string[] args)
        {
            int i;
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(i);
            Square(i);
        }
    }
}
