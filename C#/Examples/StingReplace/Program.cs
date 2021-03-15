using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StingReplace
{
    static class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello world";
            str.Replace("world", "Smith");
            Console.WriteLine(str);


            StringBuilder strBuilder = new StringBuilder("Hello world");
            strBuilder.Replace("world", "Amit");
            Console.Write(strBuilder);

            Console.ReadKey();

        }
    }
}
