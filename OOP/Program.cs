using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            //Person person = new Person();
            //person.Name = "MMR";
            //person.Age = 26;
            //const int V = 16;
            //person.Birthdate = new DateTime(19,3,1994);

            //Console.WriteLine($"{person.Name} age ={person.Age},Birthdate is {person.Birthdate}");

            //Person P2 = new Person();
            //Console.WriteLine(P2);
            //Console.WriteLine(P2.Name);
            //P2.Name = "Ahmed";
            //Console.WriteLine(P2.Name);

            //Person P4 = new Person(null,null);
            //Console.WriteLine(P4);

            Person p =new Person();
            Person.Print();
            Console.WriteLine(p.ToString());

           Print();

            Console.ReadKey();
        }


        public static void Print()
        {
            Console.WriteLine("Hi from Prog");
        }
    }

    class Person
    {
        string name;
        int age;
        DateTime bdate;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public DateTime Birthdate
        {
            get { return bdate; }
            set { bdate = value; }
        }

        public Person()
        {
            name = "Mostafa";
            age = 26;
            bdate = new DateTime(1994, 3, 16);

        }
        public override string ToString()
        {
            return $"{Name} age ={Age},Birthdate is {Birthdate}";
        }

        public Person(string YourName, int? YourAge)
        {
            name = YourName ?? "MMR";
            age = YourAge ?? 38;
        }

        public static void Print()
        {
            Console.WriteLine("Hi from Person");
        }


    }

}
