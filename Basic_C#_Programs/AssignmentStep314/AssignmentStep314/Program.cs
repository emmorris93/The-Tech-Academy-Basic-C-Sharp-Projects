using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentStep314
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // simulate an exception
                // throw new Exception(); 
                int userAge = 0;
                
                // verifies userAge is an integer & verifies that it's a number between 1 and 120
                while (userAge < 1 || userAge > 120)
                {
                    Console.WriteLine("How old are you? ");

                    //try here will throw an exception if they enter a non integer or a number not between 1 and 120
                    try
                    {
                        userAge = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Only enter digits between 1 and 120.\n");
                        continue;
                    }

                    if (userAge < 1 || userAge > 120)
                    {
                        Console.WriteLine("Only enter digits between 1 and 120.\n");
                    }
                }

                // makes userAge a negative number
                userAge = userAge * -1;
                
                Console.WriteLine("Have you already had your birthday for 2021? ");

                // if userAnswer is no, subtracts a year
                string userAnswer = (Console.ReadLine().ToLower());
                if (userAnswer == "no" || userAnswer == "n")
                {
                    userAge--;
                }
                // skips the if loop when answer is yes
                int getUserBirthYear = DateTime.Now.AddYears(userAge).Year;
                Console.WriteLine("Your birth year is " + getUserBirthYear + ".");

                Console.ReadLine();
            }
            // General message exception
            catch (Exception)
            {
                Console.WriteLine("An error has occurred.  Contact your system administrator.");
                Console.ReadLine();
            }
        }
    }
}
