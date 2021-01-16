using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatChallengeStep147
{
    class Program
    {
        static void Main(string[] args)
        {
            // Addition
            Console.WriteLine("Let's add two numbers!  \nEnter your first number:");
            int addNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second number:");
            int addNum2 = Convert.ToInt32(Console.ReadLine());
            int addTotal = addNum1 + addNum2;
            Console.WriteLine(addNum1 + " + " + addNum2 + " = " + addTotal);

            // Subtraction
            Console.WriteLine("\nNow, let's subtract two numbers!  \nEnter your first number:");
            int subtractNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second number:");
            int subtractNum2 = Convert.ToInt32(Console.ReadLine());
            int subtractTotal = subtractNum1 - subtractNum2;
            Console.WriteLine(subtractNum1 + " - " + subtractNum2 + " = " + subtractTotal);

            // Multiplication
            Console.WriteLine("\nOk, let's multiply two numbers!  \nEnter your first number:");
            int multiplyNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second number:");
            int multiplyNum2 = Convert.ToInt32(Console.ReadLine());
            int multiplyTotal = multiplyNum1 * multiplyNum2;
            Console.WriteLine(multiplyNum1 + " x " + multiplyNum2 + " = " + multiplyTotal);


            // Division
            Console.WriteLine("\nFinally, let's divide two numbers!  \nEnter your first number:");
            int divideNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second number:");
            int divideNum2 = Convert.ToInt32(Console.ReadLine());
            int divideTotal = divideNum1 / divideNum2;
            Console.WriteLine(divideNum1 + " / " + divideNum2 + " = " + divideTotal);

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadLine();
        }
    }
}
