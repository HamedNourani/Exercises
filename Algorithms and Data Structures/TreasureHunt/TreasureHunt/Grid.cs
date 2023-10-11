using System.Collections.Generic;
using System;

namespace TreasureHunt
{
    public class Grid
    {
        private int _width;
        private int _height;
        private int[,] _tiles;
        private int _treasureX;
        private int _treasureY;
        private int _trapX;
        private int _trapY;

        public int TreasureX => _treasureX;

        public int TreasureY => _treasureY;

        public int TrapX => _trapX;

        public int TrapY => _trapY;

        public Grid(int width, int height)
        {
            _width = width;
            _height = height;
            _tiles = new int[_width, _height];
            
            PrintGrid(0, 0);
            Initialize();
            PlaceTreasure();
            PlaceTrap();
        }
        
        public void PrintGrid(int playerX, int playerY)
        {
            for (int i = 0; i < _width; i++)
            {
                for (int j = 0; j < _height; j++)
                {
                    if (i == playerX && j== playerY)
                    {
                        Console.Write("P ");
                    }
                    else
                    {
                        Console.Write("O ");
                    }
                }
                Console.WriteLine();
            }
        }
        
        private void Initialize()
        {
            Random random = new Random();

            for (int i = 0; i < _width; i++)
            {
                for (int j = 0; j < _height; j++)
                {
                    _tiles[i, j] = random.Next(0, 10);
                }
            }
        }
        
        private void PlaceTreasure()
        {
            var maxValueIndex = MaxValueIndex();
            _treasureX = maxValueIndex[0];
            _treasureY = maxValueIndex[1];
        }
        
        private void PlaceTrap()
        {
            var minValueIndex = MinValueIndex();
            _trapX = minValueIndex[0];
            _trapY = minValueIndex[1];
        }

        private int[] MaxValueIndex()
        {
            int maxValue = 0;
            int[] maxValueIndex = new int[2];

            for (int i = 0; i < _width; i++)
            {
                for (int j = 0; j < _height; j++)
                {
                    if (_tiles[i, j] > maxValue)
                    {
                        maxValue = _tiles[i, j];
                        maxValueIndex[0] = i;
                        maxValueIndex[1] = j;
                    }
                }
            }

            return maxValueIndex;
        }
        
        private int[] MinValueIndex()
        {
            int minValue = 9;
            int[] minValueIndex = new int[2];

            for (int i = 0; i < _width; i++)
            {
                for (int j = 0; j < _height; j++)
                {
                    if (_tiles[i, j] < minValue)
                    {
                        minValue = _tiles[i, j];
                        minValueIndex[0] = i;
                        minValueIndex[1] = j;
                    }
                }
            }

            return minValueIndex;
        }

        public void ShowMap()
        {
            for (int i = 0; i < _width; i++)
            {
                for (int j = 0; j < _height; j++)
                {
                    Console.Write(_tiles[i, j]); 
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}