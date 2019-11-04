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
            y = rand.Next(1, 499);
           
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
            this.x = x;
            this.y = y;
            this.color = color;
        }
        public Point(Color color, int x, int y) : base(x, y, color)
        {
            this.x = x;
            this.y = y;
            this.color = color;
        }
        public Point(Point point)
        {
            this.x = point.x;
            this.y = point.y;
            this.color = point.color;
        }
        public override void Draw(Graphics graphics)
        {
            graphics.FillEllipse(new SolidBrush(color), x, y, 2, 2);
        }
    }
}
