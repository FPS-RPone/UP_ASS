using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP_ASS.Models
{
    public class MainDB: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Progress> Progresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Server=(LocalDB)\MSSqlLocalDB;
                                        Database=UP_ASS;
                                        Trusted_Connection=True;
                                        TrustServerCertificate=True;");
        }

        public MainDB()
        {
            this.Database.EnsureCreated();
        }
    }
}
