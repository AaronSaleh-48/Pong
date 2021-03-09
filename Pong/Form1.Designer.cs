namespace Pong
{
    partial class frmGame
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pbBall = new System.Windows.Forms.PictureBox();
            this.tmrPlayerMovement = new System.Windows.Forms.Timer(this.components);
            this.tmrCheckBorderCollision = new System.Windows.Forms.Timer(this.components);
            this.pbWallLeft = new System.Windows.Forms.PictureBox();
            this.pbWallRight = new System.Windows.Forms.PictureBox();
            this.pbWallTop = new System.Windows.Forms.PictureBox();
            this.tmrBallMovement = new System.Windows.Forms.Timer(this.components);
            this.tmrIncreaseScore = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.lblHighScoreText = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.tmrIncreaseBallSpeed = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWallLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWallRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWallTop)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbPlayer.Location = new System.Drawing.Point(170, 219);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(100, 16);
            this.pbPlayer.TabIndex = 0;
            this.pbPlayer.TabStop = false;
            // 
            // pbBall
            // 
            this.pbBall.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbBall.Location = new System.Drawing.Point(260, 165);
            this.pbBall.Name = "pbBall";
            this.pbBall.Size = new System.Drawing.Size(10, 10);
            this.pbBall.TabIndex = 1;
            this.pbBall.TabStop = false;
            // 
            // tmrPlayerMovement
            // 
            this.tmrPlayerMovement.Enabled = true;
            this.tmrPlayerMovement.Interval = 1;
            this.tmrPlayerMovement.Tick += new System.EventHandler(this.TmrPlayerMovement_Tick);
            // 
            // tmrCheckBorderCollision
            // 
            this.tmrCheckBorderCollision.Enabled = true;
            this.tmrCheckBorderCollision.Interval = 1;
            this.tmrCheckBorderCollision.Tick += new System.EventHandler(this.TmrCheckBorderCollision_Tick);
            // 
            // pbWallLeft
            // 
            this.pbWallLeft.Location = new System.Drawing.Point(0, 0);
            this.pbWallLeft.Name = "pbWallLeft";
            this.pbWallLeft.Size = new System.Drawing.Size(10, 264);
            this.pbWallLeft.TabIndex = 2;
            this.pbWallLeft.TabStop = false;
            // 
            // pbWallRight
            // 
            this.pbWallRight.Location = new System.Drawing.Point(584, 0);
            this.pbWallRight.Name = "pbWallRight";
            this.pbWallRight.Size = new System.Drawing.Size(10, 264);
            this.pbWallRight.TabIndex = 3;
            this.pbWallRight.TabStop = false;
            // 
            // pbWallTop
            // 
            this.pbWallTop.Location = new System.Drawing.Point(7, 0);
            this.pbWallTop.Name = "pbWallTop";
            this.pbWallTop.Size = new System.Drawing.Size(578, 10);
            this.pbWallTop.TabIndex = 4;
            this.pbWallTop.TabStop = false;
            // 
            // tmrBallMovement
            // 
            this.tmrBallMovement.Enabled = true;
            this.tmrBallMovement.Interval = 1;
            this.tmrBallMovement.Tick += new System.EventHandler(this.TmrBallMovement_Tick);
            // 
            // tmrIncreaseScore
            // 
            this.tmrIncreaseScore.Enabled = true;
            this.tmrIncreaseScore.Interval = 1;
            this.tmrIncreaseScore.Tick += new System.EventHandler(this.TmrIncreaseScore_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(564, 13);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(18, 20);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "0";
            // 
            // lblHighScoreText
            // 
            this.lblHighScoreText.AutoSize = true;
            this.lblHighScoreText.Location = new System.Drawing.Point(16, 13);
            this.lblHighScoreText.Name = "lblHighScoreText";
            this.lblHighScoreText.Size = new System.Drawing.Size(96, 20);
            this.lblHighScoreText.TabIndex = 6;
            this.lblHighScoreText.Text = "High Score: ";
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.Location = new System.Drawing.Point(118, 13);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(14, 20);
            this.lblHighScore.TabIndex = 7;
            this.lblHighScore.Text = "-";
            // 
            // tmrIncreaseBallSpeed
            // 
            this.tmrIncreaseBallSpeed.Enabled = true;
            this.tmrIncreaseBallSpeed.Interval = 1;
            this.tmrIncreaseBallSpeed.Tick += new System.EventHandler(this.TmrIncreaseBallSpeed_Tick);
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 264);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.lblHighScoreText);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pbWallTop);
            this.Controls.Add(this.pbWallRight);
            this.Controls.Add(this.pbWallLeft);
            this.Controls.Add(this.pbBall);
            this.Controls.Add(this.pbPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmGame";
            this.Text = "Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmGame_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWallLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWallRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWallTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.PictureBox pbBall;
        private System.Windows.Forms.Timer tmrPlayerMovement;
        private System.Windows.Forms.Timer tmrCheckBorderCollision;
        private System.Windows.Forms.PictureBox pbWallLeft;
        private System.Windows.Forms.PictureBox pbWallRight;
        private System.Windows.Forms.PictureBox pbWallTop;
        private System.Windows.Forms.Timer tmrBallMovement;
        private System.Windows.Forms.Timer tmrIncreaseScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblHighScoreText;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Timer tmrIncreaseBallSpeed;
    }
}

