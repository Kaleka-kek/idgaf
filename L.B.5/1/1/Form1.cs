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
    public partial class Form1 : Form 
    {

        bool moveRight, moveLeft;
        int speed = 12;          
        public Form1()
        {
            InitializeComponent();
            
        }     
        public virtual void MoveTimerEvent(object sender, EventArgs e)
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
        public virtual void keyisDown(object sender, KeyEventArgs e)
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


        public virtual void keyisUp(object sender, KeyEventArgs e)
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

        public virtual void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(this.textBox1.Text);
            int x1 = int.Parse(this.textBox2.Text);
            this.pictureBox1.Image = this.Draw(this.pictureBox1.Width, this.pictureBox1.Height, x, x1);
        }

        public virtual void button2_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.ShowDialog();
        }

        public virtual Bitmap Draw(int Width ,int Height,int x,int x1)
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
