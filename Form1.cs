using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_game
{
    public partial class Form1 : Form
    {

        bool goLeft, goRight, goUp, goDown;
        int speed = 10, spawnTime = 1, blocks = 0, time = 35, score_temp = 10, counter = 1, temp_timer = 1;
        public int score = 0;
       
        Random R = new Random();
        List<PictureBox> pictureBoxList = new List<PictureBox>();
        List <Pen> graphicsList = new List<Pen>();     
        Color color = Color.FromArgb(0, 0, 0);
        public Form1()
        {      
            InitializeComponent();
            startButton.Enabled = true;
            pictureBoxArrow.Visible = true;
            gameTimer.Stop();
        }
        private void startButtonClick(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void paintForm(object sender, PaintEventArgs e)
        {

            Pen blackPen = new Pen(Color.Black, 3);

            int x1 = 100, x2 = 100, x3 = 100, x4 = 668;
            int y1 = 80, y2 = 80, y3 = 600, y4 = 602;
            int x1_1 = 668, x2_2 = 100, x3_3 = 668, x4_4 = 668;
            int y1_1 = 80, y2_2 = 602, y3_3 = 600, y4_4 = 79;

            e.Graphics.DrawLine(blackPen, x1, y1, x1_1, y1_1);
            e.Graphics.DrawLine(blackPen, x2, y2, x2_2, y2_2);
            e.Graphics.DrawLine(blackPen, x3, y3, x3_3, y3_3);
            e.Graphics.DrawLine(blackPen, x4, y4, x4_4, y4_4);
        }



        private void pictureBoxDrawingArrow(object sender, PaintEventArgs e)
        {
            //int rx1 = 720, rx2 = 720;
            //int ry1 = 40, ry2 = 80;
            int rx1 = 36, rx2 = 36;
            int ry1 = 40, ry2 = 80;

            Graphics g = e.Graphics;
            Pen redPen = new Pen(Brushes.Red, 3);
            redPen.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            
           g.DrawLine(redPen, rx2, ry2, rx1, ry1);
        }
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            if(timerLabel.Text != "Timer: 60")
            {
                temp_timer = counter / 50;
                timerLabel.Text = "Timer: " + temp_timer.ToString();
                counter++;
                if (goLeft == true && head.Left > 105)
                {
                    head.Left -= speed;
                }
                if (goRight == true && head.Left < 630)
                {
                    head.Left += speed;
                }
                if (goUp == true && head.Top > 90)
                {
                    head.Top -= speed;
                }
                if (goDown == true && head.Top < 560)
                {
                    head.Top += speed;
                }
                MakePictureBox();
            }
            else
            {              
                gameTimer.Stop();
                startButton.Enabled = true;
                pictureBoxArrow.Visible = true;
                Form2 form2 = new Form2();
                form2.Show();
                this.Visible = false;
                form2.labelYourScore.Text = "Your score: " + score;

                //MessageBox.Show("Time out " + "\n" +
                //                "Your score: " + score + "\n" + 
                //                "Press START to play again");

            }
        }
        private void MakePictureBox()
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(20, 20);

            int r = R.Next(0, 255);
            int g = R.Next(0, 255);
            int b = R.Next(0, 255);


            pictureBox.BackColor = Color.FromArgb(r,g,b);

            int x = R.Next(125, this.Size.Width - 150);
            int y = R.Next(90, this.Size.Height - 120);
            pictureBox.Location = new Point(x, y);
            spawnTime -= 1;
            if (spawnTime == 0)
            {
                Controls.Add(pictureBox);
                pictureBoxList.Add(pictureBox);
                blocks += 1;
                blockLabel.Text = "Blocks: " + blocks;
                spawnTime = time;
            }
            if (score == score_temp && time > 5)
            {
                time -= 5;
                score_temp += 10;
            }
            foreach (PictureBox item in pictureBoxList.ToList())
            {
                    if (head.Bounds.IntersectsWith(item.Bounds))
                    {
                        pictureBoxList.Remove(item);
                        Controls.Remove(item);
                    score += 1;
                    blocks -= 1;
                    scoreLabel.Text = "Score: " + score;
                    blockLabel.Text = "Blocks: " + blocks;
                    }
            }

        }
        private void ResetGame()
        {
            startButton.Enabled = false;
            gameTimer.Start();
            pictureBoxArrow.Visible = false;

            spawnTime = 1;
            time = 35;
            score_temp = 10;
            counter = 1;
            temp_timer = 1;
            temp_timer = counter;
            timerLabel.Text = "Timer: " + temp_timer.ToString();

            score = 0;
            scoreLabel.Text = "Score: " + score.ToString();

            blocks = 0;
            blockLabel.Text = "Blocks: " + blocks.ToString();

            foreach(PictureBox item in pictureBoxList.ToList())
            {
                pictureBoxList.Remove(item);
                Controls.Remove(item);
            }
            PictureBox newHead = head;
            Controls.Remove(head);
            newHead.Location = new Point(374, 306);
            newHead.Name = "head";
            Controls.Add(newHead);



        }

        }
        
    }

