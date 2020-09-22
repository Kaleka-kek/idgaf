using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice();
            invoice.CalculateAndShowAccount();

            Console.ReadKey();
        }
    }
    class Invoice
    {
        int acc = 1; 
        string cust = "Kto to";
        string prov = "Ya";

        private string article = "Komputer";
        private int kol = 1;

        private int moprice = 20000; 
        public void CalculateAndShowAccount()
        {
            int perc = (kol * moprice) + (kol * acc);
            int perc1 = (kol * moprice);
            Console.WriteLine("Заказчик: " + cust + "\nПоставщик: " + prov + "\nСумма за заказанный товар " + article + "\nБЕЗ НДС: " + perc + "$" + "\nC НДС: " + perc1 + "$");
        }
    }
}