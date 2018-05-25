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
      
       
        //private static GamePlay Instance;

        public Form1()
        {
            InitializeComponent();
            new GamePlay(); 
            gameTimer.Interval = 1000 / GamePlay.Instance.Speed;//1000 milisec., cadre pe secunda, label update in fiecare secunda
            gameTimer.Tick += Update;
            gameTimer.Start();
            StartGame();
        }

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

        private void MovePlayer() //should this be in the BL project not in the UI ? or maybe split in 2 and the logic part be moved there?
        {
            for (int i = GamePlay.Instance.mySnake.Count - 1; i >= 0; i--)//mutare punct cu punct
            {//cap
                if (i == 0)
                {
                    switch (GamePlay.Instance.direction)
                    {
                        case Direction.Right:
                            GamePlay.Instance.mySnake[i].x++;//punctul curent din sarpe
                            break;
                        case Direction.Left:
                            GamePlay.Instance.mySnake[i].x--;
                            break;
                        case Direction.Up:
                            GamePlay.Instance.mySnake[i].y--;
                            break;
                        case Direction.Down:
                            GamePlay.Instance.mySnake[i].y++;
                            break;

                    }

                    GamePlay.Instance.maxX = screen.Size.Width / GamePlay.Instance.Width;//pozitia max x si y
                    GamePlay.Instance.maxY = screen.Size.Height / GamePlay.Instance.Height;
                    if (GamePlay.Instance.mySnake[i].x < 0 || GamePlay.Instance.mySnake[i].y < 0
                        || GamePlay.Instance.mySnake[i].x >= GamePlay.Instance.maxX || GamePlay.Instance.mySnake[i].y >= GamePlay.Instance.maxY)
                    {//la fiecare coleziune cu peretii, die
                        GamePlay.Instance.Die();
                    }
                    for (int j = 1; j < GamePlay.Instance.mySnake.Count; j++)//coleziunea cu corpul
                    {
                        if (GamePlay.Instance.mySnake[i].x == GamePlay.Instance.mySnake[j].x &&
                             GamePlay.Instance.mySnake[i].y == GamePlay.Instance.mySnake[j].y)
                        {

                            GamePlay.Instance.Die();
                        }
                    }

                    //detecteaza coleziunea cu mancarea
                    if (GamePlay.Instance.mySnake[0].x == GamePlay.Instance.food.x && GamePlay.Instance.mySnake[0].y == GamePlay.Instance.food.y)
                    {
                        Eat();


                    }
                }
                else
                {
                    //Move body
                    GamePlay.Instance.mySnake[i].x = GamePlay.Instance.mySnake[i - 1].x;//muta urmatorul cerc conform cercului de dinainte, va apara ca sarpele se afla intr-o miscare continua
                    GamePlay.Instance.mySnake[i].y = GamePlay.Instance.mySnake[i - 1].y;
                }
            }
        }
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
                        mySnakeColour = Brushes.Green; //capul
                    else
                        mySnakeColour = Brushes.Red;//corpul
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
                string endGame = "End Game \n" + "Your final score is: " + GamePlay.Instance.Score + "\nPress Enter to try again";//???
                lblEndGame.Text = endGame;
                lblEndGame.Visible = true;
            }
        } 
        #endregion

        #region Key
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            Insert.ChangeState(e.KeyCode, true);
        }
        private void KeyIsUp(object sender, KeyEventArgs e)
        {

            Insert.ChangeState(e.KeyCode, false);
        }

       
        #endregion














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
