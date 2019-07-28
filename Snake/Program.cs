using System;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            Console.CursorVisible = false; //Убирает видимость курсора

            Walls walls = new Walls(80, 25);
            walls.Draw();

            //Отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.DrawLine();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.DrawPoint();

            while (true) //Бесконечный цикл, он означает, что код внутри цикла будет выполняться вечно.
            {
                if (walls.IsHit(snake) || snake.IsHitTail()) break;
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.DrawPoint();
                }
                else snake.MoveSnake();
                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    snake.HendleKey(key.Key);
                }
            }
        }
    }
}
