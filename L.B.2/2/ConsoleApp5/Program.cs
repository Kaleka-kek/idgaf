using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            double a = rectangle.side1;
            double b = rectangle.side2;
            Program program = new Program();
            program.AreaCalculator(a,b);
            program.AreaPerimetr(a,b);
        }
        public double Area { get;}
        public double Perimeter { get; }
        public double AreaCalculator(double a, double b)
        {
            double Area = a * b;
            Console.WriteLine("Area= "+ Area);
            return Area;
        }
        public double AreaPerimetr(double a, double b)
        {
            double Perimeter = (a + b) * 2;
            Console.WriteLine("Perimeter= "+ Perimeter);
            return Perimeter;
        }
    }
    }
    class Rectangle
    {
        public double side1 { get; set; }
        public double side2 { get; set; }
        public Rectangle()
        {
            Console.WriteLine("Введите side1:");
            side1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите side2:");
            side2 = Double.Parse(Console.ReadLine());
            return;
  }
    }

