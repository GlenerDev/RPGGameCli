using RPGGameCli.src.Services.Models;

namespace RPGGameCli.Services
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            game.Run();
        }
    }
}
