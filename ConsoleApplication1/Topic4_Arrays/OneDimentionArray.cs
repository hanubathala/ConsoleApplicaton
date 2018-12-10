using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Topic4_Arrays
{
    class OneDimentionArray
    {

        public static void Main(string []args) {

            Console.WriteLine("*******Display the Single Dimension Array***********");

            int[] ar = new int[5]; //    inialization of single dimension array
            Console.WriteLine("Printing the values of the Single Dimention Array");
            int  [] arr=new [] {10,20,30,40,50};
            foreach (int i in arr)
                Console.Write(i+" ");
            Console.WriteLine();
            Console.WriteLine("End the printing the values of the single dimention of array");


            Console.WriteLine("Assign the values to the Single Dimension Array");
            for (int i = 0; i < ar.Length; i++) {
                ar[i] = arr[i];
                Console.Write(ar[i] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
