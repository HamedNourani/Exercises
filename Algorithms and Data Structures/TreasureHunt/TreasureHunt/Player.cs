using System.Collections.Generic;
using System;

namespace TreasureHunt
{
    public class Player
    {
        private int _x;
        private int _y;
        private int _moves;

        public int X
        {
            get => _x;
            set => _x = value;
        }

        public int Y
        {
            get => _y;
            set => _y = value;
        }

        public int Moves
        {
            get => _moves;
            set => _moves = value;
        }

        public Player(int x, int y, int moves)
        {
            _x = x;
            _y = y;
            _moves = moves;
        }
    }
}