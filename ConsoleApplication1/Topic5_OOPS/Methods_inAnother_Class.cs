using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Topic5_OOPS
{
    class Methods_inAnother_Class
    {
        int x, y;
        public Methods_inAnother_Class(int x,int y) {

            this.x = x;
            this.y = y;
        }
        public void Add()
        {

            Console.WriteLine("Addition of Two Numbers:" + (x + y));
        }
        public void Mul()
        {

            Console.WriteLine("Multiplication of Two Numbers:" + (x * y));
        }
        public void Sub()
        {

            Console.WriteLine("Subtraction of Two Numbers:" + (x - y));
        }
    }
}
