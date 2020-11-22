using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form2 : Form1
    {  bool moveRight, moveLeft;
            int speed = 1;

        public  Form2()
        {
            InitializeComponent();
        }


        public override void MoveTimerEvent(object sender, EventArgs e)
        {
                
                if (moveLeft == true)
                {
                    pictureBox1.Left -= speed;
                }
                if (moveRight == true)
                {
                    pictureBox1.Left += speed;
                }
            }
            public override void keyisDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Left)
                {
                    moveLeft = true;
                }
                if (e.KeyCode == Keys.Right)
                {
                    moveRight = true;
                }

            }


            public override void keyisUp(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Left)
                {
                    moveLeft = false;
                }
                if (e.KeyCode == Keys.Right)
                {
                    moveRight = false;
                }
            }

            public override void button1_Click(object sender, EventArgs e)
            {
                int x = int.Parse(this.textBox1.Text);
                int x1 = int.Parse(this.textBox2.Text);
                this.pictureBox1.Image = this.Draw(this.pictureBox1.Width, this.pictureBox1.Height, x, x1);
            }

    


        public override Bitmap Draw(int Width, int Height, int x, int x1)
            {

                var bitmap = new Bitmap(Width, Height, PixelFormat.Format32bppArgb);
                var graphics = Graphics.FromImage(bitmap);
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                int y, y1;
                y = x;
                y1 = x1;
                graphics.FillRectangle(new SolidBrush(Color.Tomato), x, y, x1, y1);
                return bitmap;
            }
        }
    }
