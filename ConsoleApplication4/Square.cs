using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Square
    {
        public static void Squared(ref int tree)
        {
            tree = tree * tree;
            Console.WriteLine(tree); ;
        }
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Write a number: ");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(i);
            Squared(ref i);
            Console.WriteLine(i);
        }
    }
}
