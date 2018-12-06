using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Topic3_JumpStatement
{
    class ReturnStatement
    {

        public static int Getvalue(int a) {

            return (a*10);
        }

        static void Main(string[] args) {
           int b= Getvalue(10);
            Console.WriteLine("Number Multiplication: "+b);
            Console.ReadKey();
        }
    }
}
