using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Snake_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Нажмите enter, чтобы начать игру :)");
            Console.ResetColor();
            Console.ReadLine();

            Walls walls = new Walls(80, 25);
            walls.Draw();


            // Отрисовка точек
            Point p = new Point(4, 6, '*');
            Snake snake = new Snake(p, 5, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if(walls.IsHit(snake) || snake.IsHitTail() )
                {
                    Console.SetCursorPosition(14, 12);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы проиграли :( . Нажмите enter, чтобы выйти из игры");
                    Console.ReadLine();
                    break;
                }

                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }   
            }
        }
    }
}
