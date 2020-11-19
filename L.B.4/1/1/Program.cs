using System;
using System.Diagnostics;

namespace _1
{
        class Program
        {
            static void Main(string[] args)
            {
                BaseClass baseclass = new BaseClass(); 
                baseclass.argument = "Понимаю";
                baseclass.LogValueInfo(baseclass.argument);
                DerivedClass derivedclass = new DerivedClass();
                derivedclass.LogValueInfo(baseclass.argument);
                DederivedClass dederivedclass = new DederivedClass();
                dederivedclass.LogValueInfo(baseclass.argument);
                Console.ReadKey();
            }
        }
}