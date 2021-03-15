using System;

namespace ConsoleAppUsingCore
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num1, num2;
            //Console.WriteLine("Please enter the first number:");
            //num1 = Convert.ToInt32 (Console.ReadLine());

            //Console.WriteLine("Please enter the second number");
            //num2 = Convert.ToInt32(Console.ReadLine());

            //int result = num1 + num2;
            //Console.WriteLine("Sum of {0}, {1} is: {2}", num1, num2, result);

            /*Type Conversion*/
            /*1. Implicit Conversion
              2. Explicit Conversion
              3. Conversion with Helper Class
            */
            //Implicit Conversion
            int a = 10;
            decimal d1 = a;
            Console.WriteLine("Implicit Conversion Value:"+ d1);

            //Explicit Conversion
            char c1 = '1';
            int b = (int)c1;
            Console.WriteLine("Explicit Conversion value:" + b);

            //Conversion with the Helper Class
            string str = "12";
            int c = Convert.ToInt32(str);
            Console.WriteLine("Conversion with the Helper Class value:"  + c);

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
 