using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalChallengeStep451.Models
{
    public class StudentInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<StudentDbContext>
    {
        protected override void Seed(StudentDbContext context)
        {
            var students = new List<Student>
            {
                new Student{FirstName="Carson",LastName="Alexander",EmailAddress="Alexander.Carson@mail.com", StudentId = 1}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            
        }
    }
}
