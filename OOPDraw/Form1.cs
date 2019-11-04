using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace OOPDraw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {                                                     
            Shape_Point[] shape = new Shape_Point[20];
            int ran;            
                Random rand = new Random();
            for (int i = 0; i < 20; i++)
            {
            ran=rand.Next(1, 6);                                 
                switch (ran)
                {
                    case 1:
                        shape[i] = new Point();
                        shape[i].Draw(pictureBox2.CreateGraphics());
                        break;
                    case 2:
                        shape[i] = new Line();
                        shape[i].Draw(pictureBox2.CreateGraphics());
                        break;
                    case 3:
                        shape[i] = new Circle();
                        shape[i].Draw(pictureBox2.CreateGraphics());
                        break;
                    case 4:
                        shape[i] = new Ellips();
                        shape[i].Draw(pictureBox2.CreateGraphics());
                        break;
                    case 5:
                        shape[i] = new Rectangle();
                        shape[i].Draw(pictureBox2.CreateGraphics());
                        break;
                }
                    /*for(int i = 0; i < 20; i++)
                    {
                        ran = rand.Next(1, 6);
                        switch (ran)
                        {
                            case 1:
                                Point point = new Point();
                                point.Draw(pictureBox2.CreateGraphics());
                                break;
                            case 2:
                                Line line = new Line();
                                line.Draw(pictureBox2.CreateGraphics());
                                break;
                            case 3:
                                Circle circle = new Circle();
                                circle.Draw(pictureBox2.CreateGraphics());
                                break;
                            case 4:
                                Ellips ellips = new Ellips();
                                ellips.Draw(pictureBox2.CreateGraphics());
                                break;
                            case 5:
                                Rectangle rectangle = new Rectangle();
                                rectangle.Draw(pictureBox2.CreateGraphics());
                                break;
                        }*/
                    }
                }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
            pictureBox2.Invalidate();
        }
    }
}
