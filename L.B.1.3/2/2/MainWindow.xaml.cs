using System;
using System.Collections.Generic;
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

namespace _2
{
    public partial class MainWindow : Window
    {
        private string String;
        Presenter presenter = new Presenter();
        public delegate string ClickEvent(string String);
        public event ClickEvent Click;
        public MainWindow()
        {
            InitializeComponent();
            Click += presenter.OperationDefine;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {   
            String = StringBox.Text;          
            Answer.Text = Click?.Invoke(String);
        }
    }
}
