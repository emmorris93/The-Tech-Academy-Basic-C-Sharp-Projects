using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//ASSIGNMENT (Step 255)
//Perform these actions and create a console app that includes the following:
//1. Make the Employee class take a generic type parameter.
//2. Add a property to the Employee class called "things" and have its data type be a generic list matching the generic type of the class.
//3. Instantiate an Employee object with type "string" as its generic parameter. Assign a list of strings as the property value of Things.
//4. Instantiate an Employee object with type "int" as its generic parameter. Assign a list of integers as the property value of Things.
//5. Create a loop that prints all of the Things to the Console.

namespace AssignmentStep255
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string> { "Employee", "Contract", "Temporary" };

            Employee<int> employee1 = new Employee<int>();
            employee1.Things = new List<int> { 1, 2, 3 };

            foreach (string thing in employee.Things)
            {
                Console.WriteLine(thing);
            }

            foreach (int thing in employee1.Things)
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();
        }
    }
}
