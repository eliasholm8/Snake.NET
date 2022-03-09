namespace Snake.NET
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPauseScreen = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.lblStartGame = new System.Windows.Forms.Label();
            this.lblPause = new System.Windows.Forms.Label();
            this.blinkTimer = new System.Windows.Forms.Timer(this.components);
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.lblPauseScreen);
            this.panel1.Controls.Add(this.lblGameOver);
            this.panel1.Location = new System.Drawing.Point(39, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 360);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblPauseScreen
            // 
            this.lblPauseScreen.AutoSize = true;
            this.lblPauseScreen.Font = new System.Drawing.Font("Pricedown Bl", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPauseScreen.Location = new System.Drawing.Point(195, 163);
            this.lblPauseScreen.Name = "lblPauseScreen";
            this.lblPauseScreen.Size = new System.Drawing.Size(217, 32);
            this.lblPauseScreen.TabIndex = 5;
            this.lblPauseScreen.Text = "Spelet är pausat";
            this.lblPauseScreen.Visible = false;
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Pricedown Bl", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGameOver.Location = new System.Drawing.Point(132, 114);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(0, 40);
            this.lblGameOver.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Pricedown Bl", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScore.Location = new System.Drawing.Point(671, 193);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(83, 24);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "lblScore";
            // 
            // lblStartGame
            // 
            this.lblStartGame.AutoSize = true;
            this.lblStartGame.BackColor = System.Drawing.Color.LimeGreen;
            this.lblStartGame.Font = new System.Drawing.Font("Pricedown Bl", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStartGame.Location = new System.Drawing.Point(673, 60);
            this.lblStartGame.Name = "lblStartGame";
            this.lblStartGame.Size = new System.Drawing.Size(160, 24);
            this.lblStartGame.TabIndex = 2;
            this.lblStartGame.Text = "Starta nytt spel";
            this.lblStartGame.Click += new System.EventHandler(this.lblStartGame_Click);
            // 
            // lblPause
            // 
            this.lblPause.AutoSize = true;
            this.lblPause.BackColor = System.Drawing.Color.Khaki;
            this.lblPause.Font = new System.Drawing.Font("Pricedown Bl", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPause.Location = new System.Drawing.Point(673, 128);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(60, 24);
            this.lblPause.TabIndex = 3;
            this.lblPause.Text = "Pausa";
            this.lblPause.Click += new System.EventHandler(this.lblPause_Click);
            // 
            // blinkTimer
            // 
            this.blinkTimer.Interval = 50;
            this.blinkTimer.Tick += new System.EventHandler(this.blinkTimer_Tick);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Pricedown Bl", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLevel.Location = new System.Drawing.Point(673, 259);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(70, 24);
            this.lblLevel.TabIndex = 4;
            this.lblLevel.Text = "Level: 1";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Pricedown Bl", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTime.Location = new System.Drawing.Point(670, 311);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 24);
            this.lblTime.TabIndex = 5;
            // 
            // timerTime
            // 
            this.timerTime.Interval = 1000;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblInstructions.Font = new System.Drawing.Font("Pricedown Bl", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInstructions.Location = new System.Drawing.Point(670, 416);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(145, 25);
            this.lblInstructions.TabIndex = 6;
            this.lblInstructions.Text = "instruktioner";
            this.lblInstructions.Click += new System.EventHandler(this.lblInstructions_Click);
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.Font = new System.Drawing.Font("Pricedown Bl", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHighScore.Location = new System.Drawing.Point(670, 311);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(98, 24);
            this.lblHighScore.TabIndex = 7;
            this.lblHighScore.Text = "highscore";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(857, 450);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblPause);
            this.Controls.Add(this.lblStartGame);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblStartGame;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblPause;
        private System.Windows.Forms.Timer blinkTimer;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblPauseScreen;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblHighScore;
    }
}
