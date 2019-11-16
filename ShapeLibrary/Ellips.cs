using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace ShapeLibrary
{
    class Ellips:Circle
    {
        protected int height;
        public Ellips()
        {
            Random rand = new Random();            
            height = rand.Next(4, 123);
            x = rand.Next(1, 500);
            y = rand.Next(1, 500);
            color = Color.FromArgb(
                rand.Next(256),
                rand.Next(256),
                rand.Next(256)
                );
            width = rand.Next(10, 100);
        }
        public Ellips(int x, int y, Color color, int width, int height ) : base(x, y, color,width)
        {
            this.height = height;
        }
        public Ellips(Color color, int x, int y,  int width, int height) : base(x, y, color, width)
        {
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
            graphics.DrawEllipse(new Pen(color), x - width / 2, y - height / 2, width, height);
            graphics.FillEllipse(new SolidBrush(color), x - 1, y - 1, 2, 2);
            graphics.DrawLine(new Pen(color), x , y , x , y - height / 2);
            graphics.DrawLine(new Pen(color), x , y , x + width / 2, y );
        }
    }
}
