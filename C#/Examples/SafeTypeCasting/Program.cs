using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeTypeCasting
{
    class Person
    {
        public string Name { get; set; }
    }
    class Student: Person
    {
        public int Id { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //using as Operator
            Person p1 = new Person();
            Student s1 = new Student();
            //Student s1 = p1 as Student;

            //Student s2 = new Student();
            //Person p2 = s2 as Person;

            //usign is Operator
            if (s1 is Person)
            {
                Student s2 = s1;
            }

            Console.ReadKey();
        }
    }
}
