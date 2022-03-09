namespace Snake.NET
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnToGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pricedown Bl", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(294, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Instruktioner";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Starta spelet genom att trycka på \"Starta nytt spel\".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(441, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Styr ormen med piltangenterna och få poäng genom att träffa de röda matbitarna.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Åker du in i dig själv förlorar du. ";
            // 
            // btnToGame
            // 
            this.btnToGame.Location = new System.Drawing.Point(307, 356);
            this.btnToGame.Name = "btnToGame";
            this.btnToGame.Size = new System.Drawing.Size(185, 42);
            this.btnToGame.TabIndex = 4;
            this.btnToGame.Text = "Till spelet";
            this.btnToGame.UseVisualStyleBackColor = true;
            this.btnToGame.Click += new System.EventHandler(this.btnToGame_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnToGame);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnToGame;
    }
}