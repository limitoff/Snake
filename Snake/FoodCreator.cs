﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        private int mapWidht;
        private int mapHeight;
        private char sym;

        Random random = new Random();

        public FoodCreator(int _mapWidht, int _mapHeight, char _sym)
        {
            mapWidht = _mapWidht;
            mapHeight = _mapHeight;
            sym = _sym;
        }

        internal Point CreateFood()
        {
            int x = random.Next(2, mapWidht - 2);
            int y = random.Next(2, mapHeight - 2);
            return new Point(x, y, sym);
        }
    }
}
