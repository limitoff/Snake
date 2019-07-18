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

            for (int i = 0; i < 20; i++)
            {
                snake.MoveSnake();
                Thread.Sleep(300);
            }
            

            Console.ReadLine();
        }
    }
}
