using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace OOPDraw
{
    class Ellips:Circle
    {
        protected int height;
        public Ellips()
        {
            Random rand = new Random();
            x = rand.Next(4, 398);
            width = rand.Next(10, 100);
            y = rand.Next(10, 499);            
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
            height = rand.Next(4, 123);
        }
        public Ellips(int x, int y, Color color, int width, int height ) : base(x, y, color,width)
        {
            this.x = x;
            this.y = y;
            this.color = color;
            this.width = width;
            this.height = height;
        }
        public Ellips(Color color, int x, int y,  int width, int height) : base(x, y, color, width)
        {
            this.x = x;
            this.y = y;
            this.color = color;
            this.width = width;
            this.height = height;
        }
        public Ellips(Ellips ellips)
        {
            this.x = ellips.x;
            this.y = ellips.y;
            this.color = ellips.color;
            this.width = ellips.width;
            this.height = ellips.height;
        }
        public void SetEllipsX(int X)
        {
            x = X;
        }
        public void SetEllipsY(int Y)
        {
            y = Y;
        }
        public void SetEllipsColor(Color Color)
        {
            color = Color;
        }
        public void SetEllipsWidth(int Width)
        {
            width = Width;
        }
        public void SetEllipsHeight(int Height)
        {
            height = Height;
        }
        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(new Pen(color), x, y, width, height);
            graphics.FillEllipse(new SolidBrush(color), x + width / 2 + 1, y + height / 2 - 1, 2, 2);
            graphics.DrawLine(new Pen(color), x + width / 2, y + height / 2, x + width, y + height / 2);
            graphics.DrawLine(new Pen(color), x + width / 2, y + height / 2, x + width/2, y);
        }
    }
}
