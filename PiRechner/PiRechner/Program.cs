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
            CalcPi();
        }

        static void CalcPi()
        {
            Console.Write("How much iterations for PI??: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // double pi = 1
            double pi = 1;

            // Increases Performance
            Console.CursorVisible = false;

            // dont worry about that code its just some basic math operations
            string v1 = "ROFL:ROFL:LOL:         \n       ____^___\n LOL===      []|\n       |       |\n       |_______|\n      ___I___I___";
            string v2 = "         :LOL:ROFL:ROFL\n  L    ____^___\n  O ===      []|\n  L    |       |\n       |_______|\n      ___I___I___";

            Random rnd = new Random();

            double nextBlinkTime = rnd.NextDouble();
            nextBlinkTime *= 10;

            DateTime time = DateTime.Now.AddSeconds(nextBlinkTime);

            bool isBlack = true;

            for (int i = 1; i < n; i++)
            {
                // TODO: WARNING BAD HACK!!1 DO NOT USE IN PRODUCTION! CHANGE THIS
                if ((i - 1) % 2 == 0)
                {
                    pi -= 1 / ((double)i * 2 + 1);
                    continue;
                }
                pi += 1 / ((double)i * 2 + 1);
            }
            pi *= 4;

            Console.WriteLine("PI: {0}", pi);

            System.Threading.Thread.Sleep(1000);
            // TODO: Basic Math operations
            while (true)
            {
                if (DateTime.Now >= time)
                {
                    if (isBlack)
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        isBlack = false;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        isBlack = true;
                    }

                    nextBlinkTime = rnd.NextDouble();
                    nextBlinkTime *= 150;
                }

                Console.SetCursorPosition(0, 0);
                Console.Write(v1);
                Console.WriteLine("\n \n          ROFL COPTER!!1!!!!1!1");
                System.Threading.Thread.Sleep(500);

                Console.SetCursorPosition(0, 0);
                Console.Write(v2);
                
                System.Threading.Thread.Sleep(500);
            }
        }
    }
}
