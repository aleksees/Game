
namespace FinalGame
{
    partial class ThirdLocation
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonE = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StaminaBar = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HealthBar = new System.Windows.Forms.ProgressBar();
            this.Stamina = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonE)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPlayer
            // 
            this.mainPlayer.BackColor = System.Drawing.Color.Transparent;
            this.mainPlayer.Image = global::FinalGame.Properties.Resources.idle;
            this.mainPlayer.Location = new System.Drawing.Point(21, 474);
            this.mainPlayer.Name = "mainPlayer";
            this.mainPlayer.Size = new System.Drawing.Size(100, 113);
            this.mainPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mainPlayer.TabIndex = 0;
            this.mainPlayer.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // buttonE
            // 
            this.buttonE.BackColor = System.Drawing.Color.Transparent;
            this.buttonE.Image = global::FinalGame.Properties.Resources.buttonE;
            this.buttonE.Location = new System.Drawing.Point(521, 589);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(51, 41);
            this.buttonE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonE.TabIndex = 1;
            this.buttonE.TabStop = false;
            this.buttonE.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Fifaks 1.0 dev1", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(544, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(339, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "ДА";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.ButtonYes_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(339, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "НЕТ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.ButtonNo_Click);
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
            // Stamina
            // 
            this.Stamina.Enabled = true;
            this.Stamina.Interval = 250;
            this.Stamina.Tick += new System.EventHandler(this.Stamina_Tick);
            // 
            // ThirdLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::FinalGame.Properties.Resources.backThird;
            this.ClientSize = new System.Drawing.Size(800, 667);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonE);
            this.Controls.Add(this.mainPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThirdLocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThirdLocation";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ThirdLocation_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ThirdLocation_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.mainPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonE)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPlayer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox buttonE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar StaminaBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar HealthBar;
        private System.Windows.Forms.Timer Stamina;
    }
}