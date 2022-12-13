using System;

namespace UC_6_PrintArray
{
    public class Program
    {
        public static void ToPrint(int[] inputArray)
        {
            foreach(int element in inputArray)
            {
                Console.WriteLine(element); 
            }
            Console.WriteLine("--------------------");
        }
        public static void ToPrint(double[] inputArray)
        {
            foreach (double element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("--------------------");
        }
        public static void ToPrint(char[] inputArray)
        {
            foreach (int element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("--------------------");
        }
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 5, 8, 10 };
            double[] doubleArray = { 1.2, 2.5, 3.8, 5.25 };
            char[] charArray = {'A', 'B', 'T', 'p' };
            Program.ToPrint(intArray);
            Program.ToPrint(doubleArray);
            Program.ToPrint(charArray);

        }
    }
}
