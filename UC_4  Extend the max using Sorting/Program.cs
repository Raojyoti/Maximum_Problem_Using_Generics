using System;

namespace UC_4__Extend_the_max_using_Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 105, 2159, 1125, 789, 998 };
            GenericMax<int> obj = new GenericMax<int>(arr);
            obj.PrintMaxValue();
            Console.WriteLine("-------------------------------");
            float[] arr1 = { 105.25f, 25.9f, 350.29f, 78.925f, 998.8f };
            GenericMax<float> obj1 = new GenericMax<float>(arr1);
            obj1.PrintMaxValue();
            Console.WriteLine("-------------------------------");
            string[] arr2 = { "Mango", "Banana", "Orange", "Peach" };
            GenericMax<string> obj2 = new GenericMax<string>(arr2);
            obj.PrintMaxValue();
            Console.WriteLine("-------------------------------");
        }
    }
}
