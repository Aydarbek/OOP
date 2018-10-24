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
        Circle circle;
        Box box;
        Line line;

        Sprite snowman1;
        Sprite snowman2;

        Pixel A, B, C, D, E, F, G, H, I, J, K, L, M;



        public FormMain()
        {
            InitializeComponent();
            Init();
//            InitSnowman1();
//            InitSnowman2();
//            Draw();
            Demo();
        }

        private void Init()
        {
            bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            gr = Graphics.FromImage(bmp);
            pen = new Pen(Color.Blue);
        }

        private void Demo()
        {
            Pixel P = new Pixel(100, 100);
            A = new Geometry1.Pixel(0, 0);

            circle = new Circle(A, 50);
            circle.SetGraphics(gr);
            circle.Move(P);
            circle.Draw();

            box = new Box(-50, 50, 50, 100);
            box.SetGraphics(gr);
            box.Move(P);
            box.Draw();

            line = new Line(0, -50, 0, 100);
            line.SetGraphics(gr);
            line.Move(P);
            line.Draw();


            pictureBox.Image = bmp;


        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            Pixel P = new Pixel(300, 100);
            circle.Move(P);
            circle.Draw();
            box.Move(P);
            box.Draw();
            line.Move(P);
            line.Draw();
            pictureBox.Image = bmp;
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

            snowman1 = new Sprite();
            snowman1.SetGraphics(gr);
            snowman1.AddShape(new Circle(A, D));            
            snowman1.AddShape(new Circle(B, E));
            snowman1.AddShape(new Circle(C, E));
            snowman1.AddShape(new Line(F, G));
            snowman1.AddShape(new Line(H, I));
            snowman1.AddShape(new Box(J, K));
            snowman1.AddShape(new Box(L, M));

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


            snowman2 = new Sprite();
            snowman2.SetGraphics(gr);
            snowman2.AddShape(new ColorCircle(A, D, Color.Red));
            snowman2.AddShape(new ColorCircle(B, E, Color.Green));
            snowman2.AddShape(new ColorCircle(C, E, Color.DarkMagenta));
            snowman2.AddShape(new ColorLine(F, G, Color.Orange));
            snowman2.AddShape(new ColorLine(H, I, Color.Orange));
            snowman2.AddShape(new ColorBox(J, K, Color.DarkViolet));
            snowman2.AddShape(new ColorBox(L, M, Color.DarkViolet));

        }
        private void Draw()
        {
            snowman1.Draw();
            snowman2.Draw();
            pictureBox.Image = bmp;
        }

        private void Draw(Shape [] shapes)
        {
            for (int i = 0; i < shapes.Length; i++)
                shapes[i].Draw();
        }
        
    }
}
