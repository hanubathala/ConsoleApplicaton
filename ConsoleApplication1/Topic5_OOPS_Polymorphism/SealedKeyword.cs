using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Topic5_OOPS_Polymorphism
{
    class SealedKeyword
    {
        public virtual void show()
        {
            Console.WriteLine("Paent Class Method Calling");
        }
        public virtual void show1()
        {
            Console.WriteLine("Paent Class Method Calling");
        }
    }
    class SealedClass : SealedKeyword
    {
        public sealed override void show()
        {
            Console.WriteLine("Grand Child Class Method Calling");
        }

        public override void show1()
        {
            Console.WriteLine("Grand Child Class Method Calling");
        }
    }

    class SealedClass1 : SealedClass
    {
        //public override void show()
        //{                                                                               // we cannot override the show derive from seleadKeyword
        //    Console.WriteLine(" Child Class Method Calling");
        //}
        public override void show1()
        {
            Console.WriteLine(" Child Class Method Calling");
        }
    }
    class SealedTesting {

        public static void Main()
        {
            //SealedClass sc = new SealedClass();
            //sc.show();
            SealedClass1 sc1 = new SealedClass1();
            sc1.show1();

            Console.ReadKey();
        }
    }
}
