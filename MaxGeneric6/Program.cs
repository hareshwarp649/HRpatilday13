using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxGenericNum6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome To The Finding Maximum Num Using Generic");

            while (true)
            {
                Console.WriteLine("1: Find Max Of Three Int Number" + "\n2: Find Max Of Three Float Number" + "\n3: Find the max of three string number" + "\n4: Exit");
                             
                Console.Write("Enter A Choice From Above : ");
                int select = int.Parse(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        
                        int[] intArray = { 44, 69, 15, 66 };
                        int resIntNum = new ExteMaxGene<int>(intArray).ShowMax();
                        Console.WriteLine("Maximum value from given number is : {0}", resIntNum);
                        Console.ReadLine();
                        break;
                    case 2:
                        
                        float[] floatArray = { 36.4f,58.45f,49.2f,69.58f};
                        float resFtNum = new ExteMaxGene<float>(floatArray).ShowMax();
                        Console.WriteLine("Maximum value from given float number is : {0} ", resFtNum);
                        Console.ReadLine();
                        break;
                    case 3:
                       
                        string[] stringArray = { "Navbharat", "Navkranti", "Navswaraj", "Navdrushti" };
                        string resStr = new ExteMaxGene<string>(stringArray).ShowMax();
                        Console.WriteLine("Maximum value from given string is : {0} ", resStr);
                        Console.ReadLine();
                        break;
                    case 4:
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
