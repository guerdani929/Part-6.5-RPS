namespace Part_6._5_RPS
{
    partial class MainForm
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
            this.radRock = new System.Windows.Forms.RadioButton();
            this.radPaper = new System.Windows.Forms.RadioButton();
            this.radScissor = new System.Windows.Forms.RadioButton();
            this.grpPLayersChoice = new System.Windows.Forms.GroupBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.imgRock = new System.Windows.Forms.PictureBox();
            this.imgPaper = new System.Windows.Forms.PictureBox();
            this.imgScissor = new System.Windows.Forms.PictureBox();
            this.imgScissor2 = new System.Windows.Forms.PictureBox();
            this.imgPlayer1 = new System.Windows.Forms.PictureBox();
            this.imgRock2 = new System.Windows.Forms.PictureBox();
            this.imgPaper2 = new System.Windows.Forms.PictureBox();
            this.imgPlayer2 = new System.Windows.Forms.PictureBox();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblMaster = new System.Windows.Forms.Label();
            this.lblWin = new System.Windows.Forms.Label();
            this.lblScore3 = new System.Windows.Forms.Label();
            this.lblLoseBor = new System.Windows.Forms.Label();
            this.lblTieBor = new System.Windows.Forms.Label();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblWinBor = new System.Windows.Forms.Label();
            this.grpScoreBoard = new System.Windows.Forms.GroupBox();
            this.grpPLayersChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgScissor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgScissor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRock2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPaper2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer2)).BeginInit();
            this.grpScoreBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // radRock
            // 
            this.radRock.AutoSize = true;
            this.radRock.Location = new System.Drawing.Point(6, 31);
            this.radRock.Name = "radRock";
            this.radRock.Size = new System.Drawing.Size(51, 17);
            this.radRock.TabIndex = 3;
            this.radRock.Text = "Rock";
            this.radRock.UseVisualStyleBackColor = true;
            this.radRock.CheckedChanged += new System.EventHandler(this.radRock_CheckedChanged);
            // 
            // radPaper
            // 
            this.radPaper.AutoSize = true;
            this.radPaper.Location = new System.Drawing.Point(4, 65);
            this.radPaper.Name = "radPaper";
            this.radPaper.Size = new System.Drawing.Size(53, 17);
            this.radPaper.TabIndex = 4;
            this.radPaper.Text = "Paper";
            this.radPaper.UseVisualStyleBackColor = true;
            this.radPaper.CheckedChanged += new System.EventHandler(this.radPaper_CheckedChanged);
            // 
            // radScissor
            // 
            this.radScissor.AutoSize = true;
            this.radScissor.Location = new System.Drawing.Point(6, 102);
            this.radScissor.Name = "radScissor";
            this.radScissor.Size = new System.Drawing.Size(64, 17);
            this.radScissor.TabIndex = 5;
            this.radScissor.Text = "Scissors";
            this.radScissor.UseVisualStyleBackColor = true;
            this.radScissor.CheckedChanged += new System.EventHandler(this.radScissor_CheckedChanged);
            // 
            // grpPLayersChoice
            // 
            this.grpPLayersChoice.Controls.Add(this.radRock);
            this.grpPLayersChoice.Controls.Add(this.radScissor);
            this.grpPLayersChoice.Controls.Add(this.radPaper);
            this.grpPLayersChoice.Location = new System.Drawing.Point(48, 248);
            this.grpPLayersChoice.Name = "grpPLayersChoice";
            this.grpPLayersChoice.Size = new System.Drawing.Size(200, 142);
            this.grpPLayersChoice.TabIndex = 6;
            this.grpPLayersChoice.TabStop = false;
            this.grpPLayersChoice.Text = "Players Choice";
            this.grpPLayersChoice.Enter += new System.EventHandler(this.grpPLayersChoice_Enter);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(11, 400);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(156, 38);
            this.btnPlay.TabIndex = 7;
            this.btnPlay.Text = "Click to Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Enabled = false;
            this.btnRestart.Location = new System.Drawing.Point(234, 400);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(156, 38);
            this.btnRestart.TabIndex = 8;
            this.btnRestart.Text = "Play Again!";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // imgRock
            // 
            this.imgRock.Image = global::Part_6._5_RPS.Properties.Resources.pasadena_boy_starts_rock_wall_for_painted_rocks_1_large;
            this.imgRock.Location = new System.Drawing.Point(54, 32);
            this.imgRock.Name = "imgRock";
            this.imgRock.Size = new System.Drawing.Size(194, 185);
            this.imgRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgRock.TabIndex = 2;
            this.imgRock.TabStop = false;
            this.imgRock.Visible = false;
            // 
            // imgPaper
            // 
            this.imgPaper.Image = global::Part_6._5_RPS.Properties.Resources.download;
            this.imgPaper.Location = new System.Drawing.Point(54, 32);
            this.imgPaper.Name = "imgPaper";
            this.imgPaper.Size = new System.Drawing.Size(194, 185);
            this.imgPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPaper.TabIndex = 1;
            this.imgPaper.TabStop = false;
            this.imgPaper.Visible = false;
            // 
            // imgScissor
            // 
            this.imgScissor.Image = global::Part_6._5_RPS.Properties.Resources.jake_shears_scissor_sisters_another_album;
            this.imgScissor.Location = new System.Drawing.Point(54, 32);
            this.imgScissor.Name = "imgScissor";
            this.imgScissor.Size = new System.Drawing.Size(194, 185);
            this.imgScissor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgScissor.TabIndex = 0;
            this.imgScissor.TabStop = false;
            this.imgScissor.Visible = false;
            this.imgScissor.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // imgScissor2
            // 
            this.imgScissor2.Image = global::Part_6._5_RPS.Properties.Resources.jake_shears_scissor_sisters_another_album;
            this.imgScissor2.Location = new System.Drawing.Point(357, 32);
            this.imgScissor2.Name = "imgScissor2";
            this.imgScissor2.Size = new System.Drawing.Size(200, 185);
            this.imgScissor2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgScissor2.TabIndex = 9;
            this.imgScissor2.TabStop = false;
            this.imgScissor2.Visible = false;
            // 
            // imgPlayer1
            // 
            this.imgPlayer1.Image = global::Part_6._5_RPS.Properties.Resources.bluemanc;
            this.imgPlayer1.Location = new System.Drawing.Point(48, 32);
            this.imgPlayer1.Name = "imgPlayer1";
            this.imgPlayer1.Size = new System.Drawing.Size(200, 185);
            this.imgPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayer1.TabIndex = 10;
            this.imgPlayer1.TabStop = false;
            // 
            // imgRock2
            // 
            this.imgRock2.Image = global::Part_6._5_RPS.Properties.Resources.pasadena_boy_starts_rock_wall_for_painted_rocks_1_large;
            this.imgRock2.Location = new System.Drawing.Point(357, 32);
            this.imgRock2.Name = "imgRock2";
            this.imgRock2.Size = new System.Drawing.Size(200, 185);
            this.imgRock2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgRock2.TabIndex = 11;
            this.imgRock2.TabStop = false;
            this.imgRock2.Visible = false;
            // 
            // imgPaper2
            // 
            this.imgPaper2.Image = global::Part_6._5_RPS.Properties.Resources.download;
            this.imgPaper2.Location = new System.Drawing.Point(357, 32);
            this.imgPaper2.Name = "imgPaper2";
            this.imgPaper2.Size = new System.Drawing.Size(200, 185);
            this.imgPaper2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPaper2.TabIndex = 12;
            this.imgPaper2.TabStop = false;
            this.imgPaper2.Visible = false;
            // 
            // imgPlayer2
            // 
            this.imgPlayer2.Image = global::Part_6._5_RPS.Properties.Resources.redmanc;
            this.imgPlayer2.Location = new System.Drawing.Point(357, 32);
            this.imgPlayer2.Name = "imgPlayer2";
            this.imgPlayer2.Size = new System.Drawing.Size(200, 185);
            this.imgPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayer2.TabIndex = 13;
            this.imgPlayer2.TabStop = false;
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Location = new System.Drawing.Point(115, 9);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(45, 13);
            this.lblPlayer1.TabIndex = 14;
            this.lblPlayer1.Text = "Player 1";
            // 
            // lblMaster
            // 
            this.lblMaster.AutoSize = true;
            this.lblMaster.Location = new System.Drawing.Point(422, 9);
            this.lblMaster.Name = "lblMaster";
            this.lblMaster.Size = new System.Drawing.Size(64, 13);
            this.lblMaster.TabIndex = 15;
            this.lblMaster.Text = "RPS Master";
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.Location = new System.Drawing.Point(390, 248);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(0, 32);
            this.lblWin.TabIndex = 16;
            // 
            // lblScore3
            // 
            this.lblScore3.AutoSize = true;
            this.lblScore3.Location = new System.Drawing.Point(159, 16);
            this.lblScore3.Name = "lblScore3";
            this.lblScore3.Size = new System.Drawing.Size(38, 13);
            this.lblScore3.TabIndex = 17;
            this.lblScore3.Text = "Loses:";
            // 
            // lblLoseBor
            // 
            this.lblLoseBor.AutoSize = true;
            this.lblLoseBor.Location = new System.Drawing.Point(159, 62);
            this.lblLoseBor.Name = "lblLoseBor";
            this.lblLoseBor.Size = new System.Drawing.Size(13, 13);
            this.lblLoseBor.TabIndex = 18;
            this.lblLoseBor.Text = "0";
            // 
            // lblTieBor
            // 
            this.lblTieBor.AutoSize = true;
            this.lblTieBor.Location = new System.Drawing.Point(76, 62);
            this.lblTieBor.Name = "lblTieBor";
            this.lblTieBor.Size = new System.Drawing.Size(13, 13);
            this.lblTieBor.TabIndex = 19;
            this.lblTieBor.Text = "0";
            // 
            // lblScore2
            // 
            this.lblScore2.AutoSize = true;
            this.lblScore2.Location = new System.Drawing.Point(76, 16);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(30, 13);
            this.lblScore2.TabIndex = 20;
            this.lblScore2.Text = "Ties:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(6, 16);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(34, 13);
            this.lblScore.TabIndex = 21;
            this.lblScore.Text = "Wins:";
            // 
            // lblWinBor
            // 
            this.lblWinBor.AutoSize = true;
            this.lblWinBor.Location = new System.Drawing.Point(6, 62);
            this.lblWinBor.Name = "lblWinBor";
            this.lblWinBor.Size = new System.Drawing.Size(13, 13);
            this.lblWinBor.TabIndex = 22;
            this.lblWinBor.Text = "0";
            // 
            // grpScoreBoard
            // 
            this.grpScoreBoard.Controls.Add(this.lblScore);
            this.grpScoreBoard.Controls.Add(this.lblScore3);
            this.grpScoreBoard.Controls.Add(this.lblLoseBor);
            this.grpScoreBoard.Controls.Add(this.lblTieBor);
            this.grpScoreBoard.Controls.Add(this.lblScore2);
            this.grpScoreBoard.Controls.Add(this.lblWinBor);
            this.grpScoreBoard.Location = new System.Drawing.Point(396, 338);
            this.grpScoreBoard.Name = "grpScoreBoard";
            this.grpScoreBoard.Size = new System.Drawing.Size(200, 100);
            this.grpScoreBoard.TabIndex = 23;
            this.grpScoreBoard.TabStop = false;
            this.grpScoreBoard.Text = "SCOREBOARD";
            this.grpScoreBoard.UseCompatibleTextRendering = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 450);
            this.Controls.Add(this.grpScoreBoard);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.lblMaster);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.imgPlayer2);
            this.Controls.Add(this.imgPaper2);
            this.Controls.Add(this.imgRock2);
            this.Controls.Add(this.imgPlayer1);
            this.Controls.Add(this.imgScissor2);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.grpPLayersChoice);
            this.Controls.Add(this.imgRock);
            this.Controls.Add(this.imgPaper);
            this.Controls.Add(this.imgScissor);
            this.Name = "MainForm";
            this.Text = "RPS";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpPLayersChoice.ResumeLayout(false);
            this.grpPLayersChoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgScissor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgScissor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRock2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPaper2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer2)).EndInit();
            this.grpScoreBoard.ResumeLayout(false);
            this.grpScoreBoard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgScissor;
        private System.Windows.Forms.PictureBox imgPaper;
        private System.Windows.Forms.PictureBox imgRock;
        private System.Windows.Forms.RadioButton radRock;
        private System.Windows.Forms.RadioButton radPaper;
        private System.Windows.Forms.RadioButton radScissor;
        private System.Windows.Forms.GroupBox grpPLayersChoice;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.PictureBox imgScissor2;
        private System.Windows.Forms.PictureBox imgPlayer1;
        private System.Windows.Forms.PictureBox imgRock2;
        private System.Windows.Forms.PictureBox imgPaper2;
        private System.Windows.Forms.PictureBox imgPlayer2;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblMaster;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label lblScore3;
        private System.Windows.Forms.Label lblLoseBor;
        private System.Windows.Forms.Label lblTieBor;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblWinBor;
        private System.Windows.Forms.GroupBox grpScoreBoard;
    }
}

