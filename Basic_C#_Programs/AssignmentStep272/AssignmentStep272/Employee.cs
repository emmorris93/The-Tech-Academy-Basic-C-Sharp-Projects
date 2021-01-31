using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ASSIGNMENT (Step 272)
//Perform these actions and create a console app that includes the following:
//1. In the Main() method, create a list of at least 10 employees. Each employee should have a first and last name, as well as an Id. At least two employees should have the first name "Joe".
//2. Using a foreach loop, create a new list of all employees with the first name "Joe".
//3. Perform the same action again, but this time with a lambda expression.
//4. Using a lambda expression, make a list of all employees with an Id number greater than 5.

namespace AssignmentStep272
{
    public class Employee
    {
        /// <summary>
        /// constructor: makes an object of class
        /// </summary>
        public Employee()
        {

        }

        /// <summary>
        /// constructor: takes firstName, lastName and id as input parameters, returns object with
        /// the properties set
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="id"></param>
        public Employee(string firstName, string lastName, int id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = id;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
    }
}
