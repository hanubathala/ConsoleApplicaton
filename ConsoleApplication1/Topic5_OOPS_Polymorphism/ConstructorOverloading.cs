using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Topic5_OOPS_Polymorphism
{
    class ConstructorOverloading
    {
        /**
         * 
         * 
         * **/
        int x,y;
        //public ConstructorOverloading()
        //{
         
        //    Console.WriteLine("Display the Content");
        //}
        public ConstructorOverloading()
        {

            this.x = 10;
            Console.WriteLine(x);
        }
        public ConstructorOverloading(int a,int b)
        {

            this.x = a;
            this.y = b;
            
            Console.WriteLine(x+y);
        
        }
        public static void Main()
        {
            //ConstructorOverloading(); we use  to initialize the non static value so we need to create the object of the class
            ConstructorOverloading con = new ConstructorOverloading();
            ConstructorOverloading con1 = new ConstructorOverloading(10,20);
         
            Console.ReadKey();

        }
    }
}
