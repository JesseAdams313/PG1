using System;

namespace PokemonExample
{
    public class Game
    {
        // Member fields
        // Stores a persistent Trainer type object for the player
        private Trainer player;

        //Default constructor
        public Game() 
        {
            //new DEFAULT Trainer
            player = new Trainer();
        }

        /// <summary>
        /// Starts the game
        /// </summary>
        public void Start()
        {
            UI.ShowDialog("Welcome to the wild world of pokemon!");
            UI.ShowDialog("What is your name?");

            player = UI.PromptUserName();

            UI.ShowDialog($"Welcome {player.Name}!");

            UI.PromptUserLeavingTown(player.Name);

            UI.ShowDialog("You follow Professor Oak bac to the lab.");

            player.AddPokeMonToTeam(Events.PokemonSelection());
        }
    }
}
