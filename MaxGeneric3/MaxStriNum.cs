using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxStriGen3
{
    internal class MaxStriNum
    {
        public static int MaxInt1(int Value1, int Value2, int Value3)
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

        public static float MaxFloNum2(float Value1, float Value2, float Value3)
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
        public static string MaxStriNum3(string Value1, string Value2, string Value3)
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