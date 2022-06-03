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
    public partial class FourthLocation : Form
    {
        public FourthLocation()
        {
            InitializeComponent();
            Application.OpenForms["GuessNumber"].Hide();
        }

        int playerHealth = 100;
        int count = 0;
        int countHealth = 0;
        private readonly Player player = new Player();

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            player.PlayerMovement(mainPlayer);
            MainGame();

            if ((mainPlayer.Left > 750) && (check.Visible == false))
            {
                FifthLocation l5 = new FifthLocation();
                l5.Show();
                MainTimer.Stop();
            }
        }

        private void FourthLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.R) && (countHealth < 2))
            {
                countHealth += 1;
                HealthBar.Value = 100;
                playerHealth = 100; 
                if (countHealth == 1)
                    healthLabel.Text = "1x";
                else
                {
                    healthPicture.Dispose();
                    healthLabel.Dispose();
                    buttonR.Dispose();
                }
            }
            player.KeyDown(sender, e, mainPlayer);
        }

        private void FourthLocation_KeyUp(object sender, KeyEventArgs e)
        {
            player.KeyUp(sender, e, mainPlayer, StaminaBar, this);
        }

        private void Attack(object sender, EventArgs e)
        {
            foreach (Control x in Controls)
            {
                if (x is PictureBox && (string)x.Tag == "monster")
                {
                    if (x.Left > mainPlayer.Left)
                    {
                        ShootMagicBall("left");
                    }
                    if (x.Left < mainPlayer.Left)
                    {
                        ShootMagicBallRight("right");
                    }
                }
            }
        }

        private void ShootMagicBall(string direction)
        {
            var shootMagicBall = new MagicBall()
            {
                direction = direction,
                magicBallLeft = 335,
                magicBallTop = 480
            };
            shootMagicBall.MakeMagicBall(this);
        }

        private void Stamina_Tick(object sender, EventArgs e)
        { 
            if (StaminaBar.Value < 100)
                StaminaBar.Value += 1;
        }

        private void ShootMagicBallRight(string direction)
        {
            var shootMagicBall = new MagicBall()
            {
                direction = direction,
                magicBallLeft = 500,
                magicBallTop = 480
            };
            shootMagicBall.MakeMagicBall(this);
        }

        private void MainGame()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "magicBall")
                {
                    if (mainPlayer.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerHealth -= 20;
                        x.Dispose();
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
                                this.Controls.Remove(x);
                                box2.Dispose();
                                BackgroundImage = Properties.Resources.clearBackground;
                                count = 0;
                                check.Visible = false;
                            }
                            this.Controls.Remove(j);
                            box.Dispose();
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
                timerAttack.Stop();
                MainTimer.Stop();
                Stamina.Stop();
            }
        }
    }
}
