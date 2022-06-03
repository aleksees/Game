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
    public partial class FifthLocation : Form
    {
        public FifthLocation()
        {
            InitializeComponent();
            Application.OpenForms["FourthLocation"].Hide();
        }

        readonly int playerHealth = 100;
        int count = 0;
        private readonly Player player = new Player();

        private void FifthLocation_KeyDown(object sender, KeyEventArgs e)
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
                label1.Text = "Скучно..";
            if (count == 2)
                label1.Text = "Прошлая игра \nбыла не очень";
            if (count == 3)
                label1.Text = "Побалуемся \nзагадками?";
            if (count == 4)
                label1.Text = "Ну и как в \nпрошлый раз,";
            if (count == 5)
                label1.Text = "Отгадаешь - перемещу \nдальше";
            if (count == 6)
            {
                textBoxQuestions.Visible = true;
                labelQuestions.Visible = true;
                btnCheck.Visible = true;
                label1.Text = "";
                count = 0;
            }
        }

        private void FifthLocation_KeyUp(object sender, KeyEventArgs e)
        {
            player.KeyUp(sender, e, mainPlayer, StaminaBar, this);
        }

        private void Stamina_Tick(object sender, EventArgs e)
        {
            if (StaminaBar.Value < 100)
                StaminaBar.Value += 1;
        }


        private void MainTimer_Tick(object sender, EventArgs e)
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
                MainTimer.Stop();
                Stamina.Stop();
            }
        }

        private void Check(object sender, EventArgs e)
        {

            if (textBoxQuestions.Text == "13")
            {
                labelQuestions.Text = "Что можно видеть с закрытыми глазами? \nОтвет пиши с маленькой буквы";
                textBoxQuestions.Text = "";
            }

            if ((textBoxQuestions.Text == "сны"))
            {
                FinalLocation fl = new FinalLocation();
                fl.Show();
                MainTimer.Stop();
                Stamina.Stop();
            }
        }
    }
}
