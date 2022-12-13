using System;

namespace UC_7_Print_Array_using_Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 5, 8, 10 };
            double[] doubleArray = { 1.2, 2.5, 3.8, 5.25 };
            char[] charArray = { 'A', 'B', 'T', 'K' };
            Generic.ToPrint<int>(intArray);
            Generic.ToPrint<double>(doubleArray);
            Generic.ToPrint<char>(charArray);
        }
    }
}
