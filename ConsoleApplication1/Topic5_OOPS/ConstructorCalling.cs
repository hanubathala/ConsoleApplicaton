using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Topic5_OOPS
{
    class ConstructorCalling
    {
        ConstructorCalling() {
            Console.WriteLine("Non Static Constructor Calling");
        }
        static ConstructorCalling()
        {
            Console.WriteLine("Static Constructor Calling");
        }
        public static void Main() {

            ConstructorCalling obj1 = new ConstructorCalling();
            ConstructorCalling obj2 = new ConstructorCalling();
            ConstructorCalling obj3 = new ConstructorCalling();
            ConstructorCalling obj4 = new ConstructorCalling();
            Console.ReadKey();
        }
    }

}
