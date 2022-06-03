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
    public partial class FirstLocation : Form
    {
        public FirstLocation()
        {
            InitializeComponent();
            Application.OpenForms["GameMenu"].Hide();
        }

        int count;
        readonly int playerHealth = 100;
        private readonly Player player = new Player();

        private void FirstLocation_KeyDown(object sender, KeyEventArgs e)
        {
            player.KeyDown(sender, e, mainPlayer);
            if (e.KeyCode == Keys.E)
            {
                count += 1;
                Dialog();
            }
        }

        private void FirstLocation_KeyUp(object sender, KeyEventArgs e)
        {
            player.KeyUp(sender, e, mainPlayer, StaminaBar, this);
        }

        private void TimerMove_Tick(object sender, EventArgs e)
        {
            player.PlayerMovement(mainPlayer);

            if (mainPlayer.Left > 750)
            {
                SecondLocation l2 = new SecondLocation();
                l2.Show();
                TimerMove.Stop();
            }

            if ((mainPlayer.Left > 30) && (mainPlayer.Left < 200))
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
                TimerMove.Stop();
                Stamina.Stop();
            }

        }

        private void Stamina_Tick(object sender, EventArgs e)
        {
            if (StaminaBar.Value < 100)
                StaminaBar.Value += 1;
        }

        void Dialog()
        {
            if (count == 1)
                label1.Text = "Боже...";
            if (count == 2)
                label1.Text = "Зачем её забрали?";
            if (count == 3)
                label1.Text = "Пожалуйста, спаси мою сестру";
            if (count == 4)
                label1.Text = "Ты же поможешь мне?";
            if (count == 5)
                label1.Text = "Прошу...";
            if (count == 6)
            {
                label1.Text = "";
                count = 0;
            }
        }
    }
}
