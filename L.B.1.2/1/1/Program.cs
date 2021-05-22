using System;
using System.Reflection.Metadata.Ecma335;

namespace _1
{
    class Program
        {
            static void Main(string[] args)
            {
                MyList<int> numbers = new MyList<int>();

                numbers.Add(0);
                numbers.Add(1);

                for (int i = 0; i < numbers.ListLetgth; i++)
                {
                    Console.WriteLine(numbers.GetElement(i));
                }
                Console.WriteLine(numbers.ListLetgth);
                Console.ReadKey();
            }
        }
    class MyList<T>
        {
            private T[] Array { get; set; }
            public MyList()
            {
            }
            public int ListLetgth { private set; get; }
            public int Count2 = 1;
            public void Add(T item)
            {
                if (ListLetgth == 0)
                {
                    Array = new T[Count2];
                    Array[ListLetgth] = item;
                    ListLetgth++;
                    Count2++;
                }
                else
                {
                    T[] Darr = Array;
                    Array = new T[Count2];
                    for (int i = 0; i < Darr.Length; i++)
                    {
                        Array[i] = Darr[i];
                    }
                    Array[ListLetgth] = item;
                    ListLetgth++;
                    Count2++;
                }

            }
            public T GetElement(int index)
            {
                return Array[index];
            }
        }
}

