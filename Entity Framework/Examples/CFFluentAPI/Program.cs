using CFFluentAPI.DatabaseContext;
using CFFluentAPI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFFluentAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using(var db = new MyDbContext())
                {
                    Department dept = new Department()
                    {
                        DeptId = 1,
                        DeptName = "Development"
                    };
                    db.Departments.Add(dept);
                    db.SaveChanges();
                    Console.WriteLine("Database Created");
                    Console.ReadKey();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
