using System;
using GameJun.Interfaces;

namespace GameJun.Classes
{
    public class Game : AbstractGame
    {
        public override void SelectPlayers()
        {
            string classCharacter;
            Console.WriteLine($"Выберите игрока за которого хотели бы играть: Archer, Ilya, Ivan");
            Console.Write($"Первый игрок вы: ");
            classCharacter = Console.ReadLine();
            if (classCharacter == "Archer")
            {
                player1 = new Archer();
            }
            else if (classCharacter == "Ilya")
            {
                player1 = new Ilya();
            }
            else if (classCharacter == "Ivan")
            {
                player1 = new Ivan();
            }
            Console.Write($"Второй игрок вы: ");
            classCharacter = Console.ReadLine();
            if (classCharacter == "Archer")
            {
                player2 = new Archer();
            }
            else if (classCharacter == "Ilya")
            {
                player2 = new Ilya();
            }
            else if (classCharacter == "Ivan")
            {
                player2 = new Ivan();
            }
        }

        public override void Start()
        {
            while(player1.IsAlive() && player2.IsAlive())
            {
                GameStep();
            }
        }

        protected override void GameStep()
        {
            while (player1.IsAlive() && player2.IsAlive())
            {
                player1.Attack(player2);
                player2.Attack(player1);
                Console.WriteLine($"Step Complete result: \n{player1.Health} {player2.Health}");
            }

            if(!player1.IsAlive())
            {
                Console.WriteLine("Player2 WIN!!!");
            }
            else if (!player2.IsAlive())
            {
                Console.WriteLine("Player1 WIN!!!");
            }
        }
    }
}

