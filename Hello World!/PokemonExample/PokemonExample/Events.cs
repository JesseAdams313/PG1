using System;

namespace PokemonExample
{
    public static class Events
    {
        /// <summary>
        /// Starts sequence prompting whether or not the player has left town
        /// </summary>
        /// <param name="playerName"></param>
        public static void LeavingTown(string playerName)
        {
            // Set default value
            bool playerHasLeft = false;

            do
            {
                Console.Clear();
                
                // Prompt to leave town
                Console.Write("Do you want to leave? [y/n]: ");
                string response = Console.ReadLine();

                // If yes..
                if (response.ToLower() == "yes" || response.ToLower() == "y")
                {
                    //OAK stops you
                    UI.ShowDialog("It's dangerous to go out in tall grass alone!", "OAK");
                    UI.ShowDialog("Follow me back to my lab!", "OAK");

                    //Set player has left town to break loop
                    playerHasLeft = true;
                }
                else
                {
                    // Otherwise continue to loop
                    UI.ShowDialog($"{playerName} never leaves town.");
                }

            } while (!playerHasLeft);


        }

        public static Pokemon PokemonSelection()
        {
            Pokemon starter = null;

            UI.ShowDialog("Here choose from one of these three pokemon", "OAK");
            Console.Clear();

            //create menu items
            string[] starterPokemon = { "Charmander", "Squirtel", "Bulbasaur" };

            //create a menu type object
            UI.Menu menu = new UI.Menu(starterPokemon);

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
                    starter = new Pokemon("Charmander", Type.Fire, 1);
                    break;
                case 2:
                    //Charmander
                    starter = new Pokemon("Squirtel", Type.Water, 1);
                    break;
                case 3:
                    //Charmander
                    starter = new Pokemon("Bulbasaur", Type.Grass, 1);
                    break;
                default:
                    starter = new Pokemon("Pikachu", Type.Electric, 1);
                    break;
            }
            return starter;
        }
    }
}

