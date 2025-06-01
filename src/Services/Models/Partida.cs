using RPGGameCli.Services;
using RPGGameCli.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace RPGGameCli
{
    internal class Partida
    {
        public Time Tempo;
        public int Rounds { get; set; }
        public Jogador[] Jogadores = new Jogador[2];
        public Partida(string nomeDojogador1, string nomeDojogador2)
        {
            Jogadores[0].Nome = nomeDojogador1;
            Jogadores[1].Nome = nomeDojogador2;
        }

        public void ComecarRounds()
        {
        }
        



    }
}
