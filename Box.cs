using System;

namespace Geometry1
{
    class Box : Shape
    {
        public Pixel corner1;
        public Pixel corner2;
        public int width, height;

        public Box(int x1, int y1, int x2, int y2)
            : this (new Pixel (x1, y1), new Pixel(x2, y2))
        {
        }

        public Box (Pixel a, Pixel b)
        {
            corner1 = a;
            corner2 = b;
            width = Math.Abs (corner2.x - corner1.x);
            height = Math.Abs (corner2.y - corner1.y);
        }

        override public void Draw()
        {
            gr.DrawRectangle(pen, corner1.x, corner1.y, width, height);
        }

    }
}
