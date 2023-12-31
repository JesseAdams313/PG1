﻿using System;

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

            player.Name = UI.PromptUserName();

            UI.ShowDialog($"Welcome \u001b[32m{player.Name}\u001b[0m!");


            Events.LeavingTown(player.Name);

            UI.ShowDialog("You follow Professor Oak bac to the lab.");

            player.AddPokemonToTeam(Events.PokemonSelection());
        }
    }
}
