using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace RPGGameCli.src.Services.Models
{
    internal class Carta 
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Dano;
        public Tipo TipoDeDano { get; set; }

        public void MostrarCarta() 
        {
            Console.WriteLine($"TITULO: {Titulo}");
            Console.WriteLine($"DESCRIÇÃO: {Descricao}");
        }

    }
}
