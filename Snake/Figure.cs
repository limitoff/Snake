using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> pList;
        
        public virtual void DrawLine()
        {
            foreach (Point p in pList)
            {
                p.DrawPoint();
            }
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var p in pList) //Пробегаемся по всем точкам в фигуре.
            {
                if (figure.IsHit(p)) return true; //Проверка пересекается ли фигура с какой либо точкой.
            }                                     //Вызывается метод ниже:  private bool IsHit (Point point)
            return false;
        }

        private bool IsHit (Point point)
        {
            foreach (var p in pList)
            {
                if (p.IsHit(point)) return true;
            }
            return false;
        }
    }

    class HorizontalLine : Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public override void DrawLine()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            base.DrawLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    class VerticalLine : Figure
    {
        public VerticalLine(int yTop, int yBottom, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yTop; y <= yBottom; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
        public override void DrawLine()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            base.DrawLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

}
