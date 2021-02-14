using System;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name:");
            string date = DateTime.Today.ToShortDateString();
            string uName = Console.ReadLine();
            string msg = $"\nWelcome {uName}. Today is {date}.";
            Console.WriteLine(msg);

            string path = @"C:\Users\maudi\OneDrive\Documents\GitHub\The-Tech-Academy-Basic-C-Sharp-Projects\Basic_C#_Programs\Scores\Scores\StudentScores.txt";
            string[] lines = System.IO.File.ReadAllLines(path);

            double tScore = 0;
            Console.WriteLine("\nStudent Score:   \n");
            foreach(string line in lines)
            {
                Console.WriteLine("\n" + line); ;
                double score = Convert.ToDouble(line);
                tScore += score;
            }

            double avgScore = tScore / lines.Length;
            Console.WriteLine("\nTotal of " + lines.Length + " Student Scores: \tAverage Score " + avgScore);

            Console.WriteLine("\n\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
