using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Tpoic2_Conditionals
{
    class SwithCondi
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a Value for Case Execution");
            int a = int.Parse(Console.ReadLine());

            switch (a) { 
                case 1:
                    Console.WriteLine("Your Enter Case 1");
                    break;
                case 2:
                    Console.WriteLine("Your Enter Case 2");
                    break;
                case 3:
                    Console.WriteLine("Your Enter Case 3");
                    break;
                case 4:
                    Console.WriteLine("Your Enter Case 4");
                    break;
                
                default:
                    Console.WriteLine("Your Enter Case 1");
                    break;

            }
            Console.ReadKey();

        }
    }
}
