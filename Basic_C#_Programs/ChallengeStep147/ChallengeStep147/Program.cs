using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//CHALLENGE (Step 147 )
    //With Visual Studio, perform the following with C#:
        //1. Add two numbers and display the output in the console.
        //2. Subtract two numbers and display the output in the console.
        //3. Multiply two numbers and display the output in the console.
        //4. Divide two numbers and display the output in the console.

namespace ChallengeStep147
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add Two Numbers:");
            int num1 = 10;
            int num2 = 10;
            int numTotal = num1 + num2;
            Console.WriteLine(num1.ToString() + " + " + num2.ToString() + " = " + numTotal.ToString());
            

            Console.WriteLine("Subtract Two Numbers:");
            int num3 = 502;
            int num4 = 2;
            int numDifference = num3 - num4;
            Console.WriteLine(num3.ToString() + " - " + num4.ToString() + " = " + numDifference.ToString());
            

            Console.WriteLine("Multiply Two Numbers:");
            int num5 = 50;
            int num6 = 40;
            int numProduct = num5 * num6;
            Console.WriteLine(num5.ToString() + " x " + num6.ToString() + " = " + numProduct.ToString());

            Console.WriteLine("Divide Two Numbers:");
            int num7 = 26;
            int num8 = 2;
            int numQuotient = num7 / num8;
            Console.WriteLine(num7.ToString() + " / " + num8.ToString() + " = " + numQuotient.ToString());
            Console.ReadLine();

        }
    }
}
