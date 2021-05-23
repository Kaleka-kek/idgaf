using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            user user = new user();
            Console.WriteLine("Login: ");
            user.login = Console.ReadLine();
            Console.WriteLine("name: ");
            user.name = Console.ReadLine();
            Console.WriteLine("surname: ");
            user.surname = Console.ReadLine();
            Console.WriteLine("age: ");
            user.age = Console.ReadLine();
            Console.WriteLine("date: ");
            user.date = Console.ReadLine();
            Console.WriteLine($"User :" + user.login + $"    " + user.name + $"    " + user.surname + $"    " + user.age + $"    " + user.date);
        }
    }
    class user
    {
        public string login { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string age { get; set; }
        public string date { get; set; }

    }
}
