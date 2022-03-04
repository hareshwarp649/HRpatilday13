using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExteNumGen7
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
                        
                        int[] intArray = {59,56,28,49 };
                        MethodGeniNum<int> resIntNum = new MethodGeniNum<int>(intArray);
                        resIntNum.PrintMaxValue();
                        Console.ReadLine();
                        break;
                    case 2:
                        
                        float[] floatArray = { 36.4f, 58.45f, 49.2f, 69.58f };
                        MethodGeniNum<float> resFtNum = new MethodGeniNum<float>(floatArray);
                        resFtNum.PrintMaxValue();
                        Console.ReadLine();
                        break;
                    case 3:
                        
                        string[] stringArray = { "Navbharat", "Navkranti", "Navswaraj", "Navdrushti" };
                        MethodGeniNum<string> resStr = new MethodGeniNum<string>(stringArray);
                        resStr.PrintMaxValue();
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
