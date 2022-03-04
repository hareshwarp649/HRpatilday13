using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExteNumGen7
{
    internal class MethodGeniNum<T> where T:IComparable
    {

        public T[] GenValue;

       
        public MethodGeniNum(T[] GenValue)
        {
            this.GenValue = GenValue;
        }

        public T[] Sort(T[] GenValue)
        {
            Array.Sort(GenValue);
            Array.Reverse(GenValue);
            return GenValue;
        }

        //Generic method to find max value (UC4)
        public T MaxValue(T[] GenValue)
        {
            var sortedValues = Sort(GenValue);
            return sortedValues.ElementAt(0);
        }

        //Generic method to print max value (UC5)
        public void PrintMaxValue()
        {
            var maxValue = MaxValue(this.GenValue);
            Console.WriteLine("Maximum value from given number is : {0}", maxValue);
        }

        //Extend the max method to take more then three parameters(UC4)
        public T ShowMax()
        {
            var maxValue = MaxValue(this.GenValue);
            return maxValue;
        }
    }
}
