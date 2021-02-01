using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ASSIGNMENT
//Perform these actions and create a console app that includes the following:
//1. Prints the current date and time to the console.
//2. Asks the user for a number.
//3. Prints to the console the exact time it will be in X hours, 
//   X being the number the user entered in step 2.

namespace AssignmentStep300
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            DateTime dt = DateTime.Now;
            Console.WriteLine("Current time: " + dt.ToString());

            Console.WriteLine("\nEnter a number of hours: ");
            int x = Convert.ToInt32(Console.ReadLine());

            DateTime modifiedDateTime = dt.AddHours(x);
            
            Console.WriteLine("\nIn " + x + " hours: " + modifiedDateTime.ToString());

            Console.ReadLine();
        }
    }
}
