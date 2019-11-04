using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace OOPDraw
{
    class Circle: Point
    {
        protected int width;
        public Circle()
        {
            Random rand = new Random();
            x = rand.Next(5, 459);
            width = rand.Next(10, 100);
            y = rand.Next(1, 499);
            
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
        public void SetCircleX(int X)
        {
            x = X;
        }
        public void SetCircleY(int Y)
        {
            y = Y;
        }
        public void SetCircleColor(Color Color)
        {
            color = Color;
        }
        public void SetCircleWidth(int Width)
        {
            width = Width;
        }
        public Circle(int x,int y,Color color, int width):base(x, y, color)
        {
            this.x = x;
            this.y = y;
            this.color = color;
            this.width = width;
        }
        public Circle(Color color, int x, int y,  int width) : base(x, y, color)
        {
            this.x = x;
            this.y = y;
            this.color = color;
            this.width = width;
        }
        public Circle(Circle circle)
        {
            this.x = circle.x;
            this.y = circle.y;
            this.color = circle.color;
            this.width = circle.width;
        }
        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(new Pen(color), x, y, width, width);
            graphics.FillEllipse(new SolidBrush(color), x + width / 2+1, y + width / 2-1, 2, 2);
            graphics.DrawLine(new Pen(color), x + width / 2, y + width / 2, x + width , y + width/2  );
        }
    }
}
