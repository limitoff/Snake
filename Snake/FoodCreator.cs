using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        private int MapWidht { get; set; }
        private int MapHeight { get; set; }
        private char Sym { get; set; }

        Random random = new Random();

        public FoodCreator(int _mapWidht, int _mapHeight, char _sym)
        {
            MapWidht = _mapWidht;
            MapHeight = _mapHeight;
            Sym = _sym;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, MapWidht - 2);
            int y = random.Next(2, MapHeight - 2);
            return new Point(x, y, Sym);
        }
    }
}
