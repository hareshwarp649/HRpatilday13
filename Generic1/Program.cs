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
            int firstValue = int.Parse(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            int secondValue = int.Parse(Console.ReadLine());
            Console.Write("Enter Third Number : ");
            int thirdValue = int.Parse(Console.ReadLine());
            int resultNum = GenericMax1.MaxIntNumThree(firstValue, secondValue, thirdValue);
            Console.WriteLine("{0} is maximum value from first: {1} second: {2} third: {3}", resultNum, firstValue, secondValue, thirdValue);
            Console.ReadLine();


            //int[] intArray = { 34, 23, 40, 36 };
            //CompareMethod<int> resIntNum = new CompareMethod<int>(intArray);
            //resIntNum.PrintMaxValue();
            //Console.ReadLine();
        }
    }
}
