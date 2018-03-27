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
        private List<Snake.Point> mySnake = new List<Snake.Point>();
        private Snake.Point food = new Snake.Point();
        private static GamePlay Instance;
        public Form1()
        {
            InitializeComponent();
            new Settings();
            gameTimer.Interval = 1000 / Settings.Speed;//1000 milisecunde, cadre pe secunda, label update in fiecare secunda
            gameTimer.Tick += Update;// TO DO https://msdn.microsoft.com/en-us/library/dd553229.aspx
            gameTimer.Start();
            StartGame();
        }
        private void StartGame()
        {
            lblEndGame.Visible = false;//reseteaza la default
            new Settings();
            mySnake.Clear();
            Snake.Point head = new Snake.Point { x = 10, y = 5 };
            mySnake.Add(head);
            lblScore.Text = Settings.Score.ToString();
            PlaceFood();
        }
        private void PlaceFood()
        {
            int maxX = boardGame.Size.Width / Settings.Width;
            int maxY = boardGame.Size.Height / Settings.Height;
            Random random = new Random();
            food = new Snake.Point { x = random.Next(0, maxX), y = random.Next(0, maxY) };

         }
        private void Update(object sender, EventArgs e)//
        {
            if (Settings.EndGame)
            {
               // if (btnPlay.MouseClick())//????
                {
                    StartGame();
                }
             
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            SystemSounds.Exclamation.Play();
            MessageBox.Show("Are you sure you want to quit?");
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
                Settings.PlayerName = txtName.Text;

                Settings.Difficulty = Convert.ToInt32(Difficulty.Value);
                //de setat butonul btnClockwise_Click or anti
            }
            else
            {
                MessageBox.Show("Please enter your name");
            }
        }
        private void lblScore_Click(object sender, EventArgs e)
        {
            lblScore.Text = Settings.Score.ToString();//set label score
            Settings.Score += Settings.Points; //update score
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

        private void Die()
        {
            Settings.EndGame = true;
        }
    }



}
