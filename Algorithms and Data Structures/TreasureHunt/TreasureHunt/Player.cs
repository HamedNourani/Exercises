using System.Collections.Generic;
using System;

namespace TreasureHunt
{
    public class Player
    {
        private int _x;
        private int _y;
        private int _movesLeft;

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

        public int MovesLeft
        {
            get => _movesLeft;
            set => _movesLeft = value;
        }

        public Player(int x, int y, int movesLeft)
        {
            _x = x;
            _y = y;
            _movesLeft = movesLeft;
        }
    }
}