using System;
namespace PokemonExample
{
    internal class Trainer
    {
        // Member fields
        private string name;
        private Pokemon[] team = new Pokemon[6];

        //C# Properties
        public string Name 
        { 
            get { return GetName(); }
            set { SetName(value); }
        }

        //Default Constructor
        public Trainer()
        {
            name = "RED";
        }

        //Overloaded Constructor
        public Trainer(string name)
        {
            this.name = name;
        }

        //Getter for Name Field
        public string GetName() 
        {
            return name; 
        }
        public void SetName(string name)
        {
            // If the name parameter is NOT emoty or null
            if(!string.IsNullOrEmpty(name))
            {
                // Set the value of the parameter to the name field
                this.name = name;
            }
        }

        //Getter for the Team Field
        public Pokemon[] GetTeam()
        {
            return team;
        }
        public void AddPokemonToTeam(Pokemon pokemon)
        {
            //loop through the team array...
            for(int i = 0; i < team.Length; i++)
            {
                // Check for empty (null) positions...
                team[i] = pokemon;
                UI.ShowDialog($"{pokemon.Name} Has been added to {name}'s team.");
                break;
            }
        }

    }
}

