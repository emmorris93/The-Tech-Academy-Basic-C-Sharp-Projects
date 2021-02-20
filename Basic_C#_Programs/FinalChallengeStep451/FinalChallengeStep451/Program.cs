using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace FinalChallengeStep451
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new StudentContext())
            {
                Console.WriteLine("Enter new student's first name: ");
                var firstName = Console.ReadLine();

                Console.WriteLine("Enter new student's last name:");
                var lastName = Console.ReadLine();

                Console.WriteLine("Enter new student's email address:");
                var emailAddress = Console.ReadLine();

                var newStudent = new Student
                {
                    FirstName = firstName,
                    LastName = lastName,
                    EmailAddress = emailAddress
                };
                db.Students.Add(newStudent);
                db.SaveChanges();

                var students = from b in db.Students
                            orderby b.FirstName, b.LastName, b.EmailAddress
                            select b;

                foreach(var student in students)
                {
                    Console.WriteLine(student.FirstName + " " + student.LastName + " " + student.EmailAddress);
                }

            }
            
        }
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }

        public virtual List<Student> Students { get; set; }
    }

    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
