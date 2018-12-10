using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Topic4_Arrays
{

    class TwoDimensionArray
    {

        public static void Main(string[] args)
        {

            Console.WriteLine("*******Display the Tow Dimension Array***********");

            int[,] ar=new int[2,2]; //    inialization of Two dimension array
            Console.WriteLine("Printing the values of the Two dimention Array");

            int [,] arr={{10,20},{30,40}};
            foreach (int i in arr) 
                Console.Write(i + " ");
           
            Console.WriteLine(" \n");
            Console.WriteLine("End the printing the values of the Two dimention of array");


            Console.WriteLine("Assign the values to Two Dimension Array");
            int a = 5;
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(1); j++) {
                    a += 5;
                    ar[i,j] = a;
                }
            }
            Console.WriteLine("After Assigning  the values to Two Dimension Array to print");
            foreach (int b in ar) {
                Console.Write(b+" ");
            }

            Console.WriteLine("\n");
            Console.WriteLine("********Jagged Array******");
            int[][] jarr = new int[2][];
            jarr[0] = new int[2];
            jarr[1] = new int[1];
            int c = 5;
            for (int i = 0; i < jarr.GetLength(0); i++)
            {
                for (int j = 0; j < jarr[i].Length; j++)
                {
                    c += 5;
                    jarr[i][j] = c;
                }
            }
            Console.WriteLine("After Assigning  the values to Two Dimension Array to print");
            
            for(int i=0;i<jarr.GetLength(0);i++){
                        foreach (int b in jarr[i])
                        {
                            Console.Write(b+" ");
                        }
                }
            Console.WriteLine("\n");
            Console.ReadKey();
        }
    }
}
