using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypesRepeat
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Maudi";
            int myNumber = 2;
            Console.WriteLine("My name is " + myName + " and my favorite number is " + myNumber);

            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is " + yourName);

            // ctrl + K + C to make a comment
            // ctrl + k + U to uncomment

            Console.WriteLine("What is your favorite number? ");
            int favoriteNumber = Convert.ToInt32(Console.ReadLine());
            int total = favoriteNumber + 5;
            Console.WriteLine("Your favorite number plus 5 is " + total);

            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemperature = -23;
            char questionMark = '\u2103';
            Console.WriteLine(questionMark);
            decimal moneyInBank = 100.4m; // m does not stand for million; just used for decimal numbers
            double heightInCentimeters = 211.30202002;
            float secondsLeft = 2.62f;
            short temperatureOnMars = -341;

            int currentAge = 30;
            string yearsOld = currentAge.ToString();
            Console.WriteLine(yearsOld);

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);
            Console.WriteLine(rainingStatus);
                
            Console.ReadLine();


        }
    }
}
