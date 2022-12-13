using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace UC_4__Extend_the_max_using_Sorting
{
    public class GenericMax<T> where T : IComparable
    {
        public T[] value;
        public GenericMax(T[] value) 
        {
            this.value = value;
        }
        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }
        public T MaxValue(params T[] values)
        {
            var sorted_values = Sort(values);
            return sorted_values[^1];
        }
        public T MaxMethod()
        {
            var max = MaxValue(this.value);
            return max;
        }
        public void PrintMaxValue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("Maximum value is " + max);
        }
    }
}
