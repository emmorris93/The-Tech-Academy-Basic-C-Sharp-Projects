using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentStep272
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            //Way One
            Employee employee1 = new Employee("Joe", "Smith", 1);
            employees.Add(employee1);

            //Way Two
            Employee employee2 = new Employee();
            employee2.FirstName = "Joe";
            employee2.LastName = "McDougal";
            employee2.Id = 2;
            employees.Add(employee2);

            //Way Three
            employees.Add(new Employee("Fred", "Sanders", 3));
            employees.Add(new Employee("Lucy", "Ball", 4));
            employees.Add(new Employee("Ricky", "Wells", 5));
            employees.Add(new Employee("Julian", "Trombley", 6));
            employees.Add(new Employee("Bubbles", "Smith", 7));
            employees.Add(new Employee("Jim", "Lahey", 8));
            employees.Add(new Employee("Randy", "Roach", 9));
            employees.Add(new Employee("Corey", "Trevor", 10));

            List<Employee> listJoe = new List<Employee>();

            foreach(Employee employee in employees)
            {
                if(employee.FirstName == "Joe")
                {
                    listJoe.Add(employee);
                }
            }

            //lambda expression
            //makes new list of employees called listLambaJoe
            //assigns it the value of employees with firstname Joe
            List<Employee> listLambdaJoe = employees.Where(e => e.FirstName == "Joe").ToList();

            List<Employee> listLambdaId = employees.Where(e => e.Id > 5).ToList();
            
            Console.WriteLine("List of Employees:");
            foreach (Employee employee in employees)
            {
                Console.WriteLine("ID: " + employee.Id + " Name: " + employee.FirstName + " " + employee.LastName);
            }

            Console.WriteLine();
            Console.WriteLine("List of Joe's:");
            foreach (Employee employee in listJoe)
            {
                Console.WriteLine("ID: " + employee.Id + " Name: " + employee.FirstName + " " + employee.LastName);
            }

            Console.WriteLine();
            Console.WriteLine("List Joe's using Lambda Expression:");
            listLambdaJoe.ForEach(employee => 
                {
                    Console.WriteLine("ID: " + employee.Id + " Name: " + employee.FirstName + " " + employee.LastName);
                });

            Console.WriteLine();
            Console.WriteLine("List of IDs Greater than 5 using Lambda Expression:");
            listLambdaId.ForEach(employee =>
            {
                Console.WriteLine("ID: " + employee.Id + " Name: " + employee.FirstName + " " + employee.LastName);
            });

            Console.ReadLine();
        }
    }
}
