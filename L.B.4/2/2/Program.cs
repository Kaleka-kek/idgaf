using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                B b = new B();
                DerivedClassB_1 derivedClassB_1 = new DerivedClassB_1();
                DerivedClassB_2 derivedClassB_2 = new DerivedClassB_2();
                DerivedClassB_3 derivedClassB_3 = new DerivedClassB_3();
                Console.WriteLine("Enter argument 1 value: ");
                b.arg1 = Console.ReadLine();
                Console.WriteLine("Enter argument 2 value: ");
                b.arg2 = Console.ReadLine();
                b.ShowArgInfo();
                derivedClassB_1.ShowArgInfo();
                derivedClassB_2.ShowArgInfo();
                derivedClassB_3.ShowArgInfo();
                Console.ReadKey();
            }
        }
    }
}