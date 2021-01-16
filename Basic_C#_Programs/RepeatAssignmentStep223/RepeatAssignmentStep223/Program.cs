using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ASSIGNMENT Step 223
// Perform these actions and create a console app that includes the following:
//1. Create a class. In that class, create three methods, each of which will take one integer parameter in and return an integer. The methods should do some math operation on the received parameter. Put this class in a separate.cs file in the application.
//2. In the Main() program, ask the user what number they want to do the math operations on.
//3. Call each method in turn, passing the user input to the method.Display the returned integer to the screen.

namespace RepeatAssignmentStep223
{
    class Program
    {
        static void Main(string[] args)
        {
            // In the Main() program, ask the user what number they want to do the math operations on.
            Console.WriteLine("User, what number do you want to do math operations on?");
            int userNum = Convert.ToInt32(Console.ReadLine());

            // Call each method in turn, passing the user input to the method.
            // Display the returned integer to the screen.
            Console.WriteLine(myMathClass.myNum + " + " + userNum + " = " + myMathClass.Addition(userNum));
            Console.WriteLine(myMathClass.myNum + " - " + userNum + " = " + myMathClass.Subtraction(userNum));
            Console.WriteLine(myMathClass.myNum + " x " + userNum + " = " + myMathClass.Multiplication(userNum));

            Console.ReadLine();
        }

        
    }
}
