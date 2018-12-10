using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Topic5_OOPS
{
    class Methods_Calling_AnotherClass
    {
        static void Main() {

            Methods_inAnother_Class obj = new Methods_inAnother_Class(10, 5);
            obj.Add();
            obj.Mul();
            obj.Sub();
            Console.ReadKey();
        }
    }
}
