using System;

namespace myConsoleProject
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
            Console.Read();
        }
    }
}

// namespace is an added layer of organization for your code; Namespaces make it easier to remember where items are stored
// class is an organized grouping of code which can also be used to define very specific ways that data works together
// static void Main(string[] args) is a function named Main that takes an argument named args

// solution is a container for storing projects
// project is an application

// Properties: Gives you advanced access to a project’s properties – which vary depending on the type of application being built.
// A reference is a value that allows a program to indirectly access data in memory. References is where internal and external Libraries 
//      are referenced (listed records that contain references about data). Part of the power of C# and .NET is its wide range of 3rd 
//      party libraries available for inclusion into an application. Any time a library is included in a project, you’ll find it listed under References.
// App.Config: A file that contains very specific configuration settings for the project
