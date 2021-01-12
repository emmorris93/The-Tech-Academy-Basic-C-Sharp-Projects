using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ASSIGNMENT (Step 193)
    //Create a console app that does/includes the following:
        //1) Concatenates three strings.
        //2) Converts a string to uppercase.
        //3) Creates a Stringbuilder and builds a paragraph of text, one sentence at a time.

namespace AssigmentStep193
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            string a = "Rush: ", b = "The ", c = "Trees";
            sb.Append(a.ToUpper());
            sb.Append(b);
            sb.AppendLine(c);
            sb.AppendLine();

            sb.AppendLine("There is unrest in the forest");
            sb.AppendLine("There is trouble with the trees");
            sb.AppendLine("For the maples want more sunlight");
            sb.AppendLine("And the oaks ignore their pleas");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}