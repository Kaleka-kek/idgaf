using System;
using System.Collections.Generic;
using System.Text;

namespace _2
{
    class B
    {
        public string arg1;
        public string arg2;
        public B() { arg1 = "3"; arg2 = "4"; }
        public virtual void ShowArgInfo()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Аргумент: " + arg1 + " Тип: " + arg1.GetType());
            Console.WriteLine("Аргумент: " + arg2 + " Тип: " + arg2.GetType());
        }
    }
}
