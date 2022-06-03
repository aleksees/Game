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
    public partial class GameMenu : Form
    {
        public GameMenu()
        {
            InitializeComponent();
        }

        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            FirstLocation l1 = new FirstLocation();
            l1.Show();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonPlay_MouseHover(object sender, EventArgs e)
        {
            ButtonPlay.Image = Properties.Resources.buttonPlay2;
        }

        private void ButtonPlay_MouseLeave(object sender, EventArgs e)
        {
            ButtonPlay.Image = Properties.Resources.buttonPlay1;
        }

        private void ButtonExit_MouseHover(object sender, EventArgs e)
        {
            ButtonExit.Image = Properties.Resources.buttonExit2;
        }

        private void ButtonExit_MouseLeave(object sender, EventArgs e)
        {
            ButtonExit.Image = Properties.Resources.buttonExit1;
        }
    }
}
