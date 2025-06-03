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
        private int Vida { get; set; }

        private int Vigor { get; set; }
        private int Mana { get; set; }
        private List<Carta> Deck = new List<Carta>();
        public Jogador(string nome)
        {
            Vida = 100;
            Vigor = 50;
            Mana = 50;
            Nome = nome;
        }
        public void Atacar(Carta cartausada, Jogador oponente)
        {
            if (cartausada.Dano < 0 && oponente.Vida > 0)
            {
                oponente.Vida -= cartausada.Dano;
                return;
            }
            throw new NotImplementedException("os parametros estao incorreto, porfavor coloque na ordem correta ");
        }
        public void Enfeiticar() { }
        public void AdicionarCartasNoDeckDoJogador(string titulo, string descricao, int dano, Tipo tipo_de_dano)
        {
            Deck.Add(new Carta(titulo,descricao,dano,tipo_de_dano));
        }
    }
}
