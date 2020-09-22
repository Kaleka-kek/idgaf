using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {

            Address address = new Address();
            address.index = "11111";
            address.country = "Kyiv";
            address.city = "Ukraine";
            address.street = "Shevchenko";
            address.house = "12";
            address.appartment = "1";
            Console.WriteLine($"Address :" + address.index + $"    " + address.country + $"    " + address.city + $"    " + address.street + $"    " + address.house + $"    " + address.appartment);
        }
    }
    class Address
    {
        public string index { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public string house { get; set; }
        public string appartment { get; set; }
    }
}