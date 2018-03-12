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

namespace Start
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            SystemSounds.Exclamation.Play();
            MessageBox.Show("Are you sure you want to quit?");
            Application.Exit();
          
        }
       
        private void Form1_Load(object sender, EventArgs e)
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

            //if (txtName.Text != " ")
            //{
            //    Snake.Player.PlayerName == txtName.Text;

            //}
            //else
            //{
            //    MessageBox.Show("Please enter your name");
            //}
        }

        private void Canvas_Click(object sender, EventArgs e)
        {
           
        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }
    }
}
