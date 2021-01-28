using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatAssignmentStep223
{
    // Create a class. 
    // In that class, create three methods, each of which will take one integer parameter in and return an integer.
    // The methods should do some math operation on the received parameter.
    // Put this class in a separate.cs file in the application.

    public class myMathClass
    {
        public static int myNum = 50;

        // Multiplication
        public static int Multiplication(int userNum)
        {
            return myNum * userNum;
        }

        // Subtraction
        public static int Subtraction(int userNum)
        {
            return myNum - userNum;
        }

        // Multiplication
        public static int Addition(int userNum)
        {
            return myNum + userNum;
        }
    }
}
