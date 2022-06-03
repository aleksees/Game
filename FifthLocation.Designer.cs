
namespace FinalGame
{
    partial class FifthLocation
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
            this.buttonE = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StaminaBar = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HealthBar = new System.Windows.Forms.ProgressBar();
            this.Stamina = new System.Windows.Forms.Timer(this.components);
            this.labelQuestions = new System.Windows.Forms.Label();
            this.textBoxQuestions = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
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
            this.mainPlayer.Location = new System.Drawing.Point(41, 475);
            this.mainPlayer.Name = "mainPlayer";
            this.mainPlayer.Size = new System.Drawing.Size(100, 113);
            this.mainPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mainPlayer.TabIndex = 0;
            this.mainPlayer.TabStop = false;
            // 
            // MainTimer
            // 
            this.MainTimer.Enabled = true;
            this.MainTimer.Interval = 10;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // buttonE
            // 
            this.buttonE.BackColor = System.Drawing.Color.Transparent;
            this.buttonE.Image = global::FinalGame.Properties.Resources.buttonE;
            this.buttonE.Location = new System.Drawing.Point(515, 590);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(72, 42);
            this.buttonE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonE.TabIndex = 1;
            this.buttonE.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Fifaks 1.0 dev1", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(569, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = ".";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.StaminaBar);
            this.panel2.Location = new System.Drawing.Point(12, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 26);
            this.panel2.TabIndex = 12;
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
            this.panel1.TabIndex = 11;
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
            // labelQuestions
            // 
            this.labelQuestions.AutoSize = true;
            this.labelQuestions.Font = new System.Drawing.Font("Fifaks 1.0 dev1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuestions.ForeColor = System.Drawing.Color.White;
            this.labelQuestions.Location = new System.Drawing.Point(221, 290);
            this.labelQuestions.Name = "labelQuestions";
            this.labelQuestions.Size = new System.Drawing.Size(369, 38);
            this.labelQuestions.TabIndex = 14;
            this.labelQuestions.Text = "Полтора судака стоят полтора рубля. \r\nСколько стоят 13 судаков?";
            this.labelQuestions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelQuestions.Visible = false;
            // 
            // textBoxQuestions
            // 
            this.textBoxQuestions.Font = new System.Drawing.Font("Fifaks 1.0 dev1", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxQuestions.Location = new System.Drawing.Point(269, 335);
            this.textBoxQuestions.Name = "textBoxQuestions";
            this.textBoxQuestions.Size = new System.Drawing.Size(276, 26);
            this.textBoxQuestions.TabIndex = 15;
            this.textBoxQuestions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxQuestions.Visible = false;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Black;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCheck.ForeColor = System.Drawing.Color.Transparent;
            this.btnCheck.Location = new System.Drawing.Point(343, 367);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(121, 28);
            this.btnCheck.TabIndex = 16;
            this.btnCheck.Text = "Проверить";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Visible = false;
            this.btnCheck.Click += new System.EventHandler(this.Check);
            // 
            // FifthLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::FinalGame.Properties.Resources.backgroundFifthLoc;
            this.ClientSize = new System.Drawing.Size(800, 667);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.textBoxQuestions);
            this.Controls.Add(this.labelQuestions);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonE);
            this.Controls.Add(this.mainPlayer);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FifthLocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FifthLocation_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FifthLocation_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.mainPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonE)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPlayer;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.PictureBox buttonE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar StaminaBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar HealthBar;
        private System.Windows.Forms.Timer Stamina;
        private System.Windows.Forms.Label labelQuestions;
        private System.Windows.Forms.TextBox textBoxQuestions;
        private System.Windows.Forms.Button btnCheck;
    }
}