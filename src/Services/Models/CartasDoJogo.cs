using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGameCli.src.Services.Models
{
    internal class CartasDoJogo
    {
        public static Dictionary<string, Carta> DeckGame { get; } = new()
        {
            { "Cura do arcano", new Carta("Cura do arcano", "Cura 10 de vida.", 10, Tipo.Magia) },
            { "Bola de Fogo", new Carta("Bola de fogo", "tira 30 de vida do adversario.", 30, Tipo.Magia) },
            { "Ataque da serpente",new Carta("Ataque da serpente", "Tira 12 de vida do adversario.", 12, Tipo.Fisico)},
            { "Guinada da espada", new Carta("Guinada da espada", "tira 5 de vida.", 5, Tipo.Fisico) },
            { "Flexa da Guerra", new Carta("Flexa da Guerra", "Tira 45 de vida do adversário.", 45, Tipo.Magia) },
            { "Chora mana", new Carta("Chora mana", "A cada round sera dado 10 de mana no  maximo 2 veses.", 12, Tipo.Fisico) },
            { "Big bundada", new Carta("Big bundada", "Tira 25 de vida.", 25, Tipo.Fisico) },
            { "Escudo Da Misericorida", new Carta("Escudo Da Misericordia", "Os proximo 10 de dano que receber sera discontado no atacante.", 10, Tipo.Defesa) },
            { "Ladrao de Coringa", new Carta("Ladrao de Coringa", "Pega a melhor carta do adversario.", 12, Tipo.Fisico) },
            { "Ataque da serpente", new Carta("Ataque da serpente", "Tira 12 de vida do adversario", 12, Tipo.Fisico) },
        };
    }
}
