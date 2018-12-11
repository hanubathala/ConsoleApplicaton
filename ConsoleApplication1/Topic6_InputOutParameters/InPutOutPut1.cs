using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Topic6_InputOutParameters
{
    class InPutOutPut1
    {
        public static void Add1(int a, int b = 100, int c = 200) {

            Console.WriteLine("Display Total:"+(a+b+c));
        }
        public static void Main(string []args) {
            Add1(10);
            Add1(100, 200, 300);
            Console.WriteLine("Testing");
            Console.ReadLine();
        }
    }
}
