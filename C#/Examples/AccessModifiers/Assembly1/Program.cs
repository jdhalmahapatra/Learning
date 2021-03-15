using System;

namespace Assembly1
{
    public class Assembly1BaseClass
    {
        readonly private string privatevariable = "privatevariable";
        protected string protectvariable = "protectedvariable";
        internal string internalVariable = "internalvariable";
        protected internal string protectedInternalVariable = "protectedInternalVariable";
        public string publicVaribale = "publicVaribale";
        public void TestAccess()
        {
            //All Accessible
            Console.WriteLine(privatevariable);
            Console.WriteLine(protectvariable);
            Console.WriteLine(internalVariable);
            Console.WriteLine(protectedInternalVariable);
            Console.WriteLine(publicVaribale);
        }
    }
    class Assembly1DerivedClass : Assembly1BaseClass
    {
        public void TestDerivedAccess()
        {
            //Not Accessible
            //Console.WriteLine(privatevariable); //Private

            //Accessible
            Console.WriteLine(protectvariable);
            Console.WriteLine(internalVariable);
            Console.WriteLine(protectedInternalVariable);
            Console.WriteLine(publicVaribale);
        }
    }
    class AssemblyOtherClass
    {
        public void TestOtherClassAccess()
        {
            
            Assembly1BaseClass obj = new Assembly1BaseClass();
            
            //Console.WriteLine(obj.privatevariable); //Private
            //Console.WriteLine(obj.protectvariable); //Protected

            Console.WriteLine(obj.internalVariable);
            Console.WriteLine(obj.protectedInternalVariable);
            Console.WriteLine(obj.publicVaribale);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Assembly1BaseClass a1bc = new Assembly1BaseClass();
            //a1bc.TestAccess();

            //Assembly1DerivedClass a1dc = new Assembly1DerivedClass();
            //a1dc.TestDerivedAccess();
            //a1dc.TestAccess();

            AssemblyOtherClass objOther = new AssemblyOtherClass();
            objOther.TestOtherClassAccess();

            Console.ReadKey();
        }
    }
}
