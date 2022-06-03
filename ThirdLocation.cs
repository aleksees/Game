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
    public partial class ThirdLocation : Form
    {
        public ThirdLocation()
        {
            InitializeComponent();
            Application.OpenForms["SecondLocation"].Hide();
        }

        readonly int playerHealth = 100;
        int count = 0;
        private readonly Player player = new Player();

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            player.PlayerMovement(mainPlayer);

            if ((mainPlayer.Left > 350) && (mainPlayer.Left < 600))
            {
                label1.Visible = true;
                buttonE.Visible = true;
            }
            else
            {
                label1.Visible = false;
                label1.Text = "";
                count = 0;
                buttonE.Visible = false;
            }

            if (playerHealth > 1)
                HealthBar.Value = playerHealth;
            else
            {
                GameMenu gm = new GameMenu();
                gm.Show();
                timer1.Stop();
                Stamina.Stop();
            }
        }

        private void ThirdLocation_KeyDown(object sender, KeyEventArgs e)
        {
            player.KeyDown(sender, e, mainPlayer);
            if (e.KeyCode == Keys.E)
            {
                count += 1;
                Dialog();
            }
        }

        void Dialog()
        {
            if (count == 1)
                label1.Text = "Слушай..";
            if (count == 2)
                label1.Text = "Не хочешь \nотгадать число?";
            if (count == 3)
                label1.Text = "Мне так скучно \nв этом подземелье";
            if (count == 4)
                label1.Text = "Отгадаешь его, и \nя перемещу тебя \nдальше";
            if (count == 5)
                label1.Text = "Ты согласен?";
            if (count == 6)
            {
                button1.Visible = true;
                button2.Visible = true;
                label1.Text = "";
                count = 0;
            }
        }

        private void ButtonNo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonYes_Click(object sender, EventArgs e)
        {
            GuessNumber gn = new GuessNumber();
            gn.Show();
        }

        private void ThirdLocation_KeyUp(object sender, KeyEventArgs e)
        {
            player.KeyUp(sender, e, mainPlayer, StaminaBar, this);
        }

        private void Stamina_Tick(object sender, EventArgs e)
        {
            if (StaminaBar.Value < 100)
                StaminaBar.Value += 1;
        }
    }
}
