using System;

namespace PokemonExample
{
    public class Game
    {
        private string playerName;

        public void Start()
        {
            UI.ShowDialog("Welcome to the wild world of pokemon!");
            UI.ShowDialog("What is your name?");

            playerName = UI.PromptUserName();

            UI.ShowDialog($"Welcome {playerName}!");

            UI.PromptUserLeavingTown(playerName);

            UI.ShowDialog("You follow Professor Oak bac to the lab.");

            UI.PokemonSelectionEvent();
        }
    }
}
