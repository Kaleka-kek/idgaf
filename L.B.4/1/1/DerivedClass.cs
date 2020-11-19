using System;
using System.Collections.Generic;
using System.Text;

namespace _1
{
    class DerivedClass : BaseClass
    {
        public override void LogValueInfo(string argument)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Значение аргумента: " + argument + " Тип аргумента: " + argument.GetType());

        }
    }
}
