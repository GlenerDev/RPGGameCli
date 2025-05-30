using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGameCli.Services.Models
{
    internal class Time
    {
        public static int Horas = 3600;
        public static int Minutos = 60;
        public static int Segundos = 1;


        public static int ContagemDeRounds() 
        {
            var result = 0;
            for ( int i = 0; i < Horas; i++) 
            {
                result++;
            }
            return result;
        }
    }
}
