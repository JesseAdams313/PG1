using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonExample
{
    public static class UI
    {
        /// <summary>
        /// Clears console and prints a given text argument as a formatted dialog with key continue.
        /// </summary>
        /// <param name="text"></param>

        public static void ShowDialog(string text)
        {
            Console.Clear();
            Console.WriteLine(text);

            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
        }

        public static string PromptUserName(string userName)
        {
            Console.Clear();
            Console.Write("Name: ");
            return Console.ReadLine();
        }
    }
}
