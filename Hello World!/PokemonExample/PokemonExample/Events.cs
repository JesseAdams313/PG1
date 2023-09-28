using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonExample
{
    public static class Events
    {

        public static void PokemonSelection()
        {
            Pokemon starter = null;

            UI.ShowDialog("Here choose from one of these three pokemon", "OAK");
            Console.Clear();

            //create menu items
            string[] starterPokemon = { "Charmander", "Squirtel", "Bulbasaur" };

            //create a menu type object
            MenuCommand menu = new Menu(starterPokemon);

            //Display the menu
            menu.Display();

            // Prompt user for a selection
            Console.Write("\nChoose a Pokemon: ");

            //Create an initial selection variable
            int userSelection = 0;

            //Validate the user input
            Int32.TryParse(Console.ReadLine(), out userSelection);

            switch (userSelection)
            {
                case 1:
                    //Charmander
                    starter = new Pokemon("Charmander", Type.Fire);
                    break;
                case 2:
                    //Charmander
                    starter = new Pokemon("Squirtel", Type.Water);
                    break;
                case 3:
                    //Charmander
                    starter = new Pokemon("Bulbasaur", Type.Grass);
                    break;
                default:
                    starter = new Pokemon("Pikachu", Type.Electric);
                    break;
            }
            return starter;
        }
    }
}
