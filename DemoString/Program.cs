using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initializing variables
            Byte num1 = 64;
            Byte num2 = 67;
            Byte num3 = 0;
            int num4 = 0;
            int num5 = 0;
            int num6 = 0;
            int num7 = 0;

            //Output Intial Values
            Console.WriteLine("Initial values:");
           //Console.WriteLine(num1);
           //Console.WriteLine(num2);
           //Console.WriteLine(num3);

            Console.WriteLine("\n");
            Console.WriteLine();
            Console.WriteLine("When Number 1, 2, and 3 are added:", "\n", + num1 + "\n" + num2 + "\n" + num3);
            Console.WriteLine();

            //Demo Addition
            num4 = num1 + num2;
            Console.WriteLine("\n" + num4);

            num5 = num4 / num1;
            Console.WriteLine("\n" + num5, "\n");
            
            //Demo under/overflow
            Console.WriteLine();
            num7 = int.MaxValue;
            Console.Write("num7 value set to int.MaxValue: ");
            num7 = num7 + 1;
            Console.WriteLine("When Num7 is incremented by 1:"+ num7);
            Console.ReadLine();

        }
    }
}
