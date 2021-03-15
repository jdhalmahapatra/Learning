using CodeFirst.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.DBContext
{
    class MyDbContext : DbContext
    {
        public MyDbContext() : base("StudentDB_Annotation")
        {
            
            Database.SetInitializer<MyDbContext>(new DropCreateDatabaseAlways<MyDbContext>());
        }
        public virtual DbSet<Programme> Programmes { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentAddress> StudentAddresses { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
    }
}
