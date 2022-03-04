using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Welcome to the finding maximum number program using generics");
           
            Console.Write("Enter First Number : ");
            int Value1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            int Value2 = int.Parse(Console.ReadLine());
            Console.Write("Enter Third Number : ");
            int Value3 = int.Parse(Console.ReadLine());
            int resultNum = GenericMax1.MaxIntNumThree(Value1, Value2, Value3);
            Console.WriteLine("{0} is maximum value from first: {1} second: {2} third: {3}", resultNum, Value1, Value2, Value3);
            Console.ReadLine();


            //int[] intArray = { 34, 23, 40, 36 };
            //CompareMethod<int> resIntNum = new CompareMethod<int>(intArray);
            //resIntNum.PrintMaxValue();
            //Console.ReadLine();
        }
    }
}
