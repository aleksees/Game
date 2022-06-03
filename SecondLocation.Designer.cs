
namespace FinalGame
{
    partial class SecondLocation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainPlayer = new System.Windows.Forms.PictureBox();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.StaminaBar = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HealthBar = new System.Windows.Forms.ProgressBar();
            this.monster1 = new System.Windows.Forms.PictureBox();
            this.monster2 = new System.Windows.Forms.PictureBox();
            this.check = new System.Windows.Forms.PictureBox();
            this.Stamina = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainPlayer)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monster1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monster2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPlayer
            // 
            this.mainPlayer.BackColor = System.Drawing.Color.Transparent;
            this.mainPlayer.Image = global::FinalGame.Properties.Resources.idle;
            this.mainPlayer.Location = new System.Drawing.Point(2, 474);
            this.mainPlayer.Name = "mainPlayer";
            this.mainPlayer.Size = new System.Drawing.Size(100, 113);
            this.mainPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mainPlayer.TabIndex = 3;
            this.mainPlayer.TabStop = false;
            // 
            // MainTimer
            // 
            this.MainTimer.Enabled = true;
            this.MainTimer.Interval = 2;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.StaminaBar);
            this.panel2.Location = new System.Drawing.Point(12, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 26);
            this.panel2.TabIndex = 8;
            // 
            // StaminaBar
            // 
            this.StaminaBar.BackColor = System.Drawing.SystemColors.Highlight;
            this.StaminaBar.ForeColor = System.Drawing.Color.Turquoise;
            this.StaminaBar.Location = new System.Drawing.Point(0, 0);
            this.StaminaBar.Name = "StaminaBar";
            this.StaminaBar.Size = new System.Drawing.Size(279, 23);
            this.StaminaBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.StaminaBar.TabIndex = 1;
            this.StaminaBar.Value = 100;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.HealthBar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 26);
            this.panel1.TabIndex = 7;
            // 
            // HealthBar
            // 
            this.HealthBar.BackColor = System.Drawing.Color.Maroon;
            this.HealthBar.ForeColor = System.Drawing.Color.Red;
            this.HealthBar.Location = new System.Drawing.Point(0, 0);
            this.HealthBar.Name = "HealthBar";
            this.HealthBar.Size = new System.Drawing.Size(279, 23);
            this.HealthBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.HealthBar.TabIndex = 0;
            this.HealthBar.Value = 100;
            // 
            // monster1
            // 
            this.monster1.BackColor = System.Drawing.Color.Transparent;
            this.monster1.Image = global::FinalGame.Properties.Resources.monster2right;
            this.monster1.Location = new System.Drawing.Point(538, 521);
            this.monster1.Name = "monster1";
            this.monster1.Size = new System.Drawing.Size(58, 66);
            this.monster1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.monster1.TabIndex = 9;
            this.monster1.TabStop = false;
            this.monster1.Tag = "monster";
            // 
            // monster2
            // 
            this.monster2.BackColor = System.Drawing.Color.Transparent;
            this.monster2.Image = global::FinalGame.Properties.Resources.monster2right;
            this.monster2.Location = new System.Drawing.Point(654, 521);
            this.monster2.Name = "monster2";
            this.monster2.Size = new System.Drawing.Size(58, 66);
            this.monster2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.monster2.TabIndex = 10;
            this.monster2.TabStop = false;
            this.monster2.Tag = "monster";
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(538, 107);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(100, 50);
            this.check.TabIndex = 11;
            this.check.TabStop = false;
            // 
            // Stamina
            // 
            this.Stamina.Enabled = true;
            this.Stamina.Interval = 250;
            this.Stamina.Tick += new System.EventHandler(this.Stamina_Tick);
            // 
            // SecondLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::FinalGame.Properties.Resources.backSecLoc;
            this.ClientSize = new System.Drawing.Size(800, 667);
            this.Controls.Add(this.check);
            this.Controls.Add(this.monster2);
            this.Controls.Add(this.monster1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SecondLocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SecondLocation";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SecondLocation_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SecondLocation_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.mainPlayer)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.monster1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monster2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPlayer;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar StaminaBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar HealthBar;
        private System.Windows.Forms.PictureBox monster1;
        private System.Windows.Forms.PictureBox monster2;
        private System.Windows.Forms.PictureBox check;
        private System.Windows.Forms.Timer Stamina;
    }
}