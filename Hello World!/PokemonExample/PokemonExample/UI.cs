using System;
using System.Threading;

namespace PokemonExample
{
    public static class UI
    {
        /// <summary>
        /// Clears console and prints a given text argument as a formatted dialog with key continue.
        /// </summary>
        /// <param name="text"></param>
        /// 

        //Child (inner) Menu Class

        public class Menu
        {
            //feilds
            public string[] items;


            //Menu Constructor
            public Menu(string[] items)
            {
                this.items = items;
            }

            //Displays menu item
            public void Display()
                {
                    int counter = 1;

                    foreach(string item in items)
                    counter++;
                }
        }
        public static void ShowDialog(string text)
        {
            Console.Clear();

            foreach(char letter in text)
            {
                Console.Write(letter);
                Thread.Sleep(30);
            }

            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
        }

        public static void ShowDialog(string text, string subject)
        {
            Console.Clear();

            Console.Write($"{subject}: ");

            foreach (char letter in text)
            {
                Console.Write(letter);
                Thread.Sleep(30);
            }

            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
        }

        public static string PromptUserName()
        {
            string name = null;

            do
            {
                Console.Clear();
                Console.Write("Name: ");

                name = Console.ReadLine();

                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Username cannot be empty! Try again.");
                    Console.ReadKey();
                }

            } while (string.IsNullOrEmpty(name));

            return name;
        }

        public static void PromptUserLeavingTown(string playerName) 
    {

        bool playerHasLeft = false;

        do
        {
            Console.Clear();

            Console.Write("Do you want to leave? [y/n]: ");

            string response = Console.ReadLine();

            if (response.ToLower() == "yes" || response.ToLower() == "y")
            {
                UI.ShowDialog("It's dangerous to go out in tall grass alone!", "OAK");
                UI.ShowDialog("Follow me back to my lab!", "OAK");
                playerHasLeft = true;
            }
            else
            {
                UI.ShowDialog($"{playerName} never leaves town.");
            }

        } while (!playerHasLeft);

            
    }
        

    }
}
