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
        public int dx = 20;
        public int dy = 0;
        public int size = 20;
        public bool isPaused = false;

        Random rnd = new Random();

        public Rectangle food;
        List<Rectangle> snakeList = new List<Rectangle>();
        public Form1()
        {
            InitializeComponent();
        }
        private void StartGame()
        {
            dy = 0;
            dx = stepLength;
            snakeList.Clear();
            lblGameOver.Visible = false;
            timer1.Start();
            snakeList.Add(new Rectangle(20, 20, size, size));
            NewFood();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.Red, food);

            foreach (var (rec, i) in snakeList.Select((rec, i) => (rec,i)))
            {
                if (i % 2 == 0)
                {
                    g.FillRectangle(Brushes.LightGreen, rec);
                }
                else
                {
                    g.FillRectangle(Brushes.Green, rec);
                }
            }

        }

        private bool CheckIfSnake(Rectangle rec)
        {
            bool IsOccupied = false;
            foreach (var item in snakeList)
            {
                if (item.IntersectsWith(rec))
                {
                    IsOccupied = true;
                }
            }
            return IsOccupied;
        }
        /// <summary>
        /// Placerar mat till snake. Placerar med samma mellanrum som ormens bredd.
        /// </summary>
        private void NewFood()
        {
            int x, y;
            Rectangle temp;

            x = rnd.Next(0, (panel1.Width / size)) * size;
            y = rnd.Next(0, (panel1.Height / size)) * size;

            temp = new Rectangle(x, y, size, size);

            if (!CheckIfSnake(temp))
            {
                food = temp;
            }
            else
            {
                NewFood();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CheckKey()
        {
            switch (direction)
            {
                case 1:
                    if (direction != 3)
                    {
                        dy = -stepLength;
                        dx = 0;
                    }
                    break;

                case 2:
                    if (direction != 4)
                    {                        
                        dx = stepLength;
                        dy = 0;
                    }
                    break;

                case 3:
                    if (direction != 1)
                    {
                        dy = stepLength;
                        dx = 0;
                    }
                    break;

                case 4:
                    if (direction != 2)
                    {
                        dx = -stepLength;
                        dy = 0;
                    }
                    break;

                default:
                    break;
            }
        }
        private async void Form1_KeyDown(object sender, KeyEventArgs e)
        {           

            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (direction != 3)
                    {
                        direction = 1;
                        dy = -stepLength;
                        dx = 0;
                    }
                    break;

                case Keys.Right:

                    if (direction != 4)
                    {
                        direction = 2;
                        dx = stepLength;
                        dy = 0;
                    }
                    break;

                case Keys.Down:
                    if (direction != 1)
                    {
                        direction = 3;
                        dy = stepLength;
                        dx = 0;
                    }
                    break;

                case Keys.Left:
                    if (direction != 2)
                    {
                        direction = 4;
                        dx = -stepLength;
                        dy = 0;
                    }
                    break;

                default:
                    break;
            }
            


            if (false)
            {
                if (e.KeyCode == Keys.Up)
                {
                    direction = 1;
                    
                }
                else if (e.KeyCode == Keys.Down)
                {
                    direction = 3;
                    
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

        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            Rectangle temp;
            int xHeadPosition,yHeadPosition;

            xHeadPosition = snakeList[0].X + dx;
            yHeadPosition = snakeList[0].Y + dy;

            int left, top;

            left = panel1.Left;
            top = panel1.Top;


            temp = new Rectangle(xHeadPosition, yHeadPosition, size, size);

            if (xHeadPosition <= 0)
            {
                temp = new Rectangle(panel1.Right - size, yHeadPosition, size, size);
            }
            if (xHeadPosition >= panel1.Width)
            {
                temp = new Rectangle(panel1.Left, yHeadPosition, size, size);
            }
            if (yHeadPosition <= 0)
            {
                temp = new Rectangle(xHeadPosition, panel1.Height - size, size, size);
            }
            if (yHeadPosition >= panel1.Height)
            {
                temp = new Rectangle(xHeadPosition, 0 + size, size, size);
            }

            if (CheckIfSnake(temp))
            {
                GameOver();
            }
            else
            {
                snakeList.Insert(0, temp);
                
                snakeList.RemoveAt(snakeList.Count - 1);           
            }
            panel1.Invalidate();

            if (snakeList[0].IntersectsWith(food))
            {
                int xPosition, yPosition;

                xPosition = snakeList[snakeList.Count - 1].X;
                yPosition = snakeList[snakeList.Count - 1].Y;

                snakeList.Insert(snakeList.Count, new Rectangle(xPosition, yPosition, size, size));
                NewFood();
            }
            lblScore.Text = $"Score: {(snakeList.Count() - 1)}";
        }

        private void lblStartGame_Click(object sender, EventArgs e)
        {
            StartGame();
        }
        private void GameOver()
        {
            timer1.Stop();
            lblGameOver.Visible = true;
            lblGameOver.Text = "wasted";
        }
        private void PauseGame()
        {
            isPaused = !isPaused;
            timer1.Enabled = isPaused;
        }

        private void lblPause_Click(object sender, EventArgs e)
        {
            PauseGame();
        }
    }
}
