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
        private int _minValue = 0;
        private int _maxValue = 9;

        public int Width => _width;
        public int Height => _height;
        public int TreasureX => _treasureX;
        public int TreasureY => _treasureY;
        public int TrapX => _trapX;
        public int TrapY => _trapY;

        public Grid(int width, int height)
        {
            _width = width;
            _height = height;
            _tiles = new int[_width, _height];
            
            Initialize();
            PrintGrid(GetMidValueIndex()[0], GetMidValueIndex()[1]);
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
                    _tiles[i, j] = random.Next(_minValue, _maxValue + 1);
                }
            }
        }
        
        private void PlaceTreasure()
        {
            var maxValueIndex = GetMaxValueIndex();
            _treasureX = maxValueIndex[0];
            _treasureY = maxValueIndex[1];
        }
        
        private void PlaceTrap()
        {
            var minValueIndex = GetMinValueIndex();
            _trapX = minValueIndex[0];
            _trapY = minValueIndex[1];
        }

        private int[] GetMaxValueIndex()
        {
            int maxValue = _minValue;
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
        
        private int[] GetMinValueIndex()
        {
            int minValue = _maxValue;
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

        public int[] GetMidValueIndex()
        {
            List<int> values = new List<int>();
            int[] midValueIndex = new int[2];

            for (int i = 0; i < _width; i++)
            {
                for (int j = 0; j < _height; j++)
                {
                    values.Add(_tiles[i, j]);
                }
            }

            values.Sort();
            int midValue = values[values.Count / 2];
            
            for (int i = 0; i < _width; i++)
            {
                for (int j = 0; j < _height; j++)
                {
                    if (_tiles[i, j] == midValue)
                    {
                        midValueIndex[0] = i;
                        midValueIndex[1] = j;
                    }
                }
            }

            return midValueIndex;
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