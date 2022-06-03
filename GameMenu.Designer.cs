
namespace FinalGame
{
    partial class GameMenu
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
            this.ButtonPlay = new System.Windows.Forms.PictureBox();
            this.ButtonExit = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonExit)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonPlay
            // 
            this.ButtonPlay.Image = global::FinalGame.Properties.Resources.buttonPlay1;
            this.ButtonPlay.Location = new System.Drawing.Point(254, 327);
            this.ButtonPlay.Name = "ButtonPlay";
            this.ButtonPlay.Size = new System.Drawing.Size(274, 101);
            this.ButtonPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonPlay.TabIndex = 2;
            this.ButtonPlay.TabStop = false;
            this.ButtonPlay.Click += new System.EventHandler(this.ButtonPlay_Click);
            this.ButtonPlay.MouseLeave += new System.EventHandler(this.ButtonPlay_MouseLeave);
            this.ButtonPlay.MouseHover += new System.EventHandler(this.ButtonPlay_MouseHover);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Image = global::FinalGame.Properties.Resources.buttonExit1;
            this.ButtonExit.Location = new System.Drawing.Point(249, 434);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(279, 105);
            this.ButtonExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonExit.TabIndex = 3;
            this.ButtonExit.TabStop = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            this.ButtonExit.MouseLeave += new System.EventHandler(this.ButtonExit_MouseLeave);
            this.ButtonExit.MouseHover += new System.EventHandler(this.ButtonExit_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Wander Over Yonder", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(231, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 100);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dungeon";
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::FinalGame.Properties.Resources.clearBackground;
            this.ClientSize = new System.Drawing.Size(800, 667);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonPlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameMenu";
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ButtonPlay;
        private System.Windows.Forms.PictureBox ButtonExit;
        private System.Windows.Forms.Label label2;
    }
}