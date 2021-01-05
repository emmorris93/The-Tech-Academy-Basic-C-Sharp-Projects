using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy" + "\n" + "Student Daily Report" + "\n");
                        
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumber);

            Console.WriteLine("Do you need help with anything? please answer \"true\" or \"false\".");
            string helpAnswerInput = Console.ReadLine();
            bool needsHelp = Convert.ToBoolean(helpAnswerInput);

            Console.WriteLine("Were there any positive experiences you'd like to share? Please be specific.");
            string positiveExperiences = Console.ReadLine();
            
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            
            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            int hoursStudied = Convert.ToInt32(studyHours);

            Console.WriteLine("Thank you for your answers.  An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
