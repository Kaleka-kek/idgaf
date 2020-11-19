using System;
using System.Collections.Generic;
using System.Text;

namespace _1
{
    class DederivedClass : BaseClass
    {
        public override void LogValueInfo(string argument)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Значение аргумента: " + argument + " Тип аргумента: " + argument.GetType());

        }
    }
}