using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Topic5_OOPS
{
    class Inheritance2
    {
        public static void Main() {

            Inheritance obj = new Inheritance();
            obj.Test1(); obj.Test4(); obj.Test3();
            Inheritance1 obj2 = new Inheritance1();
            //obj2.Test3(); it throws an error,because parent class  cannot access the child class members
            Console.ReadKey();
        }
    }
}
