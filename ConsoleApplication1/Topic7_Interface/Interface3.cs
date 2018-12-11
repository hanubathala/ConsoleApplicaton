using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Topic7_Interface
{
    interface Interface3
    {

        void show();
    }

    interface Interface5
    {
        void show();
    }

    class Testing4:Interface3,Interface5
    {
         void Interface3.show()
        {
         Console.WriteLine("it is calling inerface 3");   
        }
        void Interface5.show()
        {
         Console.WriteLine("it is calling inerface 4");   
        }
        public static void Main()
        {
            Testing4 t = new Testing4();
            Interface3 inf = t;
            Interface5 inf1 = t;
            inf.show();
            inf1.show();
            Console.ReadKey();

        }
    }
}
