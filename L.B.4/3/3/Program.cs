using System;
using System.Diagnostics;

namespace _3
{
    class AnimalG
    {
        public string Group { get; set; }
        public AnimalG(string group)
        {
            Group = group;
        }
        public virtual void Display()
        {
            Debug.WriteLine($"Group: {Group}");
        }
    }

    class AName1 : AnimalG
    {
        public string Name1 { get; set; }
        public AName1(string group, string name1) : base(group)
        {
            Name1 = name1;
        }
        public override void Display()
        {
            base.Display();
            Debug.WriteLine($"Name: {Name1}");
        }
    }

    class AName2 : AnimalG
    {
        public string Name2 { get; set; }
        public AName2(string group, string name2) : base(group)
        {
            Name2 = name2;
        }
        public override void Display()
        {
            base.Display();
            Debug.WriteLine($"Name: {Name2}");
        }
    }
    class AName3 : AnimalG
    {
        public string Name3 { get; set; }
        public AName3(string group, string name3) : base(group)
        {
            Name3 = name3;
        }
        public override void Display()
        {
            base.Display();
            Debug.WriteLine($"Name: {Name3}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AName1 aName1 = new AName1("Amphibians", "Cobras");
            AName2 aName2 = new AName2("Reptiles", "Turtles");
            AName3 aName3 = new AName3 ("Insects", "Spiders");

            aName1.Display();
            aName2.Display();
            aName3.Display();

            Console.ReadKey();
        }
    }
}
