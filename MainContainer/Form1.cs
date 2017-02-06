using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainContainer
{
    public partial class MainContainer : Form
    {
        Random rng;
        int dieRoll;
        int forThefakes = 0;

        public MainContainer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void d6Button_Click(object sender, EventArgs e)
        {
            rng = new Random();
            dieRoll = rng.Next(1, 7);
            //fake a one lulz
            if(forThefakes == 0)
            {
                dieRoll = 1;
                forThefakes++;
            }
            dicePictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            switch (dieRoll)
            {
                case 1:
                    {
                        dicePictureBox.Image = Properties.Resources.nat1;
                        break;
                    }
                default :
                    {
                        MessageBox.Show("Transforming pizza to code... Please wait. \n "+ dieRoll+".", "The programmer made an oopsie", MessageBoxButtons.OK);
                        break;
                    }
            }
            dicePictureBox.Refresh();
        }

        private void d4Button_Click(object sender, EventArgs e)
        {
            rng = new Random();
            dieRoll = rng.Next(1, 5);
            //fake a one lulz
            if (forThefakes == 0)
            {
                dieRoll = 1;
                forThefakes++;
            }
            dicePictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            switch (dieRoll)
            {
                case 1:
                    {
                        dicePictureBox.Image = Properties.Resources.nat1;
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Transforming pizza to code... Please wait.", "The programmer made an oopsie", MessageBoxButtons.OK);
                        break;
                    }
            }
            dicePictureBox.Refresh();
        }
    }
}
