using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using ShapeLibrary;
namespace OOPDraw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<ShapeLibrary.Shape_Point> shape;
        private void InputBox()
        {
           
            DialogResult result = MessageBox.Show("Для использования всех функций введите номер карты и пин-код.Оплата будет составлять 100 грн.", "ERROR!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                label2.Visible = true;
                label3.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
            } 
        }
        int run = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            shape = new List<ShapeLibrary.Shape_Point>();
            int ran;
            Random rand = new Random();
            
            if(textBox1.TextLength!=0 && textBox2.TextLength != 0 && run != 1)
            {
                run++;
                label2.Visible = false;
                label3.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                MessageBox.Show("Спасибо за покупку,приятного пользования)");
            }
            if (Count.Value > 15 && run == 0)
            {
                InputBox();
                return;
            }
            for (int i = 0; i < Count.Value; i++)
            {
            ran=rand.Next(1, 6);                                 
                switch (ran)
                {
                    case 1:
                        shape.Add(new ShapeLibrary.Point(
                             rand.Next(1, pictureBox2.Width),
                             rand.Next(1, pictureBox2.Height),
                             Color.FromArgb(
                                rand.Next(256),
                                rand.Next(256),
                                rand.Next(256)
                            )
                            ));
                        break;
                    case 2:
                        shape.Add(new ShapeLibrary.Line(
                                rand.Next(1, pictureBox2.Width),
                                rand.Next(1, pictureBox2.Height),
                                rand.Next(1, pictureBox2.Width),
                                rand.Next(1, pictureBox2.Height),
                                Color.FromArgb(
                                    rand.Next(256),
                                    rand.Next(256),
                                    rand.Next(256)
                            )
                            ));
                        break;
                    case 3:
                        shape.Add(new ShapeLibrary.Circle(
                                rand.Next(1, pictureBox2.Width),
                             rand.Next(1, pictureBox2.Height),
                             Color.FromArgb(
                                rand.Next(256),
                                rand.Next(256),
                                rand.Next(256)
                            ),
                             rand.Next(1, pictureBox2.Width/10)
                            ));
                        break;
                    case 4:
                        shape.Add(new ShapeLibrary.Ellips(
                            rand.Next(1, pictureBox2.Width),
                             rand.Next(1, pictureBox2.Height),
                             Color.FromArgb(
                                rand.Next(256),
                                rand.Next(256),
                                rand.Next(256)
                            ),
                             rand.Next(1, pictureBox2.Width/10),
                             rand.Next(1, pictureBox2.Height/10)
                            ));
                        break;
                    case 5:
                        shape.Add (new ShapeLibrary.Rectangle(
                            Color.FromArgb(
                                rand.Next(256),
                                rand.Next(256),
                                rand.Next(256)
                            ),
                            rand.Next(1, pictureBox2.Width),
                             rand.Next(1, pictureBox2.Height),
                             rand.Next(1, pictureBox2.Width/10),
                             rand.Next(1, pictureBox2.Height/10)
                            ));
                        break;
                }
                    }
            foreach(Shape_Point i in shape)
                i.Draw(pictureBox2.CreateGraphics());
            pictureBox2.Refresh();
                }

        private void button2_Click(object sender, EventArgs e)
        {
            shape.Clear();           
            pictureBox2.Refresh();
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            if (shape != null)
            {
                for(int i = 0; i < shape.Count; i++)
                {
                    shape[i].Draw(e.Graphics);
                }
            }
        }
        private void NumberKill_ValueChanged(object sender, EventArgs e)
        {
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int Number = Convert.ToInt32(NumberKill.Value);
            if(Number >= 0 && Number < (int)shape.Count)
            {
                shape.RemoveAt(Number);
                
            }
         pictureBox2.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (shape == null)
                shape = new List<Shape_Point>();
            if (textBox1.TextLength != 0 && textBox2.TextLength != 0 && run != 1)
            {
                run++;
                label2.Visible = false;
                label3.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                MessageBox.Show("Спасибо за покупку,приятного пользования)");
            }
            if (shape.Count > 15 && run == 0)
            {
                InputBox();
                shape.Clear();
                pictureBox2.Refresh();
                return;
            }
            Random rand = new Random();
            if (col.ShowDialog() != DialogResult.OK)
                return;
            if (Figure.SelectedItem == null)
                return;
            switch (Figure.SelectedIndex)
            {
                case 4:
                    shape.Add(new ShapeLibrary.Point(
                         rand.Next(1, pictureBox2.Width),
                         rand.Next(1, pictureBox2.Height),
                         Color.FromArgb(
                            rand.Next(256),
                            rand.Next(256),
                            rand.Next(256)
                        )
                        ));
                    break;
                case 3:
                    shape.Add(new Line(
                            rand.Next(1, pictureBox2.Width),
                            rand.Next(1, pictureBox2.Height),
                            rand.Next(1, pictureBox2.Width),
                            rand.Next(1, pictureBox2.Height),
                            Color.FromArgb(
                                rand.Next(256),
                                rand.Next(256),
                                rand.Next(256)
                        )
                        ));
                    break;
                case 2:
                    shape.Add(new Circle(
                            rand.Next(1, pictureBox2.Width),
                         rand.Next(1, pictureBox2.Height),
                         Color.FromArgb(
                            rand.Next(256),
                            rand.Next(256),
                            rand.Next(256)
                        ),
                         rand.Next(1, pictureBox2.Width / 10)
                        ));
                    break;
                case 1:
                    shape.Add(new Ellips(
                        rand.Next(1, pictureBox2.Width),
                         rand.Next(1, pictureBox2.Height),
                         Color.FromArgb(
                            rand.Next(256),
                            rand.Next(256),
                            rand.Next(256)
                        ),
                         rand.Next(1, pictureBox2.Width / 10),
                         rand.Next(1, pictureBox2.Height / 10)
                        ));
                    break;
                case 0:
                    shape.Add(new ShapeLibrary.Rectangle(
                        Color.FromArgb(
                            rand.Next(256),
                            rand.Next(256),
                            rand.Next(256)
                        ),
                        rand.Next(1, pictureBox2.Width ),
                         rand.Next(1, pictureBox2.Height ),
                         rand.Next(1, pictureBox2.Width / 10),
                         rand.Next(1, pictureBox2.Height / 10)
                        ));
                    break;                
            }         
            shape[shape.Count()-1].SetShapeColor(col.Color);
            foreach (Shape_Point i in shape)
                i.Draw(pictureBox2.CreateGraphics());            
        }
        public void Figure_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            if (shape == null)
                return;
            if (NumberKill.Value >= shape.Count)
                return;
            int Number = Convert.ToInt32(NumberKill.Value);
             shape[Number].Left();
            pictureBox2.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            if (shape == null)
                return;
            if (NumberKill.Value >= shape.Count)
                return;
            int Number = Convert.ToInt32(NumberKill.Value);
            shape[Number].Right();
            pictureBox2.Refresh();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            if (shape == null)
                return;
            if (NumberKill.Value >= shape.Count)
                return;
            int Number = Convert.ToInt32(NumberKill.Value);
            shape[Number].Up();
            pictureBox2.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            if (shape == null)
                return;
            if (NumberKill.Value >= shape.Count)
                return;
            int Number = Convert.ToInt32(NumberKill.Value);
            shape[Number].Down();
            pictureBox2.Refresh();
        }
        int X,Y,maxx,maxy,widthrec,heightrec;

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (checkBox2.Checked)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (textBox1.TextLength != 0 && textBox2.TextLength != 0 && run != 1)
                    {
                        run++;
                        label2.Visible = false;
                        label3.Visible = false;
                        textBox1.Visible = false;
                        textBox2.Visible = false;
                        MessageBox.Show("Спасибо за покупку,приятного пользования)");
                    }
                    if (shape.Count > 15 && run == 0)
                    {
                        InputBox();
                        shape.Clear();
                        pictureBox2.Refresh();
                        return;
                    }
                    if (e.X < X) maxx = e.X;
                    else maxx = X;
                    if (e.Y < Y) maxy = e.Y;
                    else maxy = Y;
                    Random rand = new Random();
                    if (shape == null)
                        shape = new List<Shape_Point>();
                    if (Figure.SelectedItem == null)
                        return;
                    switch (Figure.SelectedIndex)
                    {
                        case 4:
                            shape.Add(new ShapeLibrary.Point(
                                e.X,
                                e.Y,
                                 Color.FromArgb(
                                    rand.Next(256),
                                    rand.Next(256),
                                    rand.Next(256)
                                )
                                ));
                            break;
                        case 3:
                            shape.Add(new Line(
                                    X,
                                    Y,
                                    e.X,
                                    e.Y,
                                    Color.FromArgb(
                                        rand.Next(256),
                                        rand.Next(256),
                                        rand.Next(256)
                                )
                                ));
                            break;
                        case 2:
                            shape.Add(new Circle(
                                    X,
                                    Y,
                                 Color.FromArgb(
                                    rand.Next(256),
                                    rand.Next(256),
                                    rand.Next(256)
                                ),
                                 Math.Abs(e.Y - Y) * 2
                                ));
                            break;
                        case 1:
                            shape.Add(new Ellips(
                                    X,
                                    Y,
                                 Color.FromArgb(
                                    rand.Next(256),
                                    rand.Next(256),
                                    rand.Next(256)
                                ),
                                 Math.Abs(e.X - X) * 2,
                                 Math.Abs(e.Y - Y) * 2
                                ));
                            break;
                        case 0:
                            heightrec = Math.Abs(e.Y - Y);
                            widthrec = Math.Abs(e.X - X);
                            shape.Add(new ShapeLibrary.Rectangle(
                                Color.FromArgb(
                                    rand.Next(256),
                                    rand.Next(256),
                                    rand.Next(256)
                                ),
                                maxx,
                                maxy,
                                 heightrec,
                                 widthrec
                                ));

                            break;

                    }
                    pictureBox2.Refresh();
                }
            }
            else
            {


                if (!checkBox1.Checked)
                    pictureBox2.Refresh();
                if (e.Button == MouseButtons.Left)
                {
                    if (e.X < X) maxx = e.X;
                    else maxx = X;
                    if (e.Y < Y) maxy = e.Y;
                    else maxy = Y;
                    Random rand = new Random();
                    if (shape == null)
                        shape = new List<Shape_Point>();
                    if (Figure.SelectedItem == null)
                        return;
                    Graphics gr = pictureBox2.CreateGraphics();
                    switch (Figure.SelectedIndex)
                    {
                        case 4:
                            gr.DrawEllipse(
                                new Pen(Color.FromArgb(
                                   rand.Next(256),
                                   rand.Next(256),
                                   rand.Next(256)
                               )),
                               e.X - 1,
                               e.Y - 1,
                                2,
                                2
                               );
                            break;
                        case 3:
                            gr.DrawLine(
                                new Pen(Color.FromArgb(
                                    rand.Next(256),
                                    rand.Next(256),
                                    rand.Next(256)
                                )),
                                    X,
                                    Y,
                                    e.X,
                                    e.Y
                                );
                            break;
                        case 2:
                            gr.DrawEllipse(
                                 new Pen(Color.FromArgb(
                                    rand.Next(256),
                                    rand.Next(256),
                                    rand.Next(256)
                                )),
                                    X - Math.Abs(e.Y - Y) * 2 / 2 - 1,
                                    Y - Math.Abs(e.Y - Y) * 2 / 2 - 1,
                                 Math.Abs(e.Y - Y) * 2,
                                 Math.Abs(e.Y - Y) * 2
                                );
                            break;
                        case 1:
                            gr.DrawEllipse(
                                 new Pen(Color.FromArgb(
                                    rand.Next(256),
                                    rand.Next(256),
                                    rand.Next(256)
                                )),
                                    X - Math.Abs(e.X - X) * 2 / 2 - 1,
                                    Y - Math.Abs(e.Y - Y) * 2 / 2 - 1,
                                 Math.Abs(e.X - X) * 2,
                                 Math.Abs(e.Y - Y) * 2
                                );
                            break;
                        case 0:
                            heightrec = Math.Abs(e.Y - Y);
                            widthrec = Math.Abs(e.X - X);
                            gr.DrawRectangle(
                                new Pen(Color.FromArgb(
                                    rand.Next(256),
                                    rand.Next(256),
                                    rand.Next(256)
                                )),
                                maxx,
                                maxy,
                                widthrec,
                                 heightrec

                                );

                            break;

                    }
                }
            }
            
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            if (textBox1.TextLength != 0 && textBox2.TextLength != 0 && run != 1)
            {
                run++;
                label2.Visible = false;
                label3.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                MessageBox.Show("Спасибо за покупку,приятного пользования)");
            }
            if (shape.Count > 15 && run == 0)
            {
                InputBox();
                shape.Clear();
                pictureBox2.Refresh();
                return;
            }
            if (e.X < X) maxx = e.X;
            else maxx = X;
            if (e.Y < Y) maxy = e.Y;
            else maxy = Y;
            Random rand = new Random();
            if (shape == null)
                shape = new List<Shape_Point>();
            if (Figure.SelectedItem == null)
                return;
            switch (Figure.SelectedIndex)
            {
                case 4:
                    shape.Add(new ShapeLibrary.Point(
                        e.X,
                        e.Y,
                         Color.FromArgb(
                            rand.Next(256),
                            rand.Next(256),
                            rand.Next(256)
                        )
                        ));
                    break;
                case 3:
                    shape.Add(new Line(
                            X,
                            Y,
                            e.X,
                            e.Y,
                            Color.FromArgb(
                                rand.Next(256),
                                rand.Next(256),
                                rand.Next(256)
                        )
                        ));
                    break;
                case 2:
                    shape.Add(new Circle(
                            X,
                            Y,
                         Color.FromArgb(
                            rand.Next(256),
                            rand.Next(256),
                            rand.Next(256)
                        ),
                         Math.Abs(e.Y - Y)*2
                        ));
                    break;
                case 1:
                    shape.Add(new Ellips(
                            X,
                            Y,
                         Color.FromArgb(
                            rand.Next(256),
                            rand.Next(256),
                            rand.Next(256)
                        ),                         
                         Math.Abs(e.X - X)*2,
                         Math.Abs(e.Y - Y)*2
                        ));
                    break;
                case 0:
                    heightrec = Math.Abs(e.Y - Y);
                    widthrec = Math.Abs(e.X - X);
                    shape.Add(new ShapeLibrary.Rectangle(
                        Color.FromArgb(
                            rand.Next(256),
                            rand.Next(256),
                            rand.Next(256)
                        ),
                        maxx,
                        maxy,
                         heightrec,
                         widthrec
                        ));
                    
                    break;

            }
            pictureBox2.Refresh();
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (shape == null)
                shape = new List<Shape_Point>();
            if (Figure.SelectedItem == null)
                return;
            X = e.X;
            Y = e.Y;
            /*Random rand = new Random();
            if (shape == null)
                shape = new List<Shape_Point>();
            if (Figure.SelectedItem == null)
                return;
            switch (Figure.SelectedIndex)
            {
                case 4:
                    shape.Add(new Point(
                        e.X,
                        e.Y,
                         Color.FromArgb(
                            rand.Next(256),
                            rand.Next(256),
                            rand.Next(256)
                        )
                        ));
                    break;
                case 3:
                    shape.Add(new Line(
                            e.X,
                            e.Y,
                            rand.Next(1, pictureBox2.Width),
                            rand.Next(1, pictureBox2.Height),
                            Color.FromArgb(
                                rand.Next(256),
                                rand.Next(256),
                                rand.Next(256)
                        )
                        ));
                    break;
                case 2:
                    shape.Add(new Circle(
                            e.X,
                            e.Y,
                         Color.FromArgb(
                            rand.Next(256),
                            rand.Next(256),
                            rand.Next(256)
                        ),
                         rand.Next(1, pictureBox2.Width / 10)
                        ));
                    break;
                case 1:
                    shape.Add(new Ellips(
                        e.X,
                        e.Y,
                         Color.FromArgb(
                            rand.Next(256),
                            rand.Next(256),
                            rand.Next(256)
                        ),
                         rand.Next(1, pictureBox2.Width / 10),
                         rand.Next(1, pictureBox2.Height / 10)
                        ));
                    break;
                case 0:
                    shape.Add(new Rectangle(
                        Color.FromArgb(
                            rand.Next(256),
                            rand.Next(256),
                            rand.Next(256)
                        ),
                        e.X,
                        e.Y,
                         rand.Next(1, pictureBox2.Width / 10),
                         rand.Next(1, pictureBox2.Height / 10)
                        ));
                    break;

            }
            pictureBox2.Refresh();*/
        }
    }
}
