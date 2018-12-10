using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Topic6_InputOutParameters
{
    class InputOutput2
    {
        public static void Add1(int a, ref int x, out int c)
        {

            c = x + a;
            Console.WriteLine("Display Total:" + (a + x + c));

        }
        public static void Main(string[] args)
        {
            int x = 100;
            int y;
            Add1(100, ref x, out y); //ref type is mandatory to initilization where as out type is optional
            Console.WriteLine("Testing");
        }
    }
}
