using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Database.Entity;

namespace UserService
{
    public class DatabaseContext :DbContext
    {
        public DatabaseContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\.;Initial Catalog=UserMicroservice;persist security info=True;Integrated Security=True");
        }

        public DbSet<User> Users { get; set; }
    }
}
