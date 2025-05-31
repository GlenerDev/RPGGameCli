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


        public static int DefinicaoDeRounds(int timeEmMinutos)
        {
            var retorno = 0;
            if (int.TryParse(timeEmMinutos.ToString(), out int minutos) && timeEmMinutos > 0)
            {
                retorno = timeEmMinutos * 60;
                for (int i = 0; i < timeEmMinutos * 60; i++)
                {
                    Console.WriteLine($"{retorno / 60}:{retorno}");
                    retorno %= 1;
                    Thread.Sleep(1000);
                }
            }
            return retorno;
        }
    }
}
