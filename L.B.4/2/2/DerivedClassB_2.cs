using System;
using System.Collections.Generic;
using System.Text;

namespace _2
{
    partial class DerivedClassB_2 : B
    {
        public override void ShowArgInfo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Аргумент: " + arg1 + " Тип: " + arg1.GetType());
            Console.WriteLine("Аргумент: " + arg2 + " Тип: " + arg2.GetType());
        }
    }
}
