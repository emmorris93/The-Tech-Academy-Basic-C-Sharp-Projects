using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ASSIGNMENT (Step 227)
//Perform these actions and create a console app that includes the following:
//1.Create a class. In that class, create a method that takes two integers as parameters. Make one of them optional. Have the method do a math operation and return an integer result.
//2. In the Main() method of the console app, instantiate the class.
//3.Ask the user to input two numbers, one at a time. Let them know they need not enter anything for the second number.
//4. Call the method in the class, passing in the one or two numbers entered.
//5. Try various combinations of numbers on the code, including having no second number.

namespace AssignmentStep227
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input two integers: ");
            Console.WriteLine("Enter integer One:");
            int inputOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter integer Two (optional):");
            string rawInputTwo = Console.ReadLine();
            int inputTwo = int.MinValue;
            try
            {
                inputTwo = Convert.ToInt32(rawInputTwo);
            }

            catch
            {
                // do nothing
            }
            

            MyMathClass myClass = new MyMathClass();
            if(inputTwo == int.MinValue)
               Console.WriteLine(myClass.MultiplicationMethod(inputOne));
            else
            {
                Console.WriteLine(myClass.MultiplicationMethod(inputOne, inputTwo));
            }

            Console.ReadLine();
        }
    }
}
