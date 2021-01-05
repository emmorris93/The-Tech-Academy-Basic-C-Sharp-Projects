using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//CONSOLE APPLICATION ASSIGNMENT (Step 158)
    //In Visual Studio, create a console application that does the following:
        //1. Takes an input from the user, multiplies it by 50, then prints the result to the console. (Note: make sure your code can take inputs larger than 10,000,000).
        //2. Takes an input from the user, adds 25 to it, then prints the result to the console.
        //3. Takes an input from the user, divides it by 12.5, then prints the result to the console.
        //4. Takes an input from the user, checks if it is greater than 50, then prints the true/false result to the console.
        //5. Takes an input from the user, divides it by 7, then prints the remainder to the console (tip: think % operator).

namespace ConsoleApplicationAssignmentStep158
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            string userInput = Console.ReadLine();
            int numInput = Convert.ToInt32(userInput);
            long numProduct = numInput * 50;
            int numTotal = numInput + 25;
            float numQuotient = numInput / 12.5f;
            bool greaterThan = numInput > 50;
            int numRemainder = numInput % 7;
            Console.WriteLine(userInput.ToString() + " x 50 = " + numProduct.ToString());
            Console.WriteLine(userInput.ToString() + " + 25 = " + numTotal.ToString());
            Console.WriteLine(userInput.ToString() + " / 12.5 = " + numQuotient.ToString());
            Console.WriteLine(userInput.ToString() + " > 50? " + greaterThan.ToString());
            Console.WriteLine(userInput.ToString() + " / 7 has a remainder of: " + numRemainder.ToString());
            Console.ReadLine();


        }
    }
}
