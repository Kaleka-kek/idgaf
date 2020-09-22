using System;

namespace _6
{
    class Program 
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(27.91, 33.46, 0.3794);
        }
    }
    class Converter
    {
        public double usd { get; set; }
        public double eur { get; set; }
        public double rub { get; set; }
        public Converter(double usd, double eur, double rub) : base()
        {
            double ans;
            Console.WriteLine("Введите валюту в которую конвертируете(eur,usd,rub,uah)");
            string con = Console.ReadLine();
            if( con == "uah")
            {
                Console.WriteLine("Введите количество");
                double num1 = Double.Parse(Console.ReadLine());
                Console.WriteLine("валюта usd,eur или rub?");
                string uahto = Console.ReadLine();
                if (uahto == "usd")
                {
                    ans = usd / num1;
                    Console.WriteLine(ans);
                }
                if (con == "eur")
                {
                    ans = eur/num1;
                    Console.WriteLine(ans);
                }
                if (con == "rub")
                {
                    ans = rub/num1;
                    Console.WriteLine(ans);
                }
            }
            if (con == "usd")
            {
                Console.WriteLine("Введите количество");
                double num = Double.Parse(Console.ReadLine());
                ans = num / usd;
                Console.WriteLine(ans);
            }
            if (con == "eur")
            {
                Console.WriteLine("Введите количество");
                double num = Double.Parse(Console.ReadLine());
                ans = num / eur;
                Console.WriteLine(ans);
            }
            if (con == "rub")
            {
                Console.WriteLine("Введите количество");
                double num = Double.Parse(Console.ReadLine());
                ans = num / rub;
                Console.WriteLine(ans);
            }
        }
    }
}
