using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Sym { get; set; }

        public Point() { }

        public Point(int _x, int _y, char _sym)
        {
            X = _x;
            Y = _y;
            Sym = _sym;
        }
        public Point(Point p)
        {
            X = p.X;
            Y = p.Y;
            Sym = p.Sym;
        }

        public void MovePoint(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT) X += offset;
            else if (direction == Direction.LEFT) X -= offset;
            else if (direction == Direction.UP) Y -= offset;
            else if (direction == Direction.DOWN) Y += offset;
        }

        internal bool IsHit(Point food) => food.X == this.X && food.Y == this.Y;

        public void DrawPoint()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Sym);
        }

        internal void Clear()
        {
            Sym = ' ';
            DrawPoint();
        }

        public override string ToString() => X + ", " + Y + ", " + Sym;
    }
}
