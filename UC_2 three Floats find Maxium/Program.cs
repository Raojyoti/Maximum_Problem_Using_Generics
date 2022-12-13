using System;

namespace UC_2_three_Floats_find_Maxium
{
    public class Program
    {
        static void Main(string[] args)
        {
            float OutputFloat = MaximumNumberCheck.MaxfloatNumCheck(101.25f, 5.52f, 81.30f);
            Console.WriteLine("Maximum float number is {0} ",OutputFloat);
        }
    }
}
