using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Math Operators:
            // Addition +
            int total = 5 + 10;
            int otherTotal = 12 + 22;
            int combined = total + otherTotal;
            Console.WriteLine("Five plus Ten = " + total.ToString());
            Console.WriteLine("Twelve plus Twenty-Two = " + otherTotal.ToString());
            Console.WriteLine("Their combined total = " + combined.ToString());

            // Subtraction -
            int difference = 10 - 5;
            Console.WriteLine("Ten minus Five = " + difference.ToString());

            // Multiplication *
            int product = 10 * 5;
            Console.WriteLine("Ten times Five = " + product.ToString());

            // Division /
            int quotient = 100 / 5;
            Console.WriteLine("One Hundred divided by Five = " + quotient.ToString());

            double quotient2 = 100.0 / 17.0;
            Console.WriteLine("One Hundred divided by Seventeen = " + quotient2.ToString());

            // Remainder or Modulus Operator %
            int remainder = 10 % 2;
            Console.WriteLine("Ten divided by Two has a remainder of " + remainder.ToString());

            int remainder2 = 11 % 2;
            Console.WriteLine("Eleven divided by Two has a remainder of " + remainder2.ToString());
      

            // Comparison Operators: output a boolean value (true or false)

            bool trueOrFalse = 12 > 5;
            Console.WriteLine(trueOrFalse.ToString());

            bool trueOrFalseB = 12 < 5;
            Console.WriteLine(trueOrFalseB.ToString());

            int roomTemperature = 70;
            int currentTemperature = 72;
            
            // Greater Than
            //bool isWarm = currentTemperature > roomTemperature;

            // Less Than
            //bool isWarm = currentTemperature < roomTemperature;

            // Greater Than or Equal To
            //bool isWarm = currentTemperature >= roomTemperature;

            // Lesser than or Equal To
            //bool isWarm = currentTemperature <= roomTemperature;

            // Equal To
            //bool isWarm = currentTemperature == roomTemperature;

            // NOT Equal To
            bool isWarm = currentTemperature != roomTemperature;
            Console.WriteLine(isWarm);
            Console.ReadLine();




        }
    }
}
