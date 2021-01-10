using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//CONSOLE APP ASSIGNMENT (Step 190)
    //Create a console app that does/includes the following:
        //1.Do a boolean comparison using a while statement.
        //2.Do a boolean comparison using a do while statement.

namespace ConsoleAppAssignmentStep190
{
    class Program
    {
        static void Main(string[] args)
        {

            bool guessAgain;
            do
            {
                Console.WriteLine("Guess my favorite color: red, green, purple, yellow, gray, blue, or orange");
                string guess = Console.ReadLine();
                switch (guess.ToLower())
                {
                    case "gray":
                    case "grey":
                        Console.WriteLine("You have chosen ... wisely.");
                        guessAgain = false;
                        break;
                    default:
                        Console.WriteLine("You chose ... poorly.");
                        Console.WriteLine("Do you want to guess again? Y or N");
                        string playAgain = Console.ReadLine();
                        guessAgain = playAgain.ToLower() == "y";
                        break;

                }

            } while (guessAgain);
            Console.WriteLine("Good-bye!");
            Console.Read();

        }
    }
}
