using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form2 : Form1
    {
        public Form2()
        {
            InitializeComponent();
            Form1 fm1 = new Form1();
            fm1.ShowDialog();
        }

        public override void button1_Click(object sender, EventArgs e)
        {
            double r = double.Parse(textBox6.Text);
            double R = double.Parse(textBox1.Text);
            double H = double.Parse(textBox2.Text);
            double V = ((3.14 * (Math.Pow(R, 2)*R* r *Math.Pow(r, 2)) * H)) / 3;
            textBox3.Text = V.ToString();
            double S = (3.14 * Math.Pow(R, 2));
            textBox4.Text = S.ToString();
        }
    }
}
