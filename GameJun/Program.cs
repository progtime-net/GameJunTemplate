using GameJun.Interfaces;
using GameJun.Classes;

namespace GameJun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractGame game = new Game();
            game.SelectPlayers();
            game.Start();
        }
    }
}