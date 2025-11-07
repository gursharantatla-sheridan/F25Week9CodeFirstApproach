using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace F25Week9CodeFirstApproach
{
    // context class
    public class SchoolContext : DbContext
    {
        // entity sets - required
        // define properties of type DbSet<>
        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }


        // connection string - required
        // override the OnConfiguring method
        // read the conn str from the App.config
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connStr = ConfigurationManager.ConnectionStrings["School"].ConnectionString;
            optionsBuilder.UseSqlServer(connStr);
        }


        // data seed - optional
        // override the OnModelCreating method
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Standard>().HasData(
                new Standard() { StandardId = 1, StandardName = "Standard-1" },
                new Standard() { StandardId = 2, StandardName = "Standard-2" },
                new Standard() { StandardId = 3, StandardName = "Standard-3" },
                new Standard() { StandardId = 4, StandardName = "Standard-4" },
                new Standard() { StandardId = 5, StandardName = "Standard-5" }
            );

            modelBuilder.Entity<Student>().HasData(
                new Student() { StudentId = 1, StudentName = "John", StandardId = 1 },
                new Student() { StudentId = 2, StudentName = "Anne", StandardId = 1 },
                new Student() { StudentId = 3, StudentName = "Mark", StandardId = 2 },
                new Student() { StudentId = 4, StudentName = "Mary", StandardId = 3 }
            );
        }
    }
}
