
namespace FinalGame
{
    partial class FourthLocation
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
            this.monster = new System.Windows.Forms.PictureBox();
            this.timerAttack = new System.Windows.Forms.Timer(this.components);
            this.check = new System.Windows.Forms.PictureBox();
            this.Stamina = new System.Windows.Forms.Timer(this.components);
            this.healthPicture = new System.Windows.Forms.PictureBox();
            this.buttonR = new System.Windows.Forms.PictureBox();
            this.healthLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainPlayer)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonR)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPlayer
            // 
            this.mainPlayer.BackColor = System.Drawing.Color.Transparent;
            this.mainPlayer.Image = global::FinalGame.Properties.Resources.idle;
            this.mainPlayer.Location = new System.Drawing.Point(12, 474);
            this.mainPlayer.Name = "mainPlayer";
            this.mainPlayer.Size = new System.Drawing.Size(100, 113);
            this.mainPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mainPlayer.TabIndex = 0;
            this.mainPlayer.TabStop = false;
            this.mainPlayer.Tag = "player";
            // 
            // MainTimer
            // 
            this.MainTimer.Enabled = true;
            this.MainTimer.Interval = 10;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.StaminaBar);
            this.panel2.Location = new System.Drawing.Point(12, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 26);
            this.panel2.TabIndex = 10;
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
            this.panel1.TabIndex = 9;
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
            // monster
            // 
            this.monster.BackColor = System.Drawing.Color.Transparent;
            this.monster.Location = new System.Drawing.Point(413, 299);
            this.monster.Name = "monster";
            this.monster.Size = new System.Drawing.Size(65, 288);
            this.monster.TabIndex = 11;
            this.monster.TabStop = false;
            this.monster.Tag = "monster";
            // 
            // timerAttack
            // 
            this.timerAttack.Enabled = true;
            this.timerAttack.Interval = 2500;
            this.timerAttack.Tick += new System.EventHandler(this.Attack);
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(491, 103);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(105, 51);
            this.check.TabIndex = 12;
            this.check.TabStop = false;
            // 
            // Stamina
            // 
            this.Stamina.Enabled = true;
            this.Stamina.Interval = 250;
            this.Stamina.Tick += new System.EventHandler(this.Stamina_Tick);
            // 
            // healthPicture
            // 
            this.healthPicture.BackColor = System.Drawing.Color.Transparent;
            this.healthPicture.Image = global::FinalGame.Properties.Resources.health;
            this.healthPicture.Location = new System.Drawing.Point(12, 82);
            this.healthPicture.Name = "healthPicture";
            this.healthPicture.Size = new System.Drawing.Size(33, 67);
            this.healthPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.healthPicture.TabIndex = 13;
            this.healthPicture.TabStop = false;
            // 
            // buttonR
            // 
            this.buttonR.BackColor = System.Drawing.Color.Transparent;
            this.buttonR.Image = global::FinalGame.Properties.Resources.tile_0360;
            this.buttonR.Location = new System.Drawing.Point(29, 103);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(69, 34);
            this.buttonR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonR.TabIndex = 14;
            this.buttonR.TabStop = false;
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.BackColor = System.Drawing.Color.Transparent;
            this.healthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.healthLabel.ForeColor = System.Drawing.Color.White;
            this.healthLabel.Location = new System.Drawing.Point(15, 152);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(25, 20);
            this.healthLabel.TabIndex = 15;
            this.healthLabel.Text = "2x";
            // 
            // FourthLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::FinalGame.Properties.Resources.backgroundFourthLeft;
            this.ClientSize = new System.Drawing.Size(800, 667);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.healthPicture);
            this.Controls.Add(this.check);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainPlayer);
            this.Controls.Add(this.monster);
            this.Controls.Add(this.buttonR);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FourthLocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FourthLocation";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FourthLocation_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FourthLocation_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.mainPlayer)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.monster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonR)).EndInit();
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
        private System.Windows.Forms.PictureBox monster;
        private System.Windows.Forms.Timer timerAttack;
        private System.Windows.Forms.PictureBox check;
        private System.Windows.Forms.Timer Stamina;
        private System.Windows.Forms.PictureBox healthPicture;
        private System.Windows.Forms.PictureBox buttonR;
        private System.Windows.Forms.Label healthLabel;
    }
}