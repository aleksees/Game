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
    public partial class SecondLocation : Form
    {
        public SecondLocation()
        {
            InitializeComponent();
            Application.OpenForms["FirstLocation"].Hide();
        }

        int playerHealth = 100;
        int count = 0;
        readonly int monsterSpeed = 4;
        private readonly Player player = new Player();

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            player.PlayerMovement(mainPlayer);
            MainGame();

            if ((mainPlayer.Left > 750) && (check.Visible == false))
            {
                ThirdLocation l3 = new ThirdLocation();
                l3.Show();
                MainTimer.Stop();
            }
        }

        private void SecondLocation_KeyDown(object sender, KeyEventArgs e)
        {
            player.KeyDown(sender, e, mainPlayer);
        }

        private void SecondLocation_KeyUp(object sender, KeyEventArgs e)
        {
            player.KeyUp(sender, e, mainPlayer, StaminaBar, this);
        }

        private void Stamina_Tick(object sender, EventArgs e)
        {
            if (StaminaBar.Value < 100)
                StaminaBar.Value += 1;
        }

        private void MainGame()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox box0 && (string)x.Tag == "monster")
                {
                    if (x.Left > mainPlayer.Left)
                    {
                        x.Left -= monsterSpeed;
                        box0.Image = Properties.Resources.monster2right;
                    }
                    if (x.Left < mainPlayer.Left)
                    {
                        x.Left += monsterSpeed;
                        box0.Image = Properties.Resources.monster1right;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "monster")
                {
                    if (mainPlayer.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerHealth -= 1;
                    }
                }

                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox box && (string)j.Tag == "arrow" && x is PictureBox box2 && (string)x.Tag == "monster")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            count += 1;
                            if (count == 7)
                            {
                                this.Controls.Remove(j);
                                box.Dispose();
                                this.Controls.Remove(x);
                                box2.Dispose();
                                check.Visible = false;
                                count = 0;
                            }
                        }
                    }
                }

            }


            if (playerHealth > 1)
                HealthBar.Value = playerHealth;
            else
            {
                GameMenu gm = new GameMenu();
                gm.Show();
                MainTimer.Stop();
                Stamina.Stop();
            }
        }
    }
}
