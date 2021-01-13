using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//CONSOLE APP ASSIGNMENT PART ONE
//Create a console app the does/contains the following:
//1.A one - dimensional array of strings.
//2. Ask the user to input some text.
//3. A loop that iterates through each string in the array and adds the user's text input to the end of each string. This step will not output anything to the console, but will update each array element by appending the user's text.
//4. Then create a loop that prints off each string in the array on a separate line.
//5. Save and execute your code.

//CONSOLE APP ASSIGNMENT PART TWO
//Add the following to your console app and perform these actions:
//1.An infinite loop.
//2. Save your code.
//3. Fix the infinite loop so that it will execute properly.
//4. Save and execute your code.

//CONSOLE APP ASSIGNMENT PART THREE
//Add the following to your console app and perform these actions:
//1.A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<” operator.
//2. Save and execute your code.
//3. A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator.
//4. Save and execute your code.

//CONSOLE APP ASSIGNMENT PART FOUR
//Add the following to your console app and perform these actions:
//1.A list of strings where each item in the list is unique.
//2. Ask the user to input text to search for in the list.
//3. A loop that iterates through the list and then displays the index of the list that contains matching text on the screen.
//4. Add code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list.
//5. Add code to the loop that stops it from executing once a match has been found.
//6. Save and execute your code.

//CONSOLE APP ASSIGNMENT PART FIVE
//Add the following to your console app and perform these actions:
//1.A list of strings that has at least two identical strings in the list. Ask the user to select text to search for in the list.
//2. Create a loop that iterates through the list and then displays the indices of the list that contain matching text on the screen.
//3. Add code to the loop to check if the user put in text that isn't on the list and, if they did, tells the user their input is not on the list.
//4. Save and execute your code.

//CONSOLE APP ASSIGNMENT PART SIX
//Add the following to your console app and perform these actions:
//1.Create a list of strings that has at least two identical strings in the list.
//2. Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.
//3. Save and execute your code.

namespace ConsoleAppAssignmentStep204
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] charClass = new string[7];
            charClass[0] = "warrior";
            charClass[1] = "cleric";
            charClass[2] = "rogue";
            charClass[3] = "wizard";
            charClass[4] = "ranger";
            charClass[5] = "bard";
            charClass[6] = "paladin";

            Console.WriteLine("Let's go on a dungeon crawling adventure!");
            Console.WriteLine();
            Console.WriteLine("Choose your race: human, elf, dwarf, gnome, halfling");
            string inputText = Console.ReadLine();

            int counter = 10;

            while(true) // Infinite Loop
            {
                Console.Write("*");
                if (counter < 1)
                    break; // Infinite Loop Fix

                counter--;
            }
            
            Console.WriteLine();
            
            counter = 10;
            while (true) // Infinite Loop
            {
                Console.Write("*");
                if (counter <= 0)
                    break; // Infinite Loop Fix

                counter--;
            }
            
            Console.WriteLine();
            
            int i = 0;
            while(i < charClass.Count())
            {
                string item = charClass[i];
                item = inputText + " " + item;
                charClass[i] = item;
                i++;
            }

            Console.WriteLine("You can be these classes:");

            for (int x = 0; x < charClass.Length; x++)
            {
                Console.WriteLine(charClass[x]);
            }

            Console.WriteLine();

            Console.WriteLine("You enter a room with several chests.");

            List<string> weapons = new List<string> { "sword", "flail", "dagger", "staff", "bow", "rapier", "mace" };
            Console.WriteLine("What weapon do you search for?");
            string inputWeapon = Console.ReadLine();

            bool containsWeapon = false;
            for(int w = 0; w < weapons.Count; w++)
            {
                string item = weapons[w];
                if (item.Equals(inputWeapon))
                {
                    Console.WriteLine("You find a " + inputWeapon + " in chest #" + ((int)(w + 1)).ToString() + ".");
                    containsWeapon = true;
                    break;
                }
                
            }
            if(!containsWeapon)
            {
                Console.WriteLine("Sorry, you do not find a " + inputWeapon + " in any of the chests.");
            }

            Console.WriteLine();

            List<string> armor = new List<string> { "plate", "mail", "leather", "cloth", "mail", "plate" };
            Console.WriteLine("What type of armor do you search for?");
            string inputArmor = Console.ReadLine();
            List<int> armorMatches = new List<int>();

            bool containsArmor = false;
            for (int a = 0; a < armor.Count; a++)
            {
                string item = armor[a];
                if (item.Equals(inputArmor))
                {
                    armorMatches.Add(a+1);                    
                    containsArmor = true;                   
                }

            }
            if (containsArmor)
            {
                string formatMatches = String.Join(" and ", armorMatches.ToArray());
                Console.WriteLine("You find " + inputArmor + " armor in chest #" + formatMatches + ".");
            }

            else 
            {
                Console.WriteLine("Sorry, no " + inputArmor + " armor is found in any of the chests.");
            }

            Console.WriteLine();

            Console.WriteLine("Suddenly, these monsters rush in and attack!");
            List<string> mobs = new List<string> { "goblin", "hobgoblin", "skeleton", "zombie", "ghoul", "goblin", "skeleton" };
            List<string> matchedMobs = new List<string>();
            foreach(string item in mobs)
            {
                bool containsMatch = matchedMobs.Contains(item);
                if(containsMatch)
                {
                    Console.WriteLine("Uh oh! Another " + item + " has entered the room.");
                }
                else
                {
                    Console.WriteLine(item);
                    matchedMobs.Add(item);
                }
                

            }

            Console.WriteLine();
            Console.WriteLine("I would run if I were you!");
            Console.ReadLine();

        }
    }
}
