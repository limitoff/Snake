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
}
