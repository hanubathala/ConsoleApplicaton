using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Topic5_OOPS_Polymorphism
{
    class MethodHiding
    {

        /**
         *  we can override the base
         * 
         * **/

        public virtual void Test()
        {
            Console.WriteLine("Parent Class Test Method calling"); 
        }
        public virtual void display()
        {
            Console.WriteLine("Parent Class dipaly Method calling");
        }
        public virtual void show()
        {
            Console.WriteLine("Parent Class show Method calling");
        }
    }
    class MethodHide:MethodHiding 
    {

        public override void Test()
        {
            Console.WriteLine("Child Class Test Method Calling");
        }
        public new  void display()
        {
            Console.WriteLine("Child Class display Method Calling");
        }
        public override void show()
        {
            base.show();
            //Console.WriteLine("Child Class show Method Calling");
        }
        public static void Main()
        {
            MethodHide mh = new MethodHide();
            mh.Test();
            mh.display();
            mh.show();
            Console.ReadKey();
        }
    
    }
    
}
