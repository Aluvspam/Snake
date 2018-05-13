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
        private List<Snake.Point> mySnake = new List<Snake.Point>();
        private Snake.Point food = new Snake.Point();
        //private static GamePlay Instance;
     
        public Form1()
        {
           InitializeComponent();
            new GamePlay();
            gameTimer.Interval = 1000 / GamePlay.Speed;//1000 milisecunde, cadre pe secunda, label update in fiecare secunda
            gameTimer.Tick += Update;// TO DO https://msdn.microsoft.com/en-us/library/dd553229.aspx
            gameTimer.Start();
            StartGame();
        }
     
        private void StartGame()
        {
            lblEndGame.Visible = false;//reseteaza la default
            new GamePlay();
            mySnake.Clear();
            Snake.Point head = new Snake.Point { x = 10, y = 5 };
            mySnake.Add(head);
            lblScore.Text = GamePlay.Score.ToString();
            PlaceFood();
        }
        private void PlaceFood()
        {
            int maxX = screen.Size.Width / GamePlay.Width;//max x rezultat al imp dintre lat tablei si set
            int maxY = screen.Size.Height / GamePlay.Height;
            Random random = new Random();
            food = new Snake.Point { x = random.Next(0, maxX), y = random.Next(0, maxY) };

         }
        private void Update(object sender, EventArgs e)//
        {
            if (GamePlay.EndGame)
            {

                //if (btnPlay_Click == true)
                if (KeysInput.KeyPressed(Keys.Enter))
                {
                    StartGame();
                }

            }
            else
            {

                if (KeysInput.KeyPressed(Keys.Right) && GamePlay.direction != Direction.Left)
                    GamePlay.direction = Direction.Right;
                else if (KeysInput.KeyPressed(Keys.Left) && GamePlay.direction != Direction.Right)
                    GamePlay.direction = Direction.Left;
                else if (KeysInput.KeyPressed(Keys.Up) && GamePlay.direction != Direction.Down)
                    GamePlay.direction = Direction.Up;
                else if (KeysInput.KeyPressed(Keys.Down) && GamePlay.direction != Direction.Up)
                    GamePlay.direction = Direction.Down;

                MovePlayer();
            }


            screen.Invalidate();//refresh
        }

        private void screen_Paint(object sender, PaintEventArgs e)
        {
           Graphics canvas = e.Graphics;//???
            if (!GamePlay.EndGame)
            {
                for (int i = 0; i < mySnake.Count; i++) //move
                {
                    Brush mySnakeColour;
                    if (i == 0)
                        mySnakeColour = Brushes.Green; //capul
                    else
                        mySnakeColour = Brushes.Red;//corpul
                    canvas.FillEllipse(mySnakeColour, //sarpele
                        new Rectangle(mySnake[i].x * GamePlay.Width,
                                       mySnake[i].y * GamePlay.Height,
                                      GamePlay.Width, GamePlay.Height));

                    canvas.FillEllipse(Brushes.Yellow,     //mancarea
                        new Rectangle(food.x * GamePlay.Width,
                             food.y * GamePlay.Height, GamePlay.Width, GamePlay.Height));
                }
            }
            else
            {
                string endGame = "End Game \nYour final score is: " + GamePlay.Score + "\nPress Enter to try again";//???
                lblEndGame.Text = endGame;
                lblEndGame.Visible = true;
            }
        }
        
        private void MovePlayer()
        {
            for (int i = mySnake.Count - 1; i >= 0; i--)//mutare punct cu punct
            {//cap
                if (i == 0)
                {
                    switch (GamePlay.direction)
                    {
                        case Direction.Right:
                            mySnake[i].x++;//punctul curent din sarpe
                            break;
                        case Direction.Left:
                            mySnake[i].x--;
                            break;
                        case Direction.Up:
                            mySnake[i].y--;
                            break;
                        case Direction.Down:
                            mySnake[i].y++;
                            break;

                    }
                    int maxX = screen.Size.Width / GamePlay.Width;//pozitia max x si y
                    int maxY = screen.Size.Height / GamePlay.Height;
                    if (mySnake[i].x < 0 || mySnake[i].y < 0
                        || mySnake[i].x >= maxX || mySnake[i].y >= maxY)
                    {//la fiecare coleziune cu peretii, die
                        Die();
                    }
                    for (int j = 1; j < mySnake.Count; j++)//coleziunea cu corpul
                    {
                        if (mySnake[i].x == mySnake[j].x &&
                             mySnake[i].y == mySnake[j].y)
                        {
                            Die();
                        }
                    }

                    //Detect collision with food piece
                    if (mySnake[0].x == food.x && mySnake[0].y == food.y)
                    {
                        Eat();
                    }
                }
                else
                {
                    //Move body
                    mySnake[i].x = mySnake[i - 1].x;//muta urmatorul cerc conform cercului de dinainte, va apara ca sarpele se afla intr-o miscare continua
                    mySnake[i].y = mySnake[i - 1].y;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            KeysInput.ChangeState(e.KeyCode, true);//lasa aplicatie sa stie ca butonul a fost apasat down
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            KeysInput.ChangeState(e.KeyCode, false);
        }

       

        private void Eat()
        {
            Snake.Point circle = new Snake.Point//cresc sarpele
            {
                x = mySnake[mySnake.Count - 1].x,

                y = mySnake[mySnake.Count - 1].y
            };
            mySnake.Add(circle);

            GamePlay.Score += GamePlay.Points;
            lblScore.Text = GamePlay.Score.ToString();
            PlaceFood();

        }
        private void btnClockwise_Click(object sender, EventArgs e)
        {
           // GamePlay.Instance.Turn(Turns.ClockWise);
        }
        private void btnAnticlockwise_Click(object sender, EventArgs e)
        {
           // GamePlay.Instance.Turn(Turns.AntiClockWise);
        }
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

       
        private void lblScore_Click(object sender, EventArgs e)
        {
            lblScore.Text = GamePlay.Score.ToString();//set label score
            GamePlay.Score += GamePlay.Points; //update score
        }
        
        private void Die()
        {
            GamePlay.EndGame = true;
        }
            


        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {

        }
    }



}
