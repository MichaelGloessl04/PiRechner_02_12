using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiRechner
{
    class Program
    {
        static void Main(string[] args)
        {
            double _input = 215;
            int c = 0;

            int[] binaryNumber = new int[8];


            double input = _input;

            if (input > 255)
            {
                Console.WriteLine("Die Zahl darf nicht größer als 255 sein!\n\n", Console.ForegroundColor = ConsoleColor.Red);

                Console.ForegroundColor = ConsoleColor.Gray;

                Environment.Exit(0);
            }

            while (input > 1)
            {
                input /= 2;

                if (input % 2 == 0)
                {
                    binaryNumber[c] = 0;
                }
                else
                {
                    binaryNumber[c] = 1;
                }

                input = Math.Floor(input);
                c++;
            }

            Array.Reverse(binaryNumber);

            Console.WriteLine("Input: " + _input + "\n");

            Console.Write("Binary: ");

            foreach (var item in binaryNumber)
            {
                Console.Write(item);
            }

            Console.Write("\n");
        }
    }
}
