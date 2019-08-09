using System;
using System.Collections.Generic;
using System.Text;

namespace _12_les_classes
{
    class Point
    {

        public int x, y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            Console.WriteLine("Hello World2!");
        }

        public Point p1 = new Point(0, 0);
        private Point p2 = new Point(10, 20);
        //Console.WriteLine("p1");
    }
}
