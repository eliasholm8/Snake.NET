using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake.NET
{
    public partial class Form1 : Form
    {
        public int direction = 0;
        public int stepLength = 20;
        public int dx = 0;
        public int dy = 5;
        public int size = 20;

        Random rnd = new Random();

        public Rectangle food;
        List<Rectangle> snakeList = new List<Rectangle>();
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.Red, food);

            foreach (Rectangle rec in snakeList)
            {
                g.FillRectangle(Brushes.Blue, rec);
            }

        }
        public void NewFood()
        {

            food = new Rectangle(rnd.Next(0, panel1.Width),rnd.Next(0 ,panel1.Height),size,size);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            snakeList.Add(new Rectangle(40, 40, size, size));
            NewFood();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                direction = 1;
                dy = -stepLength;
                dx = 0;
            }
            else if (e.KeyCode == Keys.Down)
            {
                direction = 3;
                dy = stepLength;
                dx = 0;
            }
            else if (e.KeyCode == Keys.Left)
            {
                direction = 3;
                dx = -stepLength;
                dy = 0;
            }
            else if (e.KeyCode == Keys.Right)
            {
                direction = 2;
                dx = stepLength;
                dy = 0;
            }                       
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Invalidate();
            
            snakeList.Insert(0, new Rectangle(snakeList[0].X + dx, snakeList[0].Y + dy, size, size));
            snakeList.RemoveAt(snakeList.Count - 1);

            if (snakeList[0].IntersectsWith(food))
            {
                snakeList.Insert(snakeList.Count, new Rectangle(snakeList[snakeList.Count - 1].X, snakeList[snakeList.Count - 1].Y, size, size));
                NewFood();
            }
            lblDebug.Text = (snakeList.Count() - 1).ToString();
        }
    }
}
