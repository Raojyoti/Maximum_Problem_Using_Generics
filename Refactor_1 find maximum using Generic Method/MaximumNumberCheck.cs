using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Refactor_1_find_maximum_using_Generic_Method
{
    public class MaximumNumberCheck<T> where T : IComparable
    {
        public T firstValue, secondValue, thirdValue;
        public MaximumNumberCheck(T firstValue, T secondValue, T thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }
        public static T MaxIntegerNumCheck(T firstValue, T secondValue, T thirdValue)
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
        public static T MaxFloatNumCheck(T firstValue, T secondValue, T thirdValue)
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
        public static T MaxStringNumCheck(T firstValue, T secondValue, T thirdValue)
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
            T max = MaximumNumberCheck<T>.MaxIntegerNumCheck(this.firstValue, this.secondValue, this.thirdValue);
            return max;
        }
        public T MaxFloatMethod()
        {
            T max = MaximumNumberCheck<T>.MaxFloatNumCheck(this.firstValue, this.secondValue, this.thirdValue);
            return max;
        }
        public T MaxStringMethod()
        {
            T max = MaximumNumberCheck<T>.MaxStringNumCheck(this.firstValue, this.secondValue, this.thirdValue);
            return max;
        }
    } 
}