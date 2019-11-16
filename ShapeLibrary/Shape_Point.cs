using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace ShapeLibrary
{
    public abstract class Shape_Point
    {
        public int x;
        protected int y;
        protected int col; 
        protected Color color;
        public Shape_Point()
        {
            Random rand = new Random();
            x = rand.Next(1, 500);
            y= rand.Next(1, 500);
            color = Color.FromArgb(
                rand.Next(256),
                rand.Next(256),
                rand.Next(256)
                );
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
        public abstract void Draw(Graphics graphics);        
        public Shape_Point decx(Shape_Point shape)
        {
            shape.x--;
            return shape;
        }
        public Shape_Point incx(Shape_Point shape)
        {
            shape.x++;
            return shape;
        }
        public Shape_Point decy(Shape_Point shape)
        {
            shape.y--;
            return shape;
        }
        public Shape_Point incy(Shape_Point shape)
        {
            shape.y++;
            return shape;
        }
    }
}
