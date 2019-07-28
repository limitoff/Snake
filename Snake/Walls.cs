﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            //Отрисовка рамочки
            HorizontalLine topLine = new HorizontalLine(0, mapWidth-2, 0, '-');
            HorizontalLine bottomLine = new HorizontalLine(0, mapWidth-2, mapHeight-1, '-');
            VerticalLine leftLine = new VerticalLine(0, mapHeight-1, 0, '|');
            VerticalLine rightLine = new VerticalLine(0, mapHeight-1, mapWidth-2, '|');

            wallList.Add(topLine);
            wallList.Add(bottomLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }

        internal bool IsHit(Figure figure) //В функцию передаётся змейка, сама функция принимает любую фигуру.
        {
            foreach (var wall in wallList)
                if (wall.IsHit(figure)) return true; //Проверка есть ли столкновение (пересечение) линии с фигурой.
            return false;
        }
        public void Draw()
        {
            foreach (var wall in wallList)
                wall.DrawLine();
        }
    }
}
