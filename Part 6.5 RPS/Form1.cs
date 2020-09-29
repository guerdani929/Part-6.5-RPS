using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_6._5_RPS
{
    public partial class MainForm : Form
    {
        Random generator = new Random();

        int ainum;
        int win;
        int lose;
        int tie;

        public MainForm()
        {
            

            InitializeComponent();
           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void grpPLayersChoice_Enter(object sender, EventArgs e)
        {
           
        }

        private void radRock_CheckedChanged(object sender, EventArgs e)
        {
            
            if (radRock.Checked == true)
            {
                imgRock.Visible = Enabled;
                imgPaper.Visible = false;
                imgScissor.Visible = false;
                imgPlayer1.Visible = false;
                
            }
        }

        private void radPaper_CheckedChanged(object sender, EventArgs e)
        {
            if (radPaper.Checked == true)
            {
                imgPaper.Visible = Enabled;
                imgScissor.Visible = false;
                imgRock.Visible = false;
                imgPlayer1.Visible = false;
                
            }
        }

        private void radScissor_CheckedChanged(object sender, EventArgs e)
        {
            if(radScissor.Checked == true)
            {
                imgScissor.Visible = Enabled;
                imgRock.Visible = false;
                imgPaper.Visible = false;
                imgPlayer1.Visible = false;
                
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            
            //1-Rock, 2-Paper, 3-Scissor
            ainum = generator.Next(1, 4);
            
            if (ainum == 1)
            {
                imgRock2.Visible = true;
                imgPaper2.Visible = false;
                imgScissor2.Visible = false;
                imgPlayer2.Visible = false;
            }
            else if (ainum == 2)
            {
                imgPaper2.Visible = true;
                imgScissor2.Visible = false;
                imgRock2.Visible = false;
                imgPlayer2.Visible = false;
            }
            else if (ainum == 3)
            {
                imgScissor2.Visible = true;
                imgRock2.Visible = false;
                imgPaper2.Visible = false;
                imgPlayer2.Visible = false;
            }

            if (ainum ==1 && radPaper.Checked == true)
            {
                lblWin.Text = "You Win!";
                win += 1;
                lblWinBor.Text = win + "";
            }
            else if (ainum == 1 && radScissor.Checked == true)
            {
                lblWin.Text = "You Lose!";
                lose += 1;
                lblLoseBor.Text = lose + "";
            }
            else if (ainum == 1 && radRock.Checked == true)
            {
                lblWin.Text = "It's a Tie!";
                tie += 1;
                lblTieBor.Text = tie + "";
            }
            
            if (ainum == 2 && radPaper.Checked == true)
            {
                lblWin.Text = "It's a Tie!";
                tie += 1;
                lblTieBor.Text = tie + "";
            }
            else if (ainum == 2 && radScissor.Checked == true)
            {
                lblWin.Text = "You Win!";
                win += 1;
                lblWinBor.Text = win + "";
            }
            else if (ainum == 2 && radRock.Checked == true)
            {
                lblWin.Text = "You Lose!";
                lose += 1;
                lblLoseBor.Text = lose + "";
            }

            if (ainum == 3 && radPaper.Checked == true)
            {
                lblWin.Text = "It's a Tie!";
                tie += 1;
                lblTieBor.Text = tie + "";
            }
            else if (ainum == 3 && radScissor.Checked == true)
            {
                lblWin.Text = "You Win!";
                win += 1;
                lblWinBor.Text = win + "";
            }
            else if (ainum == 3 && radRock.Checked == true)
            {
                lblWin.Text = "You Lose!";
                lose += 1;
                lblLoseBor.Text = lose + "";
            }


            grpPLayersChoice.Enabled = false;
            btnPlay.Enabled = false;
            btnRestart.Enabled = true;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            grpPLayersChoice.Enabled = true;
            btnPlay.Enabled = true;
            btnRestart.Enabled = false;

            imgPlayer1.Visible = true;
            imgPlayer2.Visible = true;

            lblWin.Text = "";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            win = Convert.ToInt32(lblWinBor.Text);
            tie = Convert.ToInt32(lblTieBor.Text);
            lose = Convert.ToInt32(lblLoseBor.Text);
        }
    }
}
