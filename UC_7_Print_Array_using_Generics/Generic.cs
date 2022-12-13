using System;
using System.Collections.Generic;
using System.Text;

namespace UC_7_Print_Array_using_Generics
{
    public class Generic
    {
        public static void ToPrint<T>(T[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("--------------------");
        }
       
    }
}
