using System;
using System.Collections.Generic;
using System.Text;

/*Let's understand the multicast delegate.
 - A delegate can reference/point to one or more function is called Mulitcast Delegate.
 - It's best used for Obeserver-Remover Design pattern
 - To add multiple delegate invocation method use + or += and to remove use - or -=*/

namespace Delegate
{
    class MulticastDelegate
    {
        static void Main(string[] args)
        {
            //1.This is One way
            MethodDelegate mdel1 = new MethodDelegate(Method.MethodA);
            MethodDelegate mdel2 = new MethodDelegate(Method.MethodB);
            MethodDelegate mdel3 = new MethodDelegate(Method.MethodC);

            MethodDelegate mdel4 = mdel1 + mdel2 + mdel3;
            mdel4();
            Console.WriteLine("Hello World After delegate is Invoked");
            mdel4 = mdel4 - mdel2;
            mdel4();

            //2. Another way
            Console.WriteLine("Invoking Delegate in another way, Lets see it then");
            MethodDelegate mdel = new MethodDelegate(Method.MethodA);
            mdel += Method.MethodB;
            mdel += Method.MethodC;
            mdel();
            Console.WriteLine("Removing 2nd Method after everything");
            mdel -= Method.MethodB;
            mdel();
        }
    }

    delegate void MethodDelegate();
    public class Method
    {
        public static void MethodA()
        {
            Console.WriteLine("Method A called and Invoked");
        }
        public static void MethodB()
        {
            Console.WriteLine("Method B called and Invoked");
        }
        public static void MethodC()
        {
            Console.WriteLine("Method C called and Invoked");
        }
    }
}
