using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Countdown
{
    
    public partial class NumberGameForm : Form
    {
        int t = 0;
        Logger logger;
        int q = 0;
        NumbersRound NumberGame;
        bool Active = false;
        int seconds = 30;
        const int AMOUNT_OF_NUMBERS = 6;
        Label[] numberContainers = new Label[AMOUNT_OF_NUMBERS];
        public NumberGameForm()
        {
            InitializeComponent();
            InitiateLetterGame();
        }
        public void InitiateLetterGame()
        {
            //убрать старые буквы
            NumberGame = new NumbersRound();
            for (int i = 0; i < AMOUNT_OF_NUMBERS; i++)
            {
                numberContainers[i] = new Label();
                numberContainers[i].Location = new Point(12 + 60 * i, 50);
                numberContainers[i].Size = new Size(50, 50);
                numberContainers[i].BorderStyle = BorderStyle.FixedSingle;
                numberContainers[i].TextAlign = ContentAlignment.MiddleCenter;
                numberContainers[i].BackColor = Color.Blue;
                numberContainers[i].ForeColor = Color.White;
                numberContainers[i].Font = new Font(FontFamily.GenericSansSerif, 15.0f, FontStyle.Bold);
                Controls.Add(numberContainers[i]);
            }
            this.Size = new Size(36 + 60 * (AMOUNT_OF_NUMBERS), this.Size.Height);
            logger = new Logger("NUMBER");
            UpdateScores();
            logger.Add("Number game initiated.");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (Active) button4_Click(button4, e);
            count.Text = "30";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer("clock.wav");
            if (!Active)
            {
                logger.Add("Timer activated.");
                sp.Play();
                Active = true;
                timer1.Enabled = true;
                seconds--;
                count.Text = seconds.ToString();
                button4.Text = "Стоп";
            }
            else
            {
                if (!(seconds == 0))
                {
                    logger.Add("Timer stopped prematurely.");
                    sp.Stop();
                }
                else
                {
                    logger.Add("Timer stopped, 30 seconds have passed.");
                }
                Active = false;
                timer1.Enabled = false;
                button4.Text = "Старт";
                seconds = 30;
                count.Text = seconds.ToString();
            }
            if (NumberGame.IsFull())
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Interval == 1000)
            {
                if (seconds <= 0) button4_Click(button4, e);
                else
                {
                    seconds--;
                    count.Text = seconds.ToString();
                }
            }
            else
            {
                q++;
                if (q == 21)
                {
                    timer1.Interval = 1000;
                    timer1.Enabled = false;
                    q = 0;
                    if (NumberGame.IsFull()) button4_Click(button4, e);
                }
                else
                {
                    NumberGame.ChangeNumberGoal();
                    label1.Text = NumberGame.NumberGoal.ToString();
                }
            }
        }
        void NumAnimated()
        {
            timer1.Interval = 100;
            timer1.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NumAnimated();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t++;
            if (NumberGame.IsFull()) return;
            NumberGame.AddBig();
            logger.Add(NumberGame.numbers.Last<int>().ToString() + " was added on the board.");
            for (int i = 0; i < NumberGame.numbers.Count; i++)
            {
                numberContainers[i].Text = NumberGame.numbers[i].ToString();
            }
            if (NumberGame.IsFull())
            {
                button6.Enabled = true;
                button1.Enabled = false;
                button2.Enabled = false;
            }
            if (t == 4)
            {
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (NumberGame.IsFull()) return;
            logger.Add(NumberGame.numbers.Last<int>().ToString() + " was added on the board.");
            NumberGame.AddSmall();
            for (int i = 0; i < NumberGame.numbers.Count; i++)
            {
                numberContainers[i].Text = NumberGame.numbers[i].ToString();
            }
            if (NumberGame.IsFull())
            {
                button6.Enabled = true;
                button1.Enabled = false;
                button2.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < AMOUNT_OF_NUMBERS; i++)
            {
                numberContainers[i].Text = "";
            }
            logger.Add("Board cleared.");
            NumberGame.Clear();
            label1.Text = "";
            button1.Enabled = true;
            button2.Enabled = true;
            button6.Enabled = false;
            player1TextBox.Clear();
            player2TextBox.Clear();
            textBox1.Clear();
            textBox2.Clear();
            t = 0;
        }
        void UpdateScores()
        {
            player1Score.Text = Player1.Score.ToString();
            player2Score.Text = Player2.Score.ToString();
        }

        private void NumberGameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            logger.Add("Session is closed. Exporting logger now...");
            logger.ExportLog();
        }

        private void playersAnswersCheck_Click(object sender, EventArgs e)
        {
            int player1 = NumberGame.ComputeFormula(player1TextBox.Text);
            int player2 = NumberGame.ComputeFormula(player2TextBox.Text);
            int m1 = Math.Abs(NumberGame.NumberGoal - player1);
            int m2 = Math.Abs(NumberGame.NumberGoal - player2);
            textBox1.Text = player1.ToString();
            textBox2.Text = player2.ToString();
            int score1 = 0;
            if (m1 == 0) score1 = 10;
            else if (m1 > 0 && m1 <= 5) score1 = 7;
            else if (m1 > 5 && m1 <= 10) score1 = 5;
            int score2 = 0;
            if (m2 == 0) score2 = 10;
            else if (m2 > 0 && m2 <= 5) score2 = 7;
            else if (m2 > 5 && m2 <= 10) score2 = 5;
            logger.Add("Goal: " + NumberGame.NumberGoal.ToString() + ", Player 1: " + player1 + ", formula: " + player1TextBox.Text +  ", Player 2: " + player2 + ", formula: " + player2TextBox.Text + ". Player 1 might get " + score1.ToString() + " and Player 2 might get " + score2.ToString() + " points. Checking...");
            if (m1 == m2)
            {
                Player1.AddScore(score1);
                Player2.AddScore(score2);
                logger.Add("Both players get " + " points.");
            }
            else if (m1 < m2)
            {
                Player1.AddScore(score1);
                logger.Add("Player 1 gets " + score1 + " points. He was the closest to the goal.");
            }
            else
            {
                Player2.AddScore(score2);
                logger.Add("Player 2 gets " + score2 + " points. He was the closest to the goal.");
            }
            UpdateScores();
        }
    }
}
