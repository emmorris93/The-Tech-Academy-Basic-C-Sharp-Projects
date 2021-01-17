using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ASSIGNMENT
//Perform these actions and create a console app that includes the following:
//1. Create a class. In that class, create a void method that outputs an integer. Have the method divide the data passed to it by 2.
//2. In the Main() method, instantiate that class.
//3. Have the user enter a number. Call the method on that number. Display the output to the screen. It should be the entered number, divided by two.
//4. Create a method with output parameters.
//5. Overload a method.
//6. Declare a class to be static.

namespace AssignmentStep231
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a whole number:");
            int numInput = Convert.ToInt32(Console.ReadLine());

            int numOutput;
            MyMathClass myClass = new MyMathClass();
            myClass.DivideMethod(numInput, out numOutput);
            Console.WriteLine(numOutput);

            Console.ReadLine();
        }
    }
}
