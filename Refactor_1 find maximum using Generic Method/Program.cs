using System;

namespace Refactor_1_find_maximum_using_Generic_Method
{
    public class Program
    {
        static void Main(string[] args)
        {
            MaximumNumberCheck<int> obj = new MaximumNumberCheck<int>(10, 50, 30);
            int result = obj.MaxMethod();
            Console.WriteLine("Maximum integer value is: {0} ", result);
            Console.WriteLine("--------------------------------------------------");
            MaximumNumberCheck<float> obj1 = new MaximumNumberCheck<float>(100.25f, 20.65f, 30.358f);
            float result1 = obj1.MaxFloatMethod();
            Console.WriteLine("Maximum float value is: {0} ", result1);
            Console.WriteLine("--------------------------------------------------");
            MaximumNumberCheck<string> obj2 = new MaximumNumberCheck<string>("Orange", "Banana", "Peach");
            string result2= obj2.MaxStringMethod();
            Console.WriteLine("Maximum string value is: {0} ", result2);
            Console.WriteLine("--------------------------------------------------");
           
        }
    }
}
