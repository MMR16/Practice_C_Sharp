using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var departments = new List<Departments>() {
            new Departments{Did=1,DeptName="FullStack"},
            new Departments{Did=2,DeptName="IOS"},
            new Departments{Did=3,DeptName="Android"},
            new Departments{Did=4,DeptName="Python"}};

            var filteredList = new List<Employees>();

            var listOfEmployees = new List<Employees>
            {
                new Employees {Did=1, EmployeeID=1, FirstName="Jack",LastName="Steven", Salary=5000m, Age=35,Appraisal = new List<int>{7,7,8,9,7} },
                new Employees {Did=2, EmployeeID=2, FirstName="Debora",LastName="Watson", Salary=10000m, Age=45,Appraisal = new List<int>{9,9,8,9,8} },
                new Employees {Did=4, EmployeeID=3, FirstName="Claire",LastName="Adam", Salary=7500m, Age=32,Appraisal = new List<int>{9,7,8,9,7} },
                new Employees {Did=1, EmployeeID=4, FirstName="Michael",LastName="Rob", Salary=3500m, Age=22,Appraisal = new List<int>{6,7,8,7,7} },
                new Employees {Did=1, EmployeeID=5, FirstName="Matthew",LastName="Forest", Salary=4500m, Age=28,Appraisal = new List<int>{7,7,6,6,7} },
                new Employees {Did=4, EmployeeID=6, FirstName="Charles",LastName="Kris", Salary=8000m, Age=27,Appraisal = new List<int>{8,9,7,8,8} },
                new Employees {Did=2, EmployeeID=7, FirstName="Robert",LastName="Wilson", Salary=8000m, Age=28,Appraisal = new List<int>{8,9,8,9,9} },
                new Employees {Did=1, EmployeeID=8, FirstName="Emma",LastName="Brooks", Salary=6000m, Age=23,Appraisal = new List<int>{8,6,9,9,7} },
                new Employees {Did=3, EmployeeID=9, FirstName="Jennifer",LastName="Blake", Salary=3000m, Age=38,Appraisal = new List<int>{6,7,7,6,6} },
                new Employees {Did=3, EmployeeID=10, FirstName="Terry",LastName="Loyd", Salary=9000m, Age=49,Appraisal = new List<int>{9,9,9,8,7} },
                new Employees {Did=3, EmployeeID=11, FirstName="Adam",LastName="Spencer", Salary=7000m, Age=33,Appraisal = new List<int>{8,8,8,6,7} },
                new Employees {Did=1, EmployeeID=12, FirstName="Stacy",LastName="Shelton", Salary=4000m, Age=25,Appraisal = new List<int>{8,7,8,6,7} },
                new Employees {Did=4, EmployeeID=12, FirstName="Stacy",LastName="Shelton", Salary=4000m, Age=25,Appraisal = new List<int>{8,7,8,6,7} },
                new Employees {Did=2, EmployeeID=12, FirstName="Stacy",LastName="Shelton", Salary=4000m, Age=25,Appraisal = new List<int>{8,7,8,6,7} }
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
            //instance of Class EC:IEqualityComparer
            EC Emp = new EC();

            var UniqueEmp = listOfEmployees.Distinct(Emp);

            foreach (var item in UniqueEmp)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("========================Distinct Query=====================");
            var x = (from p in listOfEmployees
                     group p by new { p.EmployeeID, p.FirstName } //or group by new {p.ID, p.Name, p.Whatever}
                        into mygroup
                     select mygroup.FirstOrDefault().EmployeeID).ToList();

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

            Console.WriteLine("----------------Projection Select------------------");
            //Select one column or more 

            var P = listOfEmployees.Where(Q => Q.EmployeeID > 7).Select(w => new { w.EmployeeID, w.Age });//anonymous Type

            //Alias Name For Columns :
            var P2 = listOfEmployees.Where(Q => Q.EmployeeID > 9).Select(w => new { EmpID = w.EmployeeID, EmpAge = w.Age }).ToList();//anonymous Type
            //Using Anonymous Names  to get properties
            var P22 = listOfEmployees.Select(w => new { EmpID = w.EmployeeID, EmpAge = w.Age }).Where(Q => Q.EmpID > 9).ToList(); ;//anonymous Type

            foreach (var item in P2)
            {
                Console.WriteLine(item.EmpID + "  " + item.EmpAge);
            }

            //select only
            var P3 = listOfEmployees.Select(w => new { w.Age, w.EmployeeID }).ToList();
            //select with where
            //two results only because of select 
            var P4 = listOfEmployees.Select(w => new { w.Age, w.EmployeeID }).Where(w=>w.EmployeeID>7 && w.Age>30);

            foreach (var item in P4)
            {
                Console.WriteLine(item);
            }
            ///////////////////////////////////////////Join
            ///Inner Join
            Console.WriteLine("----------------******Joins******------------------");

            var q6 = listOfEmployees.Join(departments,w=>w.Did,d=>d.Did,(a,b)=>new { a.EmployeeID,a.FirstName,a.Age, b.DeptName }) ;
            //Alias
            var q7 = listOfEmployees.Join(departments, w => w.Did, d => d.Did, (a, b) => new {EmpId= a.EmployeeID, EmpFirstName = a.FirstName, EmpAge = a.Age, EmpDepartment = b.DeptName });

            foreach (var item in q6)
            {
                Console.WriteLine(item);
            }
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
