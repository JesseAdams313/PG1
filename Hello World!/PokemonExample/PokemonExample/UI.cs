using System;
using System.Threading;

namespace PokemonExample
{
    /// <summary>
    /// Contains all methods for creating UI elements
    /// </summary>
    public static class UI
    {
        /// <summary>
        /// Creates menus for use in selection sequences
        /// </summary>
        public class Menu
        {

            //feilds
            public string[] items;


            //Menu Constructor
            public Menu(string[] items)
            {
                this.items = items;
            }
            /// <summary>
            /// Displays all menu items with selection identifiers
            /// </summary>
            public void Display()
            {
                int counter = 1;

                foreach (string item in items)
                {
                    Console.WriteLine($"[{counter}]{item}");
                    counter++;
                }
            }
        }

        /// <summary>
        /// Clears console and prints a given text argument as a formatted dialog with key continue.
        /// </summary>
        /// <param name="text"></param>
        /// 
        public static void ShowDialog(string text)
        {
            Console.Clear();
            //Displays text one character at a time to simulate dialog from pokemon
            foreach (char letter in text)
            {
                Console.Write(letter);
                //Delay each itteration by 30ms
                Thread.Sleep(30);
            }

            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
        }

        /// <summary>
        /// Clears console and prints a given text argument as spoken by a subject
        /// </summary>
        /// <param name="text"></param>
        /// <param name="subject"></param>
        public static void ShowDialog(string text, string subject)
        {
            Console.Clear();
            //Displays text one character at a time to simulate dialog from pokemon
            foreach (char letter in text)
            {
                Console.Write(letter);
                //Delay each itteration by 30ms
                Thread.Sleep(30);
            }

            Console.WriteLine($"\n\nPress any key to continue...");
            Console.ReadKey();
        }

        /// <summary>
        /// Prompt ueser for string input and validates that its not empty
        /// </summary>
        /// <returns></returns>
        public static string PromptUserName()
        {
            string name = null;

            do
            {
                Console.Clear();
                Console.Write("\u001b[34mName: \u001b[0m");

                name = Console.ReadLine();

                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("\u001b[31mUsername cannot be empty! Try again. Error!\u001b[0m");
                    Console.ReadKey();
                }

            } while (string.IsNullOrEmpty(name));

            return name;
        }




    }



}
