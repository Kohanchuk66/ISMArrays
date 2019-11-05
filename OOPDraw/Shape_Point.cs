using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace OOPDraw
{
    public abstract class Shape_Point
    {
        protected int x;
        protected int y;
        protected int col; 
        protected Color color;
        public Shape_Point()
        {
            Random rand = new Random();
            x = rand.Next(1, 500);
            y= rand.Next(1, 500);
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
        public Shape_Point(int X,int Y, Color pen)
        {
            x = X;
            y = Y;
            color = pen;
        }
        public Shape_Point(Color pen, int X, int Y)
        {
            x = X;
            y = Y;
            color = pen;
        }
        public Shape_Point(Shape_Point shape_Point)
        {
            x = shape_Point.x;
            y = shape_Point.y;
            color = shape_Point.color;
        }
        public void SetShapeX(int X)
        {
            x = X;
        }
        public void SetShapeY(int Y)
        {
            y = Y;
        }
        public void SetShapeColor(Color Color)
        {
            color = Color;
        }
        public abstract void Draw(Graphics graphics)
    }
}
