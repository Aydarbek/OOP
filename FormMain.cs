using System;
using System.Drawing;
using System.Windows.Forms;

namespace Geometry1
{
    public struct Pixel
    {
        public int x;
        public int y;

        public Pixel(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int Distanse (Pixel pixel)
        {
            return Convert.ToInt32(Math.Sqrt(
                (this.x - pixel.x) * (this.x - pixel.x) + 
                (this.y - pixel.y) * (this.y - pixel.y)
                ));
        }
    }
    public partial class FormMain : Form 
    {
        Bitmap bmp;
        Graphics gr;
        Pen pen;

        Shape[] snowman1;
        Shape[] snowman2;

        Pixel A, B, C, D, E, F, G, H, I, J, K, L, M;

        public FormMain()
        {
            InitializeComponent();
            Init();
            InitSnowman1();
            InitSnowman2();
            Draw();
        }

        private void Init()
        {
            bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            gr = Graphics.FromImage(bmp);
            pen = new Pen(Color.Blue);

        }

        private void InitSnowman1()
        {
            A = new Pixel(96, 39);
            B = new Pixel(96, 117);
            C = new Pixel(96, 242);
            D = new Pixel(96, 66);
            E = new Pixel(96, 167);
            F = new Pixel(68, 75);
            G = new Pixel(10, 131);
            H = new Pixel(125, 76);
            I = new Pixel(175, 125);
            J = new Pixel(49, 296);
            K = new Pixel(66, 314);
            L = new Pixel(123, 298);
            M = new Pixel(139, 315);

            snowman1 = new Shape[7];
            snowman1 [0] = new Circle(A, D);            
            snowman1 [1] = new Circle(B, E);
            snowman1 [2] = new Circle(C, E);
            snowman1 [3] = new Line(F, G);
            snowman1 [4] = new Line(H, I);
            snowman1 [5] = new Box(J, K);
            snowman1 [6] = new Box(L, M);

            for (int i=0; i<snowman1.Length; i++)
            {
                snowman1[i].SetGraphics(gr);
                snowman1[i].SetPen(pen);

            }
        }

        private void InitSnowman2()
        {
            int delta = 200;
            A = new Pixel(delta + 96, 39);
            B = new Pixel(delta + 96, 117);
            C = new Pixel(delta + 96, 242);
            D = new Pixel(delta + 96, 66);
            E = new Pixel(delta + 96, 167);
            F = new Pixel(delta + 68, 75);
            G = new Pixel(delta + 10, 131);
            H = new Pixel(delta + 125, 76);
            I = new Pixel(delta + 175, 125);
            J = new Pixel(delta + 49, 296);
            K = new Pixel(delta + 66, 314);
            L = new Pixel(delta + 123, 298);
            M = new Pixel(delta + 139, 315);


            snowman2 = new Shape[7];
            snowman2[0] = new ColorCircle(A, D, Color.Red);
            snowman2[1] = new ColorCircle(B, E, Color.Green);
            snowman2[2] = new ColorCircle(C, E, Color.DarkMagenta);
            snowman2[3] = new ColorLine(F, G, Color.Orange);
            snowman2[4] = new ColorLine(H, I, Color.Orange);
            snowman2[5] = new ColorBox(J, K, Color.DarkViolet);
            snowman2[6] = new ColorBox(L, M, Color.DarkViolet);


            for (int i = 0; i < snowman2.Length; i++)
            {
                snowman2[i].SetGraphics(gr);
            }
        }
        private void Draw()
        {
            Draw(snowman1);
            Draw(snowman2);
            pictureBox.Image = bmp;
        }

        private void Draw(Shape [] shapes)
        {
            for (int i = 0; i < shapes.Length; i++)
                Draw(shapes[i]);
        }

        private void Draw(Shape shape)
        {
            if (shape.GetType() == typeof(Line))
               ((Line)shape).Draw();
            else if (shape.GetType() == typeof(Box))
                ((Box)shape).Draw();
            else if (shape.GetType() == typeof(Circle))
                ((Circle)shape).Draw();
            else if (shape.GetType() == typeof(ColorLine))
                ((ColorLine)shape).Draw();
            else if (shape.GetType() == typeof(ColorBox))
                ((ColorBox)shape).Draw();
            else if (shape.GetType() == typeof(ColorCircle))
                ((ColorCircle)shape).Draw();
        }

    }
}
