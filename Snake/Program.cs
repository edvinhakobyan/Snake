using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using  System.Windows;

namespace Snake
{
    class Program
    {
        private static int W = Console.LargestWindowWidth/2;
        private static int H = Console.LargestWindowHeight/2;
        static private int offset = 3;


        static void Main(string[] args)
        {
            if (W % 2 == 1) W++;
            if (H % 2 == 1) H++;
            Console.SetBufferSize(W, H);
            Console.SetWindowSize(W, H);

            Snake snake = new Snake(new Point(30, 30));


            ConsoleKey buton = ConsoleKey.UpArrow;
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    buton = Console.ReadKey().Key;
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    Console.Write(' ');
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);

                    if (buton == ConsoleKey.UpArrow && Snake.Dir != Direction.down)
                        Snake.Dir = Direction.up;
                    else if (buton == ConsoleKey.DownArrow && Snake.Dir != Direction.up)
                        Snake.Dir = Direction.down;
                    else if (buton == ConsoleKey.LeftArrow && Snake.Dir != Direction.right)
                        Snake.Dir = Direction.left;
                    else if (buton == ConsoleKey.RightArrow && Snake.Dir != Direction.left)
                        Snake.Dir = Direction.right;
                }

                Point t;
                snake.move(out t);

                if (snake.Hed.X > W-2 || snake.Hed.X < 1 || snake.Hed.Y > H-1 || snake.Hed.Y < 2)
                {
                    break;
                }
                else if(snake.Hed == new Point(50,30))
                {
                    snake.EatFood(new Point(50, 30));
                }
                snake.Crawl(t, true);


                Thread.Sleep(100);

            }


        }
    }
}
