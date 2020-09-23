using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGameTemplate4U
{
    public partial class ResultScreen : UserControl
    {
        public ResultScreen()
        {
            InitializeComponent();
        }

        private void ResultScreen_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Form1.guessList.Count(); i++)
            {
                outputLabel.Text += "\nGuess List" + (i+1) + ": " + Form1.guessList[i];
            }
            outputLabel.Text += "\n\nGuess count:" + Form1.guessList.Count() + "\n";
            Form1.guessList.Sort();
            for (int i = 0; i < Form1.guessList.Count(); i++)
            {
                outputLabel.Text += "\nSorted List" + (i+1) + ": " + Form1.guessList[i];
            }
        }
    }
}
