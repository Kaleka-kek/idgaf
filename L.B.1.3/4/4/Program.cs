using System;
using System.Threading;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static int threadNumber;
        static void Main(string[] args)
        {
            while (0 != 1)
            {
                StartMethod();
                Task.Delay(4000).Wait();
            }
        }
        static async void StartMethod()
        {
            await Task.Run(() => NewMethod());
        }
        static void NewMethod()
        {
            Console.WriteLine("Поток" + Thread.CurrentThread.ManagedThreadId);
            Task.Delay(1000000).Wait();
        }
    }
}
