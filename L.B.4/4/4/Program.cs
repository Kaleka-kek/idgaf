using System;
using System.Threading;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("License key: ");
            VPN scan = new VPN(Console.ReadLine());
            scan.AllowTrial();
            scan.AllowFull();
            Console.WriteLine("Select the country you want to connect to(for the free version only UK): uk - (trial v.), full.");
            string run = Console.ReadLine();
            if (run == "uk") scan.VPNTRIAL();
            if (run == "full")
            {
                Console.WriteLine("Select the country you want to connect to:");
                string country = Console.ReadLine();
                scan.VPNFULL(country);
            }
            Console.WriteLine("Press any key to exit: ");
            Console.ReadKey();
        }
    }
    }

