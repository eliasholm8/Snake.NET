/*
 * Elias Holm 19NAA1
 * https://github.com/eliasholm8/Snake.NET
 * 
 * Tillagda delar:
 * Inforuta
 * Starta nytt spel utan omstart
 * Timer
 * Levlar med varierande hastighet
 * Start och paus knappar
 * Blinkade GameOver
 * Flera matbitar
 * Ormen kan gå genom väggar
 * Flerfärgad orm
 * Grand Theft Auto tema på texten.
 * Highscore
 * Paus på Esc-knappen
 * 
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Snake.NET
{
    public partial class Form1 : Form
    {
        public int highscore = 0;
        public int direction = 2;
        public int stepLength = 20;
        public int dx = 20;
        public int dy = 0;
        public int size = 20;
        public int level = 1;
        public int score = 0;
        public int time = 0;
        public bool food1Eaten = true;
        public bool food2Eaten = true;
        public bool isPaused = false;

        Random rnd = new Random();

        /// <summary>
        /// Intierar matens platser.
        /// </summary>
        public Rectangle food1, food2;

        /// <summary>
        /// Initierar listan som sparar ormens delar.
        /// </summary>
        List<Rectangle> snakeList = new List<Rectangle>();

        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Startar spelet och återställer alla relevanta variabler.
        /// </summary>
        private void StartGame()
        {
            dy = 0;
            dx = stepLength;
            snakeList.Clear();
            lblGameOver.Visible = false;
            ResetLevel();
            UnPause();
            StopBlink();
            snakeList.Add(new Rectangle(0, 0, size, size));
            NewFood();
        }
        /// <summary>
        /// Renderar spelplanen med data ur <typeparamref name="snakeList"/> med varannnan färg.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.Red, food1);
            g.FillRectangle(Brushes.Red, food2);

            // i refererar till vilken position snakeList item har.

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
        /// <summary>
        /// Kontrollerar om någon del av <typeparamref name="snakeList"/> befinner sig på positionen <typeparamref name="rec"/> uppehåller sig på.
        /// </summary>
        /// <param name="rec"></param>
        /// <returns></returns>
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
        /// Återställer level och hastighet.
        /// </summary>
        private void ResetLevel()
        {
            score = 0;
            level = 1;
            timer1.Interval = 100;
            time = 0;
            food1Eaten = true;
            food2Eaten = true;

            CheckLevel();
        }
        /// <summary>
        /// Kontrollerar vilken level spelaren befinner sig på och uppdaterar score.
        /// </summary>
        private void CheckLevel()
        {
            lblLevel.Text = $"Level: {level}";
            switch (score)
            {
                case 5:
                    level = 2;
                    timer1.Interval = 120;
                    break;

                case 10:
                    level = 3;
                    timer1.Interval = 100;
                    break;

                case 15:
                    level = 4;
                    timer1.Interval = 75;
                    break;

                case 20:
                    level = 5;
                    timer1.Interval = 60;
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// Placerar mat till snake. Placerar med samma mellanrum som ormens bredd.
        /// </summary>
        private void NewFood()
        {
            int x, y;
            Rectangle temp;

            // Ser till att maten placeras på ett rutnät jämnt med ormen.

            x = rnd.Next(0, (panel1.Width / size)) * size;
            y = rnd.Next(0, (panel1.Height / size)) * size;

            temp = new Rectangle(x, y, size, size);

            if (food1Eaten)
            {
                // Kontrollerar att den nya maten inte kolliderar med ormen och den andra matbiten.

                if (temp.IntersectsWith(food1) || temp.IntersectsWith(food2) || CheckIfSnake(temp))
                {
                    NewFood();
                }
                else
                {
                    food1 = temp;
                    food1Eaten = false;
                }
            }
            if (food2Eaten)
            {
                if (temp.IntersectsWith(food1) || temp.IntersectsWith(food2) || CheckIfSnake(temp))
                {
                    NewFood();
                }
                else
                {
                    food2 = temp;
                    food2Eaten = false;
                }
            }            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ShowInstructions();
        }        

        private void ShowInstructions()
        {
            Form Form2;

            Form2 = new Form2();
            Form2.Show();
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

                case Keys.Escape:
                    PauseGame();
                    break;

                default:
                    break;
            }
        }
        /// <summary>
        /// Kontrollerar om ormens huvudbefinner sig på en matbit.
        /// </summary>
        private void CheckFood()
        {
            if (snakeList[0].IntersectsWith(food1))
            {
                food1Eaten = true;
                EatFood();
            }
            if (snakeList[0].IntersectsWith(food2))
            {
                food2Eaten = true;
                EatFood();
            }
            
        }
        /// <summary>
        /// Förlänger ormen när medoden kallas. Används när ormen äter mat. 
        /// </summary>
        private void EatFood()
        {
            int xPosition, yPosition;


            // Positionen där den nya delen av ormen ska sättas in i.

            xPosition = snakeList[snakeList.Count - 1].X;
            yPosition = snakeList[snakeList.Count - 1].Y;

            snakeList.Insert(snakeList.Count, new Rectangle(xPosition, yPosition, size, size));
            score++;           
            CheckLevel();
            NewFood();
        }
        /// <summary>
        /// Flyttar ormen och kontollerar om den kolliderar med sig själv.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void timer1_Tick(object sender, EventArgs e)
        {
            Rectangle temp;
            int xHeadPosition,yHeadPosition;

            // Nya positionen för huvudet

            xHeadPosition = snakeList[0].X + dx;
            yHeadPosition = snakeList[0].Y + dy;

            // Skapar en temporär Rectanglevariabel.

            temp = new Rectangle(xHeadPosition, yHeadPosition, size, size);

            // Kontrollerar om ormen lämnnar kartan och flyttar den till andra sidan.

            if (xHeadPosition < 0)
            {
                temp = new Rectangle((panel1.Right + 1) - size, yHeadPosition, size, size);
            }
            if (xHeadPosition > panel1.Width)
            {
                temp = new Rectangle(0, yHeadPosition, size, size);
            }
            if (yHeadPosition < 0)
            {
                temp = new Rectangle(xHeadPosition, panel1.Height - size, size, size);
            }
            if (yHeadPosition > panel1.Height)
            {
                temp = new Rectangle(xHeadPosition, 0, size, size);
            }

            // Kontrollerar om ormen kolliderar med sig själv.

            if (CheckIfSnake(temp))
            {
                GameOver();
            }
            else
            {
                // Flyttar ormen.

                snakeList.Insert(0, temp);
                
                snakeList.RemoveAt(snakeList.Count - 1);           
            }
            panel1.Invalidate();
            CheckFood();
            
            lblScore.Text = $"Score: {score}";
        }
        /// <summary>
        /// Startar spelet med StartGame metoden.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblStartGame_Click(object sender, EventArgs e)
        {
            StartGame();
        }        
        private void StopBlink()
        {
            blinkTimer.Stop();
            lblGameOver.Visible = false;
        }

        /// <summary>
        /// Får texten att börja blinka när spelaren förlorat.
        /// </summary>
        private void BlinkGameOver()
        {
            blinkTimer.Enabled = true;
        }
        /// <summary>
        /// Stoppar spelet vid förlust.
        /// </summary>
        private void GameOver()
        {
            timer1.Stop();
            BlinkGameOver();
            lblGameOver.Text = "wasted";
            timerTime.Stop();
            if (score > highscore)
            {
                highscore = score;
            }
            lblHighScore.Text = $"highscore: {highscore}";
        }

        /// <summary>
        /// Avpausar spelet när ett nytt spel startas.
        /// </summary>
        private void UnPause()
        {
            isPaused = false;
            timer1.Enabled = true;
            lblPauseScreen.Visible = false;
            timerTime.Enabled = true;
        }
        /// <summary>
        /// Pausar spelet.
        /// </summary>
        private void PauseGame()
        {            
            isPaused = !isPaused;
            timer1.Enabled = !isPaused;
            timerTime.Enabled = !isPaused;
            lblPauseScreen.Visible = isPaused;
        }

        private void lblPause_Click(object sender, EventArgs e)
        {
            PauseGame();
        }
        /// <summary>
        /// Timern som gör det möjligt för gameover texten att blinka.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void blinkTimer_Tick(object sender, EventArgs e)
        {            
            lblGameOver.Visible = !lblGameOver.Visible;            
        }
        /// <summary>
        /// Visar hur lång tid spelet har pågått.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerTime_Tick(object sender, EventArgs e)
        {
            time++;
            lblTime.Text = $"Tid: {time}";
        }

        private void lblInstructions_Click(object sender, EventArgs e)
        {
            ShowInstructions();
        }                
    }
}
