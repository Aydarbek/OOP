using System.Drawing;

namespace Geometry1
{
    class ColorLine : Line
    {

        public ColorLine(int x1, int y1, int x2, int y2, Color color)
            : this (new Pixel(x1, y1), new Pixel (x2, y2), color)
        {

        }

        public ColorLine(Pixel begin, Pixel end, Color color)
            : base (begin, end)
        {
            pen = new Pen(color);
        }
    }
}
