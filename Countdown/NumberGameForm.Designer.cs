
namespace Countdown
{
    partial class NumberGameForm
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
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.count = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.playersAnswersCheck = new System.Windows.Forms.Button();
            this.player2Score = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.player2TextBox = new System.Windows.Forms.TextBox();
            this.player2Label = new System.Windows.Forms.Label();
            this.player1Score = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.player1TextBox = new System.Windows.Forms.TextBox();
            this.player1Label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(13, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Добавить малое число";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(13, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Добавить большое число";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(558, 328);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Старт";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(558, 357);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Сброс";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // count
            // 
            this.count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.count.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count.Location = new System.Drawing.Point(558, 389);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(85, 46);
            this.count.TabIndex = 14;
            this.count.Text = "30";
            this.count.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(177, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 54);
            this.label1.TabIndex = 17;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(206, 412);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(191, 23);
            this.button6.TabIndex = 18;
            this.button6.Text = "Задать новое число";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(25, 134);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(121, 23);
            this.button7.TabIndex = 19;
            this.button7.Text = "Очистить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // playersAnswersCheck
            // 
            this.playersAnswersCheck.Location = new System.Drawing.Point(25, 308);
            this.playersAnswersCheck.Name = "playersAnswersCheck";
            this.playersAnswersCheck.Size = new System.Drawing.Size(251, 23);
            this.playersAnswersCheck.TabIndex = 42;
            this.playersAnswersCheck.Text = "Проверить";
            this.playersAnswersCheck.UseVisualStyleBackColor = true;
            this.playersAnswersCheck.Click += new System.EventHandler(this.playersAnswersCheck_Click);
            // 
            // player2Score
            // 
            this.player2Score.AutoSize = true;
            this.player2Score.BackColor = System.Drawing.SystemColors.HotTrack;
            this.player2Score.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player2Score.ForeColor = System.Drawing.Color.White;
            this.player2Score.Location = new System.Drawing.Point(137, 247);
            this.player2Score.Name = "player2Score";
            this.player2Score.Size = new System.Drawing.Size(18, 19);
            this.player2Score.TabIndex = 41;
            this.player2Score.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Cчёт:";
            // 
            // player2TextBox
            // 
            this.player2TextBox.Location = new System.Drawing.Point(25, 267);
            this.player2TextBox.Name = "player2TextBox";
            this.player2TextBox.Size = new System.Drawing.Size(251, 22);
            this.player2TextBox.TabIndex = 39;
            // 
            // player2Label
            // 
            this.player2Label.AutoSize = true;
            this.player2Label.Location = new System.Drawing.Point(22, 247);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(58, 17);
            this.player2Label.TabIndex = 38;
            this.player2Label.Text = "Игрок 2";
            // 
            // player1Score
            // 
            this.player1Score.AutoSize = true;
            this.player1Score.BackColor = System.Drawing.SystemColors.HotTrack;
            this.player1Score.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player1Score.ForeColor = System.Drawing.Color.White;
            this.player1Score.Location = new System.Drawing.Point(137, 190);
            this.player1Score.Name = "player1Score";
            this.player1Score.Size = new System.Drawing.Size(18, 19);
            this.player1Score.TabIndex = 37;
            this.player1Score.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Cчёт:";
            // 
            // player1TextBox
            // 
            this.player1TextBox.Location = new System.Drawing.Point(25, 210);
            this.player1TextBox.Name = "player1TextBox";
            this.player1TextBox.Size = new System.Drawing.Size(251, 22);
            this.player1TextBox.TabIndex = 35;
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.player1Label.Location = new System.Drawing.Point(22, 190);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(58, 17);
            this.player1Label.TabIndex = 34;
            this.player1Label.Text = "Игрок 1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(282, 210);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(66, 22);
            this.textBox1.TabIndex = 43;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(282, 267);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(66, 22);
            this.textBox2.TabIndex = 44;
            // 
            // NumberGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.playersAnswersCheck);
            this.Controls.Add(this.player2Score);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.player2TextBox);
            this.Controls.Add(this.player2Label);
            this.Controls.Add(this.player1Score);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.player1TextBox);
            this.Controls.Add(this.player1Label);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.count);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "NumberGameForm";
            this.Text = "Игра чисел";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NumberGameForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button playersAnswersCheck;
        private System.Windows.Forms.Label player2Score;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox player2TextBox;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.Label player1Score;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox player1TextBox;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}