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
    public partial class FormGuessNumber : Form
    {
        public FormGuessNumber()
        {
            InitializeComponent();
        }
        
        public void TooBig()
        {
            labShowMessage.Text = "Too Big";
        }
        public void TooSmall()
        {
            labShowMessage.Text = "Too Small";
        }
        public static int RandomNumber;
        private void btnGuess_Click(object sender, EventArgs e)
        {
            RandomNumber = new Random(Guid.NewGuid().GetHashCode()).Next(1,101);
            FormInputGuess formInputGuess = new FormInputGuess();
            formInputGuess.Owner = this;
            formInputGuess.ShowDialog();
        }

        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Answer : " + RandomNumber.ToString());
        }
    }
}
