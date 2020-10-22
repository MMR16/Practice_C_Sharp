using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSpanApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan TS = new TimeSpan(20, 50, 30);
            Console.WriteLine(TS);
            Console.WriteLine(TS.TotalHours);
            Console.WriteLine(TS.TotalDays);
            Console.WriteLine("------------");
            TS = TS.Add(new TimeSpan(8, 40, 70));
            Console.WriteLine(TS.TotalHours);
            Console.WriteLine(TS.TotalDays);
            Console.WriteLine("------------");
            DateTime dateTime1 = new DateTime(1994, 3, 16);
            DateTime dateTime2 = DateTime.Now;


            ////DateTime Date = dateTime2 - dateTime1;  //Error
            TimeSpan Date = dateTime2 - dateTime1;
            Console.WriteLine(Date.TotalDays / 365.25);
            TimeSpan Date2 = dateTime2.Subtract(dateTime1);
            Console.WriteLine(Date2.TotalDays / 365.25);
            Console.ReadKey();
        }
    }
}
