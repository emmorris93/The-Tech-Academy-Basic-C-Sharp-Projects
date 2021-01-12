using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        int indexMeat = -1;
        string[] stringArray = { "crawfish", "shrimp", "chicken", "sausage", "crab" };
        bool askMeat = true;
        while (askMeat)
        {
            Console.WriteLine("Enter a number from 0 to 4");
            string recipeMeat = Console.ReadLine();
            indexMeat = Convert.ToInt32(recipeMeat);
            if (indexMeat > 4 || indexMeat < 0)
                Console.WriteLine("Invalid number.");
            else
            {
                Console.WriteLine(stringArray[indexMeat]);
                askMeat = false;
            }

        }

        int indexDish = -1;
        List<string> stringList = new List<string>();
        stringList.Add("gumbo");
        stringList.Add("etouffee");
        bool askDish = true;
        while (askDish)
        {         
            Console.WriteLine("Enter a number from 0 - 1");
            string cajunDish = Console.ReadLine();
            indexDish = Convert.ToInt32(cajunDish);
            if (indexDish > 2 || indexDish < 0)
                Console.WriteLine("Invalid number.");
            else
            {
                Console.WriteLine(stringList[indexDish]);
                askDish = false;
            }
        }

        Console.WriteLine("Your cajun dish is: " + stringArray[indexMeat] + " " + stringList[indexDish]);

        int[] numArray = { 2, 16, 5, 8, 75, 93, 73, 96, 98, 2007, 2021 };
        bool askNum = true;
        while (askNum)
        {
            Console.WriteLine("Enter a number from 0 to 10");
            string num = Console.ReadLine();
            int indexNum = Convert.ToInt32(num);

            if (indexNum > 10 || indexNum < 0)
                Console.WriteLine("Invalid number.");
            else
            {
                Console.WriteLine("Your number is: " + numArray[indexNum]);
                askNum = false;
            }
                
        }

        Console.ReadLine();
    }
}

