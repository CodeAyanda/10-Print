using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10Print
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Pen white = new Pen(Color.White, 1);

        private void Draw(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Draw10Print(g);

        } 

        int width = Screen.PrimaryScreen.Bounds.Width;
        int height = Screen.PrimaryScreen.Bounds.Height;
        int xOff = 0;
        int yOff = 0;
        int spacing = 10;

        void Draw10Print(Graphics g)
        {

            Random rnd = new Random();
            while (yOff < height)
            {
                while (xOff < width)
                {
                    double index = rnd.NextDouble();

                    if (index < 0.5)
                    {
                        Point p1 = new Point(0 + xOff, 0 + yOff);
                        Point p2 = new Point(spacing + xOff, spacing + yOff);
                        g.DrawLine(white, p1, p2);
                        xOff += spacing;
                    }
                    else
                    {
                        Point p3 = new Point(spacing + xOff, 0 + yOff);
                        Point p4 = new Point(0 + xOff, spacing + yOff);
                        g.DrawLine(white, p3, p4);
                        xOff += spacing;
                    }
                }
                yOff += spacing;
                xOff = 0;

            }
        }

    }
}
