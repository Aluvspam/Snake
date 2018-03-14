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
        private static int Score { get; set; }//cand seteaza Daniel clasa score, il sterg pe asta de aici
        public Form1()
        {
            InitializeComponent();

            Speed = 10;
            Score = 0;
            gameTimer.Interval = 1000 / Speed;//1000 milisecunde, cadre pe secunda, label update in fiecare secunda
            gameTimer.Tick += Update;// TO DO https://msdn.microsoft.com/en-us/library/dd553229.aspx
            gameTimer.Start();

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
        private void Form1_Load(object sender, EventArgs e)//plansa snake game
        {

        }

        private void ctnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void rbFullScreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCustom.Checked == true)//Checked din winF
            {
                lblHeight.Visible = true;
                lblWidth.Visible = true;
                sizeHeight.Visible = true;
                sizeWidth.Visible = true;
            }
            else
            {
                lblHeight.Visible = false;
                lblWidth.Visible = false;
                sizeHeight.Visible = false;
                sizeWidth.Visible = false;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (txtName.Text != " ")
            {
                Player.Name = txtName.Text;
                if (rbCustom.Checked == true)
                {
                    Player.Height = Convert.ToInt32(sizeHeight.Value);
                    Player.Width = Convert.ToInt32(sizeWidth.Value);
                }
                else
                {
                    Player.Height = Screen.PrimaryScreen.WorkingArea.Height;
                    Player.Width = Screen.PrimaryScreen.WorkingArea.Width;

                }

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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            InitializeBoard();
        }
        private void InitializeBoard()
        {
            for (int i = 0; i < 25; i++)
            {
                boardGame.BackgroundColor = Color.Azure;
                boardGame.DefaultCellStyle.BackColor = Color.Blue;
                //boardGame.Rows;
            }
        }
    }
}
