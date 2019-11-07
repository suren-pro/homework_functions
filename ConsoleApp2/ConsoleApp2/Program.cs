using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {

        public static void IntToDouble(double[] x, ref int[] y)
        {

            for (int i = 0; i < x.Length; i++)
            {
                y[i] = (int)x[i];
            }



        }
        public static void Delete(ref double[] x, int k)
        {


            for (int i = 0; i < x.Length; i++)
            {

                if (i == k)
                {

                    x[i] = 0;

                }
            }




        }
        static void MatrixTriangular(int[,] x)
        {



        }
        static void Main(string[] args)
        {
            /*double[] x = { 5, 1, 2, 3.5 };
            int[] y= new int[x.Length];*/
            /*IntToDouble(x,ref y );
             * 

            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i]+"  ");
            }
            Console.WriteLine();
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(y[i]+" ");
            }*/


            /*for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + "  ");
            }
            int k;

            do
            {
                k = Int32.Parse(Console.ReadLine());
            }
            while (k > x.Length);
            Delete(ref x, k);

            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + "  ");
            }

            */


            int[,] x = new int[3, 3];


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    x[i, j] = i + j;
                }

            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(x[i, j] + "  ");
                }
                Console.WriteLine();
            }

            for (int i = 1; i < 3; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    x[i, j] = 0;
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(x[i, j] + "  ");
                }
                Console.WriteLine();
            }




            Console.ReadLine();
        }
    }
}

