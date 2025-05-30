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
        public Time Tempo { get; set; }
         public int Rounds { get; set; } = 4;
        public Jogador[] Jogadores { get; set; }
        public Partida(string nomeDojogador1, string nomeDojogador2) 
        {
            Jogadores[0].Nome = nomeDojogador1;
            Jogadores[1].Nome = nomeDojogador2;
        }

        public void ComeçarRounds() 
        {
        
        }



        
    }
}
