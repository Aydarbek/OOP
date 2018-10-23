using System.Drawing;

namespace Geometry1
{
    class ColorCircle : Circle
    {

        public ColorCircle(int x, int y, int r, Color color)
            : this (new Pixel (x, y), r, color)
        {

        }

        public ColorCircle(Pixel a, int r, Color color)
            : base (a, r)
        {
            pen = new Pen(color);
        }

        public ColorCircle(Pixel center, Pixel point, Color color)
            : this (center, center.Distanse(point), color)
        {
        }
    }
}
