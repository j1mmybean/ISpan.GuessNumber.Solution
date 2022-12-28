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
        private void btnEnter_Click(object sender, EventArgs e)
        {
            FormGuessNumber formGuessNumber = (FormGuessNumber)this.Owner;
            int Guess = int.Parse(txtInput.Text);
            int Answer = FormGuessNumber.RandomNumber;
            if (Guess == Answer)
                MessageBox.Show("Congratulation!!!You got " + Answer + "!!!");
            else if (Guess > Answer)
            {
                formGuessNumber.TooBig();
            }
            else if (Guess < Answer)
            {
                formGuessNumber.TooSmall();
            }
            else
            {
                string message = "請輸入";
                MessageBox.Show(message);
            }
        }
    }
}
