using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int, string> dictionary = new MyList<int, string>();

            dictionary.Add(0, "String");
            dictionary.Add(54, "String45");
            dictionary.Add(88, "String6546");
            dictionary.Add(89, "String5654464");

            Console.WriteLine(dictionary.ListLetgth);
            Console.WriteLine(dictionary.GetElement(734));

            Console.ReadKey();
        }
    }
    class MyList<T, R>
    {
        private T[] KeyArray { get; set; }
        private R[] ValueArray { get; set; }

        public int ListLetgth
        {
            get
            {
                return listLetgth;
            }
        }
        private int listLetgth;
        public int ArraySize = 1;
        public void Add(T key, R value)
        {
            if (ListLetgth == 0)
            {
                KeyArray = new T[ArraySize];
                KeyArray[ListLetgth] = key;

                ValueArray = new R[ArraySize];
                ValueArray[ListLetgth] = value;

                listLetgth++;
                ArraySize++;
            }
            else
            {
                T[] DkeyArr = KeyArray;
                R[] DvalueArr = ValueArray;

                KeyArray = new T[ArraySize];
                ValueArray = new R[ArraySize];

                for (int i = 0; i < DkeyArr.Length; i++)
                {
                    KeyArray[i] = DkeyArr[i];
                    ValueArray[i] = DvalueArr[i];
                }
                KeyArray[ListLetgth] = key;
                ValueArray[ListLetgth] = value;

                listLetgth++;
                ArraySize++;
            }
        }
        public R GetElement(T value)
        {
            int index = Array.IndexOf(KeyArray, value);
            return ValueArray[index];
        }
    }
}