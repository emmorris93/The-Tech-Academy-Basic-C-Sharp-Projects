using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            // Branching
            int currentTemperature = 75;
            int roomTemperature = 70;

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            int userTemperature = Convert.ToInt32(Console.ReadLine());

            if (currentTemperature == roomTemperature)
            {
                Console.WriteLine("It is exactly room temperature.");
            }
            else if (currentTemperature > roomTemperature)
            {
                Console.WriteLine("It is warmer than room temperature.");
            }
            else if (roomTemperature > currentTemperature)
            {
                Console.WriteLine("It is warmer than room temperature.");
            }
            else
            {
                Console.WriteLine("It is not exactly room temperature.");
            }

            // Ternary Operator
            string comparisonResult = currentTemperature == roomTemperature ? "It is room temp." : "It is not room temp.";
            Console.WriteLine(comparisonResult);

            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());
            string result = favNum == 2 ? "We have the same favorite number!" : "We do not have the same favorite number.";
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
