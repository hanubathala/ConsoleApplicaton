using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Tpoic2_Conditionals
{
    class Foreachloop
    {
        static void Main(string []args)
        {

            Console.WriteLine("Using Foreach In array");
           string[]  a=new []{"10","20","30","40","50"};

           foreach(string element in a ){
           
            Console.WriteLine(element);
           }

            Console.ReadKey();
        }
    }
}
