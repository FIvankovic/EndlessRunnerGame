
namespace RunnerGame
{
    partial class GameWindow
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
            this.txtScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.obstacle1 = new System.Windows.Forms.PictureBox();
            this.obstacle2 = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(12, 9);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(135, 33);
            this.txtScore.TabIndex = 2;
            this.txtScore.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // obstacle1
            // 
            this.obstacle1.Image = global::RunnerGame.Properties.Resources.obstacle_11;
            this.obstacle1.Location = new System.Drawing.Point(498, 357);
            this.obstacle1.Name = "obstacle1";
            this.obstacle1.Size = new System.Drawing.Size(23, 46);
            this.obstacle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obstacle1.TabIndex = 6;
            this.obstacle1.TabStop = false;
            this.obstacle1.Tag = "obstacle";
            // 
            // obstacle2
            // 
            this.obstacle2.Image = global::RunnerGame.Properties.Resources.obstacle_2;
            this.obstacle2.Location = new System.Drawing.Point(586, 370);
            this.obstacle2.Name = "obstacle2";
            this.obstacle2.Size = new System.Drawing.Size(32, 33);
            this.obstacle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obstacle2.TabIndex = 5;
            this.obstacle2.TabStop = false;
            this.obstacle2.Tag = "obstacle";
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = global::RunnerGame.Properties.Resources.running;
            this.Player.Location = new System.Drawing.Point(106, 360);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(40, 43);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player.TabIndex = 3;
            this.Player.TabStop = false;
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.Black;
            this.ground.Location = new System.Drawing.Point(0, 402);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(802, 50);
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.obstacle1);
            this.Controls.Add(this.obstacle2);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.ground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "GameWindow";
            this.Text = "Endless Runner Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox obstacle2;
        private System.Windows.Forms.PictureBox obstacle1;
    }
}

