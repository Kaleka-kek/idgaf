using System;

namespace _2
{
    class Program
    {
        public delegate double Useless(double z, double x);
        private static void Main()
        {
            Console.WriteLine("Введите значение z:");
            double z = Int64.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение x:");
            double x = Int64.Parse(Console.ReadLine());
            Console.WriteLine("Выберите операцию (+,-,*,/):");
            string znak = Console.ReadLine();
            if (znak == "+")
            {
                Useless useless = (z,x) => { return z + x; };
                Console.WriteLine(useless(z, x));
            }
            if (znak == "-")
            {
                Useless useless = (z, x) => { return z - x; };
                Console.WriteLine(useless(z,x));
            }
            if (znak == "*")
            {
                Useless useless = (z, x) => { return z * x; };
                Console.WriteLine(useless(z, x));
            }
            if (znak == "/")
            {
                if (x == 0)
                {
                    Console.WriteLine("Ошибка,деление на 0");
                }
                else
                {
                    Useless useless = (z, x) => { return z / x; };
                    Console.WriteLine(useless(z, x));
                }
            }
        }
    }
}
