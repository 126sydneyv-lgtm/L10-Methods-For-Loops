using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L10_Methods_For_Loops
{
    public partial class ForLoopsForm : Form
    {
        public ForLoopsForm()
        {
            InitializeComponent();
        }

        private void repeatWordButton_Click(object sender, EventArgs e)
        {
            wordOutputLabel.Text = "";
            string wordOrPhrase = wordTextBox.Text;
            //notes on for loops
            //i could be any variable, but it must be a number and it is a counter
            for (int i = 0; i < 5; i++)
            {
                wordOutputLabel.Text += wordOrPhrase + "\n";
            }
        }

        private void repeatXButton_Click(object sender, EventArgs e)
        {
            wordOutputXLabel.Text = " ";
            try
            {
                //read in the word or phrase and the number of times to repeat
                string wordOrPhrase = wordTextBox2.Text;
                int noTimes = Convert.ToInt16(numberOfTimesBox.Text);
                for (int i = 0; i < noTimes; i++)
                {
                    wordOutputXLabel.Text += wordOrPhrase + " ";
                }
            }
            catch
            {
                wordOutputXLabel.Text = "enter an integer";
            }
        }

        private void powerButton_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(integerInputBox.Text);
                for (int i = 1; i < 6; i++)
                {
                    //start thr for loop at one, for the first power!
                    //Math.Pow is how visual studio can do an exponent, 5^2 does not work!

                    double power = Math.Pow(n, i);
                    powerOutputLabel.Text += n + " to the power " + i + " is " + power + "\n";
                }
            }
            catch
            {
                powerOutputLabel.Text = "enter an integer";
            }
        }
    }
}
