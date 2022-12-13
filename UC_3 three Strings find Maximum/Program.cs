using System;

namespace UC_3_three_Strings_find_Maximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string OutputString = MaximumStringCheck.MaxStringValueCheck("Orange", "Peach", "Banana");
            Console.WriteLine("Maximum string value is: {0}",OutputString);
        }
    }
}
