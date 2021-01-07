using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//BRANCHING ASSIGNMENT (Step 185)
//Your job is to create a console-based application for getting a shipping quote for a package.
    //REQUIREMENTS:
        //1.The first line of the program must be: “Welcome to Package Express. Please follow the instructions below.”
        //2. The user must then be prompted for the package weight.
        //3. If the weight is greater than 50, display the error message, “Package too heavy to be shipped via Package Express. Have a good day.” At this point the program would end.
        //4. The user must then be prompted for the package width.
        //5. Then the package height.
        //6. Then the package length.
        //7. If the dimensions total greater than 50, display the error message, “Package too big to be shipped via Package Express.” At this point the program would end.
        //8. Next, multiply the three dimensions (height, width, & length) together, and multiply the product by the weight. Finally, divide the outcome by 100.
        //9. The result of that calculation is the quote.
        //10. Display the quote to the user as a dollar amount.

namespace BranchingAssignmentStep185
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Package Express.  Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            string pkgWeightInput = Console.ReadLine();
            float pkgWeight = float.Parse(pkgWeightInput);
            if (pkgWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.  Have a good day.");
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
                string pkgWidthInput = Console.ReadLine();
                float pkgWidth = float.Parse(pkgWidthInput);

                Console.WriteLine("Please enter the package height:");
                string pkgHeightInput = Console.ReadLine();
                float pkgHeight = float.Parse(pkgHeightInput);

                Console.WriteLine("Please enter the package length:");
                string pkgLengthInput = Console.ReadLine();
                float pkgLength = float.Parse(pkgLengthInput);

                float pkgTotalDimensions = pkgWidth + pkgHeight + pkgLength;

                if (pkgTotalDimensions >= 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    float pkgDimensionsProduct = pkgWidth * pkgHeight * pkgLength;
                    float pkgAmount = pkgDimensionsProduct * pkgWeight;
                    float pkgTotal = pkgAmount / 100;
                    float pkgTotalDollar = pkgTotal;
                    Console.WriteLine("Your estimated total for shipping is: " + pkgTotalDollar.ToString("C2") + "\n" + "Thank you!");

                }
            }
            
            Console.ReadLine();
        }
    }
}
