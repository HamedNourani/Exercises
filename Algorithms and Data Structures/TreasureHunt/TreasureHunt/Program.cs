using System.Collections.Generic;
using System;

namespace TreasureHunt
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int width = 3; 
            int height = 4; 
            int maxMoves = 10;

            Grid grid = new Grid(width, height);
            Player player = new Player(0, 0, maxMoves);
            PlayGame(player, grid);
        }

        private static void PlayGame(Player player, Grid grid)
        {
            while (true)
            {
                var keyInfo = Console.ReadKey(true);
                var key = keyInfo.Key;
                
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        player.X--;
                        break;
                    case ConsoleKey.DownArrow:
                        player.X++;
                        break;
                    case ConsoleKey.LeftArrow:
                        player.Y--;
                        break;
                    case ConsoleKey.RightArrow:
                        player.Y++;
                        break;
                }
                
                Console.Clear();
                grid.PrintGrid(player.X, player.Y);

                if (player.X == grid.TreasureX && player.Y == grid.TreasureY)
                {
                    Console.WriteLine();
                    Console.WriteLine("You win!");
                    Console.WriteLine();
                    grid.ShowMap();
                    Environment.Exit(0);
                }
                
                if (player.X == grid.TrapX && player.Y == grid.TrapY)
                {
                    Console.WriteLine();
                    Console.WriteLine("You lose!");
                    Console.WriteLine();
                    grid.ShowMap();
                    Environment.Exit(0);
                }
            }
        }
    }
}