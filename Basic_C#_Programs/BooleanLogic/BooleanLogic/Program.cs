using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boolean Logical Operator: and &&
            Console.WriteLine(true && false);
            Console.WriteLine(true && true);
            Console.WriteLine(false && false);

            // Boolean Logical Operator: or ||
            Console.WriteLine(true || false);
            Console.WriteLine(true || true);
            Console.WriteLine(false || false);

            // Boolean Logical Operator: equals ==
            Console.WriteLine(true == false);
            Console.WriteLine(true == true);
            Console.WriteLine(false == false);

            // Boolean Logical Operator: does not equal !=
            Console.WriteLine(true != false);
            Console.WriteLine(true != true);
            Console.WriteLine(false != false);

            // Boolean Logical Operator: x or ^
            Console.WriteLine(true ^ false);
            Console.WriteLine(true ^ true);
            Console.WriteLine(false ^ false);


            Console.ReadLine();
        }
    }
}
