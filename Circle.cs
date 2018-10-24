using System.Drawing;

namespace Geometry1
{
    class Circle : Shape
    {
        public Pixel center;
        public int radius;
        public int width, height;
        public Pixel corner;


        public Circle (int x, int y, int r)
            : this (new Pixel (x, y), r)
        {
            
        }

        public Circle (Pixel a, int r)
        {
            center = a;
            radius = r;
            corner = new Pixel(
                center.x - this.radius,
                center.y - this.radius
                );
            width = 2 * this.radius;
            height = 2 * this.radius;
        }

        public Circle (Pixel center, Pixel point)
            : this (center, center.Distanse(point))
        {
        }

        override public void Draw()
        {
            gr.DrawEllipse(pen, corner.x + position.x , corner.y + position.y, width, height);
        }

    }
}
