using RPGGameCli.src.Services.Models;

namespace RPGGameCli.Services
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var entrada = int.Parse(Console.ReadLine());
            const teste = await Time.DefinicaoDeRounds(entrada);
            //var game = new Game();
            //game.Run();
        }
    }
}
