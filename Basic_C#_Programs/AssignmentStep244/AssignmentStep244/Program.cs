using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ASSIGNMENT (Step 244)
//Perform these actions and create a console app that includes the following:
//1. Create an abstract class called Person with two properties: string firstName and string lastName.
//2. Give it the method SayName().
//3. Create another class called Employee and have it inherit from the Person class.
//4. Implement the SayName() method inside of the Employee class.
//5. Inside the Main() method, instantiate an Employee object with firstName "Sample" and lastName "Student". Call the SayName() method on the object.

//ASSIGNMENT (Step 247)
//Perform these actions and create a console app that includes the following:
//1. Create an interface called IQuittable and have it define a void method called Quit().
//2. Have your Employee class from the previous drill inherit that interface and implement the Quit() method in any way you choose.
//3. Use polymorphism to create an object of type IQuittable and call the Quit() method on it. Hint: an object can be of an interface type if it implements that specific interface.

namespace AssignmentStep244
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee
            {
                firstName = "Sample",
                lastName = "Student"
            };
            employee.SayName();
            
            IQuittable polyEmployee = new Employee();
            polyEmployee.Quit();
            
            Console.ReadLine();
        }
    }
}
