using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Topic5_OOPS_Polymorphism
{
   abstract class AbstractClasses
    {           /**
                 * 
                 * Abstract method defined under the AbstractClass should be implemented within the Childclass also
                 * 
                 * 
                 * **/
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine(a-b);
        }
        public abstract void Mul(int a, int b);
        public abstract void Div(int a, int b);
    }

   class ChildClass : AbstractClasses
   {
       public override void Mul(int a, int b)
       {
           Console.WriteLine(a * b);
       }
       public override void Div(int a, int b)
       {
           Console.WriteLine((a / b));
       }
       public static void Main( string []args) 
       {

           ChildClass cc = new ChildClass();
           cc.Add(10, 20);
           cc.Sub(50, 10);
           cc.Mul(10, 10);
           cc.Div(50, 5);

           // we can also call members through the reference of the child class
           AbstractClasses ac = cc;

           ac.Add(10, 20);
           ac.Sub(50, 10);
           ac.Mul(10, 10);
           ac.Div(50, 5);
           
           Console.ReadKey();
       }
   
   }
}
