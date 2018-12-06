using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Topic3_JumpStatement
{
    class GotoStatement
    {
               /*
                * 
                *  goto statement willbe used in the most of loop stateents on
                * 
                */

        static void Main(String[] args)
            {
                int a = 5;
                Console.WriteLine("First Statement");
                for (int x = 0; x < 10; x++) // Run until condition.
                {
                    if (a == 5)
                    {
                        goto Outer;
                    }
                }
                Console.WriteLine("second Statement");
                Console.WriteLine("third Statement");
                Console.WriteLine("Four Statement");
                Console.WriteLine("Five Statement");
            Outer:
                Console.WriteLine("Six Statement");
                Console.WriteLine("Seven Statement");
                Console.ReadKey();
            }
    }
}
