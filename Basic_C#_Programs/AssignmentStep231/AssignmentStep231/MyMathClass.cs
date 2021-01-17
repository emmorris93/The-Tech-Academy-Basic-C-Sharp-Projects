using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentStep231
{
    public class MyMathClass
    {
        public void DivideMethod(int numInput)
        {
            int divideByTwo = numInput / 2;
            Console.WriteLine(divideByTwo);
        }

        public void DivideMethod(int numInput, out int numOutput)
        {
            int divideByTwo = numInput / 2;
            numOutput = divideByTwo;
        }

        public void DivideMethod(decimal numInput)
        {
            decimal divideByTwo = numInput / 2;
            Console.WriteLine(divideByTwo);
        }
    }

    public static class MyStaticMathClass
    {
        public static void DivideMethod(int numInput)
        {
            int divideByTwo = numInput / 2;
            Console.WriteLine(divideByTwo);
        }

        public static void DivideMethod(int numInput, out int numOutput)
        {
            int divideByTwo = numInput / 2;
            numOutput = divideByTwo;
        }

        public static void DivideMethod(decimal numInput)
        {
            decimal divideByTwo = numInput / 2;
            Console.WriteLine(divideByTwo);
        }
    }
}

