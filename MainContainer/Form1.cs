using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MainContainer.Utils;

namespace MainContainer
{
    public partial class MainContainer : Form
    {
        DieGenerator dg = DieGenerator.getDieGenerator();

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

        private void RollButton_Click(object sender, EventArgs e)
        {
            Dice die;
            Console.WriteLine(dieTypeComboBox.SelectedText);
            int num;
            bool isNumeric = int.TryParse(numberofdieTextBox.Text, out num);

            if (isNumeric == false )
            {
                MessageBox.Show("Number must be a valid integer, will default to 1.");
                numberofdieTextBox.Text = "1";
            }

            switch (dieTypeComboBox.SelectedItem.ToString())
            {
                case "d4":
                    {
                        die = Dice.d4;
                        break;
                    }
                case "d6":
                    {
                        die = Dice.d6;
                        break;
                    }
                case "d8":
                    {
                        die = Dice.d8;
                        break;
                    }
                case "d10":
                    {
                        die = Dice.d10;
                        break;
                    }
                case "d12":
                    {
                        die = Dice.d12;
                        break;
                    }
                case "d20":
                    {
                        die = Dice.d20;
                        break;
                    }
                case "d100":
                    {
                        die = Dice.d100;
                        break;
                    }
                default:
                    {
                        die = Dice.d20;
                        break;
                    }

            }
            dieRollTextBox.Text = dg.rollDie(Int32.Parse(numberofdieTextBox.Text), die);
        }

        private void setPortraitButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fd = new OpenFileDialog())
            {
                fd.Title = "Load Character Image";

                if (fd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        characterPictureBox.Image = Image.FromFile(fd.FileName);
                        characterPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    } catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }

        }
    }
}
