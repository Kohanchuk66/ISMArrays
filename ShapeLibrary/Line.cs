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
            x2 = rand.Next(0, 550);
            y2 = rand.Next(7, 429);
            x = rand.Next(1, 500);
            y = rand.Next(1, 500);
            color = Color.FromArgb(
                rand.Next(256),
                rand.Next(256),
                rand.Next(256)
                );
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
            this.x2 = x2;
            this.y2 = y2;
        }
        public Line(Color color, int x, int y) : base(x, y, color)
        {
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
