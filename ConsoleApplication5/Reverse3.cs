using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Reverse3
    {
        public static void Reverse(ref int firstInt, ref int thirdInt)
    {
        firstInt = thirdInt;
        thirdInt = firstInt;
    }
        static void Main(string[] args)
        {
            int firstInt = 1; int secondInt = 2; int thirdInt = 3;
            Console.WriteLine("{0} and {1} and {2}",firstInt, secondInt, thirdInt);
            Reverse(ref thirdInt,ref firstInt );

            Console.WriteLine(firstInt);
            Console.WriteLine(secondInt);
            Console.WriteLine(thirdInt);
             

        }
    }
}
