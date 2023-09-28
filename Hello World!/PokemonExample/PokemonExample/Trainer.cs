using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonExample
{
    internal class Trainer
    {
        // Member fields
        private string name;
        private PokemonExample[] team = new PokemonExample[6];

        //C# Properties
        public string Name 
        { 
            get 
            { 
                return GetName(); 
            }
            set
            {
                SetName(value);
            }
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

    }
}
