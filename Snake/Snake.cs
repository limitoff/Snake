﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;


        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.MovePoint(i, direction);
                pList.Add(p);
            }
        }

        internal void MoveSnake()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.DrawPoint();
        }

        private Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.MovePoint(1, direction);
            return nextPoint;
        }
    }
}
