using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentStep223
{
    public class Room
    {
        public string Name;
        public string Op;
        public string Description;
        public Dictionary<string, Room> Exits = new Dictionary<string, Room>();

        public Room()
        {

        }

        public void ShowExits()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("You can go:");
            int i = 0;
            foreach(string direction in Exits.Keys)
            {
                if (i == 0)
                    sb.Append(direction);
                else
                    sb.Append(" " + direction);
                i++;

            }
            Console.WriteLine(sb.ToString());
        }
    }
}
