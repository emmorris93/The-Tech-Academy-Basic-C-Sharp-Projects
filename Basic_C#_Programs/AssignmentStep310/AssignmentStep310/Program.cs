using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ASSIGNMENT
//Perform these actions and create a console app that includes the following:
//1. Create a const variable.
//2. Create a variable using the keyword "var.”
//3. Chain two constructors together.

namespace AssignmentStep310
{
    public class Program
    {
        const string GameName = "Welcome to Ixol's Tomb";

        static Program()
        {
            Console.WriteLine(GameName);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nEnter your character name: ");
            var player = new Player(Console.ReadLine());
            Console.WriteLine("\nPlayer ID: " + player.Id.ToString());
            Console.WriteLine("Character Name: " + player.Name);
            Console.ReadLine();
        }
    }

    public class Player
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }

        public Player()
        {
            this.Id = Guid.NewGuid();
        }

        public Player(string name) : this()
        {
            this.Name = name;
        }
    }
}
