using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace Snake
{
    class Snake
    {
        private List<Point> snake;
        public static Direction Dir;

        public Point Hed
        {
            get { return snake[0]; }
            set { snake[0] = value; }
        }

        public Point Tail
        {
            get { return snake[snake.Count-1]; }
            set { snake[snake.Count - 1] = value; }
        }

        public Snake(Point startPoint)
        {
            snake = new List<Point>() {startPoint};
            Dir = Direction.right;
        }

        public void Crawl(Point oldTail,bool delTail)
        {

            foreach (Point point in snake)
                _Console.Writ(point, 'O');

            if (delTail)
                _Console.Writ(oldTail, ' ');
        }

        public void EatFood(Point food)
        {
            snake.Add(food);
        }

        public void move(out Point oldTail)
        {
             oldTail = Tail;
            for (int i = snake.Count - 1; i >0 ; i--)
                snake[i] = snake[i - 1];

            if (Dir == Direction.up)
                Hed = new Point(Hed.X, Hed.Y - 1);
            else if (Dir == Direction.right)
                Hed = new Point(Hed.X + 1, Hed.Y);
            else if (Dir == Direction.down)
                Hed = new Point(Hed.X,Hed.Y + 1);
            else if (Dir == Direction.left)
                Hed = new Point(Hed.X - 1, Hed.Y);
        }


    }
}
