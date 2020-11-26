using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ActiveFilter(object sender, RoutedEventArgs e)
        {

            string searchString = nameFilter.Text;
            List<Article> newArticles = new List<Article>();
            newArticles = Store.article;
            newArticles = newArticles.FindAll(x => x.Name.Contains(nameFilter.Text));
            LoadArticle(newArticles);

        }
        public void LoadArticle(List<Article> article)
        {
            ArticleList.Items.Clear();  

            for (int i = 0; i < article.Count; i++)
            {
                ArticleList.Items.Add(article[i]);
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Store.article.Add(new Article(textBox1.Text, textBox2.Text, textBox3.Text));
            LoadArticle(Store.article);
        }
    }
    public class Article
    {
        public string Name { get; set; }
        public string ShopName { get; set; }
        public string Price { get; set; }

        public Article(string name, string shopName, string price)
        {
            this.Name = name;
            this.ShopName = shopName;
            this.Price = price;
        }
    }

    static class Store 
    {
        public static List<Article> article = new List<Article>();
    }
}
