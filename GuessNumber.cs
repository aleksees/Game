using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalGame
{
    public partial class GuessNumber : Form
    {

        readonly Random randomNumber = new Random();

        int number = 0;

        public GuessNumber()
        {
            InitializeComponent();
            LoadQuestions();
            Application.OpenForms["ThirdLocation"].Hide();
        }

        private void LoadQuestions()
        {
            number = randomNumber.Next(0, 15);

            lblQuestion.Text = "Я задумал число между: 0 и 15 ";
        }

        private void CheckNumber(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(txtEnterNumber.Text);

            if (i == number)
            {
                MessageBox.Show("ОГО, ты справился");
                LoadQuestions();
                txtEnterNumber.Text = "";
                FourthLocation l3 = new FourthLocation();
                l3.Show();
            }
            else if (i < number)
            {
                MessageBox.Show("Думаю, моё число больше");
            }
            else
            {
                MessageBox.Show("Думаю, моё число меньше");
            }
        }
    }
}
