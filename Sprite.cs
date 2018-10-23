using System.Collections.Generic;

namespace Geometry1
{
    class Sprite : Shape
    {
        List<Shape> Shapes;

        public Sprite ()
        {
            Shapes = new List<Shape>();
        }

        public void AddShape(Shape shape)
        {
            shape.SetGraphics(gr);
            Shapes.Add(shape);
        }

        public void ClearShape()
        {
            Shapes.Clear();
        }

        override public void Draw()
        {
            foreach (Shape shape in Shapes)
                shape.Draw();
        }


    }
}
