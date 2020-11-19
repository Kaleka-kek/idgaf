using System;
using System.Collections.Generic;
using System.Text;

namespace _4
{
    class License
    {
        public string Key;

        public License(string key)
        {
            Key = key;
        }

        public bool AllowTrial()
        {
            if (Key != "Full")
            {
                Console.WriteLine("Trial v.");
                return true;
            }
            else return false;
        }

        public bool AllowFull()
        {
            if (Key == "Full" )
            {
                Console.WriteLine("Full v.");
                return true;
            }
            else return false;
        }
    }
}
