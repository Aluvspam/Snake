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
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.LblScore = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.rbFullScreen = new System.Windows.Forms.RadioButton();
            this.rbCustom = new System.Windows.Forms.RadioButton();
            this.txtHihghScore = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.ctnRestart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.Color.MistyRose;
            this.Canvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Canvas.Location = new System.Drawing.Point(12, 12);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(533, 506);
            this.Canvas.TabIndex = 0;
            this.Canvas.TabStop = false;
            // 
            // LblScore
            // 
            this.LblScore.AutoSize = true;
            this.LblScore.Font = new System.Drawing.Font("Blackadder ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblScore.ForeColor = System.Drawing.Color.Maroon;
            this.LblScore.Location = new System.Drawing.Point(752, 22);
            this.LblScore.Name = "LblScore";
            this.LblScore.Size = new System.Drawing.Size(0, 41);
            this.LblScore.TabIndex = 2;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Maroon;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPlay.Location = new System.Drawing.Point(571, 371);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(82, 40);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Maroon;
            this.lblName.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblName.Location = new System.Drawing.Point(566, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 29);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtName.Font = new System.Drawing.Font("Blackadder ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Maroon;
            this.txtName.Location = new System.Drawing.Point(674, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 34);
            this.txtName.TabIndex = 5;
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficulty.ForeColor = System.Drawing.Color.Maroon;
            this.lblDifficulty.Location = new System.Drawing.Point(573, 157);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(85, 23);
            this.lblDifficulty.TabIndex = 6;
            this.lblDifficulty.Text = "Difficulty";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.NavajoWhite;
            this.numericUpDown1.Font = new System.Drawing.Font("Blackadder ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.Maroon;
            this.numericUpDown1.Location = new System.Drawing.Point(710, 157);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(49, 28);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // rbFullScreen
            // 
            this.rbFullScreen.AutoSize = true;
            this.rbFullScreen.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFullScreen.ForeColor = System.Drawing.Color.Maroon;
            this.rbFullScreen.Location = new System.Drawing.Point(572, 189);
            this.rbFullScreen.Name = "rbFullScreen";
            this.rbFullScreen.Size = new System.Drawing.Size(112, 27);
            this.rbFullScreen.TabIndex = 8;
            this.rbFullScreen.TabStop = true;
            this.rbFullScreen.Text = "Full Screen";
            this.rbFullScreen.UseVisualStyleBackColor = true;
            // 
            // rbCustom
            // 
            this.rbCustom.AutoSize = true;
            this.rbCustom.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCustom.ForeColor = System.Drawing.Color.Maroon;
            this.rbCustom.Location = new System.Drawing.Point(710, 189);
            this.rbCustom.Name = "rbCustom";
            this.rbCustom.Size = new System.Drawing.Size(117, 27);
            this.rbCustom.TabIndex = 9;
            this.rbCustom.TabStop = true;
            this.rbCustom.Text = "Custom Size";
            this.rbCustom.UseVisualStyleBackColor = true;
            // 
            // txtHihghScore
            // 
            this.txtHihghScore.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtHihghScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHihghScore.ForeColor = System.Drawing.Color.Maroon;
            this.txtHihghScore.Location = new System.Drawing.Point(572, 417);
            this.txtHihghScore.Multiline = true;
            this.txtHihghScore.Name = "txtHihghScore";
            this.txtHihghScore.ReadOnly = true;
            this.txtHihghScore.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHihghScore.Size = new System.Drawing.Size(277, 69);
            this.txtHihghScore.TabIndex = 10;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Maroon;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Location = new System.Drawing.Point(659, 371);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 40);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // ctnRestart
            // 
            this.ctnRestart.BackColor = System.Drawing.Color.Maroon;
            this.ctnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ctnRestart.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctnRestart.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ctnRestart.Location = new System.Drawing.Point(743, 371);
            this.ctnRestart.Name = "ctnRestart";
            this.ctnRestart.Size = new System.Drawing.Size(106, 40);
            this.ctnRestart.TabIndex = 12;
            this.ctnRestart.Text = "Restart";
            this.ctnRestart.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(861, 530);
            this.Controls.Add(this.ctnRestart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtHihghScore);
            this.Controls.Add(this.rbCustom);
            this.Controls.Add(this.rbFullScreen);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.LblScore);
            this.Controls.Add(this.Canvas);
            this.Name = "Form1";
            this.Text = "Snake Game";
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.Label LblScore;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RadioButton rbFullScreen;
        private System.Windows.Forms.RadioButton rbCustom;
        private System.Windows.Forms.TextBox txtHihghScore;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button ctnRestart;
    }
}