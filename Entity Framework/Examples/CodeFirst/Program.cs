using CodeFirst.DBContext;
using CodeFirst.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var db = new MyDbContext())
                {
                    Programme prog = new Programme()
                    {
                        Id = 1,
                        Title = "MBA",
                        Duration = 2,
                        Fees = 1400000
                    };
                    db.Programmes.Add(prog);
                    db.SaveChanges();
                    Console.WriteLine("Database Created");
                }
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
            Console.ReadKey();
        }
    }
}
