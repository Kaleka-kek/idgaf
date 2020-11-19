using System;
using System.Collections.Generic;
using System.Text;

namespace _1
{
    class BaseClass
    {
        public string argument;
        public virtual void LogValueInfo(string argument)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Значение аргумента: " + argument + " Тип аргумента: " + argument.GetType());
        }
    }
}
