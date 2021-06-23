namespace RacingCar
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gOver = new System.Windows.Forms.Label();
            this.coin1 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Car1 = new System.Windows.Forms.PictureBox();
            this.coin2 = new System.Windows.Forms.PictureBox();
            this.coin3 = new System.Windows.Forms.PictureBox();
            this.coin4 = new System.Windows.Forms.PictureBox();
            this.showCoin = new System.Windows.Forms.Label();
            this.playingTime = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin4)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gOver
            // 
            this.gOver.AutoSize = true;
            this.gOver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gOver.ForeColor = System.Drawing.Color.Aqua;
            this.gOver.Location = new System.Drawing.Point(145, 214);
            this.gOver.Name = "gOver";
            this.gOver.Size = new System.Drawing.Size(116, 24);
            this.gOver.TabIndex = 30;
            this.gOver.Text = "Game Over";
            // 
            // coin1
            // 
            this.coin1.Image = global::RacingCar.Properties.Resources.coin;
            this.coin1.Location = new System.Drawing.Point(43, 50);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(25, 28);
            this.coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coin1.TabIndex = 31;
            this.coin1.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.enemy1.Image = global::RacingCar.Properties.Resources.car_enemy2;
            this.enemy1.Location = new System.Drawing.Point(39, 159);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(29, 61);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemy1.TabIndex = 28;
            this.enemy1.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.enemy2.Image = global::RacingCar.Properties.Resources.car_enemy2;
            this.enemy2.Location = new System.Drawing.Point(287, 178);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(26, 64);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemy2.TabIndex = 27;
            this.enemy2.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Red;
            this.pictureBox6.Location = new System.Drawing.Point(0, -1);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(6, 465);
            this.pictureBox6.TabIndex = 26;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Red;
            this.pictureBox5.Location = new System.Drawing.Point(377, -1);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(6, 465);
            this.pictureBox5.TabIndex = 25;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(189, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(6, 100);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pictureBox4.Location = new System.Drawing.Point(189, 364);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(6, 100);
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox3.Location = new System.Drawing.Point(189, 241);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(6, 100);
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pictureBox2.Location = new System.Drawing.Point(189, 120);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(6, 100);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // Car1
            // 
            this.Car1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Car1.Image = global::RacingCar.Properties.Resources.car;
            this.Car1.Location = new System.Drawing.Point(93, 271);
            this.Car1.Name = "Car1";
            this.Car1.Size = new System.Drawing.Size(34, 81);
            this.Car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Car1.TabIndex = 20;
            this.Car1.TabStop = false;
            // 
            // coin2
            // 
            this.coin2.Image = global::RacingCar.Properties.Resources.coin;
            this.coin2.Location = new System.Drawing.Point(129, 111);
            this.coin2.Name = "coin2";
            this.coin2.Size = new System.Drawing.Size(25, 28);
            this.coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coin2.TabIndex = 32;
            this.coin2.TabStop = false;
            // 
            // coin3
            // 
            this.coin3.Image = global::RacingCar.Properties.Resources.coin;
            this.coin3.Location = new System.Drawing.Point(236, 146);
            this.coin3.Name = "coin3";
            this.coin3.Size = new System.Drawing.Size(25, 28);
            this.coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coin3.TabIndex = 33;
            this.coin3.TabStop = false;
            // 
            // coin4
            // 
            this.coin4.Image = global::RacingCar.Properties.Resources.coin;
            this.coin4.Location = new System.Drawing.Point(324, 50);
            this.coin4.Name = "coin4";
            this.coin4.Size = new System.Drawing.Size(25, 28);
            this.coin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coin4.TabIndex = 34;
            this.coin4.TabStop = false;
            // 
            // showCoin
            // 
            this.showCoin.AutoSize = true;
            this.showCoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showCoin.ForeColor = System.Drawing.Color.Aqua;
            this.showCoin.Location = new System.Drawing.Point(12, -1);
            this.showCoin.Name = "showCoin";
            this.showCoin.Size = new System.Drawing.Size(55, 16);
            this.showCoin.TabIndex = 35;
            this.showCoin.Text = "Coin=0";
            // 
            // playingTime
            // 
            this.playingTime.AutoSize = true;
            this.playingTime.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.playingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playingTime.ForeColor = System.Drawing.Color.Aqua;
            this.playingTime.Location = new System.Drawing.Point(321, -1);
            this.playingTime.Name = "playingTime";
            this.playingTime.Size = new System.Drawing.Size(44, 16);
            this.playingTime.TabIndex = 36;
            this.playingTime.Text = "00:00";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.playingTime);
            this.Controls.Add(this.showCoin);
            this.Controls.Add(this.coin4);
            this.Controls.Add(this.coin3);
            this.Controls.Add(this.coin2);
            this.Controls.Add(this.coin1);
            this.Controls.Add(this.gOver);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Car1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Car1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.Label gOver;
        private System.Windows.Forms.PictureBox coin1;
        private System.Windows.Forms.PictureBox coin2;
        private System.Windows.Forms.PictureBox coin3;
        private System.Windows.Forms.PictureBox coin4;
        private System.Windows.Forms.Label showCoin;
        private System.Windows.Forms.Label playingTime;
        private System.Windows.Forms.Timer timer2;
    }
}

