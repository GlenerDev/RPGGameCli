﻿using RPGGameCli.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace RPGGameCli.src.Services.Models
{
    internal class Partida
    {
        public List<Carta> DeckPrincipal = new List<Carta>();
        public Time Tempo;
        public int Rounds = 4;
        public Jogador[] Jogadores = new Jogador[2];
        public Partida(string nomeDojogador1, string nomeDojogador2,int TempoRounds)
        {
            Tempo = new Time(TempoRounds);
            Jogadores[0].Nome = nomeDojogador1;
            Jogadores[1].Nome = nomeDojogador2;
        }

        public void ComecarRounds()
        {
            
        }
    }
}
