using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Topic5_OOPS_Polymorphism
{
    class Overriding1
    {
        public virtual void Test()
        {
            Console.WriteLine("Parent Clsas Test Method");
        }
        public void Test(int a)
        {
            Console.WriteLine("Given value is Numeric,that value is  " + a);
        }
    }

    class Overriding2 : Overriding1
    {

        public override void Test()
        {

            Console.WriteLine("Testing Overirde");
        }
        public void Test(int a, int b)
        {

            Console.WriteLine("Addition of two Numbers" + (a+b));
        }
        public static void Main()
        {
            Overriding2 oc = new Overriding2();
            Overriding1 or = new Overriding1();
            oc.Test(10,25);
            oc.Test(10);
            oc.Test();
            or.Test();
            Console.ReadKey();
        }
    }
}
