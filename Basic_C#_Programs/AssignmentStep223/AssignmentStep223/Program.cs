using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ASSIGNMENT (Step 223)
//Perform these actions and create a console app that includes the following:
//1. Create a class. In that class, create three methods, each of which will take one integer parameter in and return
//an integer. The methods should do some math operation on the received parameter. Put this class in a separate.cs 
//file in the application.
//2. In the Main() program, ask the user what number they want to do the math operations on.
//3. Call each method in turn, passing the user input to the method. Display the returned integer to the screen.

namespace AssignmentStep223
{
    class Program
    {
        static Room Entrance;
        static Room CurrentRoom;
        static string playerName = "";
        static bool isExitVisible;
        static void Main(string[] args)

        {                                  
            Console.WriteLine("Greetings adventurer!  What is your name?");
            playerName = Console.ReadLine();
            CreateRooms();
            CurrentRoom = Entrance;
            Console.WriteLine("Congratulations, " + playerName + ". You have found Ixol's Tomb.");
            Console.WriteLine("You approach the rotting wood door and push it open.");

            while (true)
            {
                Console.WriteLine(CurrentRoom.Name);
                Console.WriteLine(CurrentRoom.Description);
                if (CurrentRoom != Entrance && CurrentRoom.Op != "Exit")
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    int result = 0, myNumber = 50;
                    switch (CurrentRoom.Op)
                    {
                        case "multiplication":
                            result = MyMathClass.Multiply(number);
                            break;
                        case "addition":
                            result = myNumber + number;
                            break;
                        case "subtraction":
                            result = myNumber - number;
                            break;
                    }
                    Console.WriteLine(String.Format(@"You receive {0} experience {1}", result, "."));
                }
                if(CurrentRoom.Op == "Exit")
                {
                    Console.WriteLine("You have left the tomb. \nPress any key to exit.");
                    Console.ReadLine();
                    break;
                }
                CurrentRoom.ShowExits();

                Console.WriteLine("Choose a direction:");
                string Direction = Console.ReadLine();

                CurrentRoom = CurrentRoom.Exits[Direction];
                if(!isExitVisible)
                    CreateExit();
            }
        }

        private static void CreateExit()
        {
            Room SouthRoom = new Room();
            Entrance.Exits.Add("south", SouthRoom);
            SouthRoom.Op = "Exit";
            isExitVisible = true;
        }
        
        private static void CreateRooms()
        {
            // create Entrance
            Entrance = new Room();
            Room LeftRoom = new Room();
            Room NorthRoom = new Room();
            Room RightRoom = new Room();         

            Entrance.Description = "The moldering tomb looms before you.";
            Entrance.Name = "You enter the foyer.";
            Entrance.Op = "none";

            RightRoom.Description = "A scorched skeleton rises from a pile of ashes on the floor.  It's jaws crack as it faintly whispers, \"I need my number.\"  Tell the skeleton a whole number between 1 and 10.";
            RightRoom.Name = "You enter a crematorium.";
            RightRoom.Op = "addition";

            NorthRoom.Description = "The lich, Ixol, sits upon his dais.  As you approach, his eyes open.  He speaks in a raspy voice, \"Welcome " + playerName + ". I have waited many years for you to tell me my number. What is my number?\"  Tell Ixol a whole number between 1 and 10.";
            NorthRoom.Name = "You enter a mausoleum.";
            NorthRoom.Op = "multiplication";

            LeftRoom.Description = "A ghoul turns as you enter, licks his lips and smiles. \"I hunger!\" he hisses. \"Feed me!\" You have 10 biscuits in your backpack.  How many biscuits do you toss towards the ghoul?";
            LeftRoom.Name = "You enter an embalming chamber";
            LeftRoom.Op = "subtraction";

            Entrance.Exits.Add("west", RightRoom);
            Entrance.Exits.Add("east", LeftRoom);
            Entrance.Exits.Add("north", NorthRoom);
            
            LeftRoom.Exits.Add("west", Entrance);
            RightRoom.Exits.Add("east", Entrance);
            NorthRoom.Exits.Add("south", Entrance);       

        }
    }
}
