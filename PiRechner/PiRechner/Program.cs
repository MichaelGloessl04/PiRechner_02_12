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
            double count = 1.0;
            bool zeichen = false;
            double Bruch = 1.0;

            for(int i = 0; i <= 999999; i++)
            {
                Bruch += 2.0;
                
                if (zeichen)
                {   
                    count += 1.0 / Bruch;
                    zeichen = false;
                }
                else
                {       
                    count -= 1.0 / Bruch;
                    zeichen = true;
                }    
            }
            Console.WriteLine(count*4);
        }
    }
}
