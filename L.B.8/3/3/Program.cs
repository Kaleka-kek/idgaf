using System;

namespace _3
{
    class Program
        {
            static void Main(string[] args)
            {
                DerivedClass derivedClass = new DerivedClass();
                Console.WriteLine("Введите char index");
                char index = char.Parse(Console.ReadLine());
                Console.WriteLine("Введите char value");
                char value = char.Parse(Console.ReadLine());
                derivedClass[index] = value;
                Console.WriteLine("Index {0} value: {1}", index, derivedClass[index]);
                Console.WriteLine("Array length: {0} CharArray length: {1}", derivedClass.ArrLength[0], derivedClass.ArrLength[1]);
                Console.ReadKey();
            }
        }
    class BaseClass
        {
            public BaseClass()
            {
                for (int i = 0; i < 20; i++)
                {
                    Random rnd = new Random();
                    Array[i] = rnd.Next(0, 25);
                }
            }
            protected int[] Array = new int[20];
            public int this[int index]
            {
                get
                {
                    return Array[index];
                }
                set
                {
                    Array[index] = value;
                }
            }
            public int ArrLength
            {
                get
                {
                    return Array.Length;
                }
            }
        }
    class DerivedClass : BaseClass
        {
            protected char[] CharArray = new char[200];
            public DerivedClass()
            {
                ArrLength[1] = CharArray.Length;
                ArrLength[0] = Array.Length;
            }
            public char this[char index]
            {
                get
                {
                    return CharArray[index];
                }
                set
                {
                    CharArray[index] = value;
                }
            }
            public new int[] ArrLength = new int[2];
        }
    }
