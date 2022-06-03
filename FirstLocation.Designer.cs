
namespace FinalGame
{
    partial class FirstLocation
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
            this.label1 = new System.Windows.Forms.Label();
            this.TimerMove = new System.Windows.Forms.Timer(this.components);
            this.mainPlayer = new System.Windows.Forms.PictureBox();
            this.buttonE = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HealthBar = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StaminaBar = new System.Windows.Forms.ProgressBar();
            this.Stamina = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonE)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Fifaks 1.0 dev1", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(174, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // TimerMove
            // 
            this.TimerMove.Enabled = true;
            this.TimerMove.Interval = 1;
            this.TimerMove.Tick += new System.EventHandler(this.TimerMove_Tick);
            // 
            // mainPlayer
            // 
            this.mainPlayer.BackColor = System.Drawing.Color.Transparent;
            this.mainPlayer.Image = global::FinalGame.Properties.Resources.idle;
            this.mainPlayer.Location = new System.Drawing.Point(246, 474);
            this.mainPlayer.Name = "mainPlayer";
            this.mainPlayer.Size = new System.Drawing.Size(100, 113);
            this.mainPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mainPlayer.TabIndex = 2;
            this.mainPlayer.TabStop = false;
            // 
            // buttonE
            // 
            this.buttonE.BackColor = System.Drawing.Color.Transparent;
            this.buttonE.Image = global::FinalGame.Properties.Resources.buttonE;
            this.buttonE.Location = new System.Drawing.Point(151, 593);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(50, 34);
            this.buttonE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonE.TabIndex = 4;
            this.buttonE.TabStop = false;
            this.buttonE.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.HealthBar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 26);
            this.panel1.TabIndex = 5;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.StaminaBar);
            this.panel2.Location = new System.Drawing.Point(12, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 26);
            this.panel2.TabIndex = 6;
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
            // Stamina
            // 
            this.Stamina.Enabled = true;
            this.Stamina.Interval = 250;
            this.Stamina.Tick += new System.EventHandler(this.Stamina_Tick);
            // 
            // FirstLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::FinalGame.Properties.Resources.задний_фон;
            this.ClientSize = new System.Drawing.Size(800, 667);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonE);
            this.Controls.Add(this.mainPlayer);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FirstLocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FirstLocation";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FirstLocation_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FirstLocation_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.mainPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonE)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer TimerMove;
        private System.Windows.Forms.PictureBox mainPlayer;
        private System.Windows.Forms.PictureBox buttonE;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar HealthBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar StaminaBar;
        private System.Windows.Forms.Timer Stamina;
    }
}