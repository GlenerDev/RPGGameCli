using RPGGameCli.Services.Models;

namespace RPGGameCli.Services
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var entrada = int.Parse(Console.ReadLine());
            Time.DefinicaoDeRounds(entrada);
            //var game = new Game();
            //game.Run();
        }
    }
}
