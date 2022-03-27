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
using System.IO;

namespace Countdown
{
    public partial class LetterGameForm : Form
    {
        Logger logger;
        LettersRound LetterGame;
        bool Active = false;
        int seconds = 30;
        const int AMOUNT_OF_LETTERS = 9;
        const string DICTIONARY_FILE = "dictionary.txt";
        Label[] letterContainers = new Label[AMOUNT_OF_LETTERS];
        public LetterGameForm()
        {
            InitializeComponent();
            InitiateLetterGame();
        }
        public void InitiateLetterGame()
        {
            logger = new Logger("LETTER");
            //убрать старые буквы
            LetterGame = new LettersRound();
            for (int i = 0; i < AMOUNT_OF_LETTERS; i++)
            {
                letterContainers[i] = new Label();
                letterContainers[i].Location = new Point(12+60*i,50);
                letterContainers[i].Size = new Size(50, 50);
                letterContainers[i].BorderStyle = BorderStyle.FixedSingle;
                letterContainers[i].TextAlign = ContentAlignment.MiddleCenter;
                letterContainers[i].BackColor = Color.Blue;
                letterContainers[i].ForeColor = Color.White;
                letterContainers[i].Font = new Font(FontFamily.GenericSansSerif, 25.0f, FontStyle.Bold);
                Controls.Add(letterContainers[i]);
            }
            this.Size = new Size(36 + 60 * AMOUNT_OF_LETTERS,this.Size.Height);
            logger.Add("Letter Game initiated.");
            UpdateScores();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (seconds <= 0) button4_Click(button4, e);
            else
            {
                seconds--;
                count.Text = seconds.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer("clock.wav");
            if (!Active)
            {
                sp.Play();
                Active = true;
                timer1.Enabled = true;
                seconds--;
                count.Text = seconds.ToString();
                button4.Text = "Стоп";
                logger.Add("Timer activated.");
            }
            else
            {
                if (!(seconds == 0))
                {
                    sp.Stop();
                    logger.Add("Timer stopped at " + seconds.ToString() + " seconds. It could be an error.");
                }
                else logger.Add("30 seconds passed, timer stopped.");
                Active = false;
                timer1.Enabled = false;
                button4.Text = "Старт";
                seconds = 30;
                count.Text = seconds.ToString();
            }
            if (LetterGame.IsFull())
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }
        }
        void updateLetters()
        {
            for (int i = 0; i < LetterGame.letters.Length; i++)
            {
                letterContainers[i].Text = LetterGame.letters[i].ToString();
            }
        }
        void clearLetters()
        {
            for (int i = 0; i < AMOUNT_OF_LETTERS; i++)
            {
                letterContainers[i].Text = "";
            }
        }
        private void button1_Click(object sender, EventArgs e) //consonant
        {
            LetterGame.AddConsonant();
            updateLetters();
            logger.Add("Consonant " + LetterGame.letters[LetterGame.letters.Length - 1] + " added.");
            if (LetterGame.letters.Length == AMOUNT_OF_LETTERS)
            {
                logger.Add("Board is full. Initiating start of the timer...");
                button4_Click(button4, e);
            }
        }

        private void button2_Click(object sender, EventArgs e) //vowel
        {
            LetterGame.AddVowel();
            updateLetters();
            logger.Add("Vowel " + LetterGame.letters[LetterGame.letters.Length - 1] + " added.");
            if (LetterGame.letters.Length == AMOUNT_OF_LETTERS)
            {
                logger.Add("Board is full. Initiating start of the timer...");
                button4_Click(button4, e);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            logger.Add("Board cleared.");
            LetterGame.Clear();
            clearLetters();
            button1.Enabled = true;
            button2.Enabled = true;
            player1TextBox.Clear();
            player2TextBox.Clear();
            richTextBox1.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            logger.Add("Opening NUMBER game. For logs, seek NUMBER<time>.txt");
            NumberGameForm ngf = new NumberGameForm();
            ngf.ShowDialog();
            UpdateScores();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Active) button4_Click(button4, e);
            count.Text = "30";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            logger.Add("Initiating word finder...");
            StreamReader sr = new StreamReader(DICTIONARY_FILE,Encoding.UTF8);
            richTextBox1.Text = LetterGame.FindWords(sr);
        }

        private void LetterGameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            logger.Add("Session is closed. Exporting logger now...");
            logger.ExportLog();
        }

        private void LetterGameForm_Load(object sender, EventArgs e)
        {

        }

        void UpdateScores()
        {
            player1Score.Text = Player1.Score.ToString();
            player2Score.Text = Player2.Score.ToString();
        }
        private void playersAnswersCheck_Click(object sender, EventArgs e)
        {
            button6_Click(button6, e);
            string player1 = player1TextBox.Text.ToUpper();
            string player2 = player2TextBox.Text.ToUpper();
            int score1 = player1TextBox.Text.Length;
            int score2 = player2TextBox.Text.Length;
            bool check1 = LetterGame.CheckDictionary(player1);
            bool check2 = LetterGame.CheckDictionary(player2);
            if (score1 == 9) score1 *= 2;
            if (score2 == 9) score2 *= 2;
            logger.Add("Player 1: " + player1 + ", Player 2: " + player2 + ". Player 1 might get " + score1.ToString() + " and Player 2 might get " + score2.ToString() + " points. Checking dictionary...");
            if (check1 && check2)
            {
                if (score1 == score2)
                {
                    logger.Add("Both players get " + score1 + " points. They got it right.");
                    Player1.AddScore(score1);
                    Player2.AddScore(score2);
                }
                else if (score1 > score2)
                {
                    logger.Add("Player 1 gets " + score1 + " points. He came up with the longest word.");
                    Player1.AddScore(score1);
                }    
                else
                {
                    logger.Add("Player 2 gets " + score2 + " points. He came up with the longest word.");
                    Player2.AddScore(score2);
                }
            }
            else if (check1 || check2)
            {
                if (check1)
                {
                    logger.Add("Player 1 gets " + score1 + " points. Only he came up with the word.");
                    Player1.AddScore(score1);
                }
                else
                {
                    logger.Add("Player 2 gets " + score2 + " points. Only he came up with the word.");
                    Player2.AddScore(score2);
                }
            }
            else logger.Add("Both players failed. No one gets any points.");
            UpdateScores();
        }
    }
}
