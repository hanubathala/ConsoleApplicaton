using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Topic5_OOPS
{
    class Methods_Same_Class
    {

        public static void Test1() {
            Console.WriteLine("Test1 Method is Calling");
        }

        public static void Main() {
            Test1();
            Console.ReadKey();
        }
    }
}
