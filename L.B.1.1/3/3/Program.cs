using System;

namespace _3
{
    public delegate int RNDdel();
    public class Program
    {
        static int Rdel()
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            return rand.Next(1, 500);
        }
        static RNDdel[] rnDdels = new RNDdel[]
        {   
            new RNDdel(Rdel),
            new RNDdel(Rdel),
            new RNDdel(Rdel),
            new RNDdel(Rdel),
            new RNDdel(Rdel),
            new RNDdel(Rdel),
            new RNDdel(Rdel)

        };
        static void Main(string[] args)
        {
            RNDdel rnDdell;
            rnDdell = delegate
            {
                int counter = 0;
                int sum = 0;
                for (int i = 0; i < rnDdels.Length; i++)
                {
                    sum =+ rnDdels[i]();
                    counter++;
                }
                return sum/counter;
            };
            Console.WriteLine(rnDdell());
        }
    }
}
