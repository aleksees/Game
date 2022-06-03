using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace FinalGame
{
    class Arrow
    {
        public string direction;
        public int arrowLeft;
        public int arrowTop;

        readonly private int speed = 10;
        private PictureBox arrow = new PictureBox();
        private Timer arrowTimer = new Timer();

        public void MakeArrow(Form form)
        {
            arrow.BackColor = Color.WhiteSmoke;
            arrow.Size = new Size(25, 3);
            arrow.Tag = "arrow";
            arrow.Left = arrowLeft;
            arrow.Top = arrowTop;
            arrow.BringToFront();

            form.Controls.Add(arrow);

            arrowTimer.Interval = speed;
            arrowTimer.Tick += new EventHandler(ArrowTimerEvent);
            arrowTimer.Start();
        }

        private void ArrowTimerEvent(object sender, EventArgs e)
        {
            if (direction == "left")
            {
                arrow.Left -= speed;
            }

            if (direction == "right")
            {
                arrow.Left += speed;
            }

            if (arrow.Left < 10 || arrow.Left > 860)
            {
                arrowTimer.Stop();
                arrowTimer.Dispose();
                arrow.Dispose();
                arrowTimer = null;
                arrow = null;
            }
        }
    }
}
