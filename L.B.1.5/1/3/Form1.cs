using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        public int I;
        public int J;
        public Form1()
        {
            InitializeComponent();
        }

        public virtual void button1_Click(object sender, EventArgs e)
        {
            I = Convert.ToInt32(textBox1.Text);
            J = Convert.ToInt32(textBox2.Text);

            dataGridView1.RowCount = J;
            dataGridView1.ColumnCount = I;
            Mat mat = new Mat(I,J);            
            int[,] array = mat.ReturnArray();
            for (int i = 0; i < J; i++)
            for (int j = 0; j < I; j++)
                dataGridView1.Rows[i].Cells[j].Value = array[i, j];
        }

        public virtual void button3_Click(object sender, EventArgs e)
        {
            I = Convert.ToInt32(textBox1.Text);
            J = Convert.ToInt32(textBox2.Text);

            dataGridView1.RowCount = J;
            dataGridView1.ColumnCount = I;
            UnitMatrix unmat = new UnitMatrix(I,J); 
            int[,] array = unmat.ReturnArray();
            for (int i = 0; i < J; i++)
            for (int j = 0; j < I; j++)
                dataGridView1.Rows[i].Cells[j].Value = array[i, j];
        }
        public virtual void button2_Click(object sender, EventArgs e)
        {
            I = Convert.ToInt32(textBox1.Text);
            J = Convert.ToInt32(textBox2.Text);

            dataGridView1.RowCount = J;
            dataGridView1.ColumnCount = I;
            UpTriangleMat uttrix = new UpTriangleMat(I, J);
            int[,] array = uttrix.ReturnArray();
            for (int i = 0; i < J; i++)
            for (int j = 0; j < I; j++)
                dataGridView1.Rows[i].Cells[j].Value = array[i, j];
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    class Mat
    {
        private int I;
        private int J;
        public Mat(int i, int j)
        {
            I = i;
            J = j;
        }

        public virtual int[,] ReturnArray()
        {
            Random rnd = new Random();
            int[,] array = new int[J, I];
            for (int i = 0; i < J; i++)
            for (int j = 0; j < I; j++)
                array[i, j] = rnd.Next(0, 150);
            return array;
        }
    }
    class UpTriangleMat : Mat
    {
        private int I;
        private int J;

        public UpTriangleMat(int i, int j) : base(i, j)
        {
            I = i;
            J = j;
        }

        public override int[,] ReturnArray()
        {
            Random rnd = new Random();
            int[,] array = new int[J, I];
            for (int i = 0; i < I; i++)
            {
                for (int j = 0; j < J; j++)
                {
                    if (i > j)
                    {
                        array[i, j] = 0;
                    }
                    else
                    {
                        array[i, j] = rnd.Next(0, 150);
                    }

                }
            }

            return array;
        }
    }
    class UnitMatrix : Mat
    {
        private int I;
        private int J;
        public UnitMatrix(int i, int j) : base(i, j)
        {
            I = i;
            J = j;
        }
        public override int[,] ReturnArray()
        {
            int[,] array = new int[J, I];
            for (int i = 0; i < I; i++)
            {
                for (int j = 0; j < J; j++)
                {
                    if (i == j)
                    {
                        array[i, j] = 1;
                    }
                    else
                    {
                        array[i, j] = 0;
                    }

                }
            }
            return array;
        }
    }
    
}
