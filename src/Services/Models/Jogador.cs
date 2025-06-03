using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace RPGGameCli.src.Services.Models
{
    internal class Jogador
    {
        public string Nome { get; set; }
        public int Vida { get; private set; } = 100;

        private int Vigor { get; set; } = 50;
        private int Mana { get; set; } = 50;
        private List<Carta> Deck = new List<Carta>();
        public Jogador(string nome)
        {
            Nome = nome;
        }
        public void Atacar(Carta cartausada, Jogador oponente)
        {
            if (cartausada.Dano < 0 && oponente.Vida > 0)
            {
                oponente.Vida -= cartausada.Dano;
                return;
            }
        }
        public void Enfeiticar() { }
        public void AdicionarCartasNoDeckDoJogador(string titulo, string descricao, int dano, Tipo tipo_de_dano)
        {
            Deck.Add(new Carta(titulo,descricao,dano,tipo_de_dano));
        }
    }
}
