using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Snake
{
    class _Console
    {
        public static void Writ(Point point, char symbol)
        {
            Console.SetCursorPosition(point.X, point.Y);
            Console.Write(symbol);
        }
        public static void Writ(int x, int y, char symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
        

    }
}
