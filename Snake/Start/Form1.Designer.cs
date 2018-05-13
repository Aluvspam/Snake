namespace Start
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.Difficulty = new System.Windows.Forms.NumericUpDown();
            this.btnExit = new System.Windows.Forms.Button();
            this.ctnRestart = new System.Windows.Forms.Button();
            this.lblOptions = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnClockwise = new System.Windows.Forms.Button();
            this.btnAnticlockwise = new System.Windows.Forms.Button();
            this.lblEndGame = new System.Windows.Forms.Label();
            this.screen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Difficulty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.screen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Maroon;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPlay.Location = new System.Drawing.Point(651, 377);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(112, 40);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Maroon;
            this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblName.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblName.Location = new System.Drawing.Point(553, 90);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(89, 29);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Maroon;
            this.txtName.Location = new System.Drawing.Point(651, 90);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 34);
            this.txtName.TabIndex = 5;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficulty.ForeColor = System.Drawing.Color.Maroon;
            this.lblDifficulty.Location = new System.Drawing.Point(669, 178);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(85, 23);
            this.lblDifficulty.TabIndex = 6;
            this.lblDifficulty.Text = "Difficulty";
            this.lblDifficulty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Difficulty
            // 
            this.Difficulty.BackColor = System.Drawing.Color.NavajoWhite;
            this.Difficulty.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Difficulty.ForeColor = System.Drawing.Color.Maroon;
            this.Difficulty.Location = new System.Drawing.Point(784, 172);
            this.Difficulty.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Difficulty.Name = "Difficulty";
            this.Difficulty.Size = new System.Drawing.Size(49, 30);
            this.Difficulty.TabIndex = 7;
            this.Difficulty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Difficulty.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Maroon;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Location = new System.Drawing.Point(750, 442);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 40);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ctnRestart
            // 
            this.ctnRestart.BackColor = System.Drawing.Color.Maroon;
            this.ctnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ctnRestart.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctnRestart.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ctnRestart.Location = new System.Drawing.Point(558, 442);
            this.ctnRestart.Name = "ctnRestart";
            this.ctnRestart.Size = new System.Drawing.Size(112, 40);
            this.ctnRestart.TabIndex = 12;
            this.ctnRestart.Text = "Restart";
            this.ctnRestart.UseVisualStyleBackColor = false;
            this.ctnRestart.Click += new System.EventHandler(this.ctnRestart_Click);
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.BackColor = System.Drawing.Color.Maroon;
            this.lblOptions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblOptions.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptions.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblOptions.Location = new System.Drawing.Point(553, 169);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(89, 29);
            this.lblOptions.TabIndex = 13;
            this.lblOptions.Text = "Options";
            this.lblOptions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(553, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Score";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(670, 24);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 13);
            this.lblScore.TabIndex = 20;
            this.lblScore.Click += new System.EventHandler(this.lblScore_Click);
            // 
            // btnClockwise
            // 
            this.btnClockwise.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnClockwise.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClockwise.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClockwise.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClockwise.Location = new System.Drawing.Point(651, 237);
            this.btnClockwise.Name = "btnClockwise";
            this.btnClockwise.Size = new System.Drawing.Size(129, 40);
            this.btnClockwise.TabIndex = 21;
            this.btnClockwise.Text = "Clockwise";
            this.btnClockwise.UseVisualStyleBackColor = false;
            this.btnClockwise.Click += new System.EventHandler(this.btnClockwise_Click);
            // 
            // btnAnticlockwise
            // 
            this.btnAnticlockwise.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAnticlockwise.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnticlockwise.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnticlockwise.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAnticlockwise.Location = new System.Drawing.Point(651, 283);
            this.btnAnticlockwise.Name = "btnAnticlockwise";
            this.btnAnticlockwise.Size = new System.Drawing.Size(129, 36);
            this.btnAnticlockwise.TabIndex = 22;
            this.btnAnticlockwise.Text = "Anticlockwise";
            this.btnAnticlockwise.UseVisualStyleBackColor = false;
            this.btnAnticlockwise.Click += new System.EventHandler(this.btnAnticlockwise_Click);
            // 
            // lblEndGame
            // 
            this.lblEndGame.AutoSize = true;
            this.lblEndGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndGame.Location = new System.Drawing.Point(26, 24);
            this.lblEndGame.Name = "lblEndGame";
            this.lblEndGame.Size = new System.Drawing.Size(108, 37);
            this.lblEndGame.TabIndex = 3;
            this.lblEndGame.Text = "label2";
            this.lblEndGame.Visible = false;
            // 
            // screen
            // 
            this.screen.BackColor = System.Drawing.Color.Linen;
            this.screen.Location = new System.Drawing.Point(-1, 0);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(538, 549);
            this.screen.TabIndex = 25;
            this.screen.TabStop = false;
            this.screen.Paint += new System.Windows.Forms.PaintEventHandler(this.screen_Paint);

            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(874, 561);
            this.Controls.Add(this.lblEndGame);
            this.Controls.Add(this.btnAnticlockwise);
            this.Controls.Add(this.btnClockwise);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOptions);
            this.Controls.Add(this.ctnRestart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.Difficulty);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.screen);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "Form1";
            this.Text = "Snake Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Difficulty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.screen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.NumericUpDown Difficulty;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button ctnRestart;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnClockwise;
        private System.Windows.Forms.Button btnAnticlockwise;
        private System.Windows.Forms.Label lblEndGame;
        private System.Windows.Forms.PictureBox screen;
    }
}