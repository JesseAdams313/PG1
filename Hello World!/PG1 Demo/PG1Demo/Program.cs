using System;

namespace PG1Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Display "Hello!" welcome header
            Console.WriteLine("========================");
            Console.WriteLine("\nHello!");
            Console.WriteLine("========================");

            //Prompt user for their name
            Console.WriteLine("\nWhat is your name?");
            Console.Write("Name: ");

            //Grab name from the console and store it in a variable
            string name = Console.ReadLine();

            //Wecome user with their name...
            Console.WriteLine("\nWelcome " + name + "!");

            //Prompt user for their age 
            Console.WriteLine("\nWhat is your age, " + name + "?");
            Console.Write("Age: ");

            int age = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"\nWow! {name} is {age}!");
            Console.WriteLine($"Next Year they will be {age + 1}!!!");

            //Exit application prompt
            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}