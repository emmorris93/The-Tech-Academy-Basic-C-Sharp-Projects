using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ASSIGNMENT
// Perform these actions and create a console app that includes the following:
// 1. Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.

namespace AssignmentStep252
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee
            {
                firstName = "Mary Jane",
                lastName = "Watson"
            };
            employee.ListName();

            Employee employee2 = new Employee
            {
                firstName = "Peter",
                lastName = "Parker"
            };
            employee2.ListName();

            employee.Id = 1;
            employee2.Id = 2;

            bool AreTheyEqual = employee == employee2;
            Console.WriteLine("Are they equal? " + AreTheyEqual);

            employee2.Id = 1;

            AreTheyEqual = employee == employee2;
            Console.WriteLine("Now, are they equal? " + AreTheyEqual);

            Console.ReadLine();

        }

    }
}
