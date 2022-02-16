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
        Rectangle food;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            snakeList.Add(new Rectangle(40, 40, 40, 40));
            food = new Rectangle(100,100,10,10);

        }
    }
}
