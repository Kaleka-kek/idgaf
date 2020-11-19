using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _4
{
    class VPN : License
    {
        public VPN(string Key) : base(Key)
        {
        }

        public void VPNTRIAL()
        {
            Console.Write("Connecting to United Kingdom ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(".");
                Thread.Sleep(300);
            }

            Console.WriteLine("Сonnected to United Kingdom ");
        }

        public void VPNFULL(string country)
        {
            if (AllowFull() == true)
            {
                Console.WriteLine("Connecting to " + country);
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(300);
                }

                Console.WriteLine("Сonnected to " + country);
            }
            else Console.WriteLine("To connect to other countries, you need the full version");
        }
    }
}