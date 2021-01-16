using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatAssignmentStep140
{
    class Program
    {
        static void Main(string[] args)
        {
            // Begin
            Console.WriteLine("The Tech Academy \nStudent Daily Report \n");

            // Questions
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string currentCourse = Console.ReadLine();          

            Console.WriteLine("What page number?");
            int currentPageNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            bool needsHelp = Convert.ToBoolean(Console.ReadLine());
            string helpStatus = Convert.ToString(needsHelp);
            
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperience = Console.ReadLine();
            
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string studentFeedback = Console.ReadLine();        

            Console.WriteLine("How many hours did you study today?");
            int hoursStudied = Convert.ToInt32(Console.ReadLine());
            
            //Console.WriteLine("Student Answers:");
            //Console.WriteLine(studentName);
            //Console.WriteLine(currentCourse);
            //Console.WriteLine(currentPageNum);
            //Console.WriteLine(helpStatus);
            //Console.WriteLine(positiveExperience);
            //Console.WriteLine(studentFeedback);
            //Console.WriteLine(hoursStudied);

            Console.WriteLine("Thank you for your answers.  An instructor will respond to this shortly.  Have a great day!");
            
            Console.ReadLine();
            
        }
    }
}
