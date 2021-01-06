using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//BOOLEAN LOGIC ASSIGNMENT (Step 168)
//Your job is to create a basic approval program for car insurance. It will ask the applicant some questions and return a “true” or “false” at the end to determine whether or not the applicant qualified for car insurance.
    //REQUIREMENTS:
        //1) Your application must ask these questions:
            //What is your age ?
            //Have you ever had a DUI?
            //How many speeding tickets do you have?
        //2) Use the following qualification rules to determine if the applicant qualifies for car insurance:
            //Applicants must be over 15 years old.
            //Applicants must not have any DUI’s.
            //Applicants must not have more than 3 speeding tickets.
        //3) Print the result of the boolean expression created from the above business rules.

namespace BooleanLogicAssignmentStep168
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string ageInput = Console.ReadLine();
            int userAge = Convert.ToInt32(ageInput);
            bool ageQualified = userAge >= 15;

            Console.WriteLine("Have you ever had a DUI?");
            string hadDuiInput = Console.ReadLine();
            bool duiQualified = hadDuiInput == "yes" || hadDuiInput == "Yes";        

            Console.WriteLine("How many speeding tickets do you have?");
            string ticketsInput = Console.ReadLine();
            int ticketsNumber = Convert.ToInt32(ticketsInput);
            bool ticketsQualified = ticketsNumber <= 3;

            Console.WriteLine("Qualified?");
            bool userQualified = userAge >= 15 && ticketsNumber <= 3 && duiQualified == false;
            Console.WriteLine(userQualified);
            Console.ReadLine();
        }
    }
}
