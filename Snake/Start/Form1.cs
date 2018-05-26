using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using Snake;
using Snake.Enums;
namespace Start
{
    public partial class Form1 : Form
    {
       

        #region Initialize
        public Form1()
        {
            InitializeComponent();
            new GamePlay();
            gameTimer.Interval = 1000 / GamePlay.Instance.Speed;//1000 milisec., cadre pe secunda, label update in fiecare secunda
            gameTimer.Tick += Update;
            gameTimer.Start();
            StartGame();
        } 
        #endregion

        #region Start
        private void StartGame()
        {
            lblEndGame.Visible = false;
            GamePlay.Instance.mySnake.Clear();
            Snake.Point head = new Snake.Point { x = 10, y = 5 };
            GamePlay.Instance.mySnake.Add(head);
            lblScore.Text = GamePlay.Instance.Score.ToString();
            PlaceFood();
        }
        #endregion

        #region PlaceFood
        private void PlaceFood()
        {

            GamePlay.Instance.maxX = screen.Size.Width / GamePlay.Instance.Width;//max x rezultat al imp dintre lat tablei si set
            GamePlay.Instance.maxY = screen.Size.Height / GamePlay.Instance.Height;
            Food.PlaceFoodLogic();

        } 
        #endregion

        #region Eat
        private void Eat()
        {

            Food.EatLogic();
            PlaceFood();
            lblScore.Text = GamePlay.Instance.Score.ToString();
        } 
        #endregion

        #region Update
        private void Update(object sender, EventArgs e)
        {
            if (GamePlay.Instance.EndGame)
            {

                if (Insert.KeyPressed(Keys.Enter))
                {
                    StartGame();
                }

            }
            else
            {

                if (Insert.KeyPressed(Keys.Right) && GamePlay.Instance.direction != Direction.Left)
                    GamePlay.Instance.direction = Direction.Right;
                else if (Insert.KeyPressed(Keys.Left) && GamePlay.Instance.direction != Direction.Right)
                    GamePlay.Instance.direction = Direction.Left;
                else if (Insert.KeyPressed(Keys.Up) && GamePlay.Instance.direction != Direction.Down)
                    GamePlay.Instance.direction = Direction.Up;
                else if (Insert.KeyPressed(Keys.Down) && GamePlay.Instance.direction != Direction.Up)
                    GamePlay.Instance.direction = Direction.Down;

                MovePlayer();
            }
            screen.Invalidate();//refresh
        }
        #endregion

        #region MovePlayer
        private void MovePlayer()
        {
            SnakeGame.MoveBodyLogic();

            //limitez sarpele la screen, spatiul de joc
            GamePlay.Instance.maxX = screen.Size.Width / GamePlay.Instance.Width;//pozitia max x si y
            GamePlay.Instance.maxY = screen.Size.Height / GamePlay.Instance.Height;
        } 
        #endregion

        #region Paint
        private void screen_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            if (!GamePlay.Instance.EndGame)
            {

                for (int i = 0; i < GamePlay.Instance.mySnake.Count; i++) //move 
                {
                    Brush mySnakeColour;
                    if (i == 0)
                    {
                        mySnakeColour = Brushes.Green; //capul
                    }
                        
                    else
                    {
                        mySnakeColour = Brushes.Red;//corpul
                    }
                    canvas.FillEllipse(mySnakeColour, //sarpele
                        new Rectangle(GamePlay.Instance.mySnake[i].x * GamePlay.Instance.Width,
                                       GamePlay.Instance.mySnake[i].y * GamePlay.Instance.Height,
                                       GamePlay.Instance.Width, GamePlay.Instance.Height));

                    canvas.FillEllipse(Brushes.Yellow,     //mancarea
                        new Rectangle(GamePlay.Instance.food.x * GamePlay.Instance.Width,
                              GamePlay.Instance.food.y * GamePlay.Instance.Height, GamePlay.Instance.Width, GamePlay.Instance.Height));
                }
            }
            else
            {
                string endGame = "End Game \n" + "Your final score is: " + GamePlay.Instance.Score + "\nPress Enter to try again";//nu merge enter
                lblEndGame.Text = endGame;
                lblEndGame.Visible = true;
            }
        } 
        #endregion

        #region Key
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Insert.ChangeState(e.KeyCode, true);
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            Insert.ChangeState(e.KeyCode, false);
        }

       
        #endregion













        //TO DO 
        //enter ? score? btn play?
        //private void btnClockwise_Click(object sender, EventArgs e)
        //{
        //   // GamePlay.Instance.Turn(Turns.ClockWise);
        //}
        //private void btnAnticlockwise_Click(object sender, EventArgs e)
        //{
        //   // GamePlay.Instance.Turn(Turns.AntiClockWise);
        //}
        //private void btnPlay_Click(object sender, EventArgs e)
        //{
        //    if (txtName.Text != " ")
        //    {
        //        GamePlay.PlayerName = txtName.Text;

        //        GamePlay.Difficulty = Convert.ToInt32(Difficulty.Value);
        //        //de setat butonul btnClockwise_Click or anti
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please enter your name");
        //    }
        //    StartGame();
        //}


        //private void ctnRestart_Click(object sender, EventArgs e)
        //{
        //    Application.Restart();
        //}


        //private void lblScore_Click(object sender, EventArgs e)
        //{
        //    lblScore.Text = GamePlay.Score.ToString();//set label score
        //    GamePlay.Score += GamePlay.Points; //update score
        //}





        //private void txtName_TextChanged(object sender, EventArgs e)
        //{

        //}



        //private void btnExit_Click(object sender, EventArgs e)
        //{
        //    SystemSounds.Exclamation.Play();
        //    MessageBox.Show("Are you sure you want to quit?");

        //    Application.Exit();
        //}
    }



}
