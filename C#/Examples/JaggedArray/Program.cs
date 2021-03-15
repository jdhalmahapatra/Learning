using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    static class Program
    {
        static void Main(string[] args)
        {
            int[][] jArray = new int[2][];

            jArray[0] = new int[2];
            jArray[1] = new int[3];

            jArray[0][0] = 10;
            jArray[0][1] = 5;

            jArray[1][0] = 7; 
            jArray[1][1] = 20;
            jArray[1][2] = 30;

            Console.WriteLine("Array Elements are: ");
            for(int i = 0; i < jArray.GetLength(0); i++)
            {
                Console.Write("\nJagged Array #{0} values are", i+1);
                for(int j = 0; j< jArray[i].GetLength(0); j++)
                {
                    Console.Write("\t{0}",jArray[i][j]);
                }
            }
            Console.ReadKey();
        }
    }
}
