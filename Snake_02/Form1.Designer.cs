namespace Snake_02
{
    partial class Form1
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
            this.labGameOver = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gameZone = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.progressTime = new System.Windows.Forms.ProgressBar();
            this.labProgress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gameZone)).BeginInit();
            this.SuspendLayout();
            // 
            // labGameOver
            // 
            this.labGameOver.AutoSize = true;
            this.labGameOver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labGameOver.Font = new System.Drawing.Font("Ink Free", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGameOver.Location = new System.Drawing.Point(212, 230);
            this.labGameOver.Name = "labGameOver";
            this.labGameOver.Size = new System.Drawing.Size(346, 79);
            this.labGameOver.TabIndex = 9;
            this.labGameOver.Text = "Game Over";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(290, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 79);
            this.label2.TabIndex = 8;
            this.label2.Text = "Snake";
            // 
            // labScore
            // 
            this.labScore.AutoSize = true;
            this.labScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labScore.Location = new System.Drawing.Point(688, 57);
            this.labScore.Name = "labScore";
            this.labScore.Size = new System.Drawing.Size(51, 20);
            this.labScore.TabIndex = 7;
            this.labScore.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(665, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Score:";
            // 
            // gameZone
            // 
            this.gameZone.BackColor = System.Drawing.Color.Yellow;
            this.gameZone.Location = new System.Drawing.Point(0, 117);
            this.gameZone.Name = "gameZone";
            this.gameZone.Size = new System.Drawing.Size(800, 318);
            this.gameZone.TabIndex = 5;
            this.gameZone.TabStop = false;
            this.gameZone.Paint += new System.Windows.Forms.PaintEventHandler(this.gameZone_Paint);
            // 
            // progressTime
            // 
            this.progressTime.Location = new System.Drawing.Point(26, 45);
            this.progressTime.Name = "progressTime";
            this.progressTime.Size = new System.Drawing.Size(200, 40);
            this.progressTime.Step = 1;
            this.progressTime.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressTime.TabIndex = 0;
            // 
            // labProgress
            // 
            this.labProgress.AutoSize = true;
            this.labProgress.Font = new System.Drawing.Font("Sylfaen", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labProgress.Location = new System.Drawing.Point(7, 15);
            this.labProgress.Name = "labProgress";
            this.labProgress.Size = new System.Drawing.Size(289, 27);
            this.labProgress.TabIndex = 11;
            this.labProgress.Text = "Hurry up before time runs out!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labProgress);
            this.Controls.Add(this.progressTime);
            this.Controls.Add(this.labGameOver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameZone);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.gameZone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labGameOver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox gameZone;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.ProgressBar progressTime;
        private System.Windows.Forms.Label labProgress;
    }
}

