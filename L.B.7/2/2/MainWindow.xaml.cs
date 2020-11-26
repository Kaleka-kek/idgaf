using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random(unchecked((int)(DateTime.Now.Ticks)));
            var m = new Matrix2x<int>();
            m.ColCount = Int32.Parse(textBox1.Text);
            m.RowCount = Int32.Parse(textBox2.Text);

            var args = new MatrixArgument<int>[m.ColCount, m.RowCount];
            var value = 0;
            var min = 10000000000000000;
            var max = 0;
            var ave = 0;
            var sum = 0;
            var counter = 0;
            for (int i = 0; i < m.ColCount; i++)
            {
                for (int j = 0; j < m.RowCount; j++)
                {
                    value = rnd.Next(0, 100);
                    args[i, j] = new MatrixArgument<int>(value);
                    if (value < min) min = value;
                    if (value > max) max = value;
                    sum += value;
                    counter++;
                }
            }
            m.Arguments = args;
            this.DataContext = m;
            textBox4.Text = sum.ToString();
            ave = sum / counter;
            textBox3.Text = ave.ToString();


        }
        public class Matrix2x<T> where T : struct
        {
            public MatrixArgument<T>[,] Arguments { get; set; }

            public IEnumerable<MatrixArgument<T>> LinearArguments
            {
                get
                {
                    foreach (var arg in this.Arguments)
                    {
                        yield return arg;
                    }
                }
            }
            public int RowCount { get; set; }

            public int ColCount { get; set; }
        }

        public class MatrixArgument<T> where T : struct
        {
            public MatrixArgument(T value)
            {
                Value = value;
            }

            public T Value { get; set; }
        }
    }
}



