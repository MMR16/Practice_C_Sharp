using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var filteredList = new List<Employees>();
            var listOfEmployees = new List<Employees>
            {
                new Employees { EmployeeID=1, FirstName="Jack",LastName="Steven", Salary=5000m, Age=35,Appraisal = new List<int>{7,7,8,9,7} },
                new Employees { EmployeeID=2, FirstName="Debora",LastName="Watson", Salary=10000m, Age=45,Appraisal = new List<int>{9,9,8,9,8} },
                new Employees { EmployeeID=3, FirstName="Claire",LastName="Adam", Salary=7500m, Age=32,Appraisal = new List<int>{9,7,8,9,7} },
                new Employees { EmployeeID=4, FirstName="Michael",LastName="Rob", Salary=3500m, Age=22,Appraisal = new List<int>{6,7,8,7,7} },
                new Employees { EmployeeID=5, FirstName="Matthew",LastName="Forest", Salary=4500m, Age=28,Appraisal = new List<int>{7,7,6,6,7} },
                new Employees { EmployeeID=6, FirstName="Charles",LastName="Kris", Salary=8000m, Age=27,Appraisal = new List<int>{8,9,7,8,8} },
                new Employees { EmployeeID=7, FirstName="Robert",LastName="Wilson", Salary=8000m, Age=28,Appraisal = new List<int>{8,9,8,9,9} },
                new Employees { EmployeeID=8, FirstName="Emma",LastName="Brooks", Salary=6000m, Age=23,Appraisal = new List<int>{8,6,9,9,7} },
                new Employees { EmployeeID=9, FirstName="Jennifer",LastName="Blake", Salary=3000m, Age=38,Appraisal = new List<int>{6,7,7,6,6} },
                new Employees { EmployeeID=10, FirstName="Terry",LastName="Loyd", Salary=9000m, Age=49,Appraisal = new List<int>{9,9,9,8,7} },
                new Employees { EmployeeID=11, FirstName="Adam",LastName="Spencer", Salary=7000m, Age=33,Appraisal = new List<int>{8,8,8,6,7} },
                new Employees { EmployeeID=12, FirstName="Stacy",LastName="Shelton", Salary=4000m, Age=25,Appraisal = new List<int>{8,7,8,6,7} },
                new Employees { EmployeeID=12, FirstName="Stacy",LastName="Shelton", Salary=4000m, Age=25,Appraisal = new List<int>{8,7,8,6,7} },
                new Employees { EmployeeID=12, FirstName="Stacy",LastName="Shelton", Salary=4000m, Age=25,Appraisal = new List<int>{8,7,8,6,7} }
            };

            //Method syntax
            ///
        
            // Employees.DisplayWithApparisal(listOfEmployees, "All Employees");

            //Salary is greater than or equal to 6000 and age greater than 40
            filteredList = listOfEmployees.Where(a => a.Salary > 5000 && a.Age >= 30).ToList(); ;
            foreach (var item in filteredList)
            {
                Console.WriteLine(item.FirstName);
            }
            Console.WriteLine();


            foreach (var employee in listOfEmployees)
            {
                if (employee.Salary >= 5000 && employee.Age >= 30)
                    Console.WriteLine(employee.FirstName);
            }
            Console.WriteLine();

            //Salary is greater than or equal to 6000 and age greater than 40 or salary is greater than or equal 8000

            filteredList = listOfEmployees.Where(a => a.Salary >= 6000 && a.Age > 40 || a.Salary >= 8000).ToList();

            foreach (var i in filteredList)
            {
                Console.WriteLine(i.FirstName);
            }

            //Distinct Ref Type
            //No Duplicates
            Console.WriteLine("**************************Distinct*******************************");
            //instance of IEqualityComparer
            EC Emp = new EC();

            var UniqueEmp = listOfEmployees.Distinct(Emp);

            foreach (var item in UniqueEmp)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("========================Distinct Query=====================");
            var x = (from p in listOfEmployees
                     group p by new { p.EmployeeID,p.FirstName } //or group by new {p.ID, p.Name, p.Whatever}
                        into mygroup
                     select mygroup.FirstOrDefault()).ToList();

            foreach (var item in x)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*********************************************************");
            Console.WriteLine();

            ///
            ////////////////////////////////Query syntax
            ///
            //Salary is greater than or equal to 6000 and age greater than 40
            filteredList = (from e in listOfEmployees
                            where e.Salary > 5000 && e.Age >= 30
                            select e).ToList();

            foreach (var item in filteredList)
            {
                Console.WriteLine(item.FirstName);
            }
            Console.WriteLine();

            //Salary is greater than or equal to 6000 and age greater than 40 or salary is greater than or equal 8000
            filteredList = (from e in listOfEmployees
                            where e.Salary >= 6000 && e.Age > 40 || e.Salary >= 8000
                            select e).ToList();

            foreach (var item in filteredList)
            {
                Console.WriteLine(item.FirstName);
            }
            Console.WriteLine("*********************************************************");

            //////////////////Sorting Using LINQ
            ///
            filteredList = (from e in listOfEmployees
                            orderby e.Salary, e.Age //descending
                            select e).ToList();
            foreach (var item in filteredList)
            {
                Console.WriteLine(item.Salary + "  " + item.Age);
            }
            Console.WriteLine("*********************************************************");
            ///Methods
            Filter_By_Age(listOfEmployees, "asc");
            Filter_By_Age(listOfEmployees, "des");
            Filter_By_Age(listOfEmployees, "jjj");
           

            Console.WriteLine();
            Console.ReadKey();
        }

        //static List<Employees> Filter_By_Age(List<Employees> employees, string SortType)
        static void Filter_By_Age(List<Employees> employees, string SortType)
        {

            switch (SortType.ToLower())
            {
                case "asc":
                    var list = (from e in employees
                                orderby e.Age ascending
                                select e).ToList();
                    Console.WriteLine("\nsorting by age " + SortType);
                    foreach (var item in list)
                    {
                        Console.WriteLine(item.Age + " " + item.FirstName);
                    }
                    break;
                case "des":
                    list = (from e in employees
                            orderby e.Age descending
                            select e).ToList();
                    Console.WriteLine("\nsorting by age " + SortType);
                    foreach (var item in list)
                    {
                        Console.WriteLine(item.Age + " " + item.FirstName);
                    }
                    break;
                default:
                    Console.WriteLine("\nPlease Enter \"des\" or \"asc\"");
                    break;
            }

        }
    }
}
