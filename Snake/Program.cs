using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            Console.CursorVisible = false; //убирает видимость курсора

            HorizontalLine topLine = new HorizontalLine(0, 78, 0, '-');
            HorizontalLine bottomLine = new HorizontalLine(0, 78, 24, '-');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '|');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '|');
            topLine.DrawLine();
            bottomLine.DrawLine();
            leftLine.DrawLine();
            rightLine.DrawLine();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.DrawLine();
            
            while (true) //Бесконечный цикл, он означает, что код внутри цикла будет выполняться вечно.
            {
                if (Console.KeyAvailable) //Проверка на то, была ли нажата какая-либо клавиша
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    snake.HendleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.MoveSnake();
            }
        }
    }
}
