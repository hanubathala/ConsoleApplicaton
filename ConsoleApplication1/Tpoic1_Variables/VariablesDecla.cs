using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Tpoic1_Variables
{
    class VariablesDecla
    {

        static String st;
        static int a;
        static bool bo;
        static  Char  ch;
        static object obj;

        static int? nullstring = null; // this feature come up in c# 2.0 version
        
        static void Main() {
            
            Console.WriteLine("Default Value of Integers"+st);
            
            // dynamic varible declaration and inilization in the program,it  come up in global declaration time
            var var1 = "this is Printing the value";
            Console.WriteLine(var1);
            Console.WriteLine(nullstring);
            Console.ReadLine();
        }
    }
}
