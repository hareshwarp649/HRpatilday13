using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumGen4
{
    internal class MaxNumRefac1
    {

        public static T RefacMaxNum<T>(T Value1, T Value2, T Value3) where T : IComparable
        {
            if (Value1.CompareTo(Value2) >= 0 && Value1.CompareTo(Value3) >= 0)
            {
                return Value1;
            }
            if (Value2.CompareTo(Value3) >= 0 && Value2.CompareTo(Value1) >= 0)
            {
                return Value2;
            }
            if (Value3.CompareTo(Value1) >= 0 && Value3.CompareTo(Value2) >= 0)
            {
                return Value3;
            }
            return default;
        }
    }
}
