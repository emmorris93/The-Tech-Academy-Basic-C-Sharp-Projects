using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//ASSIGNMENT (Step 297)
//Perform these actions and create a console app that includes the following:
//1. Asks the user for a number.
//2. Logs that number to a text file.
//3. Prints the text file back to the user.

namespace AssignmentStep297
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a whole number:");
            int answer = Convert.ToInt32(Console.ReadLine());
            string textLine;
            using(StreamWriter file = new StreamWriter(@"C:\Users\maudi\logs\log.txt", true))
            {
                file.WriteLine(answer);
            }
            using(StreamReader reader = new StreamReader(@"C:\Users\maudi\logs\log.txt"))
            {
                textLine = reader.ReadToEnd();
            }

            Console.WriteLine("You entered: " + answer + "\n");

            Console.WriteLine("Number Log: \n" + textLine);
            
            Console.ReadLine();
        }
    }
}
