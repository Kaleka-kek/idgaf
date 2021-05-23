using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employer = new Employee();
            Console.WriteLine("Имя:");
            string Name = Console.ReadLine();
            Console.WriteLine("Фамилия:");
            string Surname = Console.ReadLine();
            Console.WriteLine("Должность(уборщик,офисный планктон,директор):");
            string Doljnost = Console.ReadLine();
            employer.Employer(Name,Surname);
            Employee oklad = new Employee();
            oklad.oklad(Doljnost);
        }
    }
    class Employee
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string Employer(string name,string surname)
        {
            Console.WriteLine("Имя:" +name);
            Console.WriteLine("Фамилия:"+surname);
            return name;
        }
        public void oklad(string doljnost)
        {
            int oklad;
            int proc;
            if(doljnost== "уборщик" )
            {
                Console.WriteLine("Должность:" + doljnost);
                oklad = 10000;
                Console.WriteLine("Оклад:"+ oklad);
                proc = oklad / 5;
                Console.WriteLine("Налог:" + proc);
            }
            if (doljnost == "офисный планктон")
            {
                Console.WriteLine("Должность:" + doljnost);
                oklad = 20000;
                Console.WriteLine("Оклад:" + oklad);
                proc = oklad / 5;
                Console.WriteLine("Налог:" + proc);
            }
            if (doljnost == "директор")
            {
                Console.WriteLine("Должность:" + doljnost);
                oklad = 40000;
                Console.WriteLine("Оклад:" + oklad);
                proc = oklad / 5;
                Console.WriteLine("Налог:" + proc);
            }
        }
    } 
}
