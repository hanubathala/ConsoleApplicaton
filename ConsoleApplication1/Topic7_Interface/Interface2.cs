using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Topic7_Interface
{
    /**
     * 
     *  It allows the multi level Inheritance
     *  
     * **/
    interface Interface2
    {
        void draw();
    }
    interface Interface4
    {
        void draw();
    }

    class Testing1 : Interface1, Interface2
    {

        public void draw()
        {
            Console.WriteLine("this child class implementation");
        }

        public static void Main()
        {
            Testing1 t = new Testing1();
            t.draw();
            Console.ReadKey();
        }
    }


}
