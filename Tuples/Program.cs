using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            // takes 8 param only < for more use nested tuple
            Tuple<int> Id = new Tuple<int>(5);

            var EmpInfo = new Tuple<int, string, string, DateTime, bool>(1, "Mostafa", "Mahmoud", new DateTime(1994, 3, 16), true);
            Console.WriteLine(EmpInfo);
            Console.WriteLine(EmpInfo.Item1);
            Console.WriteLine(EmpInfo.Item2);
            Console.WriteLine(EmpInfo.Item3);
            Console.WriteLine(EmpInfo.Item4);
            Console.WriteLine(EmpInfo.Item5);

            var Student = Tuple.Create(5, 22, "MMR");

            Console.WriteLine(Student);
            Console.WriteLine(Student.Item1);
            Console.WriteLine(Student.Item2);
            Console.WriteLine(Student.Item3);
            ///nested
            ///
            Console.WriteLine("***************Nested ***************");
            var Doctors = new Tuple<int, int, string, string, int, string, decimal, Tuple<float, string, bool>>
            (1, 2, "mm", "rr", 90, "SS", 21.5m, Tuple.Create(.3f, "MMR", true));
            Console.WriteLine(Doctors.Item1);
            Console.WriteLine(Doctors.Item7);
            Console.WriteLine(Doctors.Rest.Item2);

            Console.WriteLine("***************List ***************");

            var People = new List<(int id, int age, string name)>() { 
            (1,20,"Mostafa"),(2,30,"ahmed"),(3,25,"ali"),(4,40,"omar")
            };

            foreach (var item in People)
            {
                Console.WriteLine(item.name);
            }

           ///////// Value Tuples
            Console.WriteLine("***************Value Tuples ***************");
            Console.WriteLine("***************Modern Tuples ***************");

            ///
            (int, int, string) Name1 = (1,26,"MMR");
            Console.WriteLine(Name1.Item1);
            Console.WriteLine(Name1.Item2);
            Console.WriteLine(Name1.Item3);
            Console.WriteLine("************");
            (int id, int age, string name) Name2 = (1, 26, "MMR");
            Console.WriteLine(Name2.id);
            Console.WriteLine(Name2.age);
            Console.WriteLine(Name2.name);
            Console.WriteLine("************");
            var Name3 = (1, 26, "MMR");
            Console.WriteLine(Name3.Item1);
            Console.WriteLine(Name3.Item2);
            Console.WriteLine(Name3.Item3);
            Console.WriteLine("************");
            var Name4 = (id:1, age:26, name:"MMR");
            Console.WriteLine(Name4.id);
            Console.WriteLine(Name4.age);
            Console.WriteLine(Name4.name);
            Console.ReadLine();
        }
    }
}
