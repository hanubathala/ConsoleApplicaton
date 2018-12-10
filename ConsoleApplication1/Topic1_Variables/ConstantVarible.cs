using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Topic1_Variables
{
    class ConstantVarible
    {
        /***************
         * 
         * Const connot be modified one after declaration 
         * Read only cannot be modified after initilization
         * 
         * *************/

        int x = 10;
        static int y=20;
        const float z=3.14f;
        readonly bool flag;
       public ConstantVarible(int x,bool flag){
            this.x = x;
            this.flag = flag;
        }
       static void Main(string []args) {
           Console.WriteLine(y); 
           Console.WriteLine(z);
           //z = 63.5f; it throws an error
           y = 36;
           Console.WriteLine(y);
           ConstantVarible obj1 = new ConstantVarible(10,true);
           ConstantVarible obj2 = new ConstantVarible(20, false);

           Console.WriteLine(obj1.x+" "+obj1.flag);
           Console.WriteLine(obj2.x + " " + obj2.flag);

           Console.ReadKey();

       }


    }
}
