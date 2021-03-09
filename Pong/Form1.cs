using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.IO;

namespace Pong
{
    public partial class frmGame : Form
    {
        //Variablendeklaration
        bool playerLeft;
        bool playerRight;
        bool ballRightDown;
        bool ballLeftDown;
        bool ballRightUp;
        bool ballLeftUp;
        int playerSpeed = 10;
        int ballSpeed = 1;
        int score;
        int highScore;


        public frmGame()
        {
            ballLeftDown = true;
            InitializeComponent();
        }

        private void TmrPlayerMovement_Tick(object sender, EventArgs e)
        {
            if (playerRight == true)
            {
                pbPlayer.Left += playerSpeed;
            }
            else if (playerLeft == true)
            {
                pbPlayer.Left -= playerSpeed;
            }
        }

        private void FrmGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                playerRight = true;
            }
            else if (e.KeyCode == Keys.Left)
            {
                playerLeft = true;
            }

            //Restart
            if (e.KeyCode == Keys.Enter)
            {
                this.Hide();
                new frmGame().Show(this);
            }

            //Quit Game
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }

            //Open 2 Player Mode
            if (e.KeyCode == Keys.D2)
            {
                this.Hide();
                new frmGame2().Show(this);
            }
        }

        private void FrmGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                playerRight = false;
            }
            else if (e.KeyCode == Keys.Left)
            {
                playerLeft = false;
            }
        }

        private void TmrCheckBorderCollision_Tick(object sender, EventArgs e)
        {
            //Check if player touches border of window
            if (pbPlayer.Bounds.IntersectsWith(pbWallLeft.Bounds))
            {
                playerLeft = false;
            }
            else if (pbPlayer.Bounds.IntersectsWith(pbWallRight.Bounds))
            {
                playerRight = false;
            }
        }

        private void TmrBallMovement_Tick(object sender, EventArgs e)
        {
            //Ball Movement
            if (ballLeftDown == true)
            {
                pbBall.Top += ballSpeed;
                pbBall.Left -= ballSpeed;
            }
            else if (ballRightDown == true)
            {
                pbBall.Top += ballSpeed;
                pbBall.Left += ballSpeed;
            }
            else if (ballLeftUp == true)
            {
                pbBall.Top -= ballSpeed;
                pbBall.Left -= ballSpeed;
            }
            else if (ballRightUp == true)
            {
                pbBall.Top -= ballSpeed;
                pbBall.Left += ballSpeed;
            }

            //Ball Change Direction
            //|
            //When touching Player
            if (pbBall.Bounds.IntersectsWith(pbPlayer.Bounds) && ballLeftDown == true)
            {
                ballLeftDown = false;
                ballLeftUp = true;
            }
            else if (pbBall.Bounds.IntersectsWith(pbPlayer.Bounds) && ballRightDown == true)
            {
                ballRightDown = false;
                ballRightUp = true;
            }

            //When touching left Wall
            if (pbBall.Bounds.IntersectsWith(pbWallLeft.Bounds) && ballLeftUp == true)
            {
                ballLeftUp = false;
                ballRightUp = true;
            }
            else if (pbBall.Bounds.IntersectsWith(pbWallLeft.Bounds) && ballLeftDown == true)
            {
                ballLeftDown = false;
                ballRightDown = true;
            }

            //When touching top Wall
            if (pbBall.Bounds.IntersectsWith(pbWallTop.Bounds) && ballRightUp == true)
            {
                ballRightUp = false;
                ballRightDown = true;
            }
            else if (pbBall.Bounds.IntersectsWith(pbWallTop.Bounds) && ballLeftUp == true)
            {
                ballLeftUp = false;
                ballLeftDown = true;
            }

            //When touching right Wall
            if (pbBall.Bounds.IntersectsWith(pbWallRight.Bounds) && ballRightDown == true)
            {
                ballRightDown = false;
                ballLeftDown = true;
            }
            else if (pbBall.Bounds.IntersectsWith(pbWallRight.Bounds) && ballRightUp == true)
            {
                ballRightUp = false;
                ballLeftUp = true;
            }
        }

        private void TmrIncreaseScore_Tick(object sender, EventArgs e)
        {
            //Increase Score and Speed of Ball
            if (pbBall.Bounds.IntersectsWith(pbPlayer.Bounds))
            {
                score++;
                lblScore.Text = Convert.ToString(score);
            }

            //Set High Score
            if (score >= highScore)
            {
                highScore = score;
                File.WriteAllText(Properties.Resources.highScore, Convert.ToString(highScore));
                lblHighScore.Text = Convert.ToString(highScore);
            }
            else
            {
                lblHighScore.Text = File.ReadAllText(Properties.Resources.highScore);
            }
        }

        private void TmrIncreaseBallSpeed_Tick(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblScore.Text) >= 10)
            {
                ballSpeed = 2;
            }

            if (Convert.ToInt32(lblScore.Text) >= 20)
            {
                ballSpeed = 3;
            }

            if (Convert.ToInt32(lblScore.Text) >= 30)
            {
                ballSpeed = 4;
            }

            if (Convert.ToInt32(lblScore.Text) >= 40)
            {
                ballSpeed = 5;
            }

            if (Convert.ToInt32(lblScore.Text) >= 50)
            {
                ballSpeed = 6;
            }
        }
    }
}
