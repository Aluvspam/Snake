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
using Snake;

namespace Start
{
    public partial class Form1 : Form
    {
        private static int Speed { get; set; }
        public static bool GameOver { get; set; }
        private static int Score { get; set; }
        public Form1()
        {
            InitializeComponent();

            Speed = 10;
            Score = 0;
            gameTimer.Interval = 1000 / Speed;//1000 milisecunde, cadre pe secunda, label update in fiecare secunda
            gameTimer.Tick += Update;// TO DO https://msdn.microsoft.com/en-us/library/dd553229.aspx
            gameTimer.Start();
            GameOver = false;
            StartGame();

        }
        private void StartGame()
        {
            lblEndGame.Visible = false;//set to default
            //de resetat new settings
            GamePlay.Instance.snake.Add();
        }
        private void EndGame()
        {

        }

        private void Update(object sender, EventArgs e)//
        {

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            SystemSounds.Exclamation.Play();
            MessageBox.Show("Are you sure you want to quit?");
            //TO DO btnExit_Click in Exit + score> highscore, highscore = new score here
            Application.Exit();
        }
        private void ctnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (txtName.Text != " ")
            {
                Player.Name = txtName.Text;
                Player.Difficulty = Convert.ToInt32(Difficulty.Value);

            }


            else
            {
                MessageBox.Show("Please enter your name");
            }
        }
        private void lblScore_Click(object sender, EventArgs e)
        {
            lblScore.Text = Score.ToString();//set label score
            Score += Snake.Point.Points; //update score
            //Food.SetRandomFoodLocation();
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnClockwise_Click(object sender, EventArgs e)
        {
            GamePlay.Instance.Turn(Snake.Enums.Turns.ClockWise);
        }
        private void btnAnticlockwise_Click(object sender, EventArgs e)
        {
            GamePlay.Instance.Turn(Snake.Enums.Turns.AntiClockWise);
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)//plansa snake game
        {
            InitializeBoard();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void InitializeBoard()
        {
            boardGame.DefaultCellStyle.BackColor = Color.DarkSlateBlue;
            for (int i = 0; i < 68; i++)
            {
                boardGame.Rows.Add();
            }
            foreach (DataGridViewColumn c in boardGame.Columns)//latime coloane
            {
                c.Width = boardGame.Width / boardGame.Columns.Count;
            }
            foreach (DataGridViewRow r in boardGame.Rows)//latime randuri
            {
                r.Height = boardGame.Height / boardGame.Rows.Count;
            }

            for (int row = 0; row < boardGame.Rows.Count; row++)//toate celulele read only
            {
                for (int col = 0; col < boardGame.Columns.Count; col++)
                {
                    boardGame[col, row].ReadOnly = true;
                }
            }
        }
    }
}
