using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace OOPDraw
{
    class Point: Shape_Point
    {
        public Point() 
        {
            Random rand = new Random();
            x = rand.Next(1, 500);
            y = rand.Next(1, 500);
            color = Color.FromArgb(
                rand.Next(256),
                rand.Next(256),
                rand.Next(256)
                );
        }
        public void SetPointX(int X)
        {
            x = X;
        }
        public void SetPointY(int Y)
        {
            y = Y;
        }
        public void SetPointColor(Color Color)
        {
            color = Color;
        }
        public Point(int x,int y, Color color) : base(x, y, color)
        {
        }
        public Point(Color color, int x, int y) : base(x, y, color)
        {
        }
        public Point(Point point)
        {
            this.x = point.x;
            this.y = point.y;
            this.color = point.color;
        }
        public override void Draw(Graphics graphics)
        {
            graphics.FillEllipse(new SolidBrush(color), x-1, y-1, 2, 2);
        }

    }
}
