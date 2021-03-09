namespace Pong
{
    partial class frmGame2
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
            this.pbWallLeft = new System.Windows.Forms.PictureBox();
            this.pbWallRight = new System.Windows.Forms.PictureBox();
            this.pbWallTop = new System.Windows.Forms.PictureBox();
            this.pbWallBottom = new System.Windows.Forms.PictureBox();
            this.pbPlayer1 = new System.Windows.Forms.PictureBox();
            this.pbPlayer2 = new System.Windows.Forms.PictureBox();
            this.pbBall = new System.Windows.Forms.PictureBox();
            this.tmrMovement = new System.Windows.Forms.Timer(this.components);
            this.tmrBallMovement = new System.Windows.Forms.Timer(this.components);
            this.tmrCheckBorderCollision = new System.Windows.Forms.Timer(this.components);
            this.lblScorePlayer2 = new System.Windows.Forms.Label();
            this.lblScorePlayer1 = new System.Windows.Forms.Label();
            this.tmrIncreaseScore = new System.Windows.Forms.Timer(this.components);
            this.tmrIncreaseBallSpeed = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbWallLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWallRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWallTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWallBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBall)).BeginInit();
            this.SuspendLayout();
            // 
            // pbWallLeft
            // 
            this.pbWallLeft.Location = new System.Drawing.Point(0, 0);
            this.pbWallLeft.Name = "pbWallLeft";
            this.pbWallLeft.Size = new System.Drawing.Size(10, 450);
            this.pbWallLeft.TabIndex = 0;
            this.pbWallLeft.TabStop = false;
            // 
            // pbWallRight
            // 
            this.pbWallRight.Location = new System.Drawing.Point(790, 0);
            this.pbWallRight.Name = "pbWallRight";
            this.pbWallRight.Size = new System.Drawing.Size(10, 450);
            this.pbWallRight.TabIndex = 1;
            this.pbWallRight.TabStop = false;
            // 
            // pbWallTop
            // 
            this.pbWallTop.Location = new System.Drawing.Point(-1, 0);
            this.pbWallTop.Name = "pbWallTop";
            this.pbWallTop.Size = new System.Drawing.Size(802, 10);
            this.pbWallTop.TabIndex = 2;
            this.pbWallTop.TabStop = false;
            // 
            // pbWallBottom
            // 
            this.pbWallBottom.Location = new System.Drawing.Point(0, 440);
            this.pbWallBottom.Name = "pbWallBottom";
            this.pbWallBottom.Size = new System.Drawing.Size(802, 10);
            this.pbWallBottom.TabIndex = 3;
            this.pbWallBottom.TabStop = false;
            // 
            // pbPlayer1
            // 
            this.pbPlayer1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbPlayer1.Location = new System.Drawing.Point(341, 385);
            this.pbPlayer1.Name = "pbPlayer1";
            this.pbPlayer1.Size = new System.Drawing.Size(90, 16);
            this.pbPlayer1.TabIndex = 4;
            this.pbPlayer1.TabStop = false;
            // 
            // pbPlayer2
            // 
            this.pbPlayer2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbPlayer2.Location = new System.Drawing.Point(341, 40);
            this.pbPlayer2.Name = "pbPlayer2";
            this.pbPlayer2.Size = new System.Drawing.Size(90, 16);
            this.pbPlayer2.TabIndex = 5;
            this.pbPlayer2.TabStop = false;
            // 
            // pbBall
            // 
            this.pbBall.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbBall.Location = new System.Drawing.Point(421, 341);
            this.pbBall.Name = "pbBall";
            this.pbBall.Size = new System.Drawing.Size(10, 10);
            this.pbBall.TabIndex = 6;
            this.pbBall.TabStop = false;
            // 
            // tmrMovement
            // 
            this.tmrMovement.Enabled = true;
            this.tmrMovement.Interval = 1;
            this.tmrMovement.Tick += new System.EventHandler(this.TmrMovement_Tick);
            // 
            // tmrBallMovement
            // 
            this.tmrBallMovement.Enabled = true;
            this.tmrBallMovement.Interval = 1;
            this.tmrBallMovement.Tick += new System.EventHandler(this.TmrBallMovement_Tick);
            // 
            // tmrCheckBorderCollision
            // 
            this.tmrCheckBorderCollision.Enabled = true;
            this.tmrCheckBorderCollision.Interval = 1;
            this.tmrCheckBorderCollision.Tick += new System.EventHandler(this.TmrCheckBorderCollision_Tick);
            // 
            // lblScorePlayer2
            // 
            this.lblScorePlayer2.AutoSize = true;
            this.lblScorePlayer2.Location = new System.Drawing.Point(16, 13);
            this.lblScorePlayer2.Name = "lblScorePlayer2";
            this.lblScorePlayer2.Size = new System.Drawing.Size(18, 20);
            this.lblScorePlayer2.TabIndex = 7;
            this.lblScorePlayer2.Text = "0";
            // 
            // lblScorePlayer1
            // 
            this.lblScorePlayer1.AutoSize = true;
            this.lblScorePlayer1.Location = new System.Drawing.Point(766, 417);
            this.lblScorePlayer1.Name = "lblScorePlayer1";
            this.lblScorePlayer1.Size = new System.Drawing.Size(18, 20);
            this.lblScorePlayer1.TabIndex = 8;
            this.lblScorePlayer1.Text = "0";
            // 
            // tmrIncreaseScore
            // 
            this.tmrIncreaseScore.Enabled = true;
            this.tmrIncreaseScore.Interval = 1;
            this.tmrIncreaseScore.Tick += new System.EventHandler(this.TmrIncreaseScore_Tick);
            // 
            // tmrIncreaseBallSpeed
            // 
            this.tmrIncreaseBallSpeed.Enabled = true;
            this.tmrIncreaseBallSpeed.Interval = 1;
            this.tmrIncreaseBallSpeed.Tick += new System.EventHandler(this.TmrIncreaseBallSpeed_Tick);
            // 
            // frmGame2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblScorePlayer1);
            this.Controls.Add(this.lblScorePlayer2);
            this.Controls.Add(this.pbBall);
            this.Controls.Add(this.pbPlayer2);
            this.Controls.Add(this.pbPlayer1);
            this.Controls.Add(this.pbWallBottom);
            this.Controls.Add(this.pbWallTop);
            this.Controls.Add(this.pbWallRight);
            this.Controls.Add(this.pbWallLeft);
            this.Name = "frmGame2";
            this.Text = "Pong 2 Player";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmGame2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmGame2_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbWallLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWallRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWallTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWallBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbWallLeft;
        private System.Windows.Forms.PictureBox pbWallRight;
        private System.Windows.Forms.PictureBox pbWallTop;
        private System.Windows.Forms.PictureBox pbWallBottom;
        private System.Windows.Forms.PictureBox pbPlayer1;
        private System.Windows.Forms.PictureBox pbPlayer2;
        private System.Windows.Forms.PictureBox pbBall;
        private System.Windows.Forms.Timer tmrMovement;
        private System.Windows.Forms.Timer tmrBallMovement;
        private System.Windows.Forms.Timer tmrCheckBorderCollision;
        private System.Windows.Forms.Label lblScorePlayer2;
        private System.Windows.Forms.Label lblScorePlayer1;
        private System.Windows.Forms.Timer tmrIncreaseScore;
        private System.Windows.Forms.Timer tmrIncreaseBallSpeed;
    }
}