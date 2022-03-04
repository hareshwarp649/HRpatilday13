using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumGen2
{
    internal class MaxFloGene
    {

        public static int MaxNum2(int Value1, int Value2, int Value3)
        {
            if (Value1.CompareTo(Value2) >= 0 && Value1.CompareTo(Value3) >= 0)
            {
                return Value1;
            }
            else if (Value2.CompareTo(Value1) >= 0 && Value2.CompareTo(Value3) >= 0)
            {
                return Value2;
            }
            else if (Value3.CompareTo(Value1) >= 0 && Value3.CompareTo(Value2) >= 0)
            {
                return Value3;
            }
            return default;
        }

        public static float FloMaxNum3(float Value1, float Value2, float Value3)
        {
            if (Value1.CompareTo(Value2) >= 0 && Value1.CompareTo(Value3) >= 0)
            {
                return Value1;
            }
            else if (Value2.CompareTo(Value1) >= 0 && Value2.CompareTo(Value3) >= 0)
            {
                return Value2;
            }
            else if (Value3.CompareTo(Value1) >= 0 && Value3.CompareTo(Value2) >= 0)
            {
                return Value3;
            }
            return default;
        }
    }
}