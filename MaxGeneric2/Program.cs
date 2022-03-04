using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumGen2
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
                
                Console.WriteLine("Welcome To The Finding Maximum Num Using Generic");

                while (true)
                {
                Console.WriteLine("1: Find Max Of Three Int Number" + "\n2: Find Max Of Three Float Number" + "\n3: Exit");

                    Console.Write("Enter A Choice From Above : ");
                    int select = int.Parse(Console.ReadLine());
                    switch (select)
                    {
                        case 1:
                            
                            int val1 = 99, val2 = 44, val3 = 49;
                            int resIntNum = MaxFloGene.MaxNum2(val1,val2,val3);
                            Console.WriteLine("{0} is maximum value from first: {1} second: {2} third: {3}", resIntNum, val1,val2,val3);
                            Console.ReadLine();
                            break;
                        case 2:
                            
                            float fval1 = 25.2f, fval2 = 5.4f, fval3 = 24.2f;
                            float resFtNum = MaxFloGene.FloMaxNum3(fval1,fval2,fval3);
                            Console.WriteLine("{0} is maximum value from first: {1} second: {2} third: {3}", resFtNum,fval1,fval2,fval3);
                            Console.ReadLine();
                            break;
                        case 3:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Choose a right option");
                            break;
                    }
                }
        }
    }
}
