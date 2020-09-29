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
            }
        }

        private void radPaper_CheckedChanged(object sender, EventArgs e)
        {
            if (radPaper.Checked == true)
            {
                imgPaper.Visible = Enabled;
                imgScissor.Visible = false;
                imgRock.Visible = false;
            }
        }

        private void radScissor_CheckedChanged(object sender, EventArgs e)
        {
            if(radScissor.Checked == true)
            {
                imgScissor.Visible = Enabled;
                imgRock.Visible = false;
                imgPaper.Visible = false;
            }
        }
    }
}
