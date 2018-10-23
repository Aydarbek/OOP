namespace Geometry1
{
    class Line : Shape
    {
        public Pixel begin;
        public Pixel end;

        public Line (int x1, int y1, int x2, int y2)
            : this (new Pixel(x1, y1), new Pixel (x2, y2))
        {

        }

        public Line (Pixel begin, Pixel end)
        {
            this.begin = begin;
            this.end = end;
        }

        override public void Draw()
        {
            gr.DrawLine(pen, begin.x, begin.y, end.x, end.y);
        }


    }
}
