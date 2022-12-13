using System;

namespace UC_1_three_Integers_find_Maxium
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum values after checking condition are: ");
            int OutputInt = MaximumNumberCheck.MaxIntegerNumCheck(10, 50, 100);
            Console.WriteLine(OutputInt);
        }
    }
}
