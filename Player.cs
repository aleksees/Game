using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
namespace FinalGame
{
    class Player
    { 
        bool right, left;
        readonly int playerSpeed = 13;
        string facing = "right";

        public void KeyDown(object sender, KeyEventArgs e, PictureBox pc)
        {
            if (sender is null)
            {
                throw new ArgumentNullException(nameof(sender));
            }

            if (e.KeyCode == Keys.D)
            {
                pc.Image = Properties.Resources.idle;
                right = true;
                facing = "right";
            }
            if (e.KeyCode == Keys.A)
            {
                pc.Image = Properties.Resources.idleLeft;
                left = true;
                facing = "left";
            }
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }


        public void KeyUp(object sender, KeyEventArgs e, PictureBox pc, ProgressBar pb, Form form)
        {
            if (sender is null)
            {
                throw new ArgumentNullException(nameof(sender));
            }

            if (e.KeyCode == Keys.D)
            {
                right = false;
            }
            if (e.KeyCode == Keys.A)
            {
                left = false;
            }
            if (e.KeyCode == Keys.Space)
            {
                if (pb.Value > 24)
                {
                    pb.Value -= 25;
                    ShootArrow(facing, pc, pb, form);
                }
            }
        }

        public void ShootArrow(string direction, PictureBox pc, ProgressBar pb, Form form)
        {
            if (pb.Value > 0)
            {
                var shootArrow = new Arrow()
                {
                    direction = direction,
                    arrowLeft = pc.Left + (pc.Width / 2),
                    arrowTop = pc.Top + (pc.Height / 2)
                };
                shootArrow.MakeArrow(form);
            }
        }

        public void PlayerMovement(PictureBox pc)
        {
            if ((right == true) && (pc.Left < 750))
            {
                pc.Left += playerSpeed;
            }

            if ((left == true) && (pc.Left > 0))
            {
                pc.Left -= playerSpeed;
            }
        }
    }
}
