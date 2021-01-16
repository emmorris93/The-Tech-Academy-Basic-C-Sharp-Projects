using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatMathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Math Operators

            // Addition
            Console.WriteLine("Addition Operator:");
            int total = 5 + 10;
            int otherTotal = 12 + 22;
            int combined = total + otherTotal;
            Console.WriteLine("5 + 10 = " + total.ToString());
            Console.WriteLine("12 + 22 = " + otherTotal.ToString());
            Console.WriteLine("Combined Total = " + combined.ToString());

            // Subtraction
            Console.WriteLine("\nSubtraction Operator");
            int difference = 10 - 5;
            Console.WriteLine("10 - 5 = " + difference.ToString());

            // Multiplication
            Console.WriteLine("\nMultiplication Operator");
            int product = 10 * 5;
            Console.WriteLine("10 x 5 = " + product.ToString());

            // Division
            Console.WriteLine("\nDivision Operator");
            int quotient = 100 / 5;
            Console.WriteLine("100 / 5 = " + quotient.ToString());

            Console.WriteLine();
            int quotient2 = 100 / 17;
            Console.WriteLine("100 / 17 = " + quotient2.ToString());
            // int will round the answer
            
            Console.WriteLine();
            double quotient3 = 100 / 17;
            Console.WriteLine("100.0 / 17.0 = " + quotient3.ToString());
            // double will display the decimal

            // Modulus Operator
            Console.WriteLine("\nModulus Operator");
            int remainder = 10 % 2;
            Console.WriteLine("10 / 2 has a remainder of " + remainder);

            Console.WriteLine();
            int remainder2 = 11 % 2;
            Console.WriteLine("11 / 2 has a remainder of " + remainder2);


            // Comparison Operators

            Console.WriteLine("\nComparison Operators \nGreater Than");
            bool trueOrFalse = 12 > 5;
            Console.WriteLine("Is 12 > 5? " + trueOrFalse);
            Console.WriteLine("\nLess Than");
            bool trueOrFalse2 = 12 < 5;
            Console.WriteLine("Is 12 < 5? " + trueOrFalse2);

            int roomTemp = 70;
            int currentTemp = 72;
            bool isWarm = currentTemp > roomTemp;
            Console.WriteLine("\n72 < 70 = " + isWarm);

            Console.WriteLine("\nGreater Than or Equal Too");
            int roomTemp2 = 70;
            int currentTemp2 = 70;
            bool isWarm2 = currentTemp2 >= roomTemp2;
            Console.WriteLine("\n70 >= 70 = " + isWarm2);

            Console.WriteLine("\nEqual Too");
            int roomTemp3 = 70;
            int currentTemp3 = 70;
            bool isWarm3 = currentTemp3 == roomTemp3;
            Console.WriteLine("Does 70 = 70? " + isWarm3);

            Console.WriteLine("\nNot Equal Too");
            int roomTemp4 = 70;
            int currentTemp4 = 70;
            bool isWarm4 = currentTemp4 != roomTemp4;
            Console.WriteLine("Is 70 not equal to 70? " + isWarm4);


            Console.ReadLine();
        }
    }
}
