using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
* Filipa Ivankovic
*/

//RunnerGame beginning
namespace RunnerGame
{
    public partial class GameWindow : Form
    {
        //Global variables
        bool jumping = false;
        int jumpSpeed = 12; //Speed of jumping
        int force = 12; // Jump height limit
        int score = 0; //Score board. Default set to 0
        
        int obstacleSpeed = 10;
        Random rand = new Random();
        int position;
        bool isGameOver = false;

        //Deafult positions for game elements
        readonly int playerDefaultPosition = 284;
        readonly int obstacle1Position = 281;
        readonly int obstacle2Position = 294;

        public GameWindow()
        {
            InitializeComponent();
            gameReset();
        }

        private int getPlayerDefaultPosition()
        {
            return playerDefaultPosition;
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            Player.Top += jumpSpeed;
            txtScore.Text = "Score: " + score;

            if (jumping == true && force < 0) 
            {
                jumping = false;
            }

            if (jumping == true)
            {
                jumpSpeed = -12;//Goes up player
                force -= 1;
            }
            else 
            {
                jumpSpeed = 12;
            }

            if (Player.Top > getPlayerDefaultPosition()-1 && jumping == false) 
            {
                force = 12;
                Player.Top = getPlayerDefaultPosition();
                jumpSpeed = 0;
            }

            foreach(Control obstacle in this.Controls) 
            {
                if (obstacle is PictureBox && (string)obstacle.Tag == "obstacle")
                {
                    obstacle.Left -= obstacleSpeed; //should move the obstacle to the left side of the screen

                    if (obstacle.Left < -100) //Obstacle moved out of the screen on the x axis (left screen side)
                    {
                        obstacle.Left = this.ClientSize.Width + rand.Next(200,800) + (obstacle.Width * 15);
                        score++;
                    }

                    if (Player.Bounds.IntersectsWith(obstacle.Bounds)) 
                    {
                        gameTimer.Stop();
                        Player.Image = Properties.Resources.dead;
                        txtScore.Text += "  Press R to rest the game.";
                        isGameOver = true;
                    }

                }
            }

        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }
        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            //After jumping, reset the ability to re-jump
            if (jumping == true) 
            {
                jumping = false;
            }

            //Rese functionality
            if (e.KeyCode == Keys.R && isGameOver == true) 
            {
                gameReset();
            }
        }

        private void gameReset() 
        {
            //Reset all variables to default
            force = 12;
            jumpSpeed = 0;
            jumping = false;
            score = 0;
            obstacleSpeed = 10;
            txtScore.Text = "Score: " + score;
            Player.Image = Properties.Resources.running;
            Player.Top = getPlayerDefaultPosition();
            obstacle1.Top = obstacle1Position;
            obstacle2.Top = obstacle2Position;


            foreach (Control x in this.Controls) 
            {
                if (x is PictureBox && (string)x.Tag == "obstacle") 
                {
                    position = this.ClientSize.Width + rand.Next(500, 800) + (x.Width * 10);
                    x.Left = position;
                }
            }

            gameTimer.Start();
        }//gameReset method end


    }//GameWindow main class end
}//namespace end
