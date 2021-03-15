using System;
using Assembly1;

namespace Assembly2
{
    public class Assembly2DerivedClass : Assembly1BaseClass
    {
        public void TestAccessInAssembly2DerivedClass()
        {
            //All Accessible
            //Console.WriteLine(privatevariable); //Private
            //Console.WriteLine(internalVariable);//Internal

            Console.WriteLine(protectvariable);
            Console.WriteLine(protectedInternalVariable);
            Console.WriteLine(publicVaribale);
        }
    }
    class Assembly2Other
    {
        public void TestAccess()
        {
            Assembly1BaseClass obj = new Assembly1BaseClass();
            //All Accessible
            //Console.WriteLine(obj.privatevariable); //Private
            //Console.WriteLine(obj.internalVariable);//Internal
            //Console.WriteLine(obj.protectvariable); //Protected
            //Console.WriteLine(obj.protectedInternalVariable); //Protected internal
            Console.WriteLine(obj.publicVaribale);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey I am from Assembly2 Project");
            Assembly2DerivedClass a2dc = new Assembly2DerivedClass();
            a2dc.TestAccess();
            Console.WriteLine("\n \n");
            a2dc.TestAccessInAssembly2DerivedClass();
            Console.WriteLine("\n \n");
            Assembly2Other obj = new Assembly2Other();
            obj.TestAccess();

            Console.ReadKey();
        }
    }
}
