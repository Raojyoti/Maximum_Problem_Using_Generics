using System;

namespace Extend_the_max_using_Generic_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 105, 2159, 1125, 789, 998 };
            GenericMax<int> obj = new GenericMax<int>(arr);
            obj.PrintMaxValue();
        }
    }
}
