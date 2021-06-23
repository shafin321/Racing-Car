using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace RacingCar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gOver.Visible = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            MovingLine(carSpeed);
            Enemy(carSpeed);
            Coin(carSpeed);
            GameOver();
            CollectingCoin();
        }

        Random rand = new Random();
        int x;
        public void Enemy(int speed)
        {
            if (enemy1.Top >= 500)
            {
              x = rand.Next(0, 200); 
              enemy1.Location = new Point(x, 0);
            }
            else
            { enemy1.Top += speed; }


            if (enemy2.Top >= 500)
            { 
              x = rand.Next(210, 395); 
              enemy2.Location = new Point(x, 0);
            }
            else
            { enemy2.Top += speed; }


        }

        public void GameOver()
        {
            if (Car1.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer1.Enabled = false;
                gOver.Visible = true;
                timer2.Enabled = false;
            }


            if (Car1.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                gOver.Visible = true;
                timer2.Enabled = false;
            }


        }

        public void Coin(int speed)
        {
            if (coin1.Top >= 500)
            {
                x = rand.Next(0, 400);
                coin1.Location = new Point(x, 0);
            }
            else { coin1.Top += speed; }

            if (coin2.Top >= 500)
            {
                x = rand.Next(0, 200);
                coin2.Location = new Point(x, 0);
            }
            else { coin2.Top += speed; }

            if (coin3.Top >= 500)
            {
                x = rand.Next(50, 300);
                coin3.Location = new Point(x, 0);
            }
            else { coin3.Top += speed; }

            if (coin4.Top >= 500)
            {
                x = rand.Next(0, 200);
                coin4.Location = new Point(x, 0);
            }
            else { coin4.Top += speed; }
        }

        int countCoin = 0;
        public void CollectingCoin()
        {
            if (Car1.Bounds.IntersectsWith(coin1.Bounds))
            {
                countCoin++;
                showCoin.Text = "Coin " + countCoin.ToString();
                x = rand.Next(0, 200);
                coin1.Location = new Point(x, 0);
            }

            if (Car1.Bounds.IntersectsWith(coin2.Bounds))
            {
                countCoin++;
                showCoin.Text = "Coin " + countCoin.ToString();
                x = rand.Next(0, 400);
                coin2.Location = new Point(x, 0);
            }

            if (Car1.Bounds.IntersectsWith(coin3.Bounds))
            {
                countCoin++;
                showCoin.Text = "Coin " + countCoin.ToString();
                x = rand.Next(50, 300);
                coin3.Location = new Point(x, 0);
            }

            if (Car1.Bounds.IntersectsWith(coin4.Bounds))
            {
                countCoin++;
                showCoin.Text = "Coin " + countCoin.ToString();
                x = rand.Next(200, 400);
                coin4.Location = new Point(x, 0);
            }

        }
        public void MovingLine(int speed)
        {
            if (pictureBox1.Top >= 500)
            { pictureBox1.Top = 0; }
            else
            { pictureBox1.Top += speed; }

            if (pictureBox2.Top >= 500)
            { pictureBox2.Top = 0; }
            else
            { pictureBox2.Top += speed; }

            if (pictureBox3.Top >= 500)
            { pictureBox3.Top = 0; }
            else
            { pictureBox3.Top += speed; }

            if (pictureBox4.Top >= 500)
            { pictureBox4.Top = 0; }
            else
            { pictureBox4.Top += speed; }
        }

        int carSpeed = 0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                if (e.KeyCode == Keys.Left)
            {
                if (Car1.Left >= 12)
                    Car1.Left += -20;
            }

            if (e.KeyCode == Keys.Right)
            {
                if (Car1.Right < 376)
                    Car1.Left += 20;
            }

            if (e.KeyCode == Keys.Up)
                if (carSpeed < 21)
                { carSpeed++; }


            if (e.KeyCode == Keys.Down)
                if (carSpeed > 0)
                { carSpeed--; }

        }

        int second = 0;
        int minute = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            second++;
            if (second >=60)
            {
                minute++;
                second = 0;
            }
            playingTime.Text = minute + ": " + second;
        }

    }
}
