using System;
using System.Collections.Generic;
namespace Generic_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Buildings<int, string> EmpireState = new Buildings<int, string>()
            {
                Name = "Empire State",
                City = "New York",
                Weight = 365000,
                Height = 443
            };

            Buildings<int, string> BurjKhalifa = new Buildings<int, string>()
            {
                Name = "Burj Khalifa",
                City = "Dubi",
                Weight = 450000,
                Height = 830
            };

            Buildings<int, string> EifelTower = new Buildings<int, string>()
            {
                Name = "Eifel Tower",
                City = "Paris",
                Weight = 7300,
                Height = 312
            };

            Console.WriteLine(EmpireState);
            Console.WriteLine(BurjKhalifa);
            Console.WriteLine(EifelTower);

            Console.WriteLine("*********************************");
            Emp emp1 = new Emp();
            emp1.Id = 1;
            emp1.Age = 22;
            emp1.Name = "Mostafa";
            Console.WriteLine(emp1);
            Emp emp2 = new Emp() { Id = 2, Age = 30, Name = "Ahmed" };
            Console.WriteLine(emp2);
            Emp emp3 = new Emp(5, 50, "MMR");
            Console.WriteLine(emp3);

            Console.WriteLine("*********List*****************");
            //List<Buildings<int, string>> buildings = new List<Buildings<int, string>>()
            var buildings = new List<Buildings<int, string>>()

            {
               new Buildings<int, string>()
            {
                Name = "Eifel Tower",
                City = "Paris",
                Weight = 7300,
                Height = 312
                 },

               new Buildings<int, string>()
                 {
                Name = "Empire State",
                City = "New York",
                Weight = 365000,
                Height = 443
                },
               new Buildings<int, string>()
                {
                Name = "Eifel Tower",
                City = "Paris",
                Weight = 7300,
                Height = 312 }
             };

            foreach (var item in buildings)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();


        }
    }

    class Buildings<T, S>
    {
        public S Name { get; set; }
        public S City { get; set; }
        public T Height { get; set; }
        public T Weight { get; set; }
        public override string ToString()
        {
            return $"{Name}  ,{City}  ,{Height}  ,{Weight}";
        }
    }

    class Emp
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Id}   <{Age}      <{Name}";
        }
        public Emp()
        {

        }

        public Emp(int id, int age, string name)
        {
            Id = id;
            Age = age;
            Name = name;
        }
    }
}
