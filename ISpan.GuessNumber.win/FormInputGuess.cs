using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.GuessNumber.win
{
    public partial class FormInputGuess : Form
    {
        public FormInputGuess()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int lowerBound = 1;
        int upperBound = 100;

        private void btnEnter_Click(object sender, EventArgs e)
        {
            FormGuessNumber formGuessNumber = (FormGuessNumber)this.Owner;
            int Answer = FormGuessNumber.RandomNumber;
            bool IsNumber = int.TryParse(txtInput.Text, out int Guess);

            if (!IsNumber || Guess < lowerBound || Guess > upperBound)
                MessageBox.Show($"請輸入{lowerBound}~{upperBound}間的數字。");
            else if (Guess == Answer)
                MessageBox.Show("Congratulation!!!You got " + Answer + "!!!");
            else if (Guess > Answer)
            {
                upperBound = Guess;
                formGuessNumber.TooBig(Guess, lowerBound);
            }
            else if (Guess < Answer)
            {
                lowerBound = Guess;
                formGuessNumber.TooSmall(Guess, upperBound);
            }
            txtInput.Focus();
            txtInput.SelectAll();
        }

        private void FormInputGuess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
                btnEnter.PerformClick();
        }

        private void FormInputGuess_Activated(object sender, EventArgs e)
        {
            txtInput.Focus();
        }
    }
}
