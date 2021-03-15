using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2D
{
    static class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[2, 3] { { 10, 20, 30}, { 15, 25, 35} };
            //matrix[0, 0] = 10;
            //matrix[0, 1] = 20;
            //matrix[0, 2] = 30;

            //matrix[1, 0] = 15;
            //matrix[1, 1] = 25;
            //matrix[1, 2] = 35;

            Console.Write("Elements in matrix: \n");

            for(int i=0; i < matrix.GetLength(0); i++)
            {
                Console.Write("\n Row #{0} elements :", i+1);
                for(int j=0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0}\t", matrix[i,j]);
                }
            }
            Console.ReadKey();
        }
    }
}
