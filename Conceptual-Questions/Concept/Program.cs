using System;

namespace Concept
{
    public class Test
    {
        public int i { get; set; }
    }
    public class Result
    {
        Test t1 = new Test();
        public void SomeMethod(Test t1)
        {
            t1.i = 10;
            Console.WriteLine("Value {0}", t1.i);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            t.i = 5;
            Console.WriteLine("Value {0}", t.i);
            Result r = new Result();
            r.SomeMethod(t);
            Console.WriteLine("Now Value {0}", t.i);
            Console.ReadKey();
        }
    }
}
