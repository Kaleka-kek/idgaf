using System;
using System.Collections.Generic;
using System.Text;

namespace _2
{
    class DerivedClassB_1 : B
    {
        public override void ShowArgInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Аргумент: " + arg1 + " Тип: " + arg1.GetType());
            Console.WriteLine("Аргумент: " + arg2 + " Тип: " + arg2.GetType());
        }
    }
}
