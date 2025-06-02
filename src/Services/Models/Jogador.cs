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
        public Jogador()
        {
            Vida = 100;
            Vigor = 50;
            Mana = 50;
        }
        public int GetSetVida
        {
            get { return Vida; }
            set
            {
                if (Equals(TypeCode.UInt64))
                {
                    if (Vida <= 100 && value < 0)
                    {
                        Vida -= value;
                    }
                }
            }
        }
        private int Vigor { get; set; } = 50;
        private int Mana { get; set; } = 20;
        private List<Carta> Deck { get; set; }

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
            throw new NotImplementedException("os parametros estao incorreto, porfavor coloque na ordem correta ");
        }
        public void Enfeiticar() { }

        public List<Carta> ObterDeck()
        {
            return Deck;
        }
        public void AdicionarCartasNaLista(Carta carta)
        {

        }
    }
}
