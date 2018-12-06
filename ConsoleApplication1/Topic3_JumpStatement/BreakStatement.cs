using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Topic3_JumpStatement
{
    class BreakStatement
    {

        static void Main()
        {

            int a = 5,b = 10;
            Console.WriteLine("Break Statement Works");
            for (int i = 1; i <= 5; i++)
            {
                if (i == a)
                    break;
                Console.WriteLine(i);
            }
            Console.WriteLine("Continue statement Works");
            for (int j = 1; j <= 10; j++)
            {
                if (j == a)
                    continue;
                Console.WriteLine(j);
            }
            Console.ReadKey();

        }
    }
}
