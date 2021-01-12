using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Maudi";
            // the \ escape character before the "" makes the "" marks part of the string
            // the \n escape character makes a new line
            // the \t escape character makes it tab
            string quote = "The man said, \"Hello\", Maudi. \n Hello on a new line. \n \t Hello on a tab.";
            // the \\ makes one of the \ part of the string
            string fileName = "C:\\Users\\Maudi";
            // The @ sign says everything inside the "" marks is part of the string
            string fileName2 = @"C:\\Users\\Maudi"; 

            bool trueOrFalse = name.Contains("s");
            trueOrFalse = name.EndsWith("s");

            int length = name.Length;

            //name = name.ToUpper();
            //name = name.ToLower();

            //name = "Joe";

            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Jesse.");




            Console.WriteLine(sb);
            Console.WriteLine(name);
            Console.WriteLine(quote);
            Console.WriteLine(fileName);
            Console.WriteLine(fileName2);
            Console.ReadLine();
        }
    }
}
