using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Reverse3
    {
        public static void Reverse(ref int thirdInt, ref int firstInt, ref int secondInt)
        {
            int temp = firstInt;

            firstInt = thirdInt;
            thirdInt = temp;

            //firstInt = firstInt ^ thirdInt;
            //thirdInt = firstInt ^ thirdInt;
            //firstInt =  firstInt ^ thirdInt;
            
        }
        static void Main(string[] args)
        {
            int firstInt = 1; int secondInt = 20; int thirdInt = 30;
            Console.WriteLine("{0} and {1} and {2}",firstInt, secondInt, thirdInt);
            Reverse(ref thirdInt,ref firstInt, ref secondInt );

            Console.WriteLine(firstInt);
            Console.WriteLine(secondInt);
            Console.WriteLine(thirdInt);
             

        }
    }
}
