using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace OOPDraw
{
    class Rectangle: Line
    {
        protected int width;
        protected int height;
        public Rectangle()
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            height = rand.Next(0,500);
            x = rand.Next(1, 500);
            y = rand.Next(1, 500);
            color = Color.FromArgb(
                rand.Next(256),
                rand.Next(256),
                rand.Next(256)
                );
            width = rand.Next(10, 100);

        }
        public Rectangle(Color color, int x, int y, int height, int width) : base(color, x, y )
        {
            this.height = height;
            this.width = width;
        }
        public Rectangle(Color color, int x, int y) : base(color, x, y)
        {    
        }
        public Rectangle(Rectangle rectangle)
        {
            x = rectangle.x;
            y = rectangle.y;
            color = rectangle.color;
            height = rectangle.height;
            width = rectangle.width;
        }
        public void SetRectangleX(int X)
        {
            x = X;
        }
        public void SetRectangleY(int Y)
        {
            y = Y;
        }
        public void SetRectangleColor(Color Color)
        {
            color = Color;
        }
        public void SetRectangleWidth(int Width)
        {
            width = Width;
        }
        public void SetRectangleHeight(int Height)
        {
            height = Height;
        }
        public override void Draw(Graphics graphics)
        {
            //graphics.DrawLine(new Pen(color), x, y, x2, y);
            //graphics.DrawLine(new Pen(color), x, y2, x2, y2);
            //graphics.DrawLine(new Pen(color), x, y, x, y2);
            //graphics.DrawLine(new Pen(color), x2, y, x2, y2);
            Rectangle rect = new Rectangle();
            graphics.DrawRectangle(new Pen(color), x, y, width, height);
            graphics.FillEllipse(new SolidBrush(color), x, y, 2, 2);
            graphics.FillEllipse(new SolidBrush(color), x2, y2, 2, 2);
        }
    }
}
