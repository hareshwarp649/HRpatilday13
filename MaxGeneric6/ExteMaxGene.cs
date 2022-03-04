using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxGenericNum6
{
    internal class ExteMaxGene<T> where T:IComparable 
    {

        public T[] GenValue;

        public ExteMaxGene(T[] GenValue)
        {
            this.GenValue = GenValue;
        }

       
        public T[] Sort(T[] GenValue)
        {
            Array.Sort(GenValue);
            Array.Reverse(GenValue);
            return GenValue;
        }

        
        public T MaxValue(T[] GenValue)
        {
            var sortedValues = Sort(GenValue);
            return sortedValues.ElementAt(0);
        }

       
        public T ShowMax()
        {
            var maxValue = MaxValue(this.GenValue);
            return maxValue;
        }
    }
}
