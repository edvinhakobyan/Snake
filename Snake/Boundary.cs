using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection.Metadata;

namespace Snake
{
    public class Boundary
    {
        private int w;
        private int h;
        private int offset;
        public List<Point> BounderyPointList { get; set; }
        public int X0 { get ; set ; }
        public int X1 { get; set; }
        public int Y0 { get; set; }
        public int Y1 { get; set; }


        public Boundary(int w, int h, int offset)
        {
            this.w = w;
            this.h = h;
            this.offset = offset;
            BounderyPointList = new List<Point>();
            X0 = offset;
            X1 = w - offset;
            Y0 = offset;
            Y1 = h - offset;
        }

        

        public void showBoundary()
        {
            Point temp;
            for (int i = offset; i <= w - 2 * offset; i++)
            {
                temp = new  Point(i, offset);
                _Console.Writ(temp, '*');
                BounderyPointList.Add(temp);

                temp = new Point(i, h - 2 * offset);
                _Console.Writ(temp, '*');
                BounderyPointList.Add(temp);
            }

            for (int i = offset; i <= h - 2 * offset; i++)
            {
                temp = new Point(offset, i);
                _Console.Writ(temp, '*');
                BounderyPointList.Add(temp);

                temp = new Point(w - 2 * offset, i);
                _Console.Writ(temp, '*');
                BounderyPointList.Add(temp);
            }
        }
    }
}