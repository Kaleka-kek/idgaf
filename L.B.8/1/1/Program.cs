using System;

namespace ООП_ЛР8_З1
{
    class Program
    {
        static void Main(string[] args)
        {
            Index index = new Index();
            Console.WriteLine("Индекс вызываемого поля: ");
            Console.WriteLine(index[int.Parse(Console.ReadLine())]);
            Console.ReadKey();
        }
    }
    class Index
    {
        public string x = "Это х";
        public string y = "Это y";
        public string this[int name]
        {
            get
            {
                switch (name)
                {
                    case 0: return x;
                    case 1: return y;
                    default: return "Ошибка!";
                }
            }
        }
    }
}
