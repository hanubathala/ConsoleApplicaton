using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Topic7_Interface
{
    /**
     * interface contains the abstract members only .by default is public modifier
     * 
     * **/
    interface Interface1
    {

        void draw();
    }
    class Testing:Interface1
    {

        public void draw()
        {
            Console.WriteLine("this child class implementation");
        }

        public static void Main()
        {
            Testing t = new Testing();
            t.draw();
            Console.ReadKey();
        }
    }


}
