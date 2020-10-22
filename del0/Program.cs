using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace del0
{
    class Program
    {
        static void Main(string[] args)
        {
            Modal DB = new Modal();
            var q1 = from s in DB.employees select s;
            DB.employees.All(n=> n.emp_id =="3");
            Directory.CreateDirectory(@"C:\EA");
            string file = @"C:\EA\Emp.html";
         

            StreamWriter writer = new StreamWriter(file, true, Encoding.Unicode);
            writer.WriteLine("<table>");
            writer.WriteLine("<th>Id</th><th>Last Name</th>");

            foreach (var item in q1)
            {
                Console.WriteLine($"{item.emp_id}\t{item.lname}");
                writer.WriteLine($"<tr><td>{item.emp_id}</td><td>{item.lname}</td></tr>");
            }
            writer.WriteLine("</table>");

            writer.Close();

                //int x = 150;
                //float z = 1.7f;
                //x =Convert.ToInt32(z) ;
                //Console.WriteLine(x);
                //x = (int)z;
                //Console.WriteLine(x);

                ///////////////////////////////////////////////////////
                ///
                //bool switch_on = true;
                //switch (switch_on)
                //{
                //    case true: Console.WriteLine("true");
                //        break;
                //    case false: Console.WriteLine("false");
                //        break;
                //    default: break;
                //}


                //bool b= int.TryParse(Console.ReadLine(), out int t);
                // if (!b)
                // {
                //     Console.WriteLine("Wrong");
                // }
                // else
                // {
                //     Console.WriteLine("True the number is: "+ t);
                // }


                //int g =0;
                //Console.WriteLine(g);

                //for (int i = 0; i < 10; i++)
                //{
                //    if (i == 7)
                //    {
                //        break;
                //    }
                //    g += i;
                //}
                //Console.WriteLine(g);

                //double p = 2.664d;
                //Console.WriteLine(Math.Round(p,1));      //التقريب
                //Console.WriteLine(Math.Floor(p));       //الحد الأدنى
                //Console.WriteLine(Math.Ceiling(p));     //الحد الأعلى
                //Console.WriteLine(Math.Truncate(p));    //الرقم الصحيح فقط
                //Console.WriteLine(Convert.ToInt32(p));    //التقريب
                //Console.WriteLine((int)p);    //الرقم الصحيح فقط

                //////////////////////////////////////////////////
                //DateTime x = DateTime.Today;
                //regular expression
                //string formate;
                //formate = string.Format($"{x:yyyy MM dd}");
                //formate = string.Format("");
                //Console.WriteLine($"{formate}");
                //////////////////////
                //Console.WriteLine("Please Enter the Year");
                //int q =int.Parse(Console.ReadLine());
                //Console.WriteLine("Please Enter the Month");
                //int w = int.Parse(Console.ReadLine());
                //Console.WriteLine("Please Enter the Day");
                //int e = int.Parse(Console.ReadLine());
                //DateTime z = new DateTime(q,w,e);

                //Console.WriteLine("Your Age Is:  "+(x-z).TotalDays/365);

                //bool aa = DateTime.IsLeapYear(2020);
                //Console.WriteLine(aa);
                //////////////////////////////////////////
                //int w, e;
                //w = 8;
                //e = 8;
                //Console.WriteLine( w+e);
                //Console.WriteLine(Sum( ref w, ref e));
                //Console.WriteLine(w+e);

                Console.ReadKey();
            }

            //    public static int Sum(ref int q, ref int r)
            //    {
            //        int res;
            //        q = 10;
            //        r = 53;
            //        res = q + r;
            //        Msg();
            //        return res;
            //    }

            //    public static void Msg()
            //    {
            //        Console.WriteLine("All Done");
            //    }
        }
    }

