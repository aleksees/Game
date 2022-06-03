using System;
using System.Drawing;
using System.Windows.Forms;

namespace FinalGame
{
    class MagicBall
    {
        public string direction;
        public int magicBallLeft;
        public int magicBallTop;

        readonly private int speed = 7;
        private PictureBox magicBall = new PictureBox();
        private Timer magicBallTimer = new Timer();

        public void MakeMagicBall(Form form)
        {
            magicBall.Image = Properties.Resources.www_EasyImages_net_5419169fec4846ac1fed15383539b3b2;
            magicBall.Size = new Size(50, 50);
            magicBall.BackColor = Color.Transparent;
            magicBall.Tag = "magicBall";
            magicBall.Left = magicBallLeft;
            magicBall.Top = magicBallTop;
            magicBall.BringToFront();

            form.Controls.Add(magicBall);

            magicBallTimer.Interval = speed;
            magicBallTimer.Tick += new EventHandler(MagicBallTimerEvent);
            magicBallTimer.Start();
        }

        private void MagicBallTimerEvent(object sender, EventArgs e)
        {
            if (direction == "left")
            {
                magicBall.Left -= speed;
            }

            if (direction == "right")
            {
                magicBall.Left += speed;
            }

            if (magicBall.Left < 10 || magicBall.Left > 860)
            {
                magicBallTimer.Stop();
                magicBallTimer.Dispose();
                magicBall.Dispose();
                magicBallTimer = null;
                magicBall = null;
            }
        }
    }
}