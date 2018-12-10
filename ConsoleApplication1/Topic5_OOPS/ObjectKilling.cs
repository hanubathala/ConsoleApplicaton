using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Topic5_OOPS
{
    class ObjectKilling
    {
        void Testing() {

            Console.WriteLine("Method is called");
        }

        public static void Main() {

            ObjectKilling obj = new ObjectKilling();
            obj.Testing();
            obj = null;
            //obj.Testing; it throws an error once it makes as null again we can not invoke the object.
        }
    }
}
