using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Topic5_OOPS
{
    class Inheritance1
    {
        /******
         * 
         *  Child class consume all members of parent class except privae members 
         *  but parent can not access child members
         * 
         * **/
        public void Test1() {
            Console.WriteLine("Tes1 in Parent Class");
        }
        private void Test2()
        {
            Console.WriteLine("Tes2 in Parent Class");
        }
        
    }
    class Inheritance : Inheritance1 {

        public void Test3()
        {
            Console.WriteLine("Tes3 in child Class");
        }
        public void Test4()
        {
            Console.WriteLine("Tes4 in Child Class");
        }
    
    }
}
