using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array3D
{
    static class Program
    {
        static void Main(string[] args)
        {
            int[,,] arr = new int[2, 2, 3] { { { 10, 20, 30 }, { 12, 22, 32 } }, { {112, 222, 332 },{403, 506, 221 } } };

            ////X:0 Y:0 Z:0,1,2
            //arr[0, 0, 0] = 10;
            //arr[0, 0, 1] = 20;
            //arr[0, 0, 2] = 30;
            ////X:0 Y:1 Z:0,1,2
            //arr[0, 1, 0] = 12;
            //arr[0, 1, 1] = 22;
            //arr[0, 1, 2] = 32;
            ////X:1 Y:0 Z:0,1,2
            //arr[1, 0, 0] = 112;
            //arr[1, 0, 1] = 222;
            //arr[1, 0, 2] = 332;
            ////X:1 Y:1 Z:0,1,2
            //arr[1, 1, 0] = 1112;
            //arr[1, 1, 1] = 2222;
            //arr[1, 1, 2] = 3332;

            Console.WriteLine("Elements in matrix are:");
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write("\n The row #{0} matrix value are: ", i+1);
                for(int j = 0; j< arr.GetLength(1); j++)
                {
                    for(int k=0; k<arr.GetLength(2); k++)
                    {
                        Console.Write("\t {0}", arr[i,j,k]);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
