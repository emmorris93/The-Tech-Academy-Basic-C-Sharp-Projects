using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//MATH AND COMPARISON OPERATORS ASSIGNMENT (Step 159)
//Your job is to create an anonymous income comparison program.
    //REQUIREMENTS:
        //1.The program must start by printing “Anonymous Income Comparison Program” to the screen.
        //2. It must then print “Person 1” to the screen and get the following details:
            //Hourly Rate
            //Hours worked per week
        //3. It must then print “Person 2” to the screen and then get the following details:
            //Hourly rate
            //Hours worked per week
        //4. It must then print to the screen “Annual salary of Person 1:” and display the exact salary below it.
        //5. It must then print to the screen “Annual salary of Person 2:” and display the exact salary below it.
        //6. It must then print to the screen “Does Person 1 make more money than Person 2?” and write the true or false value of this statement below it.

namespace Assignment159
{
    class Program
    {
        static void Main(string[] args)
        {
            // Person 1
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string hourlyRateInput = Console.ReadLine();
            int rateInput1 = Convert.ToInt32(hourlyRateInput);
            Console.WriteLine("Hours Worked Per Week?");
            string hoursWorkedInput = Console.ReadLine();
            int workedInput1 = Convert.ToInt32(hoursWorkedInput);
            int annualSalary1 = rateInput1 * workedInput1 * 52;

            // Person 2
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string hourlyRateInput2 = Console.ReadLine();
            int rateInput2 = Convert.ToInt32(hourlyRateInput2);
            Console.WriteLine("Hours Worked Per Week?");
            string hoursWorkedInput2 = Console.ReadLine();
            int workedInput2 = Convert.ToInt32(hoursWorkedInput2);
            int annualSalary2 = rateInput2 * workedInput2 * 52;

            // Annual Salary
            Console.WriteLine("Annual Salary of Person 1:");
            Console.WriteLine(annualSalary1);
            Console.WriteLine("Annual Salary of Person 2:");
            Console.WriteLine(annualSalary2);

            // Bool

            bool whoMakesMore = annualSalary1 > annualSalary2;
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(whoMakesMore.ToString());

            Console.ReadLine();
        }
    }
}
