using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Tpoic2_Conditionals
{
    class ifCond
    {

        static void Main() {
            
            Console.WriteLine("Default value is 30");
            Console.Write("Enter a Value: ");
            int a = Convert.ToInt16(Console.ReadLine()); //we can use other ReadLine,We have the ReadKey,Read
            if (a > 30)
            {
                Console.WriteLine("Given Value is grater then default value");
            }
            else {
                Console.WriteLine("Given Value is less then default value");
            }
            Console.ReadKey();
        }
    }
}
