using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalChallengeStep451.Models
{
    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=StudentDb",
                sqlServerOptionsAction: sqlOptions =>
                {
                    sqlOptions.EnableRetryOnFailure();
                });
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Add<Student>(new Student { StudentId = 1, FirstName = "Malcolm", LastName = "Reynolds", EmailAddress = "captain@serenity.com" });
        }
    }
}
