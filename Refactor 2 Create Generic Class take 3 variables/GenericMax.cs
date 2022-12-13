using System;
using System.Collections.Generic;
using System.Text;

namespace Refactor_2_Create_Generic_Class_take_3_variables
{
    public class GenericMax<T> where T : IComparable
    {
        public T firstValue, secondValue, thirdValue;
        public GenericMax(T firstValue, T secondValue, T thirdValue) 
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }
        public static T MaxIntValue(T firstValue, T secondValue, T thirdValue) 
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            throw new Exception("firstValue, secondValue, thirdValue are same"); 
        }
        public T MaxMethod()
        {
           T max =GenericMax<T>.MaxIntValue(this.firstValue, this.secondValue, this.thirdValue);
            return max;
        }
    }
}
