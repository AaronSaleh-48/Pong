using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class frmGame2 : Form
    {
        //Variablendeklaration
        bool right1;
        bool left1;
        bool right2;
        bool left2;
        bool ballLeftDown = true;
        bool ballLeftUp;
        bool ballRightDown;
        bool ballRightUp;
        int ballSpeed = 1;
        int playerSpeed = 10;
        int scorePlayer1;
        int scorePlayer2;

        public frmGame2()
        {
            InitializeComponent();
        }

        private void TmrMovement_Tick(object sender, EventArgs e)
        {
            //Player 1
            if (right1 == true)
            {
                pbPlayer1.Left += playerSpeed;
            }
            else if (left1 == true)
            {
                pbPlayer1.Left -= playerSpeed;
            }

            //Player 2
            if (right2 == true)
            {
                pbPlayer2.Left += playerSpeed;
            }
            else if (left2 == true)
            {
                pbPlayer2.Left -= playerSpeed;
            }
        }

        private void FrmGame2_KeyDown(object sender, KeyEventArgs e)
        {
            //Player 1
            if (e.KeyCode == Keys.Left)
            {
                left1 = true;
            }
            else if (e.KeyCode == Keys.Right)
            {
                right1 = true;
            }

            //Player2 
            if (e.KeyCode == Keys.A)
            {
                left2 = true;
            }
            else if (e.KeyCode == Keys.D)
            {
                right2 = true;
            }
        }

        private void FrmGame2_KeyUp(object sender, KeyEventArgs e)
        {
            //Player 1
            if (e.KeyCode == Keys.Left)
            {
                left1 = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                right1 = false;
            }

            //Player2 
            if (e.KeyCode == Keys.A)
            {
                left2 = false;
            }
            else if (e.KeyCode == Keys.D)
            {
                right2 = false;
            }

            //Quit Game
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }

            //Restart
            if (e.KeyCode == Keys.Enter)
            {
                this.Hide();
                new frmGame2().Show();
            }

            //Open 1 Player Mode
            if (e.KeyCode == Keys.D1)
            {
                this.Hide();
                new frmGame().Show();
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
            //When touching Player 1
            if (pbBall.Bounds.IntersectsWith(pbPlayer1.Bounds) && ballLeftDown == true)
            {
                ballLeftDown = false;
                ballLeftUp = true;
            }
            else if (pbBall.Bounds.IntersectsWith(pbPlayer1.Bounds) && ballRightDown == true)
            {
                ballRightDown = false;
                ballRightUp = true;
            }

            //When touching Player 2
            if (pbBall.Bounds.IntersectsWith(pbPlayer2.Bounds) && ballLeftUp == true)
            {
                ballLeftDown = true;
                ballLeftUp = false;
            }
            else if (pbBall.Bounds.IntersectsWith(pbPlayer2.Bounds) && ballRightUp == true)
            {
                ballRightDown = true;
                ballRightUp = false;
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

        private void TmrCheckBorderCollision_Tick(object sender, EventArgs e)
        {
            //Check if Player 1 touches Border
            if (pbPlayer1.Bounds.IntersectsWith(pbWallLeft.Bounds))
            {
                left1 = false;
            }
            else if (pbPlayer1.Bounds.IntersectsWith(pbWallRight.Bounds))
            {
                right1 = false;
            }

            //Check if Player 2 touches Border
            if (pbPlayer2.Bounds.IntersectsWith(pbWallLeft.Bounds))
            {
                left2 = false;
            }
            else if (pbPlayer2.Bounds.IntersectsWith(pbWallRight.Bounds))
            {
                right2 = false;
            }
        }

        private void TmrIncreaseScore_Tick(object sender, EventArgs e)
        {
            //Increase Score of Player 1
            if (pbBall.Bounds.IntersectsWith(pbWallBottom.Bounds))
            {
                scorePlayer2++;
                lblScorePlayer2.Text = Convert.ToString(scorePlayer2);
                ballSpeed = 1;
                pbBall.Location = new Point(300, 150);
            }

            //Increase Score of Player 1
            if (pbBall.Bounds.IntersectsWith(pbWallTop.Bounds))
            {
                scorePlayer1++;
                lblScorePlayer1.Text = Convert.ToString(scorePlayer1);
                ballSpeed = 1;
                pbBall.Location = new Point(300, 150);
            }
        }

        private void TmrIncreaseBallSpeed_Tick(object sender, EventArgs e)
        {
            //Increase Ball Speed
            if ((pbBall.Bounds.IntersectsWith(pbPlayer1.Bounds) || 
                pbBall.Bounds.IntersectsWith(pbPlayer2.Bounds)) && ballSpeed < 6)
            {
                ballSpeed++;
            }
        }
    }
}
