using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new InstituteContext())
            {
                foreach (Course cobj in db.Courses)
                {
                    Console.WriteLine("{0}\t {1}\t {2}\t", cobj.CourseId, cobj.CourseName, cobj.Duration);
                }
            }
            Console.WriteLine("Please enter any key to exit...");
            Console.ReadKey();
        }
    }
}
