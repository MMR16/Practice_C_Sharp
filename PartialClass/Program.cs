using System;



namespace PartialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals animal = new Animals();
            Console.WriteLine();
            Console.WriteLine(animal.GetAnimal());
            animal.Name = "Fox";
            animal.Age = 35;
            Console.WriteLine();
            Console.WriteLine(animal.GetAnimal());
            Console.WriteLine();
            Animals.NameAnimal("Max", 30);
            Console.WriteLine();
            Animals.NameAnimal(null, null);

        }
    }

    partial class Animals
    {
        string name;
        int ?age;

    

        //public string Name { get; set; }
        //public int Age { get; set; }

        public string GetAnimal()
        {
            return $"Animal name is {Name},it's Age is {Age}";
        }
    }

    partial class Animals
    {
        public string Name
        {
            get { return name ?? "NO Name"; }
            set { name = value; }
        }

        public int Age
        {
            get { return age ?? 10; }
            set { age = value ; }
        }

        static public void NameAnimal(string N, int ?A)
        {
            Console.WriteLine($"Animal Name Is {N??"Rox"}, It's Age Is {A??20}");
        }
    }
}
