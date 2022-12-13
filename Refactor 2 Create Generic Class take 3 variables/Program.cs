using System;

namespace Refactor_2_Create_Generic_Class_take_3_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericMax<int> obj = new GenericMax<int>(10, 50, 30);
            int result=obj.MaxMethod();
            Console.WriteLine("Maximum value is: {0} ",result);
            Console.WriteLine("--------------------------------");
        }
    }
}
