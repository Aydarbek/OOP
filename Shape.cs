using System.Drawing;

namespace Geometry1
{
    abstract class Shape
    {
        protected Pixel position;
        protected Graphics gr;
        protected Pen pen;

        public Shape()
        {
            pen = new Pen(Color.Blue);
        }

        public void SetGraphics(Graphics graph)
        {
            gr = graph;
        }

        public void SetPen(Pen pen)
        {
            this.pen = pen;
        }

        abstract public void Draw();

        virtual public void Move(Pixel position)
        {
            this.position = position;
        }

    }
}
