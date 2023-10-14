using System.Collections.Generic;
using System;

namespace TreasureHunt
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int width = 4; 
            int height = 5; 
            int maxMoves = 10;

            Grid grid = new Grid(width, height);
            var midValueIndex = grid.GetMidValueIndex();
            Player player = new Player(midValueIndex[0], midValueIndex[1], maxMoves);
            PlayGame(player, grid);
        }

        private static void PlayGame(Player player, Grid grid)
        {
            Console.WriteLine($"Remaining moves = {player.MovesLeft}");
            
            while (true)
            {
                bool isPlayerMoved = false;
                
                var keyInfo = Console.ReadKey(true);
                var key = keyInfo.Key;
                
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        if (player.X != 0)
                        {
                            player.X--;
                            isPlayerMoved = true;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (player.X != grid.Width - 1)
                        {
                            player.X++;
                            isPlayerMoved = true;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (player.Y != 0)
                        {
                            player.Y--;
                            isPlayerMoved = true;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (player.Y != grid.Height - 1)
                        {
                            player.Y++;
                            isPlayerMoved = true;
                        }
                        break;
                }

                if (isPlayerMoved)
                {
                    Console.Clear();
                    grid.PrintGrid(player.X, player.Y);
                
                    player.MovesLeft--;
                    Console.WriteLine($"Remaining moves = {player.MovesLeft}");

                    if (player.X == grid.TreasureX && player.Y == grid.TreasureY)
                    {
                        Console.WriteLine("You win! You found the treasure.");
                        grid.ShowMap();
                        Environment.Exit(0);
                    }
                    else if (player.X == grid.TrapX && player.Y == grid.TrapY)
                    {
                        Console.WriteLine("You lose! You stepped into the trap.");
                        grid.ShowMap();
                        Environment.Exit(0);
                    }
                    else if (player.MovesLeft == 0)
                    {
                        Console.WriteLine("You lose! You ran out of moves allowed.");
                        grid.ShowMap();
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}