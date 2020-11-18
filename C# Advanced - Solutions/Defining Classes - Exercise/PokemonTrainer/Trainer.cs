using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    public class Trainer
    {
        public string Name;
        public int Badges;
        public List<Pokemon> PokemonList;

        public Trainer(string name, string PokemonName, string PokemonElement, int PokemonHealth)
        {
            this.Name = name;
            this.Badges = 0;
            this.PokemonList = new List<Pokemon>();
            AddPokemon(PokemonName, PokemonElement, PokemonHealth);
        }
        public void AddPokemon(string name, string element, int health)
        {
            Pokemon pokemon = new Pokemon(name, element, health);
            PokemonList.Add(pokemon);
        }
    }
}
