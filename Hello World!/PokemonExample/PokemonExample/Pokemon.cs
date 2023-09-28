using System;
namespace PokemonExample
{
    public class Pokemon
    {
        //Member Fields
        private string name;
        private Type type;
        private int level;

        public string Name
        {
            get { return GetName(); }

        }
        //Overloaded
        public Pokemon(string name, Type type, int level = 1)
        {
            this.name = name;
            this.type = type;
            this.level = level;
        }
        public string GetName()
        {
            return name;
        }
    }
}

