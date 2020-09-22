using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Show();
        }
    }
    class Title
    {
        public string tit { get; set; }
        public void Show()
        {   Console.ForegroundColor = ConsoleColor.Red;
            Title title = new Title();  
            Console.WriteLine("Insert Title: ");
            title.tit = Console.ReadLine();

        }
    }
    class Author
    {
        public string Aut { get; set; }
        public void Show()
        {   Console.ForegroundColor = ConsoleColor.Cyan;
            Author author = new Author();
            Console.WriteLine("Insert Author: ");
            author.Aut = Console.ReadLine();
        }
    }
    class Content
    {
        public string Con { get; set; }
        public void Show()
        {   Console.ForegroundColor = ConsoleColor.Magenta;
            Content content = new Content();  
            Console.WriteLine("Insert Content: ");        
            content.Con = Console.ReadLine();
        }
    }
    class Book
    {
        public void Show()
        {
            Title title = new Title();
            title.Show();
            Content content = new Content();
            content.Show();
            Author author = new Author();
            author.Show();
            Console.WriteLine($"Author " + author.Aut + $"   Title " + title.tit + $"   Content " + content.Con);         
        }
    }
}