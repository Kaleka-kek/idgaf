using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Index index = new Index();
            Console.WriteLine("Укажите количество дней: ");
            Console.WriteLine(index[double.Parse(Console.ReadLine())]);
            Console.ReadKey();
        }
    }
    class Index
    {
        DateTime date = DateTime.Today;
        public DateTime this[double i]
        {
            get
            {
                return date.AddDays(i);
            }
        }
    }
}