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

        private Snake.Point food = new Snake.Point();
        //private static GamePlay Instance;

        #region InitializeComponent
        public Form1()
        {
            InitializeComponent();
            new GamePlay();
            gameTimer.Interval = 1000 / Snake.GamePlay.Speed;//1000 milisecunde, cadre pe secunda, label update in fiecare secunda
            gameTimer.Tick += Update;// TO DO https://msdn.microsoft.com/en-us/library/dd553229.aspx
            gameTimer.Start();
            StartGame();
        }
        #endregion

        #region StartGame
        private void StartGame()
        {
            lblEndGame.Visible = false;//reseteaza la default
            new GamePlay();
            GamePlay.Instance.mySnake.Clear();
            Snake.Point head = new Snake.Point { x = 10, y = 5 };
            GamePlay.Instance.mySnake.Add(head);
            lblScore.Text = Snake.GamePlay.Score.ToString();
            PlaceFood();
        }
        #endregion

        #region PlaceFood
        private void PlaceFood()
        {
            int maxX = boardGame.Size.Width / GamePlay.Width;//max x rezultat al imp dintre lat tablei si set
            int maxY = boardGame.Size.Height / GamePlay.Height;
            Random random = new Random();
            food = new Snake.Point { x = random.Next(0, maxX), y = random.Next(0, maxY) };

        }
        #endregion

        #region Update
        private void Update(object sender, EventArgs e)//
        {
            if (GamePlay.EndGame)
            {

                //if (btnPlay_Click == true)


                StartGame();


            }
            else
            {
                // de implementat directiile
                MovePlayer();
            }

            boardGame.Invalidate();//refresh
        }


        #endregion
        private void MovePlayer()
        {
            throw new NotImplementedException();
        }

        #region btnClockwise/Anticlockwise
        private void btnClockwise_Click(object sender, EventArgs e)
        {
            GamePlay.Instance.Turn(Snake.Enums.Turns.ClockWise);
        }
        private void btnAnticlockwise_Click(object sender, EventArgs e)
        {
            GamePlay.Instance.Turn(Snake.Enums.Turns.AntiClockWise);
        }
        #endregion

        #region btnPlay
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (txtName.Text != " ")
            {
                GamePlay.PlayerName = txtName.Text;

                GamePlay.Difficulty = Convert.ToInt32(Difficulty.Value);
                //de setat butonul btnClockwise_Click or anti
            }
            else
            {
                MessageBox.Show("Please enter your name");
            }
            StartGame();
        }
        #endregion

        #region  InitializeBoard
        private void Form1_Load(object sender, EventArgs e)//plansa snake game
        {
            InitializeBoard();
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
        #endregion

        #region BoardGame_Paint
        private void boardGame_Paint(object sender, PaintEventArgs e)
        {
            Graphics boardGame = e.Graphics;
            if (!GamePlay.EndGame)
            {
                for (int i = 0; i < GamePlay.Instance.mySnake.Count; i++) //move
                {
                    Brush mySnakeColour;
                    if (i == 0)
                        mySnakeColour = Brushes.White; //capul
                    else
                        mySnakeColour = Brushes.Red;//corpul
                    boardGame.FillEllipse(mySnakeColour, //sarpele
                        new Rectangle(GamePlay.Instance.mySnake[i].x * GamePlay.Width,
                                       GamePlay.Instance.mySnake[i].y * GamePlay.Height,
                                      GamePlay.Width, GamePlay.Height));

                    boardGame.FillEllipse(Brushes.Yellow,     //mancarea
                        new Rectangle(food.x * GamePlay.Width,
                             food.y * GamePlay.Height, GamePlay.Width, GamePlay.Height));
                }
            }
            else
            {
                string EndGame = "End Game \nYour final score is: " + GamePlay.Score + "\nPress Enter to try again";//???
                lblEndGame.Text = EndGame;
                lblEndGame.Visible = true;
            }

        }
        #endregion

        #region Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            SystemSounds.Exclamation.Play();
            MessageBox.Show("Are you sure you want to quit?");
            Application.Exit();
        }
        #endregion

        #region Restart
        private void ctnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        #endregion

        #region lblScore
        private void lblScore_Click(object sender, EventArgs e)
        {
            lblScore.Text = GamePlay.Score.ToString();//set label score
            Snake.GamePlay.Score += Snake.GamePlay.Points;

        }
        #endregion

        #region Eat
        private void Eat()
        {
            Snake.Point circle = new Snake.Point//cresc sarpele
            {
                x = GamePlay.Instance.mySnake[GamePlay.Instance.mySnake.Count - 1].x,

                y = GamePlay.Instance.mySnake[GamePlay.Instance.mySnake.Count - 1].y
            };
            GamePlay.Instance.mySnake.Add(circle);

            GamePlay.Score += GamePlay.Points;
            lblScore.Text = GamePlay.Score.ToString();
            PlaceFood();

        }
        #endregion

        #region Die
        private void Die()
        {

            Snake.GamePlay.EndGame = true;
        }
        #endregion

        #region gameTimer_Tick
        private void gameTimer_Tick(object sender, EventArgs e)
        {

        }
        #endregion

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




    }





}