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
    public partial class FinalLocation : Form
    {
        public FinalLocation()
        {
            InitializeComponent();
            Application.OpenForms["FifthLocation"].Hide();
        }

        int count;

        void Dialog()
        {
            if (count == 1)
            {
                label1.Text = "Cпасибо, что повеселил";
                label1.Visible = true;
            }
            if (count == 2)
                label1.Text = "Обычно все \nсразу умирают";
            if (count == 3)
                label1.Text = "А ты так \nхорошо держался!";
            if (count == 4)
                label1.Text = "Поздравляю";
            if (count == 5)
            {
                button1.Visible = true;
                label1.Dispose();
                count = 0;
            }
        }

        private void FinalLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.E)
            {
                count += 1;
                Dialog();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
            button1.Visible = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
        }

        private void Exit(object sender, EventArgs e)
        {
                Application.Exit();
        }
    }
}
