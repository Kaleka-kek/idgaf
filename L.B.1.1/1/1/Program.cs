using System;

namespace _1
{
    public delegate int Delegate(int z,int x,int c); 
    class Program
    {
        static void Main(string[] args)
        {
            Delegate someDelegate = delegate(int z, int x, int c)
            {
                return (z + x + c) / 3;
            };
            Console.WriteLine( someDelegate(1,2,3));
            
        }
    }
}
