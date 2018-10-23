using System;
using System.Drawing;

namespace Geometry1
{
    class ColorBox : Box
    {
        public ColorBox(int x1, int y1, int x2, int y2, Color color)
            : this (new Pixel (x1, y1), new Pixel(x2, y2), color)
        {
        }

        public ColorBox(Pixel a, Pixel b, Color color)
            : base (a, b)
        {
            pen = new Pen(color);
        }
    }
}
