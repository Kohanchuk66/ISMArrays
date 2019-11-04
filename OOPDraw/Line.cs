using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace OOPDraw
{
    class Line: Point
    {
        protected int x2,y2;
        public Line()
        {
            Random rand = new Random();
            x = rand.Next(1, 500);
            y = rand.Next(5, 439);
            x2 = rand.Next(4, 550);
            y2 = rand.Next(7, 429);
            col = rand.Next(1, 7);
            switch (col)
            {
                case 1:
                    color = Color.Green;
                    break;
                case 2:
                    color = Color.Blue;
                    break;
                case 3:
                    color = Color.Black;
                    break;
                case 4:
                    color = Color.Red;
                    break;
                case 5:
                    color = Color.Brown;
                    break;
                case 6:
                    color = Color.Pink;
                    break;
            }
        }
        public void SetLineX(int X)
        {
            x = X;
        }
        public void SetLineY(int Y)
        {
            y = Y;
        }
        public void SetLineColor(Color Color)
        {
            color = Color;
        }
        public void SetLineX2(int X2)
        {
            x2 = X2;
        }
        public void SetLineY2(int Y2)
        {
            y2 = Y2;
        }
        public Line(int x,int y,int x2,int y2, Color color) :base(x,y,color)
        {
            this.x = x;
            this.y = y;
            this.x2 = x2;
            this.y2 = y2;
            this.color = color;
        }
        public Line(Color color, int x, int y) : base(x, y, color)
        {
            this.x = x;
            this.y = y;
            this.color = color;
        }
        public Line(Line line)
        {
            this.x = line.x;
            this.y = line.y;
            this.x2 = line.x2;
            this.y2 = line.y2;
            this.color = line.color;
        }
        public override void Draw(Graphics graphics)
        {
            graphics.DrawLine(new Pen(color), x, y, x2, y2);
        }
    }
}
