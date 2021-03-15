using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1D
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[5] { 60, 66, 76, 80, 86};
            //marks[0] = 60;
            //marks[1] = 66;
            //marks[2] = 76;
            //marks[3] = 89;
            //marks[4] = 56;
            Console.Write("Marks elements in Array :");
            for(int i = 0; i< marks.Length; i++)
            {
                Console.Write("\t" + marks[i]);
            }
            Console.ReadKey();
        }
    }
}
