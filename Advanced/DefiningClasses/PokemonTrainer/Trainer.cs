﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
    public class Trainer
    {
       

        public Trainer(string name)
        {
            Name = name;
            Pokemons = new();
        }

        public string Name { get; set; }

        public int Badges { get; set; }
        public List<Pokemon> Pokemons { get; set; }
        

        public void CheckPokemon(string element)
        {
            if (Pokemons.Any(p => p.Element == element))
            {
                Badges++;
            }
            else
            {
                for (int i = 0; i < Pokemons.Count; i++)
                {
                    Pokemon currentPokemon = Pokemons[i];

                    currentPokemon.Health -= 10;

                    if (currentPokemon.Health <= 0)
                    {
                        Pokemons.Remove(currentPokemon);
                    }
                }
            }
        }

    }
}
