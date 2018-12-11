using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Topic5_OOPS_Polymorphism
{
    class Overloading1
    {
        /**
         * method overloading-->same method but diff signature is called Overloading
         * change the parameters being passed,type of parameters,change the order of type of parameters
         * the best example for the overloading is WriteLine() or Write().it accepts different type of parameters         * 
         * **/

        public static void Dispaly() {
            Console.WriteLine("Just Display the Content");
        }

        public static void Dispaly(int a)
        {
            Console.WriteLine("Just Display one Value"+a);
        }

        public static void Dispaly(String a, int b)
        {
            Console.WriteLine(a+b);
        }

        public static void Dispaly(int a, int b)
        {
            Console.WriteLine("additon of {0} and {1} numbers are {2}",a,b,(a+b));
        }
        public static void Main() {

            Dispaly();
            Dispaly(25);
            Dispaly("Given value is numeric,that values is ",25);
            Dispaly(25,25);
            Console.ReadKey();
        }
    }
}
